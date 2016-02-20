using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiamat.WindowsForms
{
    public partial class ChartOfAccounts : Form
    {
        List<object> items = new List<object>();

        public ChartOfAccounts()
        {
            InitializeComponent();
        }

        private void button_pluse_Click(object sender, EventArgs e)
        {
            listBox.Font = new Font(listBox.Font.FontFamily, listBox.Font.Size + 1);

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            
            if (listBox.Font.Size>5)
            {
                listBox.Font = new Font(listBox.Font.FontFamily, listBox.Font.Size - 1);
            }
        }

       

        private void ChartOfAccounts_Load(object sender, EventArgs e)
        {
            foreach (var item in listBox.Items)
            {
                items.Add(item);
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.ToString().ToLower().Contains(textBox_search.Text.ToLower()))
                {
                    listBox.Items.Add(item);
                }
            }
        }
    }
}
