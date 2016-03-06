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
    public partial class AccountNote : Form
    {
        private bool mode = true;

        public AccountNote()
        {
            InitializeComponent();
        }

        public void Save()
        {
            string filePath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\";
            save.Title = "Запиши като";
            save.DefaultExt = "txt";
            save.Filter = "Account note (*.txt)|*.txt";
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
                using (FileStream stream = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                if (dataGridView[j, i].Value != null)
                                {
                                    writer.Write(dataGridView[j, i].Value.ToString() + "|");
                                }
                                else
                                {
                                    writer.Write(" " + "|");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Възникна грешка при записване, моля опитайте отново!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
        }

        public void Load()
        {
            string filePath = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = string.Empty;
            open.InitialDirectory = "C";
            open.Title = "Отвори";
            open.Filter = "Account note (*.txt)|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;

                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        DataTable table = new DataTable();

                        DataColumn column;
                        DataRow row;
                        DataView view;

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Дебит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Кредит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Сума";
                        table.Columns.Add(column);

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] data = line.Split('|');

                            row = table.NewRow();

                            row["Дебит"] = data[0];
                            row["Кредит"] = data[1];
                            row["Сума"] = data[2];

                            table.Rows.Add(row);
                        }

                        view = new DataView(table);

                        dataGridView.DataSource = view;
                    }
                }
            }
            else
            {
                MessageBox.Show("Възникна грешка при отваряне, моля опитайте отново!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void New()
        {
            dataGridView.Columns.Add("Debit", "Дебит");
            dataGridView.Columns.Add("Credit", "Кредит");
            dataGridView.Columns.Add("Sum", "Сума");
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            toolStripStatusLabel_Rows.Text = "Редове: " + dataGridView.Rows.Count.ToString();
            if (mode)
            {
                ToolStripMenuItem_Light_Click(sender, e);
            }
            else
            {
                ToolStripMenuItem_Dark_Click(sender, e);
            }
        }

        private void ToolStripMenuItem_Light_Click(object sender, EventArgs e)
        {
            mode = true;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (i % 2 == 0)
                    {
                        dataGridView[j, i].Style.BackColor = Color.White;
                        dataGridView[j, i].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        dataGridView[j, i].Style.BackColor = Color.LightBlue;
                        dataGridView[j, i].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void ToolStripMenuItem_Dark_Click(object sender, EventArgs e)
        {
            mode = false;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (i % 2 == 0)
                    {
                        dataGridView[j, i].Style.BackColor = Color.DarkViolet;
                        dataGridView[j, i].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView[j, i].Style.BackColor = Color.DarkBlue;
                        dataGridView[j, i].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
