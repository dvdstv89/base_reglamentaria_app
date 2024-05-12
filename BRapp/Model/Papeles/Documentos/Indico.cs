using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class Indico : Documento
    {
        public Indico(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion)
           : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.INDICO, FechaFirma, Descripcion)
        {
             
        }
    }
}
