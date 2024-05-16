using BRapp.Enums;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class DirectorioService: IDirectorioService
    {
        private static DirectorioService instance;
        protected readonly IDirectorioRepository iDirectorioRepository;

        protected DirectorioService()
        {
            iDirectorioRepository = DirectorioRepository.Instance;
        }

        public List<Persona> filtrarContactos(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos)
        {
            return iDirectorioRepository.filtrarContactos(tipoContactoBusqueda, filtroPaginaContactos);
        }  
        public PersonaNatural GetPersonaNatural(Guid id)
        {
            return (PersonaNatural)iDirectorioRepository.getById(id);
        }

        public PersonaJuridica GetPersonaJuridica(Guid id)
        {
            return (PersonaJuridica)iDirectorioRepository.getById(id);
        }       

        public bool saveOrUpdate(Persona persona)
        {
            return iDirectorioRepository.saveOrUpdate(persona);
        }

        public List<Persona> getAll()
        {
            return iDirectorioRepository.getAllPersonas();
        }

        public List<PersonaNatural> getAllPersonaNatural()
        {
            return iDirectorioRepository.getAllPersonas()
                .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo)
                .Cast<PersonaNatural>()
                .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalInterno()
        {
            return iDirectorioRepository.getAllPersonas()
                  .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && contacto.IsInterno)
                  .Cast<PersonaNatural>()
                  .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalExterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaNatural>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridica()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaInterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaExterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }



        public static DirectorioService Instance
        {
            get
            {
                instance = (instance == null) ? new DirectorioService() : instance;
                return instance;
            }
        }
    }
}
