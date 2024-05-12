using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class OtrosDocumentoInterno : Documento
    {
        public OtrosDocumentoInterno(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.OTRO_DOCUMENTO, FechaFirma, Descripcion)
        {
             
        }
    }
}
