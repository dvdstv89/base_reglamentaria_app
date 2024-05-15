using BRapp.Dto;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface ITiendaGrupoDocumentacionDtoRepository
    {       
        List<TiendaGrupoDocumentacionDto> getAllByIdTienda(Guid idTienda);
        bool save(TiendaGrupoDocumentacionDto tienda);
        bool delete(TiendaGrupoDocumentacionDto tienda);
    }
}
