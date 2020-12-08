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
    public partial class Дата_сдачи : Form
    {
        public Дата_сдачи()
        {
            InitializeComponent();
        }

        public DateTime GetDateValue()
        {
            return this.dateTimePicker1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date))
            {
                MessageBox.Show("Нельзя выбрать предыдующую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }
    }
}
