using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class IndicacionDto : HasId
    {
        public Guid idPapel { get; set; }
        public string numero { get; set; }
        public Guid idResponsable { get; set; }
        public Guid getId()
        {
            return idPapel;
        }
    }
}
