using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class TiendaGrupoDocumentacionDto : HasId
    {
        public Guid idTienda { get; set; }
        public Guid idTipoGrupoDocumentacion { get; set; }
        public Guid getId()
        {
            throw new NotImplementedException();
        }
    }
}
