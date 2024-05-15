using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    internal interface IGrupoDocumentacionService
    {
        List<GrupoDocumentacion> getAll();
        GrupoDocumentacion getById(Guid id);
    }
}
