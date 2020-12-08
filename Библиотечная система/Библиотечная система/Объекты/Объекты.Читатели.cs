using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Библиотечная_система.Properties;
using Библиотечная_система.Карточка_читателя;
using Библиотечная_система.Формы;
using static Библиотечная_система.БиблиотекаDataSet;
using DGV2Printer;
using System.Drawing;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridView.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView.Rows[index].HeaderCell.Value = indexStr;
        }

        /// <summary>
        /// Добавить нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Новая_карточка_читателя открыть = new Новая_карточка_читателя(this.типы_номенклатурыTableAdapter,this.авторTableAdapter,библиотекаDataSet);
            открыть.ShowDialog();

            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
        }

        /// <summary>
        /// Импортирует данные из Exel-файла, выбранного в окне диалога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            ЧитателиDataTable employes = this.библиотекаDataSet.Читатели;
            this.читателиTableAdapter.Fill(employes);
            this.ImportDataFromExcel(
                this.GetImportingExcelFileName(),
                employes,
                new[] { "ФИО" });
            this.читателиTableAdapter.Update(employes);
            this.Объекты_Load();
        }

        /// <summary>
        /// Экспорт файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < this.dataGridView.Columns.Count; i++)
            {
                var cellCaption = this.dataGridView.Columns[i].HeaderText;
                var bracketIndex = cellCaption.IndexOf('(') - 1;
                if (bracketIndex > -1)
                {
                    cellCaption = cellCaption.Substring(0, bracketIndex);
                }

                cellCaption = cellCaption.Replace("Номер карточки", "Номер карточки");

                ExcelWorkSheet.Cells[1, i + 1] = cellCaption;
            }
            for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = this.dataGridView.Rows[i].Cells[j].Value.ToString();
                    if (!this.dataGridView.Columns[j].Visible)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1].ColumnWidth = 0;
                    }
                }
            }

            for (int j = 0; j < this.dataGridView.Columns.Count; j++)
            {
                if (this.dataGridView.Columns[j].Visible)
                {
                    ExcelWorkSheet.Columns[j + 1].AutoFit();
                }
            }
            ExcelApp.Visible = true;
        }

        /// <summary>
        /// Кнопка удалить строку сотрудника из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var idEmployee = ((ЧитателиЗапросRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Id;
            if (!idEmployee.HasValue)
            {
                return;
            }

            var deleteEmployeeQuestionResult = MessageBox.Show("Вы действительно хотите удалить читателя?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteEmployeeQuestionResult != DialogResult.Yes)
            {
                return;
            }

            using (var connection = new OleDbConnection(Settings.Default.БиблиотекаConnectionString))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM Читатели WHERE Id = {idEmployee.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.Объекты_Load();
            
        }

        private void UpdateЧитатели()
        {
            this.читателиTableAdapter.Update(библиотекаDataSet.Читатели);
            this.читателиTableAdapter.Fill(библиотекаDataSet.Читатели);
        }

        private void dateDeliveryButton_Click(object sender, System.EventArgs e)
        {
            Дата_сдачи формаИзмененияДатыСледующегоПолучения = new Дата_сдачи();
            var строкаЧитателейЗапрос = (ЧитателиЗапросRow)((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
            var строкаЧитателей = this.библиотекаDataSet.Читатели.FindById(строкаЧитателейЗапрос.Id);
            if (формаИзмененияДатыСледующегоПолучения.ShowDialog() == DialogResult.OK)
            {
                строкаЧитателей.Дата_сдачи = формаИзмененияДатыСледующегоПолучения.GetDateValue();
                this.UpdateЧитатели();
            }
        }

        /// <summary>
        /// Открывает окно на редактирование читателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Новая_карточка_читателя открыть = new Новая_карточка_читателя(this.типы_номенклатурыTableAdapter, авторTableAdapter, библиотекаDataSet);
            открыть.LoadКарточка_читателя(
                (ЧитателиЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row);
            открыть.ShowDialog();

            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
        }

        /// <summary>
        /// Очистить текстовое поле сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        #region Фильтрация отображаемых
        /// <summary>
        /// фильтрация читателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.читателиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        internal void onlyWorkingFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.читателиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }


        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }
        #endregion

        private void buttonPrint_Click(object sender, System.EventArgs e)
        {
            PrintDataGridView pr = new PrintDataGridView(dataGridView);
            pr.isRightToLeft = true;
            pr.ReportHeader = label6.Text;
            pr.Print();
        }
    }
}
