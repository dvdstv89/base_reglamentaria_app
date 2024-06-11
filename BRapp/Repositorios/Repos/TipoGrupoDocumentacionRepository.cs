using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using BRapp.Enums;

namespace BRapp.Repositorios.Repos
{
    public class TipoGrupoDocumentacionRepository : BaseRepository<TipoGrupoDocumentacion>, ITipoGrupoDocumentacionRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM TipoGrupoDocumentacion";
        private static readonly string QUERY_UPDATE = "UPDATE TipoGrupoDocumentacion SET name = @name, descripcion = @descripcion, lugar_mostrar_documentacion = @lugar_mostrar_documentacion WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO TipoGrupoDocumentacion (id, name, descripcion, lugar_mostrar_documentacion) VALUES ( @Id, @name, @descripcion, @lugar_mostrar_documentacion)";
        private static readonly string QUERY_DELETE = "Delete FROM TipoGrupoDocumentacion WHERE id = @Id";     

        public TipoGrupoDocumentacionRepository(IMapper tipoGrupoDocumentacionMapper) : base(tipoGrupoDocumentacionMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, tipoGrupoDocumentacion);
        }

        protected override Dictionary<string, object> buildParametros(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", tipoGrupoDocumentacion.Name },
                { "@descripcion", tipoGrupoDocumentacion.Descripcion },
                { "@lugar_mostrar_documentacion", tipoGrupoDocumentacion.LugarMostrarDocumentacion.ToString() },
                { "@Id", tipoGrupoDocumentacion.Id.ToString() }
            };          
            return parametros;
        }      
    }
}
