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
    public partial class AnaliticAccounts : Form

    {
        List<object> items = new List<object>();

        public AnaliticAccounts()
        {
            InitializeComponent();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            listBox.Font = new Font(listBox.Font.FontFamily, listBox.Font.Size + 1);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (listBox.Font.Size > 5)
            {
                listBox.Font = new Font(listBox.Font.FontFamily, listBox.Font.Size - 1);
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

        private void AnaliticAccounts_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddAnaliticAccount add = new AddAnaliticAccount();
            add.ShowDialog();
            RefreshList();
        }

        private void RefreshList()
        {
            listBox.Items.Clear();
            items.Clear();
            using (FileStream stream = new FileStream("account.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        items.Add(reader.ReadLine());

                    }
                }
            }
            foreach (var item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void StripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            items.Remove(listBox.SelectedItem);
            using (FileStream stream = new FileStream("account.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (var item in items)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            RefreshList();
        }
    }
}
