using BRapp.Dto;

namespace BRapp.Model
{
    public class ResolucionEmpresarial : Resolucion
    {     
        public ResolucionEmpresarial(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, Resolucion DerrogadaPor = null)
           : base(papel, DocumentoPDF, Responsable, DerrogadaPor)
        {   
            
        }
    }
}
