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
using Библиотечная_система.Карточка_читателя;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Формы
{
    public partial class Новый_тип_номенклатуры : Form
    {
        public delegate void OnSave();

        public delegate void OnBeforeSave(Типы_номенклатурыRow isRecordExists);

        public Новый_тип_номенклатуры()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public void ЗагрузитьНовуюКнигу(string названиеКниги)
        {
            this.textBoxBook.Text = названиеКниги;
        }

        private bool CheckTextBoxes()
        {
            if (textBoxBook.Text == ""||textBoxAutor.Text==""||textBoxDate.Text==""
                ||textBoxIzd.Text==""||textBoxZhanr.Text==""||textBoxNumber.Text=="")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Названия элементов справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var BookName = this.textBoxBook.Text;
            var adapter = new Типы_номенклатурыTableAdapter();
            adapter.Fill(EntityManager.BookDataTable);
            Типы_номенклатурыRow existingBook = null;
            foreach (var books in EntityManager.BookDataTable)
            {
                if (books.Название_книги == BookName)
                {
                    existingBook = books;
                    break;
                }
            }

            if (existingBook != null)
            {
                this.OnBeforeSaveEvent(existingBook);
                MessageBox.Show("Книга с таким названием уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newBook = EntityManager.BookDataTable.NewТипы_номенклатурыRow();
            newBook.Название_книги = BookName;
            newBook.Автор = textBoxAutor.Text;
            newBook.Год_издания = textBoxDate.Text;
            newBook.Издательство = textBoxIzd.Text;
            newBook.Жанр = textBoxZhanr.Text;
            newBook.Количество = Convert.ToInt32(textBoxNumber.Text);
            EntityManager.BookDataTable.AddТипы_номенклатурыRow(newBook);
            EntityManager.UpdateBook();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar))) return;
            else
                e.Handled = true;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            var окноЖанра = new Жанр();
            if (окноЖанра.ShowDialog() == DialogResult.OK)
            {
                this.textBoxZhanr.Text = окноЖанра.ПолучитьЖанр();
            }
        }

        private void textBoxBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var окноДаты = new Год_издания();
            if (окноДаты.ShowDialog() == DialogResult.OK)
            {
                this.textBoxDate.Text = окноДаты.ПолучитьГодИздания();
            }
        }
    }
}
