using BRapp.Data;
using BRapp.Messages;
using BRapp.UIControlers;
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
            var appService = AplicationConfig.Component.AppService;
            var app = appService.getApp();
            if (app != null)
            {
                Application.Run(new IndexUIController().ejecutar()); ;
            }
            else
            {
                DialogUtil.EXCEPTION("No se encuentra la base de datos. La aplicacion no puede ser ejecutada");
            }
        }
    }
}
