using BRapp.Data;
using BRapp.Model;
using BRapp.Services.Interfaces;
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
    }
}
