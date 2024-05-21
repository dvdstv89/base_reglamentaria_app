using BRapp.Data;
using BRapp.Enums;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    public class DirectorioRepository : BaseRepository, IDirectorioRepository
    {       
        private readonly string QUERY_SELECT_ALL_PERSONAS = "SELECT * FROM Persona order by tipo_persona DESC, name asc";       
        private readonly string QUERY_UPDATE_PERSONA = "UPDATE Persona SET name = @name, email = @email, phone = @phone,  address = @address, is_interno = @interno, is_favorito = @favorito, is_activo = @activo,  tipo_persona = @tipoPersona,  titulo_personal = @titulo, cargo = @cargo, cell = @cell,  contacto = @contacto, logo = @logo WHERE id = @personaId";
        private readonly string QUERY_INSERT_PERSONA = "INSERT INTO Persona (id, name, email, phone, address, is_interno, is_favorito, is_activo, tipo_persona, titulo_personal, cargo, cell, contacto, logo) VALUES ( @personaId, @name, @email, @phone, @address, @interno, @favorito, @activo, @tipoPersona, @titulo, @cargo, @cell, @contacto, @logo)";
        protected List<Persona> personas;
        private readonly IMapper personaJuridicaMapper;
        private readonly IMapper personaNaturalMapper;
        private readonly IFileService fileService;

        public DirectorioRepository(IMapper personaJuridicaMapper, IMapper personaNaturalMapper, IFileService fileService) : base(AplicationConfig.ConnectionString, "Persona")
        {
            this.fileService = fileService;
            this.personaNaturalMapper = personaNaturalMapper;
            this.personaJuridicaMapper = personaJuridicaMapper;
            personas = getAll();
        }

        public List<Persona> getAllPersonas()
        {
            return personas;
        }      

        private List<Persona> getAll()
        {
            List<Persona> apps = new List<Persona>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL_PERSONAS))
            {
                while (reader.Read())
                {
                    TipoPersona tipoPersona = (TipoPersona)Enum.Parse(typeof(TipoPersona), reader["tipo_persona"].ToString());
                    if(tipoPersona == TipoPersona.JURIDICA)
                    {
                        apps.Add((PersonaJuridica)personaJuridicaMapper.Map(reader));
                    }
                    else if(tipoPersona == TipoPersona.NATURAL)
                    {
                        apps.Add((PersonaNatural)personaNaturalMapper.Map(reader));
                    }                   
                }
            }
            return apps;
        }

        public List<Persona> filtrarContactos(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos)
        {
            var contactosFiltradosPorTipoContacto = personas.Where(contacto =>
               (tipoContactoBusqueda == TipoContactoBusqueda.TODOS ||
               (tipoContactoBusqueda == TipoContactoBusqueda.INTERNO && contacto.IsInterno) ||
               (tipoContactoBusqueda == TipoContactoBusqueda.EXTERNO && !contacto.IsInterno)) && contacto.IsActivo).ToList();

            // Filtra los contactos por el filtro de página (favoritos, NN, letra específica)
            var contactosFiltradosPorPagina = contactosFiltradosPorTipoContacto.Where(contacto =>
                filtroPaginaContactos == FiltroPaginaContactos.TODOS ||
                (filtroPaginaContactos == FiltroPaginaContactos.FAVORITOS && contacto.IsFavorito) ||
                (filtroPaginaContactos == FiltroPaginaContactos.NN && contacto.FiltroPorLetra("Ñ")) ||
                contacto.FiltroPorLetra(filtroPaginaContactos.ToString())
            ).ToList();

            return contactosFiltradosPorPagina;
        }

        public Persona getById(Guid id)
        {
            return personas.FirstOrDefault(persona => persona.Id == id);
        }
        private int getIndexById(Guid id)
        {
            return personas.FindIndex(doc => doc.Id == id);
        }

        public bool saveOrUpdate(Persona persona)
        {
            Dictionary<string, object> parametros = buildParametros(persona);
            int index = getIndexById(persona.Id);
            if (index != -1)
            {
                personas[index] = persona;
                return ExecuteWriteOperation(QUERY_UPDATE_PERSONA, parametros); 
            }
            else
            {                
                bool result = ExecuteWriteOperation(QUERY_INSERT_PERSONA, parametros);
                personas.Add(persona);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(Persona persona)
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
