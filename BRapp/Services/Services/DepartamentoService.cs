using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
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
