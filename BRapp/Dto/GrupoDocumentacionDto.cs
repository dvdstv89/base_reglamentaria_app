using BRapp.Enums;
using System;

namespace BRapp.Dto
{
    public class GrupoDocumentacionDto
    {
        public Guid id { get; set; }      
        public bool IsOpcional { get; set; }       
        public Guid idDocumento { get; set; }
        public Guid idTipoGrupoDocumentacion { get; set; }
    }
}
