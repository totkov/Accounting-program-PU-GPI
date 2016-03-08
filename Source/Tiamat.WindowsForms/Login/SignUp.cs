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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel_BackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (FileStream stream = new FileStream("users.txt", FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(textBox_Username.Text + "|" + textBox_Password.Text + "|" + textBox_Mail.Text + "|" + textBox_FirstName.Text + "|" + textBox_LastName.Text);
                        MessageBox.Show("Регистрацията е успешна");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Моля попълнете коректно всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_SignUp_Click(sender, e);
            }
        }

        private bool ValidateForm()
        {
            if (!ValidateUsername())
            {
                return false;
            }
            if (!ValidatePassword())
            {
                return false;
            }
            if (!ValidateRePass())
            {
                return false;
            }
            if (!ValidateMail())
            {
                return false;
            }
            if (!ValidateFirstName())
            {
                return false;
            }
            if (!ValidateLastName())
            {
                return false;
            }

            return true;
        }

        private void textBox_Username_Validating(object sender, CancelEventArgs e)
        {
            ValidateUsername();
        }
        private bool ValidateUsername()
        {
            if (IsUsernameValid(textBox_Username.Text) && IsUsernameUnique(textBox_Username.Text))
            {
                errorProvider.SetError(textBox_Username, "");
                return true;
            }
            else if (!IsUsernameValid(textBox_Username.Text))
            {
                errorProvider.SetError(textBox_Username, "Попълнете коректно полето! Дължината на потребителското име трябва да е между 4 и 30 символа.");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox_Username, "Попълнете коректно полето! Това потребителско име вече е заето.");
                return false;
            }
        }
        private bool IsUsernameValid(string username)
        {
            if (username.Length >= 4 && username.Length <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsUsernameUnique(string username)
        {
            using (FileStream stream = new FileStream("users.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line != "")
                        {
                            string[] data = line.Split('|');
                            if (data[0] == username)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
            }
        }

        private void textBox_Password_Validating(object sender, CancelEventArgs e)
        {
            ValidatePassword();
        }
        private bool ValidatePassword()
        {
            if (IsPasswordValid(textBox_Password.Text))
            {
                errorProvider.SetError(textBox_Password, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_Password, "Попълнете коректно полето! Дължината на паролата трябва да е между 6 и 30 символа.");
                return false;
            }
        }
        private bool IsPasswordValid(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_RePass_Validating(object sender, CancelEventArgs e)
        {
            ValidateRePass();
        }
        private bool ValidateRePass()
        {
            if (IsRePassValid(textBox_Password.Text, textBox_RePass.Text))
            {
                errorProvider.SetError(textBox_RePass, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_RePass, "Паролата не съответства!");
                return false;
            }
        }
        private bool IsRePassValid(string pass, string rePass)
        {
            if (pass == rePass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_Mail_Validated(object sender, EventArgs e)
        {
            ValidateMail();
        }
        private bool ValidateMail()
        {
            if (IsMailValid(textBox_Mail.Text) && IsMailUnique(textBox_Mail.Text))
            {
                errorProvider.SetError(textBox_Mail, "");
                return true;
            }
            else if (!IsMailValid(textBox_Mail.Text))
            {
                errorProvider.SetError(textBox_Mail, "Попълнете коректно полето! Дължината на e-mail трябва да е между 6 и 30 символа.");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox_Mail, "Попълнете коректно полето! Този e-mail вече се използва.");
                return false;
            }
        }
        private bool IsMailValid(string mail)
        {
            if (mail.Length >= 6 && mail.Length <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsMailUnique(string mail)
        {
            using (FileStream stream = new FileStream("users.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line != "")
                        {
                            string[] data = line.Split('|');
                            if (data[2] == mail)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
            }
        }

        private void textBox_FirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateFirstName();
        }
        private bool ValidateFirstName()
        {
            if (IsFirstNameValid(textBox_FirstName.Text))
            {
                errorProvider.SetError(textBox_FirstName, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_FirstName, "Попълнете коректно полето! Дължината на името трябва да е между 2 и 20 символа.");
                return false;
            }
        }
        private bool IsFirstNameValid(string name)
        {
            if (name.Length >= 2 && name.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_LastName_Validated(object sender, EventArgs e)
        {
            ValidateLastName();
        }
        private bool ValidateLastName()
        {
            if (IsLastNameValid(textBox_LastName.Text))
            {
                errorProvider.SetError(textBox_LastName, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_LastName, "Попълнете коректно полето! Дължината на името трябва да е между 2 и 20 символа.");
                return false;
            }
        }
        private bool IsLastNameValid(string name)
        {
            if (name.Length >= 2 && name.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}