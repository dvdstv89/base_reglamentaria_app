using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    public interface IFileService
    {
        Fichero guardarFichero(string selectedFilePath);
        Fichero extraerFichero(string fileName);
        Fichero extraerFichero(string fileName, string data);
    }
}
