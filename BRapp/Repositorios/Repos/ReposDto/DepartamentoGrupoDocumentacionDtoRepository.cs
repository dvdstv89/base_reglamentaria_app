using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Repositorios.Interfaces;
using BRapp.Dto;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class DepartamentoGrupoDocumentacionDtoRepository : BaseRepository<DepartamentoGrupoDocumentacionDto>, IDepartamentoGrupoDocumentacionDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM DepartamentoTipoGrupoDocumentacion";
        private static readonly string QUERY_DELETE = "Delete FROM DepartamentoTipoGrupoDocumentacion where id_departamento = @id_departamento and id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_DELETE_For_Tienda = "Delete FROM DepartamentoTipoGrupoDocumentacion where id_departamento = @id_departamento";
        private readonly string QUERY_DELETE_For_Grupo = "Delete FROM DepartamentoTipoGrupoDocumentacion where  id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_INSERT = "INSERT INTO DepartamentoTipoGrupoDocumentacion (id_departamento, id_tipo_grupo_documentacion) VALUES ( @id_departamento, @id_tipo_grupo_documentacion)";      

        public DepartamentoGrupoDocumentacionDtoRepository(IMapper departamentoGrupoDocumentacionMapper) :base(departamentoGrupoDocumentacionMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }
        
        public List<DepartamentoGrupoDocumentacionDto> getAllByIdDepartamento(Guid idDepartamento)
        {
            return listado.FindAll(dep => dep.idDepartamento == idDepartamento);
        }
        public ActionResult Save(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = buildParametros(departamento);
            int index = getIndexById(departamento);
            if (index != -1)
            {
                return ActionResult.NONE;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                listado.Add(departamento);
                return ActionResult.CREATED;
            }
        }
        public ActionResult Delete(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = buildParametros(departamento);
            int index = getIndexById(departamento);
            if (index != -1)
            {
                listado.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
                return ActionResult.DELETED;
            }
            else
            {
                return ActionResult.NONE;
            }
           
        }
        public ActionResult DeleteForDepartamento(Guid idDepartamento)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_departamento", idDepartamento.ToString() }
            };
            RemoveByIdDepartamento(idDepartamento);
            ExecuteWriteOperation(QUERY_DELETE_For_Tienda, parametros);
            return ActionResult.DELETED;

        }
        public ActionResult DeleteForGrupo(Guid idGrupo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tipo_grupo_documentacion",idGrupo.ToString() }
            };
            RemoveByIdGrupo(idGrupo);
            ExecuteWriteOperation(QUERY_DELETE_For_Grupo, parametros);
            return ActionResult.DELETED;
        }
        protected override Dictionary<string, object> buildParametros(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_departamento", departamento.idDepartamento.ToString() },
                { "@id_tipo_grupo_documentacion", departamento.idTipoGrupoDocumentacion.ToString() }
            };
            return parametros;
        }
        private int getIndexById(DepartamentoGrupoDocumentacionDto departamento)
        {
            return listado.FindIndex(doc => doc.idDepartamento == departamento.idDepartamento && doc.idTipoGrupoDocumentacion == departamento.idTipoGrupoDocumentacion);
        }
        private void RemoveByIdDepartamento(Guid idDepartamento)
        {
            listado.RemoveAll(doc => doc.idDepartamento == idDepartamento);
        }
        private void RemoveByIdGrupo(Guid idGrupo)
        {
            listado.RemoveAll(doc => doc.idTipoGrupoDocumentacion == idGrupo);
        }
    }
}
