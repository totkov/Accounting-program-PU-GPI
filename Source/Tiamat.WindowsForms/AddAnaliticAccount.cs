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
    public partial class AddAnaliticAccount : Form
    {
        public AddAnaliticAccount()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream("account.txt",FileMode.Append))
            {
                using (StreamWriter writer=new StreamWriter(stream))
                {
                    writer.WriteLine("{0} {1} {2} {3}", textBox_number.Text, textBox_extention.Text, textBox_name.Text, textBox_newname.Text);
                }
            }
            this.Close();
        }

        private void textBox_newname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button_add_Click(sender, e);
            }
        }

    }
}
