using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    public interface IFileService
    {
        Fichero guardarFichero(string selectedFilePath);
        Fichero extraerFichero(string fileName);
    }
}
