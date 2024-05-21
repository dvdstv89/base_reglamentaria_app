using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class PersonaJuridicaMapper : IMapper
    {
        private readonly IFileService fileService;

        public PersonaJuridicaMapper(IFileService fileService)
        {
            this.fileService = fileService;
        }
        public object Map(SqliteDataReader reader) 
        {           
            Fichero fichero = fileService.extraerFichero("logotipo.jpg", reader["logo"].ToString());
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
