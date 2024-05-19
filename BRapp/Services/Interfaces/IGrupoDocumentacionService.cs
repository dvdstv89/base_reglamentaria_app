using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IGrupoDocumentacionService
    {
        List<GrupoDocumentacion> getByIdTipoGrupoDocumentacion(Guid id);
        List<GrupoDocumentacion> getAll();
        GrupoDocumentacion getById(Guid id);
        List<GrupoDocumentacion> getAllByTipoGrupoDocumentacion(TipoGrupoDocumentacion tipoGrupoDocumentacion);
        bool saveOrUpdate(GrupoDocumentacion grupoDocumentacion);
        void Delete(GrupoDocumentacion grupoDocumentacion);       
    }
}
