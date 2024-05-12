using BRapp.Model;
using System.Collections.Generic;

namespace BRapp.Repositorios.Interfaces
{
    internal interface ITiendaRepository
    {
        List<Tienda> filtrarTiendas();
    }
}
