using BRapp.Dto;
using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IDGDtoRepository
    {
        bool saveOrUpdate(DG papel);
        DGDto getById(Guid id);
    }
}
