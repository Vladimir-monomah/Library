using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Библиотечная_система.Формы
{
    public partial class Благодарности : Form
    {
        public Благодарности()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ss_evgen_ss@mail.ru");
        }
    }
}
