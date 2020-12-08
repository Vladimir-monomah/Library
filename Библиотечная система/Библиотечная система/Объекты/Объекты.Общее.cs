using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.IO;
using Библиотечная_система.БиблиотекаDataSetTableAdapters;

using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        /// <summary>
        /// Импортирует данные из Excel-файла в таблицу
        /// </summary>
        private void ImportDataFromExcel(string sourceFileName, DataTable destinationTable, IEnumerable<string> keyFields)
        {
            if (!File.Exists(sourceFileName))
            {
                MessageBox.Show("Введите имя существующего файла");
                return;
            }

            // Загрузка данных в память из файла
            var connectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";",
                    sourceFileName);
            using (var connection = new OleDbConnection(connectionString))
            using (var adapter = new OleDbDataAdapter("SELECT * FROM [Лист1$]", connection))
            using (var excelTable = new DataTable())
            {
                adapter.Fill(excelTable);

                // Определяем общий набор полей для excel-файла и целевой таблицы
                var commonColumns = new List<string>();
                foreach (DataColumn destinationColumn in destinationTable.Columns)
                {
                    if (excelTable.Columns.Contains(destinationColumn.ColumnName))
                    {
                        commonColumns.Add(destinationColumn.ColumnName);
                    }
                }

                var nonExistingFields = keyFields
                    .Where(column => !commonColumns.Exists(keyField => keyField == column))
                    .ToList();
                if (nonExistingFields.Count > 0)
                {
                    var missingKeyFieldsMessage = "Поля \"" + string.Join("\", \"", nonExistingFields) + " \" " +
                        "обязательно должны присутствовать в импортируемых данных!";
                    throw new Exception(missingKeyFieldsMessage);
                }

                // Создание кэша строк по ключевым полям для быстрого поиска
                var destinationRowsCache = new Dictionary<string, DataRow>();
                var buildKeyFunc = new Func<DataRow, string>(
                    importingRow => string.Join("→", keyFields.Select(keyField => importingRow[keyField].ToString())));
                foreach (DataRow row in destinationTable.Rows)
                {
                    var key = buildKeyFunc(row);
                    destinationRowsCache[key] = row;
                }

                // Добавление новых строк или обновление существующих по ключевым полям
                foreach (DataRow importingRow in excelTable.Rows)
                {
                    var key = buildKeyFunc(importingRow);
                    var isNeedAdd = false;
                    if (!destinationRowsCache.TryGetValue(key, out var destinationRow))
                    {
                        destinationRow = destinationTable.NewRow();
                        isNeedAdd = true;
                    }

                    foreach(var columnName in commonColumns)
                    {
                        this.HandleColumnWithValue(columnName, destinationRow, importingRow);
                    }

                    if (isNeedAdd)
                    {
                        destinationTable.Rows.Add(destinationRow);
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает определённым образом некоторые поля
        /// Например, если поле в целевой таблице является ссылочным,
        /// то пытаемся найти запись с импортируемым значением в другой таблице.
        /// Если не находим - создаём
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="destinationRow"></param>
        /// <param name="importingRow"></param>
        private void HandleColumnWithValue(string columnName, DataRow destinationRow, DataRow importingRow)
        {
            switch (columnName)
            {
                case "Название книги":
                    var bookValue = importingRow[columnName].ToString();
                    var bookTable = EntityManager.FilterBook($"[Название книги]='{bookValue}'");
                    if (bookTable.Rows.Count == 0 && !string.IsNullOrEmpty(bookValue))
                    {
                        var newbook = bookTable.NewТипы_номенклатурыRow();
                        newbook.Название_книги = importingRow[columnName].ToString();
                        EntityManager.UpdateBook();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                case "Автор":
                    var autorValue = importingRow[columnName].ToString();
                    var autorTable = EntityManager.FilterAutor($"[Автор]='{autorValue}'");
                    if (autorTable.Rows.Count == 0 && !string.IsNullOrEmpty(autorValue))
                    {
                        var newAutor = autorTable.NewАвторRow();
                        newAutor.Автор = importingRow[columnName].ToString();
                        autorTable.AddАвторRow(newAutor);
                        EntityManager.UpdateAutor();
                    }

                    destinationRow[columnName] = importingRow[columnName];
                    break;

                default:
                    destinationRow[columnName] = importingRow[columnName];
                    break;
            }
        }

        /// <summary>
        /// Отображает диалоговое окно для выбора файла
        /// </summary>
        /// <returns>Полный путь выбранного файла, либо Null, если файл не выбран</returns>
        private string GetImportingExcelFileName()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Файл Excel|*.XLSX;*.XLS";
            return dialog.ShowDialog() == DialogResult.OK
                ? dialog.FileName
                : null;
        }
    }
}
