using BRapp.Enums;
using System;

namespace BRapp.Model.Tiendas
{
    public class Complejo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Fichero Organigrama { get; set; }
        public TipoComplejo TipoComplejo { get; set; }
        public int Orden { get; set; }

        public Complejo(string Name, Fichero Organigrama, TipoComplejo TipoComplejo, int Orden)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Organigrama = Organigrama;
            this.Orden= Orden;
            this.TipoComplejo= TipoComplejo;
        }

        public Complejo(Guid Id, string Name, Fichero Organigrama, TipoComplejo TipoComplejo, int Orden)
        {
            this.Id = Id;
            this.Name = Name;
            this.Organigrama = Organigrama;
            this.Orden = Orden;
            this.TipoComplejo = TipoComplejo;
        }

        public override string ToString()
        {
            return Name;
        }

        public bool hasImagen()
        {
            return Organigrama != null && Organigrama.hasDataValid();
        }
    }
}
