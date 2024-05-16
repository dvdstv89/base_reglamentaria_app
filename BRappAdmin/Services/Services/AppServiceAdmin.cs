using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class AppServiceAdmin: IAppServiceAdmin
    {
        private static AppServiceAdmin instance;
        private readonly IAppRepository appRepository;

        public AppServiceAdmin()
        {
            appRepository = AppRepository.Instance;
        }    

        public App getApp()
        {
            return appRepository.getApp();
        }
        public bool updateApp(App app)
        {
           return appRepository.updateApp(app);
        }

        public static AppServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new AppServiceAdmin() : instance;
                return instance;
            }
        }
    }
}
