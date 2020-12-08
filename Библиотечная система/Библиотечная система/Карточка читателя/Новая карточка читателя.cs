using DGV2Printer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Библиотечная_система.БиблиотекаDataSetTableAdapters;
using Библиотечная_система.Формы;
using static Библиотечная_система.БиблиотекаDataSet;

namespace Библиотечная_система.Карточка_читателя
{
    public partial class Новая_карточка_читателя : Form
    {
        private Dictionary<string, string[]> sexToHeightMap = new Dictionary<string, string[]>
        {
             {
                "Мужской",
                new string[]
                {
                    
                }
            },
            {
                "Женский",
                new string[]
                {
                   
                }
            }
        };

        private ЧитателиRow читатели;

        private Типы_номенклатурыTableAdapter типы_НоменклатурыTableAdapter;
        private АвторTableAdapter АвторTableAdapter;
        private БиблиотекаDataSet parentбиблиотекаDataSet;

        public Новая_карточка_читателя(Типы_номенклатурыTableAdapter типы_НоменклатурыTableAdapter, АвторTableAdapter АвторTableAdapter,БиблиотекаDataSet библиотекаDataSet)
        {
            this.InitializeComponent();

            this.DateJobChancheTimePicker.Value = DateTime.Now;
            this.DateJobChancheTimePicker.Value = this.ReceiptDateTimePicker.Value.AddDays(14);

            this.типы_НоменклатурыTableAdapter = типы_НоменклатурыTableAdapter;
            this.АвторTableAdapter = АвторTableAdapter;
            this.parentбиблиотекаDataSet = библиотекаDataSet;

        }

        public void LoadКарточка_читателя(ЧитателиЗапросRow читатели)
        {
            this.читатели = EntityManager.FilterReaders($"Id={читатели.Id}").FirstOrDefault();
            this.textBoxFIO.Text = читатели.ФИО;
            this.tbNumberPhone.Text = читатели.Номер_телефона;
            this.tbSeriya.Text = Convert.ToInt32(читатели.Серия_паспорта).ToString();
            this.tbNumber.Text = Convert.ToInt32(читатели.Номер_паспорта).ToString();
            this.label22.Text = читатели.ФИО;
            this.tbStreet.Text = читатели.Адрес_проживания;

            if (!читатели.IsПолNull())
            {
                this.comboBoxPol.SelectedIndex = this.comboBoxPol.Items.IndexOf(читатели.Пол);
            }

            this.книги_по_нормамЗапросTableAdapter.Fill(this.библиотекаDataSet.Книги_по_нормамЗапрос,читатели.Id);
            this.история_выдачЗапросTableAdapter.Fill(this.библиотекаDataSet.История_выдачЗапрос, читатели.Id);
        }

        private bool CheckTextBoxes()
        {
            if (this.textBoxFIO.Text == "" || this.tbNumberPhone.Text == ""
                || this.tbSeriya.Text == "" || this.tbNumber.Text == ""
                || this.comboBoxPol.Text == "")
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var idEmployee = this.читатели?.Id;
                var adapter = new ЧитателиTableAdapter();
                adapter.Fill(EntityManager.ReadersDataTable);
                var savingReaders = EntityManager.ReadersDataTable.FindById(idEmployee ?? -1)
                    ?? EntityManager.ReadersDataTable.NewЧитателиRow();
                savingReaders.ФИО = this.textBoxFIO.Text;
                savingReaders.Дата_выдачи = this.ReceiptDateTimePicker.Value
                    .AddHours(-this.ReceiptDateTimePicker.Value.Hour)
                    .AddMinutes(-this.ReceiptDateTimePicker.Value.Minute)
                    .AddSeconds(-this.ReceiptDateTimePicker.Value.Second)
                    .AddMilliseconds(-this.ReceiptDateTimePicker.Value.Millisecond);
                savingReaders.Дата_сдачи = this.DateJobChancheTimePicker.Value
                    .AddHours(-this.DateJobChancheTimePicker.Value.Hour)
                    .AddMinutes(-this.DateJobChancheTimePicker.Value.Minute)
                    .AddSeconds(-this.DateJobChancheTimePicker.Value.Second)
                    .AddMilliseconds(-this.DateJobChancheTimePicker.Value.Millisecond);
                savingReaders.Номер_телефона = this.tbNumberPhone.Text;
                savingReaders.Серия_паспорта = Convert.ToInt32(this.tbSeriya.Text);
                savingReaders.Номер_паспорта = Convert.ToInt32(this.tbNumber.Text);
                savingReaders.Пол = (string)this.comboBoxPol.SelectedItem;
                savingReaders.Адрес_проживания = this.tbStreet.Text;

                try
                {
                    if (this.читатели == null)
                    {
                        EntityManager.ReadersDataTable.AddЧитателиRow(savingReaders);
                        EntityManager.UpdateReaders();
                    }
                    else
                    {
                        var читателиTableAdaper = new ЧитателиTableAdapter();
                        читателиTableAdaper.Adapter.Update(savingReaders.Table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ошибка при добавлении/изменении! \r\n" + ex.ToString(),
                        "Ошибка",
                        MessageBoxButtons.OK);
                    return;
                }

                var message = this.читатели == null
                    ? "Добавление прошло успешно!"
                    : "Изменение завершено успешно!";

                MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Входные данные имели неверный формат! Проверте заполненость полей!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsReadersNumbersExists(ЧитателиRow savingReaders,int cardNumber)
        {
            foreach (var reader in EntityManager.ReadersDataTable)
            {
                if ((reader.Номер_карточки == cardNumber)
                    && (savingReaders.IsNull(0) || reader.Id != savingReaders.Id))
                {
                    return true;
                }
            }

            return false;
        }

        private void comboBoxPol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.sexToHeightMap.TryGetValue(this.comboBoxPol.SelectedItem.ToString(), out var heightArray))
            {
                throw new Exception("Выбран неправильный пол");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Вы действиетльно хотите закрыть данную вкладку?",
                "Закрытие вкладки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void DateJobChancheTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tbNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void ReceiptDateTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void buttonPickUpWarehouse_Click(object sender, EventArgs e)
        {
            Новая_книга открыть = new Новая_книга();
            if (открыть.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (this.читатели == null || this.читатели.IsNull("Id"))
            {
                MessageBox.Show("Читатель должен быть сохранён", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var newSpecialWriter = this.библиотекаDataSet.Книги_по_нормам.NewКниги_по_нормамRow();

            var writerNomecl = (Типы_номенклатурыЗапросRow)открыть.GetWriterRow();
            if (writerNomecl == null)
            {
                MessageBox.Show("Не была выбрана строка с номенклатурой", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            writerNomecl.Количество -= 1;
            newSpecialWriter.Наименование = writerNomecl.Название_книги;
            newSpecialWriter.Автор = writerNomecl.Автор;
            newSpecialWriter.Тип_номенклатуры = writerNomecl.Id_номенклатуры;
            var now = DateTime.Now;
            newSpecialWriter.Дата_выдачи_книги = now;
            newSpecialWriter.Предполагаемая_дата_сдачи = this.DateJobChancheTimePicker.Value;
            newSpecialWriter.Читатель = this.читатели.Id;

            this.библиотекаDataSet.Книги_по_нормам.AddКниги_по_нормамRow(newSpecialWriter);
            открыть.UpdateBooks(writerNomecl);
            this.UpdateЧитателей();
        }

        private void UpdateЧитателей()
        {
            this.книги_по_нормамTableAdapter.Update(this.библиотекаDataSet.Книги_по_нормам);
            this.книги_по_нормамTableAdapter.Fill(this.библиотекаDataSet.Книги_по_нормам);
            this.книги_по_нормамЗапросTableAdapter.Fill(this.библиотекаDataSet.Книги_по_нормамЗапрос, this.читатели.Id);
            this.история_выдачЗапросTableAdapter.Fill(this.библиотекаDataSet.История_выдачЗапрос, this.читатели.Id);
        }

        private void dateDeliveryButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Строка пустая! Заполните данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Дата_сдачи формаИзмененияДатыСдачиКниги = new Дата_сдачи();
            var строкаКнигиПоНормамЗапрос = (Книги_по_нормамЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
            книги_по_нормамTableAdapter.Fill(библиотекаDataSet.Книги_по_нормам);
            var строкаКнигиПоНормам = this.библиотекаDataSet.Книги_по_нормам.FindById(строкаКнигиПоНормамЗапрос.Id);
            if (формаИзмененияДатыСдачиКниги.ShowDialog() == DialogResult.OK)
            {
                var типы_номенклатурыTableAdapter = new Типы_номенклатурыTableAdapter();
                типы_номенклатурыTableAdapter.ClearBeforeFill = true;
                типы_номенклатурыTableAdapter.Fill(this.библиотекаDataSet.Типы_номенклатуры);

                var сдаваемаяКнига = this.библиотекаDataSet.Типы_номенклатуры.FindById_номенклатуры(строкаКнигиПоНормам.Тип_номенклатуры);
                сдаваемаяКнига.Количество += 1;

                строкаКнигиПоНормам.Реальная_дата_сдачи = формаИзмененияДатыСдачиКниги.GetDateValue();

                типы_номенклатурыTableAdapter.Update(this.библиотекаDataSet.Типы_номенклатуры);
                this.UpdateЧитателей();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Строка пустая! Заполните данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var строкаКнигиПоНормамЗапрос = (Книги_по_нормамЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
            var deleteСтрокаКнигиПоНормам = MessageBox.Show("Вы дейсвительно хотите удалить книгу", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteСтрокаКнигиПоНормам != DialogResult.Yes)
            {
                return;
            }
            using (var command = this.книги_по_нормамTableAdapter.Connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM `Книги по нормам` WHERE `Id` =" +
                    $"{строкаКнигиПоНормамЗапрос.Id}";
                this.книги_по_нормамTableAdapter.Connection.Open();
                command.ExecuteNonQuery();
                this.книги_по_нормамTableAdapter.Connection.Close();
            }
            this.UpdateЧитателей();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var pr = new PrintDataGridView(this.dataGridView);
            pr.isRightToLeft = true;
            pr.ReportHeader = this.label22.Text;
            pr.Print();
        }

        private void tbSeriya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
