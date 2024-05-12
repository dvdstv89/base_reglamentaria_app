using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class ManualEmpresarial : Documento
    {
        public ManualEmpresarial(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.MANUAL, FechaFirma, Descripcion)
        {
             
        }
    }
}
