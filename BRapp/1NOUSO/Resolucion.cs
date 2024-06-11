using BRapp.Dto;
using BRapp.Model.Nomenclador;
using System;

namespace BRapp.Model
{
    public class Resolucion : Papel
    {
        public PersonaNatural Responsable { get; set; }
        public string Numero { get; set; }
        public Resolucion DerrogadaPor { get; set; }

        public Resolucion(PapelDto papel, ArchivoPDF ArchivoPDF, PersonaNatural Responsable, Resolucion DerrogadaPor, string Numero, TipoDocumentacion TipoDocumentacion)
           : base(papel, ArchivoPDF, TipoDocumentacion)
        {   
            this.DerrogadaPor = DerrogadaPor;
            this.Numero = Numero;
            this.Responsable = Responsable;
        }

        public bool IsDerrogada()
        {
            return DerrogadaPor != null;
        }

        public override string ToString()
        {
            return "RES-" + Numero + ": " + Name;
        }

        public string GetNumero()
        {
            return "RES-" + Numero;
        }

        public override bool IsArchivado()
        {
            try
            {
                return IsDerrogada();
            }
            catch
            {
                return true;
            }
        }       

    }
}
