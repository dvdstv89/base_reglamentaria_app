using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class BienvenidaService: IBienvenidaService
    {
        private static BienvenidaService instance;      

        public static BienvenidaService Instance
        {
            get
            {
                instance = (instance == null) ? new BienvenidaService() : instance;
                return instance;
            }
        }
    }
}
