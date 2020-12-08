using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Карточка_читателя
{
    public partial class Новая_книга : Form
    {
        public Новая_книга()
        {
            InitializeComponent();
        }

        public DataRow GetWriterRow()
        {
            return ((DataRowView)this.positionDataGridView.CurrentRow?.DataBoundItem)?.Row;
        }

        public void UpdateBooks(Типы_номенклатурыЗапросRow book)
        {
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
            var updatingBook = this.библиотекаDataSet.Типы_номенклатуры.FindById_номенклатуры(book.Id_номенклатуры);
            updatingBook.Количество -= 1;
            this.типы_номенклатурыTableAdapter.Update(this.библиотекаDataSet.Типы_номенклатуры);
        }

        public string ПолучитьКнигу()
        {
            return ((Типы_номенклатурыЗапросRow)((DataRowView)this.positionDataGridView.CurrentRow?.DataBoundItem)?.Row)?.Название_книги;
        }

        public string ПолучитьАвтора()
        {
            return ((Типы_номенклатурыЗапросRow)((DataRowView)this.positionDataGridView.CurrentRow?.DataBoundItem)?.Row)?.Автор;
        }

        private void Новая_книга_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатурыЗапрос". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Типы_номенклатуры". При необходимости она может быть перемещена или удалена.
            this.типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);
        }

        private void positionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            positionFilterTextBox.Text = string.Empty;
        }

        private void positionFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string resultFilterText = null;
            var filterText = this.positionFilterTextBox.Text;
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                resultFilterText = "[Название книги] LIKE '%{filterText}%'";
            }

            this.типыНоменклатурыBindingSource.Filter = resultFilterText;
        }
    }
}
