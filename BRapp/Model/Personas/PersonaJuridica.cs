using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class PersonaJuridica : Persona
    {
        public string Contacto { get; set; }
        public Fichero Logo { get; set; }

        public PersonaJuridica(string Name, string Email, string Phone, string Address, bool IsInterno, string Contacto, Fichero Logo)
           : base(Name, Email, Phone, Address, IsInterno, TipoPersona.JURIDICA)
        {
            this.Contacto = Contacto;
            this.Logo = Logo;           
        }

        public bool hasLogo()
        {
            return Logo != null && Logo.hasDataValid();
        }

        public override string GetCargo()
        {
            return "";
        }
    }
}
