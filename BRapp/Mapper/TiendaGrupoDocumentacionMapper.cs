using BRapp.Dto;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class TiendaGrupoDocumentacionMapper : IMapper
    {   
        public object Map(SqliteDataReader reader)
        {
            return new TiendaGrupoDocumentacionDto()
            {
                idTienda = Guid.Parse(reader["id_tienda"].ToString()),
                idTipoGrupoDocumentacion = Guid.Parse(reader["id_tipo_grupo_documentacion"].ToString())
            };
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
