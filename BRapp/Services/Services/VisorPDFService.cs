using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class VisorPDFService: IVisorPDFService
    {
        private static VisorPDFService instance;
       

        public static VisorPDFService Instance
        {
            get
            {
                instance = (instance == null) ? new VisorPDFService() : instance;
                return instance;
            }
        }
    }
}
