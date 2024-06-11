using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos
{
    internal class DocumentoPdfRepository : BaseRepository<DocumentoPDF>, IDocumentoPdfRepository
    {       
        private static readonly string QUERY_DELETE = "Delete FROM DocumentoPDF where id = @Id";
        private static readonly string QUERY_SELECT_ALL_DOCUMENTOS_PDF = "SELECT id,pdf FROM DocumentoPDF";      
        private static readonly string QUERY_UPDATE = "UPDATE DocumentoPDF SET pdf = @pdf WHERE id = @documentoId";
        private static readonly string QUERY_INSERT = "INSERT INTO DocumentoPDF (id, pdf) VALUES ( @documentoId, @pdf)";       
             

        public DocumentoPdfRepository(IMapper documentoPDFMapper) : base(documentoPDFMapper, QUERY_DELETE, QUERY_SELECT_ALL_DOCUMENTOS_PDF) {  }

        public ActionResult SaveOrUpdate(DocumentoPDF tipo)
        {
           return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, tipo);
        }

        protected override Dictionary<string, object> buildParametros(DocumentoPDF documentoPDF)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@pdf",  documentoPDF.Name },  
                { "@documentoId", documentoPDF.Id.ToString() }
            };           
            return parametros;
        }
    }
}
