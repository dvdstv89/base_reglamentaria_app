using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class BienvenidaService: IBienvenidaService
    {
        private static BienvenidaService instance;
        private readonly ISucursalService sucursalService;

        public BienvenidaService()
        {
            sucursalService = SucursalService.Instance;
        }

        public string getBienvenida()
        {
            return sucursalService.GetApp().Bienvenida;
        }

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
