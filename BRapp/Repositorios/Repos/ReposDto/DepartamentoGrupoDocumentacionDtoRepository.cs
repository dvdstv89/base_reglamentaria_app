using BRapp.Data;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Dto;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class DepartamentoGrupoDocumentacionDtoRepository : BaseRepository, IDepartamentoGrupoDocumentacionDtoRepository
    {
        private static DepartamentoGrupoDocumentacionDtoRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM DepartamentoTipoGrupoDocumentacion";
        private readonly string QUERY_DELETE = "Delete FROM DepartamentoTipoGrupoDocumentacion where id_departamento = @id_departamento and id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_INSERT = "INSERT INTO DepartamentoTipoGrupoDocumentacion (id_departamento, id_tipo_grupo_documentacion) VALUES ( @id_departamento, @id_tipo_grupo_documentacion)";
        private List<DepartamentoGrupoDocumentacionDto> departamentoGrupoDocumentacionDtos;
        private readonly IMapper departamentoGrupoDocumentacionMapper;

        protected DepartamentoGrupoDocumentacionDtoRepository():base(AplicationConfig.ConnectionString, "DepartamentoTipoGrupoDocumentacion")
        {
            departamentoGrupoDocumentacionMapper = new DepartamentoGrupoDocumentacionMapper ();
            updateList();
        }
        protected void updateList()
        {
            departamentoGrupoDocumentacionDtos = getAll();
        }
        private List<DepartamentoGrupoDocumentacionDto> getAll()
        {
            List<DepartamentoGrupoDocumentacionDto> apps = new List<DepartamentoGrupoDocumentacionDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((DepartamentoGrupoDocumentacionDto)departamentoGrupoDocumentacionMapper.Map(reader));
                    }
                }
            }
            return apps;
        }             
        private int getIndexById(DepartamentoGrupoDocumentacionDto departamento)
        {
            return departamentoGrupoDocumentacionDtos.FindIndex(doc => doc.idDepartamento == departamento.idDepartamento && doc.idTipoGrupoDocumentacion == departamento.idTipoGrupoDocumentacion);
        }      

        public bool save(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = buildParametros(departamento);
            int index = getIndexById(departamento);
            if (index != -1)
            {
                return false;
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                departamentoGrupoDocumentacionDtos.Add(departamento);
                return result;
            }
        }
        public bool delete(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = buildParametros(departamento);
            int index = getIndexById(departamento);
            if (index != -1)
            {
                departamentoGrupoDocumentacionDtos.RemoveAt(index);
                return ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
            else
            {
                return false;
            }
           
        }
        private Dictionary<string, object> buildParametros(DepartamentoGrupoDocumentacionDto departamento)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_departamento", departamento.idDepartamento.ToString() },
                { "@id_tipo_grupo_documentacion", departamento.idTipoGrupoDocumentacion.ToString() }
            };          
            return parametros;
        }
        public List<DepartamentoGrupoDocumentacionDto> getAllByIdDepartamento(Guid idDepartamento)
        {
            return departamentoGrupoDocumentacionDtos.FindAll(dep => dep.idDepartamento == idDepartamento);
        }
        public static DepartamentoGrupoDocumentacionDtoRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new DepartamentoGrupoDocumentacionDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
