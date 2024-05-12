using BRapp.Enums;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class PersonaNaturalMapper : IMapper
    {
        public object Map(SqliteDataReader reader)
        {
            PersonaNatural persona = new PersonaNatural
                   (                     
                      reader["name"].ToString(),
                      reader["email"].ToString(),
                      reader["phone"].ToString(),
                      reader["address"].ToString(),
                      Convert.ToBoolean(reader["is_interno"]),
                      reader["cargo"].ToString(),
                      reader["cell"].ToString(),
                      (TipoTituloPersonal)Enum.Parse(typeof(TipoTituloPersonal), reader["titulo_personal"].ToString())
                   );

            persona.Id = Guid.Parse(reader["id"].ToString());
            persona.IsFavorito = Convert.ToBoolean(reader["is_favorito"]);
            persona.IsActivo = Convert.ToBoolean(reader["is_activo"]);
            return persona;
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
