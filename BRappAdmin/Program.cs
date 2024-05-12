using BRapp.Data;
using BRappAdmin.UI;
using BRappAdmin.UIControlers;
using System;
using System.Windows.Forms;

namespace BRappAdmin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AplicationConfig.APP_MODE_UPDATE = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            Application.Run(IndexAdminUIController.Instance.ejecutar());
        }
    }
}
