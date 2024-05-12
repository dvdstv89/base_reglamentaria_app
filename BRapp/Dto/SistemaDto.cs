using BRapp.Enums;
using System;

namespace BRapp.Dto
{
    public class SistemaDto
    {
        public Guid idPapel { get; set; }
        public Guid idResponsable { get; set; }       
        public TipoSistema tipoSistema { get; set; }
    }
}
