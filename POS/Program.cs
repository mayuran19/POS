using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using POS.DAO;

namespace POS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database database = new Database();
            database.GetConnection();
            Application.Run(new MainForm());
        }
    }
}
