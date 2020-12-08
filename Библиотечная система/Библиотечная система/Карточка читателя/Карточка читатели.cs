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
    public partial class Карточка_читатели : Form
    {
        public Карточка_читатели()
        {
            InitializeComponent();
        }

        public ЧитателиRow GetCurrentEmployee()
        {
            return (ЧитателиRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
        }

        private void Карточка_читатели_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.библиотекаDataSet.Читатели);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.читателиBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }
    }
}
