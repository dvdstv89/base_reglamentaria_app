using BRapp.Dto;
using BRapp.Model.Tiendas;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class GrupoDocumentacionMapper : IMapper
    {     
        public object Map(object objeto)
        {
            GrupoDocumentacion grupoDocumentacion = (GrupoDocumentacion) objeto;
            return new GrupoDocumentacionDto()
            {
                id = grupoDocumentacion.Id,              
                IsOpcional = grupoDocumentacion.IsOpcional,
                idDocumento = (grupoDocumentacion.Documento != null) ? grupoDocumentacion.Documento.Id : Guid.Empty,
                idTipoGrupoDocumentacion = (grupoDocumentacion.TipoGrupoDocumentacion != null) ? grupoDocumentacion.TipoGrupoDocumentacion.Id : Guid.Empty
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new GrupoDocumentacionDto()
            {
                id = Guid.Parse(reader["id"].ToString()),                         
                IsOpcional = Convert.ToBoolean(reader["is_opcional"]),
                idDocumento = Guid.Parse(reader["id_papel"].ToString()),
                idTipoGrupoDocumentacion = Guid.Parse(reader["id_tipo_grupo_documentacion"].ToString())
            };
        }
    }
}
