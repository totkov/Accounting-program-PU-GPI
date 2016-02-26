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
            string userName = textBox_username.Text;
            string pass = textBox_password.Text;
            CheckUser(userName, pass);
        }

        private void CheckUser(string username, string password)
        {
            using (FileStream stream = new FileStream("users.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {

                        string line = reader.ReadLine(); // username|password|email|firstname|lastname
                        string[] data = line.Split('|'); // {username, passwors, email, firsname, lastname}
                        if (username == data[0] && password == data[1])
                        {
                            MessageBox.Show("Ok");
                            return;
                        }
                    }
                }
            }

        }
    }

}
