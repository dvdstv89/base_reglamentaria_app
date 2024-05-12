using BRapp.Dto;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    internal interface IDocumentoService
    {
        DocumentoPDF getDocumentoPDFApliado(Documento documento);
        DocumentoDto getByPapel(PapelDto papel);
        bool saveOrUpdate(Documento papel);
    }
}
