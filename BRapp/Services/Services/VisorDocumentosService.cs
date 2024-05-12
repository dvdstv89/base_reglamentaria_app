using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class VisorDocumentosService: IVisorDocumentoService
    {
        private static VisorDocumentosService instance;
       

        public static VisorDocumentosService Instance
        {
            get
            {
                instance = (instance == null) ? new VisorDocumentosService() : instance;
                return instance;
            }
        }
    }
}
