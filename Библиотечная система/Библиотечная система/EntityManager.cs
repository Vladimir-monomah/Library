using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Библиотечная_система.БиблиотекаDataSetTableAdapters;
using static Библиотечная_система.БиблиотекаDataSet;
using System.Data.OleDb;
using System.Data;

namespace Библиотечная_система
{
    public class EntityManager
    {
        static БиблиотекаDataSet БиблиотекаDataSet = new БиблиотекаDataSet();

        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();
        private static ЧитателиTableAdapter ЧитателиTableAdapter = new ЧитателиTableAdapter();
        private static АвторTableAdapter АвторTableAdapter = new АвторTableAdapter();
        private static Типы_номенклатурыTableAdapter НоваяКнига = new Типы_номенклатурыTableAdapter();
        private static ЖанрTableAdapter ЖанрTableAdapter = new ЖанрTableAdapter();
        private static Год_изданияTableAdapter год_ИзданияTableAdapter = new Год_изданияTableAdapter();

        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return БиблиотекаDataSet.Пользователи;
            }
        }

        public static ЧитателиDataTable ReadersDataTable
        {
            get
            {
                return БиблиотекаDataSet.Читатели;
            }
        }

        public static АвторDataTable AutorDataTable
        {
            get
            {
                return БиблиотекаDataSet.Автор;
            }
        }

        public static Типы_номенклатурыDataTable BookDataTable
        {
            get
            {
                return БиблиотекаDataSet.Типы_номенклатуры;
            }
        }

        public static ЖанрDataTable ЖанрDataTable
        {
            get
            {
                return БиблиотекаDataSet.Жанр;
            }
        }

        public static Год_изданияDataTable DateDataTable
        {
            get
            {
                return БиблиотекаDataSet.Год_издания;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        public static void UpdateReaders()
        {
            ЧитателиTableAdapter.Adapter.Update(ReadersDataTable);
        }

        public static void UpdateAutor()
        {
            АвторTableAdapter.Adapter.Update(AutorDataTable);
        }

        public static void UpdateBook()
        {
            НоваяКнига.Adapter.Update(BookDataTable);
        }

        public static void UpdateЖанр()
        {
            ЖанрTableAdapter.Adapter.Update(ЖанрDataTable);
        }

        public static void UpdateDate()
        {
            год_ИзданияTableAdapter.Adapter.Update(DateDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Id_user, Фамилия, Имя, Отчество, Логин, Пароль, " +
                $"[Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу читатлей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ЧитателиDataTable FilterReaders(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ЧитателиTableAdapter.Connection,
                CommandText = "SELECT Id, [Номер карточки], ФИО, Пол," +
                "[Наименование книги], Автор, [Дата выдачи], [Дата сдачи] " +
                 $"FROM Читатели {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ЧитателиTableAdapter.Adapter, filterUserCommand, ReadersDataTable);

            return ReadersDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу авторов по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static АвторDataTable FilterAutor(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = АвторTableAdapter.Connection,
                CommandText = "SELECT Id_автора, Автор " +
                 $"FROM Автор {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(АвторTableAdapter.Adapter, filterUserCommand, AutorDataTable);

            return AutorDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу типы номенклатуры по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Типы_номенклатурыDataTable FilterBook(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = НоваяКнига.Connection,
                CommandText = "SELECT [Id_номенклатуры], [Название книги], Автор, Жанр," +
                "Издательство, [Год издания], Количество " +
                 $"FROM [Типы номенклатуры] {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(НоваяКнига.Adapter, filterUserCommand, BookDataTable);

            return BookDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу жанров по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ЖанрDataTable FilterЖанр(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ЖанрTableAdapter.Connection,
                CommandText = "SELECT Id, [Название жанра] " +
                 $"FROM Жанр {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ЖанрTableAdapter.Adapter, filterUserCommand, ЖанрDataTable);

            return ЖанрDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу годов издания по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Год_изданияDataTable Filterdate(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = год_ИзданияTableAdapter.Connection,
                CommandText = "SELECT Id, [Год издания] " +
                 $"FROM [Год издания] {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(год_ИзданияTableAdapter.Adapter, filterUserCommand, DateDataTable);

            return DateDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}
