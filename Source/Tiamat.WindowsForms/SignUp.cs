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
            bool isValid = textBox_Username.Text != String.Empty &&
                textBox_Password.Text != String.Empty &&
                textBox_RePass.Text != String.Empty &&
                textBox_Mail.Text != String.Empty &&
                textBox_FirstName.Text != String.Empty &&
                textBox_LastName.Text != String.Empty &&
                textBox_Password.Text == textBox_RePass.Text;
            if (isValid)
            {
                User user = new User(textBox_Username.Text, textBox_Password.Text, textBox_Mail.Text, textBox_FirstName.Text, textBox_LastName.Text);
                if (IsUnique(user))
                {
                    using (FileStream stream = new FileStream("users.txt", FileMode.Append))
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.WriteLine(textBox_Username.Text + "|" + textBox_Password.Text + "|" + textBox_Mail.Text + "|" + textBox_FirstName.Text + "|" + textBox_LastName.Text);
                            MessageBox.Show("Ok");
                        }
                    }
                }
            }
        }

        private bool IsUnique(User user)
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
                            if (data[0] == user.Username)
                            {
                                MessageBox.Show("Това потребителско име вече е заето", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else if (data[2] == user.Email)
                            {
                                MessageBox.Show("Вече съществува регистрация с този e-mail адрес", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
