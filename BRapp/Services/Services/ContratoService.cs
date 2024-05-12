using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class ContratoService : IContratoService
    {
        private static ContratoService instance;      
        private readonly IContratoDtoRepository contratoDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        private ContratoService()
        {
            contratoDtoRepository = ContratoDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
        }  

        public ContratoDto getByPapel(PapelDto papel)
        {
            return contratoDtoRepository.getById(papel.idPapel);
        }

        public DocumentoPDF getDocumentoPDFApliado(Contrato contrato)
        {
            return documentoPdfRepository.getDocumentoApliado(contrato.DocumentoPDF.Id);
        }

        public bool saveOrUpdate(Contrato papel)
        {          
            return contratoDtoRepository.saveOrUpdate(papel);
        }

        public static ContratoService Instance
        {
            get
            {
                instance = (instance == null) ? new ContratoService() : instance;
                return instance;
            }
        }                   
    }
}
