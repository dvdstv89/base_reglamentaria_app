using BRapp.Enums;
using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IDirectorioService
    {
        PersonaNatural GetPersonaNatural(Guid id);
        PersonaJuridica GetPersonaJuridica(Guid id);
        bool ContatoIsVisible(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos, Persona persona);
        List<Persona> GetAll();
        List<Persona> GetAllPersonaByTipoResponsable(TipoResponsable tipoResponsable);       
        ActionResult SaveOrUpdate(Persona persona);
    }
}
