
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class ConsultorService: IConsultorService
    {
        private static ConsultorService instance;       

        public static ConsultorService Instance
        {
            get
            {              
                instance = (instance == null) ? new ConsultorService() : instance;
                return instance;
            }
        }
    }
}
