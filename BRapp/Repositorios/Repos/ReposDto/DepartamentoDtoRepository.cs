using BRapp.Data;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using System.Linq;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Dto;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class DepartamentoDtoRepository : BaseRepository, IDepartamentoDtoRepository
    {
        private static DepartamentoDtoRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Departamento order by orden";
        private readonly string QUERY_UPDATE = "UPDATE Departamento SET name = @name, id_complejo = @id_complejo, tipo_departamento = @tipo_departamento, descripcion = @descripcion, orden = @orden WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO Departamento (id, name, id_complejo, tipo_departamento, descripcion, orden) VALUES ( @Id, @name, @id_complejo, @tipo_departamento, @descripcion, @orden)"; 
        private List<DepartamentoDto> departamentoDtos;      
        private readonly IMapper mapperDepartamento;

        protected DepartamentoDtoRepository():base(AplicationConfig.ConnectionString, "Departamento")
        {
            mapperDepartamento = new DepartamentoMapper();  
            updateListApp();

        }

        protected void updateListApp()
        {
            departamentoDtos = getAll();
        }

        public List<DepartamentoDto> getAll()
        {
            List<DepartamentoDto> apps = new List<DepartamentoDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((DepartamentoDto)mapperDepartamento.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public DepartamentoDto getById(Guid id)
        {
            return departamentoDtos.FirstOrDefault(persona => persona.id == id);
        }

        private int getIndexById(Guid id)
        {
            return departamentoDtos.FindIndex(doc => doc.id == id);
        }

        public ActionResult saveOrUpdate(Departamento departamento)
        {
            DepartamentoDto departamentoDto = (DepartamentoDto)mapperDepartamento.Map(departamento);

            Dictionary<string, object> parametros = buildParametros(departamentoDto);
            int index = getIndexById(departamentoDto.id);
            if (index != -1)
            {
                departamentoDtos[index] = departamentoDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;

            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                departamentoDtos.Add(departamentoDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(DepartamentoDto departamentoDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", departamentoDto.name },
                { "@id_complejo", departamentoDto.idComplejo },
                { "@tipo_departamento", departamentoDto.tipoDepartamento.ToString() },
                { "@descripcion", departamentoDto.descripcion },
                { "@orden", departamentoDto.Orden },
                { "@Id", departamentoDto.id.ToString() }
            };          
            return parametros;
        }

        public static DepartamentoDtoRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new DepartamentoDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
