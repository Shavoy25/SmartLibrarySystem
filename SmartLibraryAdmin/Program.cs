using System;
using System.Windows.Forms;
using SmartLibraryWinForms;

namespace SmartLibraryAdmin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            Application.Run(new frmLogin());
        }
    }
}