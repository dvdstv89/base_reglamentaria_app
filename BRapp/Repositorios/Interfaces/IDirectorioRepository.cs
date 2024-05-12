using BRapp.Enums.EnumFiltroBusqueda;
using BRapp.Model;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    public interface IDirectorioRepository
    {
        Persona getById(Guid id);
        List<Persona> filtrarContactos(TipoContactoBusqueda tipoContactoBusqueda, FiltroPaginaContactos filtroPaginaContactos);  
        List<Persona> getAllPersonas();
        bool saveOrUpdate(Persona persona);
    }
}
