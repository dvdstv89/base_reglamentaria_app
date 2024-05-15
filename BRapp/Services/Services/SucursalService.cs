using BRapp.Model;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class SucursalService: ISucursalService
    {
        private static SucursalService instance;
        private readonly IAppService appService;       

        public SucursalService()
        {
            appService = AppService.Instance;           
        }

        public App GetApp()
        {
            return appService.getApp();
        }       

        public static SucursalService Instance
        {
            get
            {
                instance = (instance == null) ? new SucursalService() : instance;
                return instance;               
            }
        }
    }
}
