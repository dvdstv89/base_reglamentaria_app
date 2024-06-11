using BRapp.Dto;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    public interface IDepartamentoGrupoDocumentacionDtoRepository
    {
        List<DepartamentoGrupoDocumentacionDto> getAllByIdDepartamento(Guid idDepartamento);
        ActionResult Save(DepartamentoGrupoDocumentacionDto departamento);
        ActionResult Delete(DepartamentoGrupoDocumentacionDto departamento);
        ActionResult DeleteForDepartamento(Guid idDepartamento);
        ActionResult DeleteForGrupo(Guid idGrupo);
    }       
}
