using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    internal class ResolucionService : IResolucionService
    {
        private readonly IResolucionDtoRepository resolucionDtoRepository;       

        public ResolucionService(IResolucionDtoRepository resolucionDtoRepository)
        {
            this.resolucionDtoRepository = resolucionDtoRepository;           
        } 

        public ResolucionDto getByPapel(PapelDto papel)
        {
            return resolucionDtoRepository.getById(papel.idPapel);
        }

        public ActionResult saveOrUpdate(Resolucion papel)
        {           
            return resolucionDtoRepository.saveOrUpdate(papel);
        }     

        public void Delete(Resolucion papel)
        {
           resolucionDtoRepository.Delete(papel);
        }       
    }
}
