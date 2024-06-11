using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    internal class DocumentoPdfBlobRepository :BaseRepository<DocumentoPDFBlob>, IDocumentoPdfBlobRepository
    {       
        private static readonly string QUERY_DELETE = "Delete FROM DocumentoPDFBlob where id = @Id";     
        private static readonly string QUERY_SELECT = "SELECT * FROM DocumentoPDFBlob WHERE id = @Id";
        private static readonly string QUERY_UPDATE = "UPDATE DocumentoPDFBlob SET blob_pdf = @blob_pdf WHERE id = @documentoId";
        private static readonly string QUERY_INSERT = "INSERT INTO DocumentoPDFBlob (id, blob_pdf) VALUES ( @documentoId, @blob_pdf)";      
          

        public DocumentoPdfBlobRepository(IMapper documentoPDFBlobMapper) : base(documentoPDFBlobMapper, QUERY_DELETE, QUERY_SELECT) {  }

        public ActionResult SaveOrUpdate(DocumentoPDFBlob documentoPDF)
        {
            DocumentoPDFBlob documentoAmpliado = GetById(documentoPDF.Id);
            if (documentoAmpliado != null)
            {
                documentoAmpliado.Data = documentoPDF.hasDataValid() ? documentoPDF.Data : documentoAmpliado.Data;
                Dictionary<string, object> parametros = buildParametros(documentoAmpliado);
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                Dictionary<string, object> parametros = buildParametros(documentoPDF);
                ExecuteWriteOperation(QUERY_INSERT, parametros);                         
                return ActionResult.CREATED;
            }
        }
        protected override List<DocumentoPDFBlob> populateListado()
        {
            return new List<DocumentoPDFBlob>();
        }

        protected override  Dictionary<string, object> buildParametros(DocumentoPDFBlob documentoPDF)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {                        
                { "@blob_pdf",  documentoPDF.hasDataValid()  ? Convert.ToBase64String(documentoPDF.Data):"" },             
                { "@documentoId", documentoPDF.Id.ToString() }
            };           
            return parametros;
        }

        public override ActionResult DeleteById(Guid id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", id.ToString() }
            };
            ExecuteWriteOperation(QUERY_DELETE, parametros);
            return ActionResult.DELETED;
        }

        public override DocumentoPDFBlob GetById(Guid id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", id.ToString() }
            };
            List<DocumentoPDFBlob> results = new List<DocumentoPDFBlob>();
            using (var reader = EjecutarConsulta(QUERY_SELECT, parametros))
            {
                while (reader.Read())
                {
                    results.Add((DocumentoPDFBlob)mapper.Map(reader));
                }
            }
            return results.FirstOrDefault();
        }
    }
}
