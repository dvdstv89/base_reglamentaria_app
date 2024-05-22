using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IDirectorioService
    {
        PersonaNatural GetPersonaNatural(Guid id);
        PersonaJuridica GetPersonaJuridica(Guid id);
        bool contatoIsVisible(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos, Persona persona);
        List<Persona> getAll();
        List<PersonaNatural> getAllPersonaNatural();
        List<PersonaNatural> getAllPersonaNaturalInterno();
        List<PersonaNatural> getAllPersonaNaturalExterno();
        List<PersonaJuridica> getAllPersonaJuridica();
        List<PersonaJuridica> getAllPersonaJuridicaInterno();
        List<PersonaJuridica> getAllPersonaJuridicaExterno();
        bool saveOrUpdate(Persona persona);
    }
}
