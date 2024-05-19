using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    public class DocumentoService : IDocumentoService
    {
        private static DocumentoService instance;      
        private readonly IDocumentoDtoRepository documentoDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        protected DocumentoService()
        {  
            documentoDtoRepository = DocumentoDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
        }      

        public DocumentoDto getByPapel(PapelDto papel)
        {
            return documentoDtoRepository.getById(papel.idPapel);
        }

        public DocumentoPDF getDocumentoPDFApliado(Documento documento)
        {
            return documentoPdfRepository.getDocumentoApliado(documento.DocumentoPDF.Id);
        }

        public ActionResult saveOrUpdate(Documento papel)
        {
            return documentoDtoRepository.saveOrUpdate(papel);
        }

        public void Delete(Documento papel)
        {
            documentoDtoRepository.Delete(papel);
        }

        public static DocumentoService Instance
        {
            get
            {
                instance = (instance == null) ? new DocumentoService() : instance;
                return instance;
            }
        }                   
    }
}
