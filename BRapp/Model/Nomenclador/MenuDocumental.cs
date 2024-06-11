using BRapp.Enums;
using BRapp.Interfaces;
using System;

namespace BRapp.Model.Nomenclador
{
    public class MenuDocumental: HasId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public bool ShowPanelBusqueda { get; set; }
        public bool ShowArchivados { get; set; }
        public bool AbrirPagina { get; set; }
        public bool IsRaiz { get; set; }
        public TipoUbicacionMenu TipoUbicacionMenu { get; set; }
        public int Orden { get; set; }

        public Guid getId()
        {
            return Id;
        }
        public string COMBO
        {
            get { return Name; }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
