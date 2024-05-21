using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IDocumentoDtoRepository documentoDtoRepository;

        public DocumentoService(IDocumentoDtoRepository documentoDtoRepository)
        {  
            this.documentoDtoRepository = documentoDtoRepository;           
        }      

        public DocumentoDto getByPapel(PapelDto papel)
        {
            return documentoDtoRepository.getById(papel.idPapel);
        }       

        public ActionResult saveOrUpdate(Documento papel)
        {
            return documentoDtoRepository.saveOrUpdate(papel);
        }

        public void Delete(Documento papel)
        {
            documentoDtoRepository.Delete(papel);
        }
    }
}
