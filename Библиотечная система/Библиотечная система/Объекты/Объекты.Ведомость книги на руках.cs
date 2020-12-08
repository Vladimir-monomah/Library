using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Библиотечная_система.БиблиотекаDataSet;
using Библиотечная_система.Карточка_читателя;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        private ЧитателиRow читателиВедомость;

        public string FIO_LIB { get; set; }

        private void button6_Click(object sender, System.EventArgs e)
        {
            var карточкиЧитателей = new Карточка_читатели();
            if (карточкиЧитателей.ShowDialog() == DialogResult.OK)
            {
                var выбранныйЧитатель = карточкиЧитателей.GetCurrentEmployee();
                this.textBox2.Text = выбранныйЧитатель.ФИО;
                this.читатели = выбранныйЧитатель;
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            DateTime dateBegin;
            DateTime dateEnd;
            if (string.IsNullOrWhiteSpace(this.textBox9.Text))
            {
                this.читатели = null;
            }

            if (this.radioButton2.Checked)
            {
                var choosedDate = DateTime.ParseExact(
                    this.dateTimePicker3.Value.ToString("dd.MM.yyyy"),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                dateBegin = choosedDate.AddDays(1 - choosedDate.Day);
                dateEnd = choosedDate.AddDays(
                    DateTime.DaysInMonth(choosedDate.Year, choosedDate.Month) - choosedDate.Day)
                    .AddHours(23)
                    .AddMinutes(59)
                    .AddSeconds(59)
                    .AddMilliseconds(999);
            }
            else if (this.radioButton1.Checked)
            {
                dateBegin = DateTime.ParseExact(
                    this.dateTimePicker2.Value.ToString("dd.MM.yyyy"),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                dateEnd = DateTime.ParseExact(
                        this.dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                        "dd.MM.yyyy",
                        CultureInfo.InvariantCulture)
                    .AddHours(23)
                    .AddMinutes(59)
                    .AddSeconds(59)
                    .AddMilliseconds(999);
            }
            else
            {
                MessageBox.Show("Выберите период формирования отчёта!");
                return;
            }

            try
            {
                this.ведомость_книги_на_рукахTableAdapter.Fill(this.библиотекаDataSet.Ведомость_книги_на_руках,
                    dateBegin,
                    dateEnd,
                    this.читатели?.Id ?? -1,
                    this.читатели?.Id ?? -1,
                    dateBegin,
                    dateEnd,
                    this.читатели == null ? "0" : "1");
                this.reportViewer2.LocalReport.SetParameters(new ReportParameter(
                    "IsDataNULL",
                    (this.библиотекаDataSet.Ведомость_книги_на_руках.Rows.Count == 0).ToString()));
                this.reportViewer2.LocalReport.SetParameters(new ReportParameter("FIO_Lib", this.FIO_Lib));
                this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet", (DataTable)this.библиотекаDataSet.Ведомость_книги_на_руках));
                this.reportViewer2.RefreshReport();
            }
            catch (Exception exception)
            {

            }
        }
    }
}
