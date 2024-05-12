using BRapp.Dto;

namespace BRapp.Model
{
    public class DG: Documento
    {
        public string Numero { get; set; }

        public DG(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, DGDto dGDto)
           : base(papel, DocumentoPDF, Responsable)
        {
            this.Numero = dGDto.numero;            
        }   

        public override string ToString()
        {
            return "DG-"+ Numero + ": "+Name;
        }
    }
}
