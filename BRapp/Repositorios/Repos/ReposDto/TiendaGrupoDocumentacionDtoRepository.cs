using BRapp.Data;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Dto;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class TiendaGrupoDocumentacionDtoRepository : BaseRepository, ITiendaGrupoDocumentacionDtoRepository
    {
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM TiendaTipoGrupoDocumentacion";
        private readonly string QUERY_DELETE = "Delete FROM TiendaTipoGrupoDocumentacion where id_tienda = @id_tienda and id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_INSERT = "INSERT INTO TiendaTipoGrupoDocumentacion (id_tienda, id_tipo_grupo_documentacion) VALUES ( @id_tienda, @id_tipo_grupo_documentacion)";
        private List<TiendaGrupoDocumentacionDto> tiendaGrupoDocumentacionDtos;
        private readonly IMapper tiendaGrupoDocumentacionMapper;

        public TiendaGrupoDocumentacionDtoRepository(IMapper tiendaGrupoDocumentacionMapper) : base(AplicationConfig.ConnectionString, "TiendaTipoGrupoDocumentacion")
        {
            this.tiendaGrupoDocumentacionMapper = tiendaGrupoDocumentacionMapper;
            updateList();
        }
        protected void updateList()
        {
            tiendaGrupoDocumentacionDtos = getAll();
        }
        private List<TiendaGrupoDocumentacionDto> getAll()
        {
            List<TiendaGrupoDocumentacionDto> apps = new List<TiendaGrupoDocumentacionDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((TiendaGrupoDocumentacionDto)tiendaGrupoDocumentacionMapper.Map(reader));
                    }
                }
            }
            return apps;
        }
        private int getIndexById(TiendaGrupoDocumentacionDto tienda)
        {
            return tiendaGrupoDocumentacionDtos.FindIndex(doc => doc.idTienda == tienda.idTienda && doc.idTipoGrupoDocumentacion == tienda.idTipoGrupoDocumentacion);
        }
        public bool save(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = buildParametros(tienda);
            int index = getIndexById(tienda);
            if (index != -1)
            {
                return false;
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                tiendaGrupoDocumentacionDtos.Add(tienda);
                return result;
            }
        }
        public bool delete(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = buildParametros(tienda);
            int index = getIndexById(tienda);
            if (index != -1)
            {
                tiendaGrupoDocumentacionDtos.RemoveAt(index);
                return ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
            else
            {
                return false;
            }

        }
        private Dictionary<string, object> buildParametros(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tienda", tienda.idTienda.ToString() },
                { "@id_tipo_grupo_documentacion", tienda.idTipoGrupoDocumentacion.ToString() }
            };
            return parametros;
        }
        public List<TiendaGrupoDocumentacionDto> getAllByIdTienda(Guid idTienda)
        {
            return tiendaGrupoDocumentacionDtos.FindAll(dep => dep.idTienda == idTienda);
        }       
    }
}
