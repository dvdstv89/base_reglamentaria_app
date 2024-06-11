using BRapp.Enums;
using BRapp.Model.Nomenclador;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class TipoDocumentacionService : BaseService<TipoDocumentacion, TipoDocumentacion>, ITipoDocumentacionService
    {  
        public TipoDocumentacionService(ITipoDocumentacionRepository tipoDocumentacionRepository) : base(tipoDocumentacionRepository) { }

        public override List<TipoDocumentacion> GetAll()
        {
            return repository.GetAll();
        }

        public List<TipoDocumentacion> GetAllByTipoCard(TipoCard tipoCard)
        {
            return repository.GetAll().Where(t => t.TipoCard == tipoCard).ToList();
        }
    }
}
