using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tiamat.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Global try-catch log
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                using (FileStream stream = new FileStream("log.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Date: {0}, Error: {1}", DateTime.Now, ex.Message);
                    }
                }
                MessageBox.Show("Възникна грешка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
