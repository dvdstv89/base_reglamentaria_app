
using BRapp.Model;
using BRapp.Utiles;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IAppServiceAdmin
    {
        App getApp();
        ActionResult updateApp(App app);
    }
}
