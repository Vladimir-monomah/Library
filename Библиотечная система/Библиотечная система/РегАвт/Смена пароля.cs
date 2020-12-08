using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Библиотечная_система.РегАвт
{
    public delegate bool ValidateUser(string login, string newPassword);

    public partial class Смена_пароля : Form
    {
        public event ValidateUser OnValidateUser;
        public Смена_пароля()
        {
            this.OnValidateUser += (login, newPassword) => { return true; };
            InitializeComponent();
        }

        public string GetLogin()
        {
            return this.textBoxLogin.Text;
        }

        public string GetNewPassword()
        {
            return this.textBoxNewPassword.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxRepeatNewPassword.Text != this.textBoxNewPassword.Text)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Введённые новые пароли не совпадают");
            }
            else if (!this.OnValidateUser(this.GetLogin(), this.GetNewPassword()))
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxNewPassword.PasswordChar = this.textBoxRepeatNewPassword.PasswordChar =
                this.checkBoxShowPassword.Checked
                ? (char)0
                : '*';
        }
    }
}
