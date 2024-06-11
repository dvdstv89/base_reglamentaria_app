using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class PersonaMapper : IMapper
    {

        private readonly IFileService fileService;

        public PersonaMapper(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public object Map(SqliteDataReader reader)
        {
            TipoPersona tipoPersona = (TipoPersona)Enum.Parse(typeof(TipoPersona), reader["tipo_persona"].ToString());
            return tipoPersona == TipoPersona.JURIDICA ? MapJuridica(reader) : MapNatural(reader);
        }

        private object MapNatural(SqliteDataReader reader)
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

        private object MapJuridica(SqliteDataReader reader)
        {
            Fichero fichero = fileService.ExtraerFichero("logotipo.jpg", reader["logo"].ToString());
            PersonaJuridica persona = new PersonaJuridica
                   (
                      reader["name"].ToString(),
                      reader["email"].ToString(),
                      reader["phone"].ToString(),
                      reader["address"].ToString(),
                      Convert.ToBoolean(reader["is_interno"]),
                      reader["contacto"].ToString(),
                      fichero
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
