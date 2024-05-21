using BRapp.Data;
using BRapp.Enums;
using BRapp.Model.Papeles;
using System;

namespace BRapp.Dto
{
    public class PapelDto
    {
        public Guid idPapel { get; set; }
        public TipoClasificacionDocumento tipoClasificacionDocumento { get; set; }       
        public Guid idPdf { get; set; }
        public string name { get; set; }
        public bool IsActivo { get; set; }
        public DateTime FechaFirma { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }

        public ClasificacionDocumento GetClasificacionDocumento()
        {
            return ClasificacionDocumentoData.getClasificacionDocumento(tipoClasificacionDocumento);
        }
    }
}
