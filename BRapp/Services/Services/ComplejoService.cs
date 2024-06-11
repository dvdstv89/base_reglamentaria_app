using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class ComplejoService : BaseService<Complejo, Complejo>, IComplejoService
    {  
        public ComplejoService(IComplejoRepository complejoRepository) : base(complejoRepository) { }

        public override List<Complejo> GetAll()
        {
            return repository.GetAll();
        }      
    }
}
