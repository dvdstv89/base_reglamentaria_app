using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public abstract class Persona: ISeleccionable
    {
        public Guid Id {get;set;}
        public string Name { get; set; }     
        public string Email { get; set; }
        public string Phone { get; set; }       
        public string Address { get; set; }
        public bool IsInterno { get; set; }
        public bool IsFavorito { get; set; }
        public bool IsActivo { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public Persona(string Name, string Email, string Phone, string Address, bool IsInterno, TipoPersona TipoPersona)
        {
            Id = Guid.NewGuid();
            IsFavorito = false;
            IsActivo = true;
            this.Name = Name;
            this.Email = Email;
            this.Phone= Phone;
            this.Address= Address;
            this.IsInterno= IsInterno;
            this.TipoPersona= TipoPersona;
        }

        public virtual bool FiltroPorLetra(string letra)
        {
            return Name.ToLower().StartsWith(letra.ToLower());
        }

        public virtual string getPhonesNumber()
        {
            return Phone;
        }

        public override string ToString()
        {
            return Name;
        }

        public string getNameSeleccionable()
        {
            return ToString();
        }

        public string COMBO
        {
            get { return ToString(); }
        }

        
    }
}
