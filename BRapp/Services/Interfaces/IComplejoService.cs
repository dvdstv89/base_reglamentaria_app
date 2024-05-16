using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IComplejoService
    {
        List<Complejo> getAll();
        Complejo getById(Guid idComplejo);
        bool saveOrUpdate(Complejo complejo);
    }
}
