using BRapp.Enums;
using System;

namespace BRapp.Model.Tiendas
{
    public class TipoGrupoDocumentacion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public TipoIndicacion TipoIndicacion { get; set; }

        public TipoGrupoDocumentacion(string Name, string Descripcion, TipoIndicacion TipoIndicacion)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Descripcion = Descripcion;    
            this.TipoIndicacion = TipoIndicacion;
        }

        public TipoGrupoDocumentacion(Guid Id, string Name, string Descripcion, TipoIndicacion TipoIndicacion)
        {
            this.Id = Id;          
            this.Name = Name;
            this.Descripcion = Descripcion;
            this.TipoIndicacion = TipoIndicacion;
        }

        public override string ToString() { return Name; }
    }
}
