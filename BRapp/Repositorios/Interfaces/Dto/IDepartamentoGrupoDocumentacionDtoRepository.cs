using BRapp.Dto;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces.Dto
{
    public interface IDepartamentoGrupoDocumentacionDtoRepository
    {
        List<DepartamentoGrupoDocumentacionDto> getAllByIdDepartamento(Guid idDepartamento);
        bool save(DepartamentoGrupoDocumentacionDto departamento);
        bool delete(DepartamentoGrupoDocumentacionDto departamento);
    }
}
