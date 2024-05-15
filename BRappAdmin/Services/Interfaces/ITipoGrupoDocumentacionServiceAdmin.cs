using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface ITipoGrupoDocumentacionServiceAdmin
    {
        List<TipoGrupoDocumentacion> getAll();  
        bool saveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion);
    }
}
