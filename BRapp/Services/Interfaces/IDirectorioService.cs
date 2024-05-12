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
        List<Persona> filtrarContactos(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos);      
        void saveOrUpdate(Persona persona);
    }
}
