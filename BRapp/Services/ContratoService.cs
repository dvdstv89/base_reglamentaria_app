using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRapp.Services
{
    internal class ContratoService
    {
        private static ContratoService instance;

        private ContratoService()
        {

        }

        public static ContratoService Instance
        {
            get
            {              
                instance = (instance == null) ? new ContratoService() : instance;
                return instance;
            }
        }
    }
}
