using BRapp.Dto;
using BRapp.Model.Nomenclador;

namespace BRapp.Model
{
    public class Indicacion: Papel
    {
        public PersonaNatural Responsable { get; set; }
        public string Numero { get; set; }

        public Indicacion(PapelDto papel, ArchivoPDF ArchivoPDF, PersonaNatural Responsable, IndicacionDto dGDto, TipoDocumentacion TipoDocumentacion)
             : base(papel, ArchivoPDF, TipoDocumentacion)
        {
            this.Numero = dGDto.numero;
            this.Responsable = Responsable;
        }   

        public override string ToString()
        {
            return "DG-"+ Numero + ": "+Name;
        }
    }
}
