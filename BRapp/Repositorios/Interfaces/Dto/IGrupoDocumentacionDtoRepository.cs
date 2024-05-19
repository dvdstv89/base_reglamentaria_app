using BRapp.Dto;
using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface IGrupoDocumentacionDtoRepository
    {
        List<GrupoDocumentacionDto> getAll();
        GrupoDocumentacionDto getById(Guid id);
        bool saveOrUpdate(GrupoDocumentacion GrupoDocumentacion);
        void Delete(GrupoDocumentacion grupoDocumentacion);
    }
}
