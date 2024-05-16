using BRapp.Dto;
using System;

namespace BRapp.Model.Tiendas
{
    public class GrupoDocumentacion
    {
        public Guid Id { get; set; }      
        public TipoGrupoDocumentacion TipoGrupoDocumentacion { get; set; }
        public Documento Documento { get; set; }
        public bool IsOpcional { get; set; }

        public GrupoDocumentacion(TipoGrupoDocumentacion TipoGrupoDocumentacion, Documento Documento, bool IsOpcional)
        {
            Id = Guid.NewGuid();           
            this.Documento = Documento;
            this.IsOpcional = IsOpcional;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
        }

        public GrupoDocumentacion(GrupoDocumentacionDto grupoDocumentacionDto, TipoGrupoDocumentacion TipoGrupoDocumentacion, Documento Documento)
        {
            this.Id = grupoDocumentacionDto.id;           
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
            this.IsOpcional = grupoDocumentacionDto.IsOpcional;
            this.Documento = Documento;
        }
        public override string ToString()
        {
            return IsOpcional ? Documento.Name + " (según proceda)" : Documento.Name;
        }
    }
}
