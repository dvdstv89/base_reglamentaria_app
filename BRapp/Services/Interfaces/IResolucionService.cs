using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface IResolucionService
    {
        DocumentoPDF getDocumentoPDFApliado(Resolucion resolucion);
        ResolucionDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(Resolucion papel);
    }
}
