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
    public partial class Добавить_год_издания : Form
    {
        public delegate void OnTave();

        public delegate void OnBeforeTave(Год_изданияRow isRecordExists);

        public Добавить_год_издания()
        {
            this.OnTaveEvent += () => { };
            this.OnBeforeTaveEvent += isRecordExists => { };
            InitializeComponent();
        }

        public event OnTave OnTaveEvent;

        public event OnBeforeTave OnBeforeTaveEvent;

        public void ЗагрузитьГодИздания(string годИзд)
        {
            this.textBoxDate.Text = годИзд;
        }

        private bool CheckTextBoxes()
        {
            if (this.textBoxDate.Text == "")
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

            var Date = this.textBoxDate.Text;
            var adapter = new Год_изданияTableAdapter();
            adapter.Fill(EntityManager.DateDataTable);
            Год_изданияRow existingDepartaments = null;
            foreach (var departaments in EntityManager.DateDataTable)
            {
                if (departaments.Год_издания == Convert.ToInt32(Date))
                {
                    existingDepartaments = departaments;
                    break;
                }
            }

            if(existingDepartaments != null)
            {
                this.OnBeforeTaveEvent(existingDepartaments);
                MessageBox.Show("Год издания уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newDepartaments = EntityManager.DateDataTable.NewГод_изданияRow();
            newDepartaments.Год_издания = Convert.ToInt32(Date);
            EntityManager.DateDataTable.AddГод_изданияRow(newDepartaments);
            EntityManager.UpdateDate();
            this.OnTaveEvent();

            MessageBox.Show("Добавление прошло успешно", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(","))
                | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
