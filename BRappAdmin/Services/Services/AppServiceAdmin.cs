using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class AppServiceAdmin: IAppServiceAdmin
    {
        private static AppServiceAdmin instance;
        private readonly IAppRepository appRepositoryAdmin;

        public AppServiceAdmin()
        {
            appRepositoryAdmin = AppRepository.Instance;
        }    

        public App getApp()
        {
            return appRepositoryAdmin.getApp();
        }
        public bool updateApp(App app)
        {
           return appRepositoryAdmin.updateApp(app);
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
