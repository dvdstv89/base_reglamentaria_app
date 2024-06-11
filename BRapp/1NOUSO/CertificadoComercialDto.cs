using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class CertificadoComercialDto : HasId
    {
        public Guid idPapel { get; set; }            
        public DateTime fechaVencimiento { get; set; }
        public string numero { get; set; }

        public Guid getId()
        {
           return idPapel;
        }
    }
}
