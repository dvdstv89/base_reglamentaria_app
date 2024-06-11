using BRapp.Enums;
using BRapp.Interfaces;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

namespace BRapp.Model.Tiendas
{
    public class TipoGrupoDocumentacion : IVisorDocumentacion, HasId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public LugarMostrarDocumentacion LugarMostrarDocumentacion { get; set; }
        public bool TieneDocumentos { get; set; }

        public TipoGrupoDocumentacion(string Name, string Descripcion, LugarMostrarDocumentacion LugarMostrarDocumentacion)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Descripcion = Descripcion;             
            this.LugarMostrarDocumentacion= LugarMostrarDocumentacion;
        }

        public TipoGrupoDocumentacion(Guid Id, string Name, string Descripcion, LugarMostrarDocumentacion LugarMostrarDocumentacion)
        {
            this.Id = Id;          
            this.Name = Name;
            this.Descripcion = Descripcion;
            this.LugarMostrarDocumentacion = LugarMostrarDocumentacion;
        }

        public override string ToString() { return Name; }

        public IconChar getIcono()
        {
            return IconChar.LayerGroup;
        }

        public List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacion()
        {
            return new List<TipoGrupoDocumentacion> ();
        }

        public string GetDescripcionRft()
        {
            return Descripcion;
        }

        public Guid getId()
        {
            return Id;
        }
    }
}
