using BRapp.Dto;
using BRapp.Model;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IPapelDtoRepository
    {
        List<PapelDto> getAll();
        PapelDto getById(Guid id);
        bool saveOrUpdate(Papel papel);
    }
}
