using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface IDepartamentoDtoRepository
    {
        List<DepartamentoDto> getAll();
        DepartamentoDto getById(Guid id);
        ActionResult saveOrUpdate(Departamento departamento);
    }
}
