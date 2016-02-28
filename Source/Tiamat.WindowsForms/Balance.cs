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
    public partial class Balance : Form
    {
        public Balance()
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
            save.Filter = "Balance (*.txt)|*.txt";
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
                        column.ColumnName = "Счетоводни сметки";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Начално салдо - Дебит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Начално салдо - Кредит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Оборот - Дебит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Оборот - Кредит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Крайно салдо - Дебит";
                        table.Columns.Add(column);

                        column = new DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = "Крайно салдо - Кредит";
                        table.Columns.Add(column);

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] data = line.Split('|');

                            row = table.NewRow();

                            row["Счетоводни сметки"] = data[0];
                            row["Начално салдо - Дебит"] = data[1];
                            row["Начално салдо - Кредит"] = data[2];
                            row["Оборот - Дебит"] = data[3];
                            row["Оборот - Кредит"] = data[4];
                            row["Крайно салдо - Дебит"] = data[5];
                            row["Крайно салдо - Кредит"] = data[6];

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
            dataGridView.Columns.Add("accountBalance", "Счетоводна сметка");
            dataGridView.Columns.Add("startBalanceDebit", "Начално салдо - Дебит");
            dataGridView.Columns.Add("startBalanceCredit", "Начално салдо - Кредит");
            dataGridView.Columns.Add("profitDebit", "Оборот - Дебит");
            dataGridView.Columns.Add("profitCredit", "Оборот - Кредит");
            dataGridView.Columns.Add("endBalanceDebit", "Крайно салдо - Дебит");
            dataGridView.Columns.Add("endBalanceCredit", "Крайно салдо - Кредит");

            for (int j = 0; j < this.dataGridView.ColumnCount; j++)
            {
                this.dataGridView.Columns[j].Width = 100;
            }
        }


    }
}
