using BRapp.Dto;
using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IDocumentoDtoRepository
    {
        bool saveOrUpdate(Documento papel);
        DocumentoDto getById(Guid id);
    }
}
