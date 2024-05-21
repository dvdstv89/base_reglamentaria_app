using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class AppMapper : IMapper
    {      
        public object Map(SqliteDataReader reader)
        {
          
            return new App
                   (
                       Convert.ToInt32(reader["Id"].ToString()),
                       reader["fecha_actualizacion"].ToString(),
                       reader["copyright"].ToString(),
                       reader["empresa"].ToString(),
                       reader["mision"].ToString(),
                       reader["vision"].ToString(),
                       reader["objeto_social"].ToString(),
                       reader["valores_compartidos"].ToString(),
                       reader["bienvenida"].ToString()
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
