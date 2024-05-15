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
                       reader["descripcion"].ToString()
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
