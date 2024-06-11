using BRapp.Dto;
using BRapp.Model.Nomenclador;

namespace BRapp.Model
{
    public class Documento: Papel
    {
        public PersonaNatural Responsable { get; set; }

        public Documento(PapelDto papel, ArchivoPDF ArchivoPDF, PersonaNatural Responsable, TipoDocumentacion TipoDocumentacion)
           : base(papel, ArchivoPDF, TipoDocumentacion)
        {
            this.Responsable = Responsable;            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
