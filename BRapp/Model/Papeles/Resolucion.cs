using BRapp.Dto;
using System;

namespace BRapp.Model
{
    public class Resolucion : Documento
    {
        public string Numero { get; set; }
        public Resolucion DerrogadaPor { get; set; }

        public Resolucion(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, Resolucion DerrogadaPor, string Numero)
           : base(papel, DocumentoPDF, Responsable)
        {   
            this.DerrogadaPor = DerrogadaPor;
            this.Numero = Numero;
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
