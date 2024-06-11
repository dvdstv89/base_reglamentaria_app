using BRapp.Enums;
using BRapp.Model.Tiendas;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class TipoGrupoDocumentacionMapper : IMapper
    {
        public object Map(SqliteDataReader reader)
        {
            return new TipoGrupoDocumentacion
                   (
                       Guid.Parse(reader["id"].ToString()),
                       reader["name"].ToString(),
                       reader["descripcion"].ToString(),
                       (LugarMostrarDocumentacion)Enum.Parse(typeof(LugarMostrarDocumentacion), reader["lugar_mostrar_documentacion"].ToString())
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
