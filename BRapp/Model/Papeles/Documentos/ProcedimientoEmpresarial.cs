using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class ProcedimientoEmpresarial : Documento
    {
        public ProcedimientoEmpresarial(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.PROCEDIMIENTO, FechaFirma, Descripcion)
        {
             
        }
    }
}
