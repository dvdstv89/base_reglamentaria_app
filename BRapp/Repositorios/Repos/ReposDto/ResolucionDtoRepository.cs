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
    internal class ResolucionDtoRepository : BaseRepository, IResolucionDtoRepository
    {
        private readonly string QUERY_DELETE = "Delete FROM Resolucion where id_papel = @papelId";
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Resolucion";
        private readonly string QUERY_UPDATE = "UPDATE Resolucion SET id_responsable = @responsable, id_derrogada = @derrogada, numero = @numero WHERE id_papel = @papelId";
        private readonly string QUERY_INSERT = "INSERT INTO Resolucion (id_papel, id_responsable, id_derrogada, numero) VALUES ( @papelId, @responsable, @derrogada, @numero)";
        private readonly List<ResolucionDto> resolucionDtos;
        private readonly IMapper mapperResolucion;

        public ResolucionDtoRepository(IMapper mapperResolucion) : base(AplicationConfig.ConnectionString, "Resolucion")
        {
            this.mapperResolucion = mapperResolucion;
            resolucionDtos = getAll_ResolucionesDto();
        }

        private List<ResolucionDto> getAll_ResolucionesDto()
        {
            List<ResolucionDto> resoluciones = new List<ResolucionDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                while (reader.Read())
                {
                    resoluciones.Add((ResolucionDto)mapperResolucion.Map(reader));
                }
            }
            return resoluciones;
        }

        public void Delete(Resolucion papel)
        {
            ResolucionDto resolucionDto = (ResolucionDto)mapperResolucion.Map(papel);
            Dictionary<string, object> parametros = buildParametros(resolucionDto);
            int index = getIndexById(resolucionDto.idPapel);
            if (index != -1)
            {
                resolucionDtos.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }

        public ResolucionDto getById(Guid id)
        {
            return resolucionDtos.FirstOrDefault(doc => doc.idPapel == id);
        }
        private int getIndexById(Guid id)
        {
            return resolucionDtos.FindIndex(doc => doc.idPapel == id);
        }

        public ActionResult saveOrUpdate(Resolucion papel)
        {
            ResolucionDto resolucionDto = (ResolucionDto)mapperResolucion.Map(papel);
            Dictionary<string, object> parametros = buildParametros(resolucionDto);
            int index = getIndexById(resolucionDto.idPapel);
            if (index != -1)
            {
                resolucionDtos[index] = resolucionDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                resolucionDtos.Add(resolucionDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(ResolucionDto resolucionDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", resolucionDto.idResponsable.ToString() },
                { "@derrogada", resolucionDto.idDerrogada.ToString() },
                { "@numero", resolucionDto.Numero },
                { "@papelId", resolucionDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
