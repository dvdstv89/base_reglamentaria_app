using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class AppService : IAppService
    {       
        protected readonly IAppRepository iAppRepository;
      
        public AppService(IAppRepository iAppRepository)
        {
            this.iAppRepository = iAppRepository;     
        }       

        public App GetApp()
        {
            return iAppRepository.GetApp();
        }     
    }
}
