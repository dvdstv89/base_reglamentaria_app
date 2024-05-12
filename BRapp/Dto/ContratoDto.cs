using BRapp.Enums;
using System;

namespace BRapp.Dto
{
    public class ContratoDto
    {
        public Guid idPapel { get; set; }
        public Guid idContratoPadre { get; set; }
        public Guid idCliente { get; set; }
        public Guid idResponsable { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string numero { get; set; }
        public int acta { get; set; }
        public int acuerdo { get; set; }
        public TipoContrato tipoContrato { get; set; }
    }
}
