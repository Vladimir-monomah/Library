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

namespace Библиотечная_система.Формы
{
    public delegate void OnTave();

    public delegate void OnBeforeTave(ЖанрRow isRecordExists);

    public partial class Жанр_книг : Form
    {
        public Жанр_книг()
        {
            this.OnTaveEvent += () => { };
            this.OnBeforeTaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnTave OnTaveEvent;

        public event OnBeforeTave OnBeforeTaveEvent;

        public void ЗагрузитьЖанр(string названиеЖанра)
        {
            this.textBoxZhanr.Text = названиеЖанра;
        }

        private bool CheckTextBoxes()
        {
            if (textBoxZhanr.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var ZhanrName = this.textBoxZhanr.Text;
            var adapter = new ЖанрTableAdapter();
            adapter.Fill(EntityManager.ЖанрDataTable);
            ЖанрRow existingDepartaments = null;
            foreach (var departaments in EntityManager.ЖанрDataTable)
            {
                if (departaments.Название_жанра == ZhanrName)
                {
                    existingDepartaments = departaments;
                    break;
                }
            }

            if (existingDepartaments != null)
            {
                this.OnBeforeTaveEvent(existingDepartaments);
                MessageBox.Show("Жанр с таким названием уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newDepartaments = EntityManager.ЖанрDataTable.NewЖанрRow();
            newDepartaments.Название_жанра= ZhanrName;
            EntityManager.ЖанрDataTable.AddЖанрRow(newDepartaments);
            EntityManager.UpdateЖанр();
            this.OnTaveEvent();
        }

        private void textBoxZhanr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
