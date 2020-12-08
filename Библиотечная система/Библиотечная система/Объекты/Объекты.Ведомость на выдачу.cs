using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Библиотечная_система.Карточка_читателя;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Объекты
{
    public partial class Объекты
    {
        private ЧитателиRow читатели;

        public string FIO_Lib { get; set; }

        private void button47_Click(object sender, System.EventArgs e)
        {
            var карточкаЧитателя = new Карточка_читатели();
            if (карточкаЧитателя.ShowDialog() == DialogResult.OK)
            {
                var выбранныйСотрудник = карточкаЧитателя.GetCurrentEmployee();
                this.textBox9.Text = выбранныйСотрудник.ФИО;
                this.читатели = выбранныйСотрудник;
            }
        }

        private void button44_Click(object sender, System.EventArgs e)
        {
            DateTime dateBegin;
            DateTime dateEnd;
            if (string.IsNullOrWhiteSpace(this.textBox9.Text))
            {
                this.читатели = null;
            }

            if (this.onMonthRadioButton.Checked)
            {
                var choosedDate = DateTime.ParseExact(
                    this.onMonthDateTimePicker.Value.ToString("dd.MM.yyyy"),
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
            else if (this.onPeriodRadioButton.Checked)
            {
                dateBegin = DateTime.ParseExact(
                    this.onPeriodBeginDateTimePicker.Value.ToString("dd.MM.yyyy"),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                dateEnd = DateTime.ParseExact(
                        this.onPeriodEndDateTimePicker.Value.ToString("dd.MM.yyyy"),
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
                this.ведомость_на_выдачуTableAdapter.Fill(this.библиотекаDataSet.Ведомость_на_выдачу,
                    dateBegin,
                    dateEnd,
                    this.читатели?.Id ?? -1,
                    this.читатели?.Id ?? -1,
                    dateBegin,
                    dateEnd,
                    this.читатели == null ? "0" : "1");
                //var resultTable = this.getВедомостьНаВыдачуTable(dateBegin, dateEnd, this.onlyWorkingReportCheckBox.Checked);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter(
                    "IsDataNull",
                    (this.библиотекаDataSet.Ведомость_на_выдачу.Rows.Count == 0).ToString()));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("FIO_Lib", this.FIO_Lib));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)this.библиотекаDataSet.Ведомость_на_выдачу));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exception)
            {

            }
        }
    }
}
