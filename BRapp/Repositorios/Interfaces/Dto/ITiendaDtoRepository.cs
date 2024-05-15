using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface ITiendaDtoRepository
    {
        List<TiendaDto> getAll();
        TiendaDto getById(Guid id);
        ActionResult saveOrUpdate(Tienda tienda);
    }
}
