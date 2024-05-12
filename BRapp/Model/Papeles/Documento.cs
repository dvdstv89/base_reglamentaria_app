using BRapp.Dto;

namespace BRapp.Model
{
    public class Documento: Papel
    {
        public PersonaNatural Responsable { get; set; }

        public Documento(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable)
           : base(papel, DocumentoPDF)
        {
            this.Responsable = Responsable;            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
