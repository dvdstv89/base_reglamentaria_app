using System;
using System.IO;
using System.Windows.Forms;

namespace BRappAdmin.Data
{
    internal static class AplicationAdminConfig
    {
        public readonly static ComponentAdmin Component;
        static AplicationAdminConfig()
        {          
            Component = new ComponentAdmin();
        }      
    }
}
