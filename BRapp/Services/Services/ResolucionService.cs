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
    internal class ResolucionService : IResolucionService
    {
        private static ResolucionService instance;      
        private readonly IResolucionDtoRepository resolucionDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        private ResolucionService()
        {
            resolucionDtoRepository = ResolucionDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
        } 

        public ResolucionDto getByPapel(PapelDto papel)
        {
            return resolucionDtoRepository.getById(papel.idPapel);
        }

        public bool saveOrUpdate(Resolucion papel)
        {           
            return resolucionDtoRepository.saveOrUpdate(papel);
        }

        public DocumentoPDF getDocumentoPDFApliado(Resolucion resolucion)
        {
            return documentoPdfRepository.getDocumentoApliado(resolucion.DocumentoPDF.Id);
        }

        public static ResolucionService Instance
        {
            get
            {
                instance = (instance == null) ? new ResolucionService() : instance;
                return instance;
            }
        }                   
    }
}
