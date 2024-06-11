using BRapp.Enums;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
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

        public bool ContatoIsVisible(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos, Persona persona)
        {
            if ((tipoContactoBusqueda == TipoContactoBusqueda.TODOS ||
               (tipoContactoBusqueda == TipoContactoBusqueda.INTERNO && persona.IsInterno) ||
               (tipoContactoBusqueda == TipoContactoBusqueda.EXTERNO && !persona.IsInterno)) && persona.IsActivo)
            {
                if (filtroPaginaContactos == FiltroPaginaContactos.TODOS ||
                (filtroPaginaContactos == FiltroPaginaContactos.FAVORITOS && persona.IsFavorito) ||
                (filtroPaginaContactos == FiltroPaginaContactos.NN && persona.FiltroPorLetra("Ñ")) ||
                persona.FiltroPorLetra(filtroPaginaContactos.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public PersonaNatural GetPersonaNatural(Guid id)
        {
            return (PersonaNatural)directorioRepository.GetById(id);
        }
        public PersonaJuridica GetPersonaJuridica(Guid id)
        {
            return (PersonaJuridica)directorioRepository.GetById(id);
        }
        public ActionResult SaveOrUpdate(Persona persona)
        {
            return directorioRepository.SaveOrUpdate(persona);
        }
        public List<Persona> GetAll()
        {
            return directorioRepository.GetAll();
        }

        public List<Persona> GetAllPersonaByTipoResponsable(TipoResponsable tipoResponsable)
        {
            TipoPersona tipoPersona = tipoResponsable == TipoResponsable.PersonaNaturalInterna || tipoResponsable == TipoResponsable.PersonaNaturalExterna ? TipoPersona.NATURAL : TipoPersona.JURIDICA;
            bool isInterno = tipoResponsable == TipoResponsable.PersonaNaturalInterna || tipoResponsable == TipoResponsable.PersonaJuridicaInterna;
            return directorioRepository.GetAll()
                .Where(contacto => contacto.TipoPersona == tipoPersona && contacto.IsInterno == isInterno  && contacto.IsActivo)                
                .ToList();
        }       
    }
}
