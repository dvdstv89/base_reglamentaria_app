using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class AppServiceAdmin: IAppServiceAdmin
    {       
        private readonly IAppRepository appRepository;

        public AppServiceAdmin(IAppRepository appRepository)
        {
            this.appRepository = appRepository;
        }    

        public App getApp()
        {
            return appRepository.getApp();
        }
        public bool updateApp(App app)
        {
           return appRepository.updateApp(app);
        }       
    }
}
