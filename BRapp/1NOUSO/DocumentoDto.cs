using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class DocumentoDto : HasId
    {
        public Guid idPapel { get; set; }
        public Guid idResponsable { get; set; }
        public Guid getId()
        {
            return idPapel;
        }
    }
}
