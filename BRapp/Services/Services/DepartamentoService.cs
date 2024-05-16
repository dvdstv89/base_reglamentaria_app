using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private static DepartamentoService instance;
        protected readonly IDepartamentoDtoRepository departamentoDtoRepository;
        private readonly IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository;
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;      
        private readonly IComplejoService complejoService;
        protected List<Departamento> departamentos;

        protected DepartamentoService()
        {
            departamentoDtoRepository = DepartamentoDtoRepository.Instance;
            departamentoGrupoDocumentacionDtoRepository = DepartamentoGrupoDocumentacionDtoRepository.Instance;          
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionService.Instance;
            complejoService = ComplejoService.Instance;
            Populate();
        }

        private List<Departamento> Populate()
        {
            departamentos = new List<Departamento>();
            List<DepartamentoDto> departamentosDto = departamentoDtoRepository.getAll();
            foreach (DepartamentoDto dpto in departamentosDto)
            {              
                List<TipoGrupoDocumentacion> grupoDocumentacions = getDepartamentoGrupoDocumentacionDtos(dpto);
                Complejo complejo = complejoService.getById(dpto.idComplejo);
                departamentos.Add(new Departamento(dpto, complejo, grupoDocumentacions));
            }
            return departamentos;
        }

        public Departamento getById(Guid id)
        {
            return departamentos.FirstOrDefault(t => t.Id == id);
        }

        protected int getIndexById(Guid id)
        {
            return departamentos.FindIndex(doc => doc.Id == id);
        }

        public List<Departamento> getDepartamentosByComplejo(Complejo complejo)
        {
            return departamentos.FindAll(t => t.Complejo.Id == complejo.Id);
        }

        private List<TipoGrupoDocumentacion> getDepartamentoGrupoDocumentacionDtos(DepartamentoDto tienda)
        {
            List<TipoGrupoDocumentacion> grupoDocumentacions = new List<TipoGrupoDocumentacion>();
            List<DepartamentoGrupoDocumentacionDto> tiendaGrupoDocumentacionDtos = departamentoGrupoDocumentacionDtoRepository.getAllByIdDepartamento(tienda.id);
            foreach (DepartamentoGrupoDocumentacionDto tiendaGrupoDocumentacion in tiendaGrupoDocumentacionDtos)
            {
                grupoDocumentacions.Add(tipoGrupoDocumentacionService.getById(tiendaGrupoDocumentacion.idTipoGrupoDocumentacion));
            }
            return grupoDocumentacions;
        }

        public bool saveOrUpdate(Departamento departamento)
        {
            ActionResult actionResult = departamentoDtoRepository.saveOrUpdate(departamento);
            if (actionResult == ActionResult.CREATED)
            {
                departamentos.Add(departamento);
            }
            else if (actionResult == ActionResult.UPDATED)
            {
                int index = getIndexById(departamento.Id);
                if (index != -1)
                {
                    departamentos[index] = departamento;
                }
            }



            List<DepartamentoGrupoDocumentacionDto> gruposAntiguos = departamentoGrupoDocumentacionDtoRepository.getAllByIdDepartamento(departamento.Id);
            List<TipoGrupoDocumentacion> gruposNuevos = departamento.TipoGrupoDocumentacion;

            List<DepartamentoGrupoDocumentacionDto> gruposParaEliminar = gruposAntiguos
                 .Where(antiguo => !gruposNuevos.Any(nuevo => nuevo.Id == antiguo.idTipoGrupoDocumentacion))
                 .ToList();

            List<TipoGrupoDocumentacion> gruposParaGuardar = gruposNuevos
                .Where(nuevo => !gruposAntiguos.Any(antiguo => antiguo.idTipoGrupoDocumentacion == nuevo.Id))
                .ToList();

            foreach (var grupoEliminar in gruposParaEliminar)
            {
                departamentoGrupoDocumentacionDtoRepository.delete(grupoEliminar);
            }

            foreach (var grupoGuardar in gruposParaGuardar)
            {
                var grupoNuevo = new DepartamentoGrupoDocumentacionDto()
                {
                    idDepartamento = departamento.Id,
                    idTipoGrupoDocumentacion = grupoGuardar.Id
                };
                departamentoGrupoDocumentacionDtoRepository.save(grupoNuevo);
            }
            return true;
        }


        public static DepartamentoService Instance
        {
            get
            {
                instance = (instance == null) ? new DepartamentoService() : instance;
                return instance;
            }
        }
    }
}
