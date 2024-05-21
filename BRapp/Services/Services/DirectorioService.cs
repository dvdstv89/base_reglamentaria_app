﻿using BRapp.Enums;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class DirectorioService: IDirectorioService
    {       
        protected readonly IDirectorioRepository directorioRepository;

        public DirectorioService(IDirectorioRepository directorioRepository)
        {
            this.directorioRepository = directorioRepository;
        }

        public List<Persona> filtrarContactos(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos)
        {
            return directorioRepository.filtrarContactos(tipoContactoBusqueda, filtroPaginaContactos);
        }  
        public PersonaNatural GetPersonaNatural(Guid id)
        {
            return (PersonaNatural)directorioRepository.getById(id);
        }

        public PersonaJuridica GetPersonaJuridica(Guid id)
        {
            return (PersonaJuridica)directorioRepository.getById(id);
        }       

        public bool saveOrUpdate(Persona persona)
        {
            return directorioRepository.saveOrUpdate(persona);
        }

        public List<Persona> getAll()
        {
            return directorioRepository.getAllPersonas();
        }

        public List<PersonaNatural> getAllPersonaNatural()
        {
            return directorioRepository.getAllPersonas()
                .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo)
                .Cast<PersonaNatural>()
                .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalInterno()
        {
            return directorioRepository.getAllPersonas()
                  .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && contacto.IsInterno)
                  .Cast<PersonaNatural>()
                  .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalExterno()
        {
            return directorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaNatural>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridica()
        {
            return directorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaInterno()
        {
            return directorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaExterno()
        {
            return directorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
    }
}
