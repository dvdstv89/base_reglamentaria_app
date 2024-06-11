using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;


namespace BRapp.Repositorios.Repos
{
    public class DirectorioRepository : BaseRepository<Persona>, IDirectorioRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Persona WHERE id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Persona order by tipo_persona DESC, name asc";       
        private static readonly string QUERY_UPDATE = "UPDATE Persona SET name = @name, email = @email, phone = @phone,  address = @address, is_interno = @interno, is_favorito = @favorito, is_activo = @activo,  tipo_persona = @tipoPersona,  titulo_personal = @titulo, cargo = @cargo, cell = @cell,  contacto = @contacto, logo = @logo WHERE id = @personaId";
        private static readonly string QUERY_INSERT = "INSERT INTO Persona (id, name, email, phone, address, is_interno, is_favorito, is_activo, tipo_persona, titulo_personal, cargo, cell, contacto, logo) VALUES ( @personaId, @name, @email, @phone, @address, @interno, @favorito, @activo, @tipoPersona, @titulo, @cargo, @cell, @contacto, @logo)";
      
      
        public DirectorioRepository(IMapper personaMapper) : base(personaMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }        


        public ActionResult SaveOrUpdate(Persona persona)
        {
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, persona);
        }       

        protected override Dictionary<string, object> buildParametros(Persona persona)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", persona.Name },
                { "@email", persona.Email },
                { "@phone", persona.Phone },
                { "@address", persona.Address },
                { "@interno", persona.IsInterno.ToString() },
                { "@favorito", persona.IsFavorito.ToString() },
                { "@activo", persona.IsActivo.ToString() },
                { "@tipoPersona", persona.TipoPersona.ToString() },
                { "@personaId", persona.Id.ToString() }
            };
            if (persona is PersonaNatural)
            {
                PersonaNatural personaNatural = persona as PersonaNatural;
                parametros.Add("@titulo", personaNatural.TipoTituloPersonal.ToString());
                parametros.Add("@cargo", personaNatural.Cargo);
                parametros.Add("@cell", personaNatural.Cell);
                parametros.Add("@contacto", "");
                parametros.Add("@logo", "");
            }
            else
            {
                PersonaJuridica personaJuridica = persona as PersonaJuridica;
                parametros.Add("@titulo", "");
                parametros.Add("@cargo", "");
                parametros.Add("@cell", "");
                parametros.Add("@contacto", personaJuridica.Contacto);                
                parametros.Add("@logo", (personaJuridica.Logo != null && personaJuridica.Logo.hasDataValid()) ? ImageManager.GetBase64Image(personaJuridica.Logo.Data, 120, 138, 90) : "");
            }
            return parametros;
        }
    }
}
