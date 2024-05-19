using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface IDocumentoService
    {
        DocumentoPDF getDocumentoPDFApliado(Documento documento);
        DocumentoDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(Documento papel);
        void Delete(Documento papel);
    }
}
