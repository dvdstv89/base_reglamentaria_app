using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class DocumentoService : BaseService<Documento, DocumentoDto>, IDocumentoService
    {
        public DocumentoService(IDocumentoDtoRepository documentoDtoRepository): base(documentoDtoRepository) { }
    }
}
