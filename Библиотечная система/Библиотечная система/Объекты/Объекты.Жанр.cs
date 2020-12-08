using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {

        private void button4_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            this.жанрBindingSource.Filter= "[Название жанра] Like'" + this.textBox1.Text + "%'";
        }
    }
}
