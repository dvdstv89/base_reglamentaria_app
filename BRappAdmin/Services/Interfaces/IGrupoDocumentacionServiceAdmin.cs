using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IGrupoDocumentacionServiceAdmin
    {
        List<GrupoDocumentacion> getAll();
        List<GrupoDocumentacion> getAllByTipoGrupoDocumentacion(TipoGrupoDocumentacion tipoGrupoDocumentacion);
        bool saveOrUpdate(GrupoDocumentacion grupoDocumentacion);
    }
}
