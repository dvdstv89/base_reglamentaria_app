using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Repositorios.Interfaces;
using BRapp.Dto;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class TiendaGrupoDocumentacionDtoRepository : BaseRepository<TiendaGrupoDocumentacionDto>, ITiendaGrupoDocumentacionDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM TiendaTipoGrupoDocumentacion";
        private static readonly string QUERY_DELETE = "Delete FROM TiendaTipoGrupoDocumentacion where id_tienda = @id_tienda and id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_DELETE_For_Tienda = "Delete FROM TiendaTipoGrupoDocumentacion where id_tienda = @id_tienda";
        private readonly string QUERY_DELETE_For_Grupo = "Delete FROM TiendaTipoGrupoDocumentacion where  id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion";
        private readonly string QUERY_INSERT = "INSERT INTO TiendaTipoGrupoDocumentacion (id_tienda, id_tipo_grupo_documentacion) VALUES ( @id_tienda, @id_tipo_grupo_documentacion)";       

        public TiendaGrupoDocumentacionDtoRepository(IMapper tiendaGrupoDocumentacionMapper) : base(tiendaGrupoDocumentacionMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public List<TiendaGrupoDocumentacionDto> getAllByIdTienda(Guid idTienda)
        {
            return listado.FindAll(dep => dep.idTienda == idTienda);
        }

        public ActionResult Save(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = buildParametros(tienda);
            int index = getIndexById(tienda);
            if (index != -1)
            {
                return ActionResult.NONE;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                listado.Add(tienda);
                return ActionResult.CREATED;
            }
        }
        public ActionResult Delete(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = buildParametros(tienda);
            int index = getIndexById(tienda);
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
        public ActionResult DeleteForTienda(Guid idTienda)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tienda", idTienda.ToString() }               
            };
            RemoveByIdTienda(idTienda);
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
      

        protected override Dictionary<string, object> buildParametros(TiendaGrupoDocumentacionDto tienda)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tienda", tienda.idTienda.ToString() },
                { "@id_tipo_grupo_documentacion", tienda.idTipoGrupoDocumentacion.ToString() }
            };
            return parametros;
        }
        private int getIndexById(TiendaGrupoDocumentacionDto tienda)
        {
            return listado.FindIndex(doc => doc.idTienda == tienda.idTienda && doc.idTipoGrupoDocumentacion == tienda.idTipoGrupoDocumentacion);
        }
        private void RemoveByIdTienda(Guid idTienda)
        {
            listado.RemoveAll(doc => doc.idTienda == idTienda);
        }
        private void RemoveByIdGrupo(Guid idGrupo)
        {
            listado.RemoveAll(doc => doc.idTipoGrupoDocumentacion == idGrupo);
        }
    }
}
