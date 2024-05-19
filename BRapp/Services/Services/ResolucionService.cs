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

        public ActionResult saveOrUpdate(Resolucion papel)
        {           
            return resolucionDtoRepository.saveOrUpdate(papel);
        }

        public DocumentoPDF getDocumentoPDFApliado(Resolucion resolucion)
        {
            return documentoPdfRepository.getDocumentoApliado(resolucion.DocumentoPDF.Id);
        }

        public void Delete(Resolucion papel)
        {
           resolucionDtoRepository.Delete(papel);
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
