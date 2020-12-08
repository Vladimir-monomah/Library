using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Библиотечная_система.Формы;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        private void button37_Click(object sender, EventArgs e)
        {
            Автор открыть = new Автор();
            открыть.OnSaveEvent += () =>
            {
                this.авторTableAdapter.Fill(this.библиотекаDataSet.Автор);
            };
            открыть.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.авторTableAdapter.Update(this.библиотекаDataSet);
            this.авторTableAdapter.Fill(this.библиотекаDataSet.Автор);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView7.SelectedCells[0].RowIndex;
            this.dataGridView7.Rows.RemoveAt(ind);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.авторBindingSource.Filter = "[Автор] Like'" + textBox7.Text + "%'";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
        }
    }
}
