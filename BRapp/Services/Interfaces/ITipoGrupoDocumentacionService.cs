using BRapp.Dto;
using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface ITipoGrupoDocumentacionService
    {
        TipoGrupoDocumentacion getById(Guid id);
        List<TipoGrupoDocumentacion> getAll();      
        bool saveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion);
    }
}
