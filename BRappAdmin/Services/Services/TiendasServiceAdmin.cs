using BRapp.Model;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class TiendasServiceAdmin : ITiendasServiceAdmin
    {
        private static TiendasServiceAdmin instance;

       
        public static TiendasServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new TiendasServiceAdmin() : instance;
                return instance;
            }
        }
    }
}
