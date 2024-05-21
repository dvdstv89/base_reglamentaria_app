﻿using BRapp.Model;
using BRapp.Services.Interfaces;
using System;
using System.IO;

namespace BRapp.Services.Services
{  
    public class FileService : IFileService
    {
        public Fichero guardarFichero(string selectedFilePath)
        {
            string fileName = Path.GetFileName(selectedFilePath);
            return new Fichero(fileName, File.ReadAllBytes(selectedFilePath));
        }

        public Fichero extraerFichero(string fileName)
        {
            if (fileName == "")
                return new Fichero("",null);          
            return new Fichero(fileName, null);
        }

        public Fichero extraerFichero(string fileName, string data)
        {
            byte[] imagenData = Convert.FromBase64String(data);
            string logo = imagenData.Length != 0 ? "logotipo.jpg" : "";
            return new Fichero(logo, imagenData);
        }
    }
}
