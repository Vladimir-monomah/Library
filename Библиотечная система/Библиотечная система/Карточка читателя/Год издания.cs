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
    public partial class Год_издания : Form
    {
        public Год_издания()
        {
            InitializeComponent();
        }

        public string ПолучитьГодИздания()
        {
            return ((Год_изданияRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row).Год_издания.ToString();
        }

        private void Год_издания_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Год_издания". При необходимости она может быть перемещена или удалена.
            this.год_изданияTableAdapter.Fill(this.библиотекаDataSet.Год_издания);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
