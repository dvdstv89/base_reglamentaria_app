using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    public interface ITipoGrupoDocumentacionRepository
    {
        List<TipoGrupoDocumentacion> getAll();
        TipoGrupoDocumentacion getById(Guid id);
        bool saveOrUpdate(TipoGrupoDocumentacion TipoGrupoDocumentacion);
    }
}
