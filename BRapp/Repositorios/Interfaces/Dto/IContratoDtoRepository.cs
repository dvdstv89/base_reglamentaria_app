using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IContratoDtoRepository
    {
        ActionResult saveOrUpdate(Contrato papel);
        ContratoDto getById(Guid id);
    }
}
