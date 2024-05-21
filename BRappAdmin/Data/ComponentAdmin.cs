using BRapp.Data;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;

namespace BRappAdmin.Data
{
    internal class ComponentAdmin
    {       
        public  Component Component {get; set;}
        public IAppServiceAdmin AppServiceAdmin { get; set; }      

        public ComponentAdmin()
        {
            this.Component = AplicationConfig.Component;
            this.AppServiceAdmin = new AppServiceAdmin(Component.AppRepository);
        }
    }
}
