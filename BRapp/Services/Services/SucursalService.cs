using BRapp.Model;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class SucursalService: ISucursalService
    {      
        private readonly IAppService appService;       

        public SucursalService(IAppService appService)
        {
            this.appService = appService;           
        }

        public App GetApp()
        {
            return appService.GetApp();
        }   
    }
}
