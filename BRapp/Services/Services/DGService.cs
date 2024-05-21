using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    internal class DGService : IDGService
    {             
        private readonly IDGDtoRepository dGDtoRepository;       

        public DGService(IDGDtoRepository dGDtoRepository)
        {
            this.dGDtoRepository = dGDtoRepository;           
        }      

        public DGDto getByPapel(PapelDto papel)
        {   
            return dGDtoRepository.getById(papel.idPapel);
        }

        public ActionResult saveOrUpdate(DG papel)
        {           
            return dGDtoRepository.saveOrUpdate(papel);
        }

        public void Delete(DG papel)
        {
            dGDtoRepository.Delete(papel);
        }
    }
}
