using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Библиотечная_система.БиблиотекаDataSetTableAdapters;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Карточка_читателя
{
    public partial class Книги : Form
    {
        private Типы_номенклатурыRow книги;

        private Типы_номенклатурыTableAdapter типы_НоменклатурыTableAdapter;
        private БиблиотекаDataSet библиотекаDataSet;

        public Книги(Типы_номенклатурыTableAdapter типы_НоменклатурыTableAdapter, БиблиотекаDataSet библиотекаDataSet)
        {
            InitializeComponent();

            this.типы_НоменклатурыTableAdapter = типы_НоменклатурыTableAdapter;
            this.библиотекаDataSet = библиотекаDataSet;
        }

        public void LoadКниги(Типы_номенклатурыЗапросRow книги)
        {
            this.книги = EntityManager.FilterBook($"Id_номенклатуры={книги.Id_номенклатуры}").FirstOrDefault();
            this.tbBookName.Text = книги.Название_книги;
            this.tbAutor.Text = книги.Автор;
            this.tbIZD.Text = книги.Издательство;
            this.tbZhanr.Text = книги.Жанр;
            this.tbSum.Text = книги.Количество.ToString();
            this.tbDate.Text = книги.Год_издания;
        }

        private bool CheckTextBoxes()
        {
            if (this.tbBookName.Text == "" || this.tbAutor.Text == ""
                || this.tbIZD.Text == "" || this.tbZhanr.Text == ""
                || this.tbSum.Text == ""||this.tbDate.Text=="")
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idEmployee=this.книги?.Id_номенклатуры;
            var adapter = new Типы_номенклатурыTableAdapter();
            adapter.Fill(EntityManager.BookDataTable);
            var savingBook = EntityManager.BookDataTable.FindById_номенклатуры(idEmployee ?? -1)
                ?? EntityManager.BookDataTable.NewТипы_номенклатурыRow();
            savingBook.Название_книги = this.tbBookName.Text;
            savingBook.Автор = this.tbAutor.Text;
            savingBook.Издательство = this.tbIZD.Text;
            savingBook.Жанр = this.tbZhanr.Text;
            savingBook.Количество = Convert.ToInt32(this.tbSum.Text);
            savingBook.Год_издания = this.tbDate.Text;

            try
            {
                if (this.книги == null)
                {
                    EntityManager.BookDataTable.AddТипы_номенклатурыRow(savingBook);
                    EntityManager.UpdateBook();
                }
                else
                {
                    var книгиTableAdapter = new Типы_номенклатурыTableAdapter();
                    книгиTableAdapter.Adapter.Update(savingBook.Table);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                       "Ошибка при добавлении/изменении! \r\n" + ex.ToString(),
                       "Ошибка",
                       MessageBoxButtons.OK);
                return;
            }
            var message = this.книги == null
                    ? "Добавление прошло успешно!"
                    : "Изменение завершено успешно!";

            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Вы действиетльно хотите закрыть данную вкладку?",
                "Закрытие вкладки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
