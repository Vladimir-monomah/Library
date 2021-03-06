﻿using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты : Form
    {

        private OleDbConnection connection;

        public Объекты()
        {
            InitializeComponent();
            this.Объекты_Load();
        }

        public TabPage GetTabByName(string tabName)
        {
            return (TabPage)this.GetType()
                .GetField(tabName, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
        }

        public void Объекты_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Жанр". При необходимости она может быть перемещена или удалена.
            this.жанрTableAdapter.Fill(this.библиотекаDataSet.Жанр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Автор". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.библиотекаDataSet.Автор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Автор". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.библиотекаDataSet.Автор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.ЧитателиЗапрос". При необходимости она может быть перемещена или удалена.
            this.читателиЗапросTableAdapter.Fill(this.библиотекаDataSet.ЧитателиЗапрос);
        }

        private void Объекты_Load(object sender, System.EventArgs e)
        {

        }
    }
}
