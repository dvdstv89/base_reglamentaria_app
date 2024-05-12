using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Text;

namespace BRapp.Mapper
{
    internal class PersonaJuridicaMapper : IMapper
    {
        private readonly IFileService fileLogoService;

        public PersonaJuridicaMapper(IFileService fileLogoService)
        {
            this.fileLogoService = fileLogoService;
        }

        public object Map(SqliteDataReader reader) 
        {
            byte[] imagenData = Convert.FromBase64String(reader["logo"].ToString());
            string logo = "";
            if (imagenData.Length != 0) logo = "logotipo.jpg";
            Fichero fichero= new Fichero(logo, imagenData);

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
