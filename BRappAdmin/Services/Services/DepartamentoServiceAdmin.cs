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
    internal class DepartamentoServiceAdmin : DepartamentoService, IDepartamentoServiceAdmin
    {
        private static DepartamentoServiceAdmin instance;
        private readonly IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository;

        public DepartamentoServiceAdmin()
        {
            departamentoGrupoDocumentacionDtoRepository = DepartamentoGrupoDocumentacionDtoRepository.Instance;
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

        public static DepartamentoServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new DepartamentoServiceAdmin() : instance;
                return instance;
            }
        }
    }
}
