using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Библиотечная_система.РегАвт;
using Библиотечная_система.Формы;

namespace Библиотечная_система.Админка
{
    public partial class Администратор : Form
    {
        const string FilterNonAdministrators = "([Является администратором]=FALSE)";

        public Администратор()
        {
            InitializeComponent();
        }

        private void Администратор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.библиотекаDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.библиотекаDataSet.Пользователи);

        }

        ///<summary>
        ///Фильтрация пользователей
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"</param>
        private void clientFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, clientFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $"AND ({filterString})";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пользователиTableAdapter.Adapter.Update(this.библиотекаDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Библиотека.mdb";
            var saveDialog = new SaveFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(dataBasePath, saveDialog.FileName, true);
                    MessageBox.Show("Резервное копирование прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удаётся скопировать файл из-за исключения: " + exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Библиотека.mdb";
            var openDialog = new OpenFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openDialog.FileName, dataBasePath, true);
                    MessageBox.Show("Восстановление прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                пользователиTableAdapter.Adapter.Fill(библиотекаDataSet.Пользователи);
                пользователиTableAdapter.Adapter.Update(библиотекаDataSet.Пользователи);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var открыть = new Автор();
            открыть.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var открыть = new Новый_тип_номенклатуры();
            открыть.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int ind = dataGridView.SelectedCells[0].RowIndex;
            dataGridView.Rows.RemoveAt(ind);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.Filter = null;
            clientFilterTextBox.Text = "";
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var открыть = new Жанр_книг();
            открыть.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var открыть = new Авторизация();
            открыть.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var открыть = new Добавить_год_издания();
            открыть.Show();
        }
    }
}
