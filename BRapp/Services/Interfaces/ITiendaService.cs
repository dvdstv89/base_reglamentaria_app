using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using System.Collections.Generic;
using System;
using BRapp.Model.Tiendas;

namespace BRapp.Services.Interfaces
{
    internal interface ITiendaService
    {
        List<Tienda> getTiendasByComplejo(Complejo complejo);
        Tienda getById(Guid id);
    }
}
