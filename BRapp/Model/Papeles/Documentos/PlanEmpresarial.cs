using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class PlanEmpresarial : Documento
    {
        public PlanEmpresarial(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.PLAN_EMPRESARIAL, FechaFirma, Descripcion)
        {
             
        }
    }
}
