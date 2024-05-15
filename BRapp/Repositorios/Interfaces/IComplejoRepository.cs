using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    public interface IComplejoRepository
    {
        List<Complejo> getAll();
        Complejo getById(Guid id);
        bool saveOrUpdate(Complejo complejo);
    }
}
