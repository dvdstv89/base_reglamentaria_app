using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model.Nomenclador;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.Nomenclador
{
    public class ClasificacionDocumentacionDtoRepository : BaseRepository<ClasificacionDocumentacionDto>, IClasificacionDocumentacionRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM ClasificacionDocumentacion where id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * From ClasificacionDocumentacion";
        private static readonly string QUERY_UPDATE = "UPDATE ClasificacionDocumentacion SET id_tipo_documentacion = @id_tipo_documentacion, id_menu_documental = @id_menu_documental WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO ClasificacionDocumentacion (id, id_tipo_documentacion, id_menu_documental) VALUES ( @Id, @id_tipo_documentacion, @id_menu_documental)";
        private readonly string QUERY_DELETE_For_TipoDocumentacion = "Delete FROM ClasificacionDocumentacion where id_tipo_documentacion = @id_tipo_documentacion";
        private readonly string QUERY_DELETE_For_MenuDocumental = "Delete FROM ClasificacionDocumentacion where  id_menu_documental = @id_menu_documental";

        public ClasificacionDocumentacionDtoRepository(IMapper ClasificacionDocumentacionlMapper) : base(ClasificacionDocumentacionlMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }        

        public ActionResult SaveOrUpdate(ClasificacionDocumentacion clasificacionDocumentacion)
        {
            ClasificacionDocumentacionDto clasificacionDocumentacionDto = (ClasificacionDocumentacionDto)mapper.Map(clasificacionDocumentacion);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, clasificacionDocumentacionDto);
        }

        protected override Dictionary<string, object> buildParametros(ClasificacionDocumentacionDto clasificacionDocumentacionDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tipo_documentacion", clasificacionDocumentacionDto.IdTipoDocumentacion.ToString() },
                { "@id_menu_documental", clasificacionDocumentacionDto.IdMenuDocumental.ToString() },
                { "@Id", clasificacionDocumentacionDto.Id.ToString() }
            };
            return parametros;
        }

        public ActionResult DeleteByTipoDocumentacion(Guid IdTipoDocumentacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_tipo_documentacion", IdTipoDocumentacion.ToString() }
            };
            RemoveByIdTipoDocumentacion(IdTipoDocumentacion);
            ExecuteWriteOperation(QUERY_DELETE_For_TipoDocumentacion, parametros);
            return ActionResult.DELETED;

        }
        public ActionResult DeleteByMenuDocumental(Guid IdMenuDocumental)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id_menu_documental",IdMenuDocumental.ToString() }
            };
            RemoveByIdMenuDocumental(IdMenuDocumental);
            ExecuteWriteOperation(QUERY_DELETE_For_MenuDocumental, parametros);
            return ActionResult.DELETED;
        }

        private void RemoveByIdTipoDocumentacion(Guid IdTipoDocumentacion)
        {
            listado.RemoveAll(doc => doc.IdTipoDocumentacion == IdTipoDocumentacion);
        }
        private void RemoveByIdMenuDocumental(Guid IdMenuDocumental)
        {
            listado.RemoveAll(doc => doc.IdMenuDocumental == IdMenuDocumental);
        }
    }
}
