using System;

namespace BRapp.Model.Tiendas
{
    public class TipoGrupoDocumentacion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }

        public TipoGrupoDocumentacion(string Name, string Descripcion)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Descripcion = Descripcion;           
        }

        public TipoGrupoDocumentacion(Guid Id, string Name, string Descripcion)
        {
            this.Id = Id;          
            this.Name = Name;
            this.Descripcion = Descripcion;
        }

        public override string ToString() { return Name; }
    }
}
