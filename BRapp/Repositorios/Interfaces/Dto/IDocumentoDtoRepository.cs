using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;
using System;

namespace BRapp.Repositorios.Interfaces.Dto
{
    internal interface IDocumentoDtoRepository
    {
        ActionResult saveOrUpdate(Documento papel);
        DocumentoDto getById(Guid id);
        void Delete(Documento papel);
    }
}
