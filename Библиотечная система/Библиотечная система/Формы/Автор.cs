using System;
using System.Windows.Forms;
using Библиотечная_система.БиблиотекаDataSetTableAdapters;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Формы
{
    public delegate void OnSave();

    public delegate void OnBeforeSave(АвторRow isRecordExists);

    public partial class Автор : Form
    {
        public Автор()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public void ЗагрузитьАвтора(string Автор)
        {
            this.textBoxAutor.Text = Автор;
        }

        private bool CheckTextBoxes()
        {
            if (textBoxAutor.Text == "")
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

            var autorName = this.textBoxAutor.Text;
            var adapter = new АвторTableAdapter();
            adapter.Fill(EntityManager.AutorDataTable);
            АвторRow existingAutor = null;
            foreach (var autors in EntityManager.AutorDataTable)
            {
                if (autors.Автор == autorName)
                {
                    existingAutor = autors;
                    break;
                }
            }

            if (existingAutor != null)
            {
                this.OnBeforeSaveEvent(existingAutor);
                MessageBox.Show("Автор с таким именем уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newAutor = EntityManager.AutorDataTable.NewАвторRow();
            newAutor.Автор = autorName;
            EntityManager.AutorDataTable.AddАвторRow(newAutor);
            EntityManager.UpdateAutor();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void textBoxAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
