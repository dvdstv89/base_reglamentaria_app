using BRapp.Model;

namespace BRapp.Repositorios.Interfaces
{
    public interface IAppRepository
    {
        bool updateApp(App app);
        App getApp();
    }
}
