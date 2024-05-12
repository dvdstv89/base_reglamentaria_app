using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class ProgramaEmpresarial : Documento
    {
        public ProgramaEmpresarial(Guid Id, string Name, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DateTime FechaFirma, string Descripcion) 
            : base(Id, Name, DocumentoPDF, Responsable, TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL, FechaFirma, Descripcion)
        {
             
        }
    }
}
