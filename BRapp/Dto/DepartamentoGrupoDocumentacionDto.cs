using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class DepartamentoGrupoDocumentacionDto : HasId
    {
        public Guid idDepartamento { get; set; }
        public Guid idTipoGrupoDocumentacion { get; set; }
        public Guid getId()
        {
            throw new NotImplementedException();
        }
    }
}
