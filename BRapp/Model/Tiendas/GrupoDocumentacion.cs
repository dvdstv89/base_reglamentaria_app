using BRapp.Dto;
using BRapp.Interfaces;
using FontAwesome.Sharp;
using System;

namespace BRapp.Model.Tiendas
{
    public class GrupoDocumentacion: HasId
    {
        public Guid Id { get; set; }      
        public TipoGrupoDocumentacion TipoGrupoDocumentacion { get; set; }
        public Papel Documento { get; set; }       
        public int Orden { get; set; }

        public GrupoDocumentacion(TipoGrupoDocumentacion TipoGrupoDocumentacion, Papel Documento, int Orden)
        {
            Id = Guid.NewGuid();           
            this.Documento = Documento;           
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
            this.Orden = Orden;
        }

        public GrupoDocumentacion(GrupoDocumentacionDto grupoDocumentacionDto, TipoGrupoDocumentacion TipoGrupoDocumentacion, Papel Documento)
        {
            this.Id = grupoDocumentacionDto.id;           
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;          
            this.Documento = Documento;
            this.Orden = grupoDocumentacionDto.Orden;
        }
        public override string ToString()
        {
            return Documento.IsOpcional ? Documento.Name + " (según proceda)" : Documento.Name;
        }

        public IconChar getIcono()
        {
            return Documento.getIcono();
        }

        public Guid getId()
        {
            return Id;
        }
    }
}
