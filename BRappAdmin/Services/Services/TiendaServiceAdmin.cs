using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Services;
using BRapp.Utiles;
using BRappAdmin.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BRappAdmin.Services.Services
{
    internal class TiendaServiceAdmin : TiendasService, ITiendaServiceAdmin
    {
        private static TiendaServiceAdmin instance;
        private readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionDtoRepository;

        public TiendaServiceAdmin()
        {
            tiendaGrupoDocumentacionDtoRepository = TiendaGrupoDocumentacionDtoRepository.Instance;
        }


        public bool saveOrUpdate(Tienda tienda)
        {
            ActionResult actionResult = tiendaDtoRepository.saveOrUpdate(tienda);
            if(actionResult == ActionResult.CREATED)
            {
                tiendas.Add(tienda);
            }
            else if(actionResult == ActionResult.UPDATED)
            {
                int index = getIndexById(tienda.Id);
                if (index != -1)
                {
                    tiendas[index] = tienda;
                }
            }


            List<TiendaGrupoDocumentacionDto> gruposAntiguos = tiendaGrupoDocumentacionDtoRepository.getAllByIdTienda(tienda.Id);
            List<TipoGrupoDocumentacion> gruposNuevos = tienda.TipoGrupoDocumentacion;


            List<TiendaGrupoDocumentacionDto> gruposParaEliminar = gruposAntiguos
                 .Where(antiguo => !gruposNuevos.Any(nuevo => nuevo.Id == antiguo.idTipoGrupoDocumentacion))
                 .ToList();

            List<TipoGrupoDocumentacion> gruposParaGuardar = gruposNuevos
                .Where(nuevo => !gruposAntiguos.Any(antiguo => antiguo.idTipoGrupoDocumentacion == nuevo.Id))
                .ToList();

            foreach (var grupoEliminar in gruposParaEliminar)
            {
                tiendaGrupoDocumentacionDtoRepository.delete(grupoEliminar);
            }
           
            foreach (var grupoGuardar in gruposParaGuardar)
            {     
                var grupoNuevo = new TiendaGrupoDocumentacionDto()
                {
                    idTienda = tienda.Id,
                    idTipoGrupoDocumentacion = grupoGuardar.Id
                };
                tiendaGrupoDocumentacionDtoRepository.save(grupoNuevo);
            }
            return true;
        }

        public static TiendaServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new TiendaServiceAdmin() : instance;
                return instance;
            }
        }
    }
}
