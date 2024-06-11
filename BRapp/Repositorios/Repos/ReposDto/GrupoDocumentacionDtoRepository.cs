using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Dto;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class GrupoDocumentacionDtoRepository : BaseRepository<GrupoDocumentacionDto>, IGrupoDocumentacionDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM GrupoDocumentacion order by orden";
        private static readonly string QUERY_DELETE = "Delete FROM GrupoDocumentacion where id = @Id";
        private static readonly string QUERY_UPDATE = "UPDATE GrupoDocumentacion SET id_tipo_grupo_documentacion = @id_tipo_grupo_documentacion, id_papel = @id_papel, orden = @orden WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO GrupoDocumentacion (id, id_tipo_grupo_documentacion, id_papel, orden) VALUES ( @Id, @id_tipo_grupo_documentacion, @id_papel, @orden)"; 
        

        public GrupoDocumentacionDtoRepository(IMapper grupoDocumentacionMapper) : base(grupoDocumentacionMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }


        public ActionResult SaveOrUpdate(GrupoDocumentacion grupoDocumentacion)
        {
            GrupoDocumentacionDto grupoDocumentacionDto = (GrupoDocumentacionDto)mapper.Map(grupoDocumentacion);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, grupoDocumentacionDto);
        }

        protected override Dictionary<string, object> buildParametros(GrupoDocumentacionDto grupoDocumentacionDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {              
                { "@id_tipo_grupo_documentacion", grupoDocumentacionDto.idTipoGrupoDocumentacion },
                { "@id_papel", grupoDocumentacionDto.idDocumento },               
                { "@orden", grupoDocumentacionDto.Orden },
                { "@Id", grupoDocumentacionDto.id.ToString() }
            };          
            return parametros;
        }       
    }
}
