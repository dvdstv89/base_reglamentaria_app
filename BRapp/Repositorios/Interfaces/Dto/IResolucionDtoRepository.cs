using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IResolucionDtoRepository
    {
        ActionResult saveOrUpdate(Resolucion papel);
        ResolucionDto getById(Guid id);
    }
}
