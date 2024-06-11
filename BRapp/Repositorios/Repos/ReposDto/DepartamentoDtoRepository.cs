using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Dto;
using BRapp.Utiles;
using System;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class DepartamentoDtoRepository : BaseRepository<DepartamentoDto>, IDepartamentoDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Departamento order by orden";
        private static readonly string QUERY_UPDATE = "UPDATE Departamento SET name = @name, id_complejo = @id_complejo, tipo_departamento = @tipo_departamento, descripcion = @descripcion, orden = @orden, trabajadores = @trabajadores WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO Departamento (id, name, id_complejo, tipo_departamento, descripcion, orden, trabajadores) VALUES ( @Id, @name, @id_complejo, @tipo_departamento, @descripcion, @orden, @trabajadores)";
        private static readonly string QUERY_DELETE = "Delete FROM Departamento WHERE id = @Id";

        private readonly IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository;

        public DepartamentoDtoRepository(IMapper departamentoMapper, IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository) :base(departamentoMapper, QUERY_DELETE, QUERY_SELECT_ALL) 
        {
            this.departamentoGrupoDocumentacionDtoRepository = departamentoGrupoDocumentacionDtoRepository;
        }

        public override ActionResult DeleteById(Guid id)
        {
           base.DeleteById(id);
           return departamentoGrupoDocumentacionDtoRepository.DeleteForDepartamento(id);
        }

        public ActionResult SaveOrUpdate(Departamento departamento)
        {
            DepartamentoDto departamentoDto = (DepartamentoDto)mapper.Map(departamento);
            ActionResult actionResult =  saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, departamentoDto);

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
                departamentoGrupoDocumentacionDtoRepository.Delete(grupoEliminar);
            }

            foreach (var grupoGuardar in gruposParaGuardar)
            {
                var grupoNuevo = new DepartamentoGrupoDocumentacionDto()
                {
                    idDepartamento = departamento.Id,
                    idTipoGrupoDocumentacion = grupoGuardar.Id
                };
                departamentoGrupoDocumentacionDtoRepository.Save(grupoNuevo);
            }

            return actionResult;
        }

        protected override Dictionary<string, object> buildParametros(DepartamentoDto departamentoDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", departamentoDto.name },
                { "@id_complejo", departamentoDto.idComplejo },
                { "@tipo_departamento", departamentoDto.tipoDepartamento.ToString() },
                { "@descripcion", departamentoDto.descripcion },
                { "@orden", departamentoDto.Orden },
                { "@trabajadores", departamentoDto.CantidadTrabajadores },
                { "@Id", departamentoDto.id.ToString() }
            };
            return parametros;
        }
    }
}
