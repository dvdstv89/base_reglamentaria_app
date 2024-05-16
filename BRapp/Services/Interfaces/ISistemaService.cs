using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface ISistemaService
    {
        DocumentoPDF getDocumentoPDFApliado(Sistema sistema);
        SistemaDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(Sistema papel);
    }
}
