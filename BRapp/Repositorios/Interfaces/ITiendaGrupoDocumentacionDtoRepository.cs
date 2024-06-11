using BRapp.Dto;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    public interface ITiendaGrupoDocumentacionDtoRepository
    {       
        List<TiendaGrupoDocumentacionDto> getAllByIdTienda(Guid idTienda);
        ActionResult Save(TiendaGrupoDocumentacionDto tienda);
        ActionResult Delete(TiendaGrupoDocumentacionDto tienda);
        ActionResult DeleteForTienda(Guid idTienda);
        ActionResult DeleteForGrupo(Guid idGrupo);
    }
}
