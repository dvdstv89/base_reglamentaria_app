using BRapp.Model;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class SucursalService: ISucursalService
    {
        private static SucursalService instance;
        private readonly IIndexService indexService;       

        public SucursalService()
        {
            indexService = IndexService.Instance;           
        }

        public App GetApp()
        {
            return indexService.getApp();
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
