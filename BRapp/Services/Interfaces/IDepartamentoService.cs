using System.Collections.Generic;
using System;
using BRapp.Model.Tiendas;

namespace BRapp.Services.Interfaces
{
    public interface IDepartamentoService
    {
        List<Departamento> getDepartamentosByComplejo(Complejo complejo);
        Departamento getById(Guid id);  
        bool saveOrUpdate(Departamento departamento);
    }
}
