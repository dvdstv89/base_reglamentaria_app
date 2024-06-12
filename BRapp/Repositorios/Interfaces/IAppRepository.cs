using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Repositorios.Interfaces
{
    public interface IAppRepository
    {
        ActionResult UpdateApp(App app);
        ActionResult vacumm();
        App GetApp();
    }
}
