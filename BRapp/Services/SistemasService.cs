using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRapp.Services
{
    internal class SistemasService
    {
        private static SistemasService instance;

        private SistemasService()
        {

        }

        public static SistemasService Instance
        {
            get
            {
                instance = (instance == null) ? new SistemasService() : instance;
                return instance;               
            }
        }
    }
}
