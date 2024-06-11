using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class GrupoDocumentacionDto : HasId
    {
        public Guid id { get; set; }      
        public bool IsOpcional { get; set; }       
        public Guid idDocumento { get; set; }
        public Guid idTipoGrupoDocumentacion { get; set; }
        public int Orden { get; set; }
        public Guid getId()
        {
            return id;
        }
    }
}
