using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    public interface IFileService
    {
        Fichero GuardarFichero(string selectedFilePath);
        Fichero ExtraerFichero(string fileName);
        Fichero ExtraerFichero(string fileName, string data);
    }
}
