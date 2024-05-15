using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    public interface ITiendaServiceAdmin
    {
        Tienda getById(Guid id);
        List<Tienda> getTiendasByComplejo(Complejo complejo);
        bool saveOrUpdate(Tienda tienda);
    }
}
