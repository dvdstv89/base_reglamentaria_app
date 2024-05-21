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
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Departamento order by orden";
        private readonly string QUERY_UPDATE = "UPDATE Departamento SET name = @name, id_complejo = @id_complejo, tipo_departamento = @tipo_departamento, descripcion = @descripcion, orden = @orden, trabajadores = @trabajadores WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO Departamento (id, name, id_complejo, tipo_departamento, descripcion, orden, trabajadores) VALUES ( @Id, @name, @id_complejo, @tipo_departamento, @descripcion, @orden, @trabajadores)"; 
        private List<DepartamentoDto> departamentoDtos;      
        private readonly IMapper departamentoMapper;

        public DepartamentoDtoRepository(IMapper departamentoMapper) :base(AplicationConfig.ConnectionString, "Departamento")
        {
            this.departamentoMapper = departamentoMapper;  
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
                        apps.Add((DepartamentoDto)departamentoMapper.Map(reader));
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
            DepartamentoDto departamentoDto = (DepartamentoDto)departamentoMapper.Map(departamento);

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
                { "@trabajadores", departamentoDto.CantidadTrabajadores },
                { "@Id", departamentoDto.id.ToString() }
            };          
            return parametros;
        }
    }
}
