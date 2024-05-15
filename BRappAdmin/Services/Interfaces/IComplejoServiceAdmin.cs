using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IComplejoServiceAdmin
    {
        List<Complejo> getAll();  
        bool saveOrUpdate(Complejo complejo);
    }
}
