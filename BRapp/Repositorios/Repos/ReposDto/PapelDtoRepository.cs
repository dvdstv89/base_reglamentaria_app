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
    internal class PapelDtoRepository : BaseRepository, IPapelDtoRepository
    {
        private readonly string QUERY_DELETE = "Delete FROM Papel where id = @documentoId";
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Papel order by orden desc";
        private readonly string QUERY_UPDATE = "UPDATE Papel SET tipo_clasificacion_documento = @tipo_clasificacion_documento, id_pdf = @id_pdf, name = @name, is_activo = @is_activo, fecha = @fecha, descripcion = @descripcion, orden = @orden WHERE id = @documentoId";
        private readonly string QUERY_INSERT = "INSERT INTO Papel (id, tipo_clasificacion_documento, id_pdf, name, is_activo, fecha, descripcion, orden) VALUES ( @documentoId, @tipo_clasificacion_documento, @id_pdf, @name, @is_activo, @fecha, @descripcion, @orden)";
        private List<PapelDto> papelDtos;
        private readonly IMapper mapperPapel;

        public PapelDtoRepository(IMapper mapperPapel) : base(AplicationConfig.ConnectionString, "Papel")
        {
            this.mapperPapel = mapperPapel;
            papelDtos = getAll_PapelesDto();
        }
        private List<PapelDto> getAll_PapelesDto()
        {
            List<PapelDto> papeles = new List<PapelDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                while (reader.Read())
                {
                    papeles.Add((PapelDto)mapperPapel.Map(reader));
                }
            }
            return papeles;
        }

        public void Delete(Papel papel)
        {
            PapelDto papelDto = (PapelDto)mapperPapel.Map(papel);
            Dictionary<string, object> parametros = buildParametros(papelDto);
            int index = getIndexById(papelDto.idPapel);
            if (index != -1)
            {
                papelDtos.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }

        public PapelDto getById(Guid id)
        {
            return papelDtos.FirstOrDefault(doc => doc.idPapel == id);
        }
        private int getIndexById(Guid id)
        {
            return papelDtos.FindIndex(doc => doc.idPapel == id);
        }
        public List<PapelDto> getAll()
        {
            return papelDtos.ToList();
        }
        public ActionResult saveOrUpdate(Papel papel)
        {
            PapelDto papelDto = (PapelDto)mapperPapel.Map(papel);
            Dictionary<string, object> parametros = buildParametros(papelDto);
            int index = getIndexById(papelDto.idPapel);
            if (index != -1)
            {
                papelDtos[index] = papelDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                papelDtos.Add(papelDto);
                return ActionResult.CREATED;
            }
        }
        private Dictionary<string, object> buildParametros(PapelDto papelDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@tipo_clasificacion_documento", papelDto.tipoClasificacionDocumento.ToString()},
                { "@id_pdf", papelDto.idPdf.ToString() },
                { "@name", papelDto.name},
                { "@is_activo", papelDto.IsActivo},
                { "@fecha", papelDto.FechaFirma },
                { "@descripcion", papelDto.Descripcion},
                { "@orden", papelDto.Orden},
                { "@documentoId", papelDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
