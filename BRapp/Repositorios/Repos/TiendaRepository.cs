using BRapp.Data;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos
{
    internal class TiendaRepository : ITiendaRepository
    {
        private static TiendaRepository instance;      

        public List<Tienda> filtrarTiendas()
        {
            return new List<Tienda>();
        }
       
        public static TiendaRepository Instance
        {
            get
            {
                instance = (instance == null) ? new TiendaRepository() : instance;
                return instance;
            }
        } 
    }
}
