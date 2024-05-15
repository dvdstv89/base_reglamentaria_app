using System;

namespace BRapp.Model.Tiendas
{
    public class Complejo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Fichero Organigrama { get; set; }

        public Complejo(string Name, Fichero Organigrama)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Organigrama = Organigrama;
        }

        public Complejo(Guid Id, string Name, Fichero Organigrama)
        {
            this.Id = Id;
            this.Name = Name;
            this.Organigrama = Organigrama;
        }

        public override string ToString()
        {
            return Name;
        }

        public bool hasImagen()
        {
            return Organigrama != null && Organigrama.Data.Length > 0;
        }
    }
}
