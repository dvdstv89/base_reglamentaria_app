using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
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
            return appRepository.GetApp();
        }
        public ActionResult updateApp(App app)
        {
           return appRepository.UpdateApp(app);
        }

        public ActionResult vacumm()
        {
            return appRepository.vacumm();
        }
    }
}
