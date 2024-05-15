using BRapp.Data;
using BRapp.Services.Services;
using BRapp.UIControlers;
using BRapp.Utiles;
using System;
using Application = System.Windows.Forms.Application;

namespace BRapp
{
    internal static class Program
    {   
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AplicationConfig.APP_MODE_UPDATE = false;
            var appService = AppService.Instance;
            var app = appService.getApp();
            if (app != null)
            {                
                Application.Run(IndexUIController.Instance.ejecutar());
            }
            else
            {
                DialogUtil.EXCEPTION("No se encuentra la base de datos. La aplicacion no puede ser ejecutada");
            }
        }
    }
}
