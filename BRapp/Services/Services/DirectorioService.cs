using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;

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

        public void saveOrUpdate(Persona persona)
        {
            iDirectorioRepository.saveOrUpdate(persona);
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
