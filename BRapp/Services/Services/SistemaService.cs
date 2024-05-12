using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class SistemaService : ISistemaService
    {
        private static SistemaService instance;       
        private readonly ISistemaDtoRepository sistemaDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        private SistemaService()
        {              
            sistemaDtoRepository = SistemaDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
        }      

        public SistemaDto getByPapel(PapelDto papel)
        {   
            return sistemaDtoRepository.getById(papel.idPapel);
        }

        public DocumentoPDF getDocumentoPDFApliado(Sistema sistema)
        {
            return documentoPdfRepository.getDocumentoApliado(sistema.DocumentoPDF.Id);
        }

        public bool saveOrUpdate(Sistema papel)
        {           
            return sistemaDtoRepository.saveOrUpdate(papel);
        }

        public static SistemaService Instance
        {
            get
            {
                instance = (instance == null) ? new SistemaService() : instance;
                return instance;
            }
        }                   
    }
}
