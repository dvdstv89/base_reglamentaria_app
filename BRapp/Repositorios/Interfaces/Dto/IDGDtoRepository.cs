using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IDGDtoRepository
    {
        ActionResult saveOrUpdate(DG papel);
        DGDto getById(Guid id);
        void Delete(DG papel);
    }
}
