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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Menu_Tools_Calculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void Menu_Help_Abot_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Menu_Help_Documentation_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Menu_Tools_Chart_National_Click(object sender, EventArgs e)
        {
            ChartOfAccounts chart = new ChartOfAccounts();
            chart.Show();
        }

        private void Menu_Tools_Chart_Personal_Click(object sender, EventArgs e)
        {
            AnaliticAccounts analitic = new AnaliticAccounts();
            analitic.Show();
        }
    }
}
