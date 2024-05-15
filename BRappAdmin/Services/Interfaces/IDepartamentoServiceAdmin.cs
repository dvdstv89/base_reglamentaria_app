using BRapp.Model.Tiendas;
using System;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IDepartamentoServiceAdmin
    {
        Departamento getById(Guid id);
        List<Departamento> getDepartamentosByComplejo(Complejo complejo);
        bool saveOrUpdate(Departamento departamento);
    }
}
