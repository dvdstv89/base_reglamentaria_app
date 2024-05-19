using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface IPapelDtoRepository
    {
        List<PapelDto> getAll();
        PapelDto getById(Guid id);
        ActionResult saveOrUpdate(Papel papel);
        void Delete(Papel papel);
    }
}
