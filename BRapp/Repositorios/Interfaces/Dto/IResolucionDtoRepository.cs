using BRapp.Dto;
using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IResolucionDtoRepository
    {
        bool saveOrUpdate(Resolucion papel);
        ResolucionDto getById(Guid id);
    }
}
