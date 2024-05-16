using BRapp.Data;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using System.Linq;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Dto;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class GrupoDocumentacionDtoRepository : BaseRepository, IGrupoDocumentacionDtoRepository
    {
        private static GrupoDocumentacionDtoRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM GrupoDocumentacion";
        private readonly string QUERY_UPDATE = "UPDATE GrupoDocumentacion SET id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion, id_papel = @id_papel, is_opcional = @is_opcional WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO GrupoDocumentacion (id, id_tipo_grupo_documentacion, id_papel, is_opcional) VALUES ( @Id, @id_tipo_grupo_documentacion, @id_papel, @is_opcional)"; 
        private List<GrupoDocumentacionDto> grupoDocumentacions;      
        private readonly IMapper mapperGrupoDocumentacion;

        protected GrupoDocumentacionDtoRepository():base(AplicationConfig.ConnectionString, "GrupoDocumentacion")
        {
            mapperGrupoDocumentacion = new GrupoDocumentacionMapper();  
            updateListApp();

        }

        protected void updateListApp()
        {
            grupoDocumentacions = getAll();
        }

        public List<GrupoDocumentacionDto> getAll()
        {
            List<GrupoDocumentacionDto> apps = new List<GrupoDocumentacionDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((GrupoDocumentacionDto)mapperGrupoDocumentacion.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public GrupoDocumentacionDto getById(Guid id)
        {
            return grupoDocumentacions.FirstOrDefault(persona => persona.id == id);
        }

        private int getIndexById(Guid id)
        {
            return grupoDocumentacions.FindIndex(doc => doc.id == id);
        }

        public bool saveOrUpdate(GrupoDocumentacion grupoDocumentacion)
        {           
            GrupoDocumentacionDto grupoDocumentacionDto = (GrupoDocumentacionDto)mapperGrupoDocumentacion.Map(grupoDocumentacion);

            Dictionary<string, object> parametros = buildParametros(grupoDocumentacionDto);
            int index = getIndexById(grupoDocumentacion.Id);
            if (index != -1)
            {
                grupoDocumentacions[index] = grupoDocumentacionDto;
                return ExecuteWriteOperation(QUERY_UPDATE, parametros);
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                grupoDocumentacions.Add(grupoDocumentacionDto);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(GrupoDocumentacionDto grupoDocumentacionDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {              
                { "@id_tipo_grupo_documentacion", grupoDocumentacionDto.idTipoGrupoDocumentacion },
                { "@id_papel", grupoDocumentacionDto.idDocumento },
                { "@is_opcional", grupoDocumentacionDto.IsOpcional },
                { "@Id", grupoDocumentacionDto.id.ToString() }
            };          
            return parametros;
        }

        public static GrupoDocumentacionDtoRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new GrupoDocumentacionDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
