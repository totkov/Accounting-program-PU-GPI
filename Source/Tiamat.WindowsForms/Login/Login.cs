using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tiamat.WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel_singUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Грешен потребител или парола!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, e);
            }
        }

        private bool ValidateForm()
        {
            if (!ValidateLogin())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_login_Validating(object sender, CancelEventArgs e)
        {
            ValidateLogin();
        }
        private bool ValidateLogin()
        {
            if (IsLoginValid(textBox_username.Text, textBox_password.Text))
            {
                errorProvider.SetError(button_login, "");
                return true;
            }
            else
            {
                errorProvider.SetError(button_login, "Невалиден потребител или парола");
                return false;
            }
        }
        private bool IsLoginValid(string user, string pass)
        {
            using (FileStream stream = new FileStream("users.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {

                        string line = reader.ReadLine(); // username|password|email|firstname|lastname
                        string[] data = line.Split('|'); // {username, passwors, email, firsname, lastname}
                        if (user == data[0] && pass == data[1])
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }

}
