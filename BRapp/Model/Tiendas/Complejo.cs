using BRapp.Enums;
using BRapp.Interfaces;
using System;

namespace BRapp.Model.Tiendas
{
    public class Complejo: HasId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Fichero Organigrama { get; set; }
        public TipoComplejo TipoComplejo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }

        public Complejo(string Name, Fichero Organigrama, TipoComplejo TipoComplejo, int Orden, string Descripcion)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Organigrama = Organigrama;
            this.Orden= Orden;
            this.TipoComplejo= TipoComplejo;
            this.Descripcion= Descripcion;
        }

        public Complejo(Guid Id, string Name, Fichero Organigrama, TipoComplejo TipoComplejo, int Orden, string Descripcion)
        {
            this.Id = Id;
            this.Name = Name;
            this.Organigrama = Organigrama;
            this.Orden = Orden;
            this.TipoComplejo = TipoComplejo;
            this.Descripcion = Descripcion;           
        }

        public override string ToString()
        {
            return Name;
        }

        public bool hasImagen()
        {
            return Organigrama != null && Organigrama.hasDataValid();
        }

        public Guid getId()
        {
            return Id;
        }
    }
}
