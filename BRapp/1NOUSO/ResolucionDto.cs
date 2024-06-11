using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class ResolucionDto : HasId
    {
        public Guid idPapel { get; set; }
        public Guid idResponsable { get; set; }
        public Guid idDerrogada { get; set; }
        public string Numero { get; set; }
        public Guid getId()
        {
            return idPapel;
        }
    }
}
