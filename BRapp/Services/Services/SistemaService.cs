using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    internal class SistemaService : ISistemaService
    {
        private readonly ISistemaDtoRepository sistemaDtoRepository;
        public SistemaService(ISistemaDtoRepository sistemaDtoRepository)
        {              
            this.sistemaDtoRepository = sistemaDtoRepository;          
        }      

        public SistemaDto getByPapel(PapelDto papel)
        {   
            return sistemaDtoRepository.getById(papel.idPapel);
        }       

        public ActionResult saveOrUpdate(Sistema papel)
        {           
            return sistemaDtoRepository.saveOrUpdate(papel);
        }

        public void Delete(Sistema papel)
        {
           sistemaDtoRepository.Delete(papel);
        }                   
    }
}
