using BRapp.Model.Tiendas;
using BRapp.Services.Services;
using BRappAdmin.Services.Interfaces;

namespace BRappAdmin.Services.Services
{
    internal class TipoGrupoDocumentacionServiceAdmin : TipoGrupoDocumentacionService, ITipoGrupoDocumentacionServiceAdmin
    {
        private static TipoGrupoDocumentacionServiceAdmin instance;
       
        public static TipoGrupoDocumentacionServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new TipoGrupoDocumentacionServiceAdmin() : instance;
                return instance;
            }
        }        

        public bool saveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            return tipoGrupoDocumentacionRepository.saveOrUpdate(tipoGrupoDocumentacion);
        }
    }
}
