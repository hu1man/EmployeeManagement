using EmployeeApp.Core;
using EmployeeManagement.src.EmployeeApp.Core.Interfaces;
using EmployeeManagement.src.EmployeeApp.Data;
using EmployeeManagement.src.EmployeeApp.Data.Repositories;
using EmployeeManagement.src.EmployeeApp.UI;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace EmployeeManagement
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

            string conn = "Data Source=DESKTOP-RU25KP9;Initial Catalog=EmployeeDB;Persist Security Info=True;User ID=sa;Password=123;";

            DbInitializer.Initialize(conn);
            IEmployeeRepository repo = new AdoEmployeeRepository(conn);
            Application.Run(new MainForm(repo));


        }
    }
}
