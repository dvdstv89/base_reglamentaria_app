using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using System.Collections.Generic;
using System;
using BRapp.Model.Tiendas;

namespace BRapp.Services.Interfaces
{
    public interface ITiendaService
    {
        DocumentoPDF getDocumentoPDFApliado(Tienda tienda);
        List<Tienda> getTiendasByComplejo(Complejo complejo);
        Tienda getById(Guid id);
        bool saveOrUpdate(Tienda tienda);
    }
}
