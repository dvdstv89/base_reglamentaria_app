using BRapp.Data;
using BRapp.UIControlers;
using System;
using System.Configuration;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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
            Application.Run(IndexUIController.Instance.ejecutar());
        }
    }
}
