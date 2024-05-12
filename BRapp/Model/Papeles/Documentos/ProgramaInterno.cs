using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class ProgramaInterno : Documento
    {
        public ProgramaInterno(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.PROGRAMA_INTERNO, FechaFirma, Descripcion)
        {
             
        }
    }
}
