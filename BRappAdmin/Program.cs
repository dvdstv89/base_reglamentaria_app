using BRapp.Data;
using BRapp.Messages;
using BRappAdmin.Data;
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
            var appService =  AplicationAdminConfig.Component.AppServiceAdmin;
            var app = appService.getApp();
            if (app != null)
            {
                Application.Run(new IndexAdminUIController().ejecutar());
            }
            else
            {
                DialogUtil.EXCEPTION("No se encuentra la base de datos. La aplicacion no puede ser ejecutada");
            }
        }
    }
}
