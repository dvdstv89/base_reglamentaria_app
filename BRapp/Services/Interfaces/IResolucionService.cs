﻿using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface IResolucionService
    {
        ResolucionDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(Resolucion papel);
        void Delete(Resolucion papel);
    }
}
