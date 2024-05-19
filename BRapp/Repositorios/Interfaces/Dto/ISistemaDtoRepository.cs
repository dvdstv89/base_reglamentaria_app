using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface ISistemaDtoRepository
    {
        ActionResult saveOrUpdate(Sistema papel);
        SistemaDto getById(Guid id);
        void Delete(Sistema papel);
    }
}
