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
    public partial class Жанр : Form
    {
        public Жанр()
        {
            InitializeComponent();
        }

        public string ПолучитьЖанр()
        {
            return ((ЖанрRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row).Название_жанра;
        }

        private void Жанр_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Жанр". При необходимости она может быть перемещена или удалена.
            this.жанрTableAdapter.Fill(this.библиотекаDataSet.Жанр);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
