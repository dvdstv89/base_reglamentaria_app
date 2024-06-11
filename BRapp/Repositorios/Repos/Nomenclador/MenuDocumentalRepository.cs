using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Utiles;
using BRapp.Repositorios.Interfaces;
using BRapp.Model.Nomenclador;

namespace BRapp.Repositorios.Repos.Nomenclador
{
    public class MenuDocumentalRepository : BaseRepository<MenuDocumental>, IMenuDocumentalRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM MenuDocumental WHERE id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM MenuDocumental order by orden";
        private static readonly string QUERY_UPDATE = "UPDATE MenuDocumental SET name = @name, descripcion = @descripcion, show_panel_busqueda = @show_panel_busqueda, show_archivados = @show_archivados, ubicacion_menu = @ubicacion_menu, orden = @orden, is_raiz = @is_raiz, abrir_pagina = @abrir_pagina WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO MenuDocumental (id, name, descripcion, show_panel_busqueda, show_archivados, ubicacion_menu, orden, is_raiz, abrir_pagina) VALUES ( @Id, @name, @descripcion, @show_panel_busqueda, @show_archivados, @ubicacion_menu, @orden, @is_raiz, @abrir_pagina)";        

        public MenuDocumentalRepository(IMapper menuDocumentalMapper) : base(menuDocumentalMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(MenuDocumental menuDocumental)
        {         
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, menuDocumental);
        }

        protected override Dictionary<string, object> buildParametros(MenuDocumental menuDocumental)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", menuDocumental.Name },
                { "@descripcion", menuDocumental.Descripcion },
                { "@show_panel_busqueda", menuDocumental.ShowPanelBusqueda},
                { "@show_archivados", menuDocumental.ShowArchivados},
                { "@is_raiz", menuDocumental.IsRaiz},
                { "@abrir_pagina", menuDocumental.AbrirPagina},                
                { "@ubicacion_menu", menuDocumental.TipoUbicacionMenu.ToString() },
                { "@orden", menuDocumental.Orden},
                { "@Id", menuDocumental.Id.ToString() }
            };          
            return parametros;
        }       
    }
}
