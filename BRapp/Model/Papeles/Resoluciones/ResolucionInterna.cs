using BRapp.Dto;

namespace BRapp.Model
{
    public class ResolucionInterna : Resolucion
    {     
        public ResolucionInterna(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, Resolucion DerrogadaPor = null) 
            : base(papel, DocumentoPDF, Responsable, DerrogadaPor)
        {   
            
        }
    }
}
