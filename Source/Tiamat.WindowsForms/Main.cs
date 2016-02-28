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
            DialogResult result = login.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Моля влезте в системата с валидно потребителско име и парола!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

        private void Menu_AccounNote_New_Click(object sender, EventArgs e)
        {
            AccountNote note = new AccountNote();
            note.MdiParent = this;
            note.Show();
        }

        private void Menu_Balance_New_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.MdiParent = this;
            balance.Show();

        }

        private void Menu_AccounNote_Save_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            var form = active as AccountNote;
            form.Save();
        }

        private void Menu_Balance_Save_Click(object sender, EventArgs e)
        {

        }

        private void Menu_AccounNote_Open_Click(object sender, EventArgs e)
        {
            AccountNote note = new AccountNote();
            note.MdiParent = this;
            note.Show();
            note.Load();
        }
    }
}
