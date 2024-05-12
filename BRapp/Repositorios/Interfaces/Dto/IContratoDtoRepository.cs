using BRapp.Dto;
using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IContratoDtoRepository
    {
        bool saveOrUpdate(Contrato papel);
        ContratoDto getById(Guid id);
    }
}
