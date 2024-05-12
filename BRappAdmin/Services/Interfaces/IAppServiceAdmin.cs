
using BRapp.Model;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IAppServiceAdmin
    {
        App getApp();
        bool updateApp(App app);
    }
}
