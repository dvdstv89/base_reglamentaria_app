using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class AppService : IAppService
    {       
        protected readonly IAppRepository iAppRepository;
        private static AppService instance;

        protected AppService()
        {
            this.iAppRepository = AppRepository.Instance;            
        }       

        public App getApp()
        {
            return iAppRepository.getApp();
        }        

        public static AppService Instance
        {
            get
            {               
                instance = (instance == null) ? new AppService() : instance;
                return instance;
            }
        }
    }
}
