using BRapp.Dto;
using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface ISistemaDtoRepository
    {
        bool saveOrUpdate(Sistema papel);
        SistemaDto getById(Guid id);
    }
}
