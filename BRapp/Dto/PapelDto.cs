using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class PapelDto : HasId
    {
        public Guid IdPapel { get; set; }       
        public Guid IdPdf { get; set; }       
        public Guid IdTipoDocumentacion { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActivo { get; set; }
        public DateTime FechaFirma { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int Orden { get; set; }
        public Guid IdPadre { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdResponsable { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Numero { get; set; } = string.Empty;
        public string Acta { get; set; } = string.Empty;
        public string Acuerdo { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public bool IsOpcional { get; set; }

        public Guid getId()
        {
            return IdPapel;
        }
    }
}
