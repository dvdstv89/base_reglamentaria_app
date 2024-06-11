using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Utiles;
using BRapp.Repositorios.Interfaces;
using BRapp.Model.Nomenclador;


namespace BRapp.Repositorios.Repos.Nomenclador
{
    public class TipoDocumentacionRepository : BaseRepository<TipoDocumentacion>, ITipoDocumentacionRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM TipoDocumentacion WHERE id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM TipoDocumentacion order by name";
        private static readonly string QUERY_UPDATE = "UPDATE TipoDocumentacion SET name = @name, tipo_card = @tipo_card, icon = @icon, has_pdf = @has_pdf, tipo_responsable = @tipo_responsable, has_numeracion = @has_numeracion, has_fecha_creacion = @has_fecha_creacion, has_fecha_vencimiento = @has_fecha_vencimiento,tipo_cliente = @tipo_cliente,has_es_obligatorio = @has_es_obligatorio,has_tipo = @has_tipo,has_padre = @has_padre,has_acta_acuerdo = @has_acta_acuerdo  WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO TipoDocumentacion (id, name, tipo_card, icon, has_pdf, tipo_responsable, has_numeracion, has_fecha_creacion, has_fecha_vencimiento,tipo_cliente,has_es_obligatorio,has_tipo,has_padre,has_acta_acuerdo ) VALUES ( @Id, @name, @tipo_card, @icon, @has_pdf, @tipo_responsable, @has_numeracion, @has_fecha_creacion, @has_fecha_vencimiento,@tipo_cliente,@has_es_obligatorio,@has_tipo,@has_padre,@has_acta_acuerdo)";       

        public TipoDocumentacionRepository(IMapper tipoDocumentacionMapper) : base(tipoDocumentacionMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(TipoDocumentacion tipoDocumentacion)
        {         
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, tipoDocumentacion);
        }

        protected override Dictionary<string, object> buildParametros(TipoDocumentacion tipoDocumentacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", tipoDocumentacion.Name },
                { "@tipo_card", tipoDocumentacion.TipoCard.ToString() },
                { "@icon", tipoDocumentacion.Icon.ToString() },
                { "@has_pdf", tipoDocumentacion.HasPdf },
                { "@tipo_responsable", tipoDocumentacion.TipoResponsable.ToString() },
                { "@has_numeracion", tipoDocumentacion.HasNumeracion },
                { "@has_fecha_creacion", tipoDocumentacion.HasFechaCreacion },
                { "@has_fecha_vencimiento", tipoDocumentacion.HasFechaVencimiento },
                { "@tipo_cliente", tipoDocumentacion.TipoCliente.ToString() },
                { "@has_es_obligatorio", tipoDocumentacion.HasOpcionalidad },
                { "@has_tipo", tipoDocumentacion.HasTipo },
                { "@has_padre", tipoDocumentacion.HasPadre },
                { "@has_acta_acuerdo", tipoDocumentacion.HasActaAcuerdo },
                { "@Id", tipoDocumentacion.Id.ToString() }
            };          
            return parametros;
        }       
    }
}
