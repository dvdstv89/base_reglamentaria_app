using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;

namespace BRapp.Services.Services
{
    internal class ContratoService : IContratoService
    {
        private readonly IContratoDtoRepository contratoDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        public ContratoService(IContratoDtoRepository contratoDtoRepository)
        {
            this.contratoDtoRepository = contratoDtoRepository;          
        }  

        public ContratoDto getByPapel(PapelDto papel)
        {
            return contratoDtoRepository.getById(papel.idPapel);
        }      

        public ActionResult saveOrUpdate(Contrato papel)
        {          
            return contratoDtoRepository.saveOrUpdate(papel);
        }

        public void Delete(Contrato papel)
        {
            contratoDtoRepository.Delete(papel);
        }
    }
}
