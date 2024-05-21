using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class BienvenidaService: IBienvenidaService
    {
        private readonly ISucursalService sucursalService;

        public BienvenidaService(ISucursalService sucursalService)
        {
            this.sucursalService = sucursalService;
        }

        public string getBienvenida()
        {
            return sucursalService.GetApp().Bienvenida;
        }
    }
}
