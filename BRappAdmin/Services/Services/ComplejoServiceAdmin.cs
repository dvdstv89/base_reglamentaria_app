using BRapp.Model.Tiendas;
using BRapp.Services.Services;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class ComplejoServiceAdmin : ComplejoService, IComplejoServiceAdmin
    {
        private static ComplejoServiceAdmin instance;
       
        public static ComplejoServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new ComplejoServiceAdmin() : instance;
                return instance;
            }
        }        

        public bool saveOrUpdate(Complejo complejo)
        {
            return complejoRepository.saveOrUpdate(complejo);
        }
    }
}
