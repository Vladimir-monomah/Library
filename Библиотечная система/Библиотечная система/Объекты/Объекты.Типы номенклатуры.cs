using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Библиотечная_система.Формы;
using static Библиотечная_система.БиблиотекаDataSet;
using Библиотечная_система.Карточка_читателя;
using System.Data;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        private bool ExistsТипНоменклатуры(Типы_номенклатурыRow типы_НоменклатурыRow)
        {
            foreach(Типы_номенклатурыRow row in this.библиотекаDataSet.Типы_номенклатуры.Rows)
            {
                if (row.Название_книги == типы_НоменклатурыRow.Название_книги)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Добавить типы номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button42_Click(object sender, EventArgs e)
        {
            Новый_тип_номенклатуры открыть = new Новый_тип_номенклатуры();
            открыть.OnSaveEvent += () =>
            {
                this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            };
            открыть.ShowDialog();
        }

        private void setReadOnlyТип_номенклатуры(bool mode)
        {
            this.названиеКнигиDataGridViewTextBoxColumn.ReadOnly = mode;
        }

        /// <summary>
        /// Кнопка сохранить тип номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button39_Click(object sender, EventArgs e)
        {
            this.типы_номенклатурыЗапросTableAdapter.Update(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
            this.setReadOnlyТип_номенклатуры(true);
        }

        /// <summary>
        /// Удалить тип номенклатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button40_Click(object sender, EventArgs e)
        {
            var deleteNomen = MessageBox.Show("Вы действительно хотите удалить тип номенклатуры?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteNomen != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView8.SelectedCells[0].RowIndex;
            this.dataGridView8.Rows.RemoveAt(ind);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.типыНоменклатурыЗапросBindingSource.Filter = this.BuildCardFilter();
        }

        private string BuildCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox8.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([Жанр] Like '%{0}%') OR ([Автор] Like '%{0}%') OR ([Название книги] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }

        /// <summary>
        /// Очистить текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button43_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            var открыть = new Книги(this.типы_номенклатурыTableAdapter,библиотекаDataSet);
            открыть.ShowDialog();

            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
        }

        private void dataGridView8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var открыть = new Книги(this.типы_номенклатурыTableAdapter, библиотекаDataSet);
            открыть.LoadКниги(
                (Типы_номенклатурыЗапросRow)((DataRowView)this.dataGridView8.CurrentRow.DataBoundItem).Row);
            открыть.ShowDialog();

            this.типы_номенклатурыЗапросTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатурыЗапрос);
        }
    }
}
