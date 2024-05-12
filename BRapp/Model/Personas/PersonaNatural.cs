using BRapp.Enums;
using System;
using System.Xml.Linq;

namespace BRapp.Model
{
    public class PersonaNatural : Persona
    {
        public TipoTituloPersonal TipoTituloPersonal { get; set; }
        public string Cargo { get; set; }       
        public string Cell { get; set; }

        public PersonaNatural(string Name, string Email, string Phone, string Address, bool IsInterno, string Cargo, string Cell, TipoTituloPersonal TipoTituloPersonal) 
            : base(Name, Email, Phone, Address, IsInterno, TipoPersona.NATURAL)
        {
            this.Cargo = Cargo;
            this.Cell = Cell;
            this.TipoTituloPersonal= TipoTituloPersonal;
        }       

        public override string getPhonesNumber()
        {
            return Phone + " / " + Cell;
        }
    }
}
