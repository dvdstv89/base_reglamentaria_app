﻿using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows.Forms;

namespace BRapp.Data
{
    public static class AplicationConfig
    {
        public static bool APP_MODE_UPDATE;
        public readonly static string ApplicationPath;
        private static IConfiguration configuration;
        public static readonly int ANCHO_PANTALLA = 1500; 
        static AplicationConfig()
        {
            ApplicationPath = Application.StartupPath;
            var builder = new ConfigurationBuilder()
                .AddJsonFile("Data/settings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }
        public static string ConnectionString
        {
            get
            {
                return configuration["DefaultConnectionSQLite"];               
            }              
        }

        public static string AppId
        {
            get
            {              
                return configuration["AppId"];
            }
        }
        public static string ConsultorWeb
        {
            get
            {
                string index = configuration["ConsultorWeb"];
                string destinationPath = Path.Combine(ApplicationPath, index);
                return destinationPath;
            }
        }
        
    }
}