using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    internal interface IComplejoService
    {
        List<Complejo> getAll();
        Complejo getById(Guid idComplejo);
    }
}
