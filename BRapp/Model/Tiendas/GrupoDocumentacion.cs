using BRapp.Dto;
using System;

namespace BRapp.Model.Tiendas
{
    public class GrupoDocumentacion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TipoGrupoDocumentacion TipoGrupoDocumentacion { get; set; }
        public Documento Documento { get; set; }
        public bool IsOpcional { get; set; }

        public GrupoDocumentacion(string Name, TipoGrupoDocumentacion TipoGrupoDocumentacion, Documento Documento, bool IsOpcional)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Documento = Documento;
            this.IsOpcional = IsOpcional;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
        }

        public GrupoDocumentacion(GrupoDocumentacionDto grupoDocumentacionDto, TipoGrupoDocumentacion TipoGrupoDocumentacion, Documento Documento)
        {
            this.Id = grupoDocumentacionDto.id;
            this.Name = grupoDocumentacionDto.name;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
            this.IsOpcional = grupoDocumentacionDto.IsOpcional;
            this.Documento = Documento;
        }
        public override string ToString()
        {
            return IsOpcional ? Name +" (segun proceda)" : Name ;
        }
    }
}
