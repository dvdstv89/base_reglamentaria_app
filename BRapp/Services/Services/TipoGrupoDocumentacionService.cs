using BRapp.Dto;
using BRapp.Model.Nomenclador;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class TipoGrupoDocumentacionService : BaseService<TipoGrupoDocumentacion, TipoGrupoDocumentacion> ,ITipoGrupoDocumentacionService
    {        
        private readonly IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository;
        private readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionRepository;

        public TipoGrupoDocumentacionService(ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository, IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository, ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionRepository)
        :base(tipoGrupoDocumentacionRepository)
        {           
            this.departamentoGrupoDocumentacionDtoRepository = departamentoGrupoDocumentacionDtoRepository;
            this.tiendaGrupoDocumentacionRepository = tiendaGrupoDocumentacionRepository;
        }

        public override List<TipoGrupoDocumentacion> GetAll()
        {
           return repository.GetAll();
        }

        public List<TipoGrupoDocumentacion> GetByIdDepartamento(Guid id)
        {
            List<TipoGrupoDocumentacion> grupoDocumentacions = new List<TipoGrupoDocumentacion>();
            List<DepartamentoGrupoDocumentacionDto> departamentoGrupoDocumentacionDtos = departamentoGrupoDocumentacionDtoRepository.getAllByIdDepartamento(id);
            foreach (DepartamentoGrupoDocumentacionDto departamentoGrupoDocumentacion in departamentoGrupoDocumentacionDtos)
            {
                grupoDocumentacions.Add(GetById(departamentoGrupoDocumentacion.idTipoGrupoDocumentacion));
            }
            return grupoDocumentacions;
        }

        public List<TipoGrupoDocumentacion> GetByIdTienda(Guid id)
        {
            List<TipoGrupoDocumentacion> grupoDocumentacions = new List<TipoGrupoDocumentacion>();
            List<TiendaGrupoDocumentacionDto> tiendaGrupoDocumentacionDtos = tiendaGrupoDocumentacionRepository.getAllByIdTienda(id);
            foreach (TiendaGrupoDocumentacionDto tiendaGrupoDocumentacion in tiendaGrupoDocumentacionDtos)
            {
                grupoDocumentacions.Add(GetById(tiendaGrupoDocumentacion.idTipoGrupoDocumentacion));
            }
            return grupoDocumentacions;
        }


        public List<TipoGrupoDocumentacion> GetAllForTienda()
        {
            return GetAll().Where(t => t.LugarMostrarDocumentacion == Enums.LugarMostrarDocumentacion.TODOS || t.LugarMostrarDocumentacion == Enums.LugarMostrarDocumentacion.TIENDA).ToList();
        }
        public List<TipoGrupoDocumentacion> GetAllForDepartamentos()
        {
            return GetAll().Where(t => t.LugarMostrarDocumentacion == Enums.LugarMostrarDocumentacion.TODOS || t.LugarMostrarDocumentacion == Enums.LugarMostrarDocumentacion.DEPARTAMENTO).ToList();
        }
    }
}
