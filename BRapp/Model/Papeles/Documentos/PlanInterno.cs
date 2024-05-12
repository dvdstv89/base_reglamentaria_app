using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class PlanInterno : Documento
    {
        public PlanInterno(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.PLAN_INTERNO, FechaFirma, Descripcion)
        {
             
        }
    }
}
