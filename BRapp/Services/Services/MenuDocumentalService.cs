using BRapp.Enums;
using BRapp.Model.Nomenclador;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class MenuDocumentalService : BaseService<MenuDocumental, MenuDocumental>, IMenuDocumentalService
    {  
        public MenuDocumentalService(IMenuDocumentalRepository menuDocumentalRepository) : base(menuDocumentalRepository) { }

        public override List<MenuDocumental> GetAll()
        {
            return repository.GetAll().OrderBy(o => o.Orden).ToList();
        }

        public List<MenuDocumental> GetAllByTipoUbicacionMenu(TipoUbicacionMenu tipoUbicacionMenu)
        {
            return GetAll().FindAll(m => m.TipoUbicacionMenu == tipoUbicacionMenu).OrderByDescending(m=> m.IsRaiz).ToList();
        }
    }
}
