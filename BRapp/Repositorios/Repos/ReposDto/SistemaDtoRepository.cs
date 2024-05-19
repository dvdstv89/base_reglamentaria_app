using BRapp.Data;
using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class SistemaDtoRepository : BaseRepository, ISistemaDtoRepository
    {
        private static SistemaDtoRepository instance;       
        private readonly string QUERY_DELETE = "Delete FROM Sistema where id_papel = @papelId";
        private readonly string QUERY_SELECT_ALL_SISTEMAS = "SELECT * FROM Sistema";
        private readonly string QUERY_UPDATE = "UPDATE Sistema SET id_responsable = @responsable, tipo_sistema = @tiposistema WHERE id_papel = @papelId";
        private readonly string QUERY_INSERT = "INSERT INTO Sistema (id_papel, id_responsable, tipo_sistema) VALUES ( @papelId, @responsable, @tiposistema)";
        private readonly List<SistemaDto> sistemasDto;
        private readonly IMapper mapperSistema;

        private SistemaDtoRepository() : base(AplicationConfig.ConnectionString, "Sistema")
        {
            mapperSistema = new SistemaMapper();
            sistemasDto = getAll_SistemasDto();
        }

        public void Delete(Sistema papel)
        {
            SistemaDto sistemaDto = (SistemaDto)mapperSistema.Map(papel);
            Dictionary<string, object> parametros = buildParametros(sistemaDto);
            int index = getIndexById(sistemaDto.idPapel);
            if (index != -1)
            {
                sistemasDto.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }

        private List<SistemaDto> getAll_SistemasDto()
        {
            List<SistemaDto> sistemas = new List<SistemaDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL_SISTEMAS))
            {
                while (reader.Read())
                {
                    sistemas.Add((SistemaDto)mapperSistema.Map(reader));
                }
            }
            return sistemas;
        }

        public SistemaDto getById(Guid id)
        {
            return sistemasDto.FirstOrDefault(doc => doc.idPapel == id);
        }

        private int getIndexById(Guid id)
        {
            return sistemasDto.FindIndex(doc => doc.idPapel == id);
        }

        public ActionResult saveOrUpdate(Sistema papel)
        {
            SistemaDto sistemaDto = (SistemaDto)mapperSistema.Map(papel);
            Dictionary<string, object> parametros = buildParametros(sistemaDto);
            int index = getIndexById(sistemaDto.idPapel);
            if (index != -1)
            {
                sistemasDto[index] = sistemaDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                sistemasDto.Add(sistemaDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(SistemaDto sistemaDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", sistemaDto.idResponsable.ToString() },
                { "@tiposistema", sistemaDto.tipoSistema.ToString() },
                { "@papelId", sistemaDto.idPapel.ToString() }
            };
            return parametros;
        }

        public static SistemaDtoRepository Instance
        {
            get
            {
                instance = (instance == null) ? new SistemaDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
