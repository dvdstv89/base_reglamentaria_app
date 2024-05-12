using BRapp.Dto;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    internal interface IResolucionService
    {
        DocumentoPDF getDocumentoPDFApliado(Resolucion resolucion);
        ResolucionDto getByPapel(PapelDto papel);
        bool saveOrUpdate(Resolucion papel);
    }
}
