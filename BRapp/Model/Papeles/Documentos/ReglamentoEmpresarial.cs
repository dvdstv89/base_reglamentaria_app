using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class ReglamentoEmpresarial : Documento
    {
        public ReglamentoEmpresarial(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.REGLAMENTO, FechaFirma, Descripcion)
        {
             
        }
    }
}
