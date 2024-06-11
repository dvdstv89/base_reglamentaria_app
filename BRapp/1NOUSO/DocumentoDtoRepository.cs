using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class DocumentoDtoRepository : BaseRepository<DocumentoDto>, IDocumentoDtoRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Documento where id_papel = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Documento";
        private static readonly string QUERY_UPDATE = "UPDATE Documento SET id_responsable = @responsable WHERE id_papel = @papelId";
        private static readonly string QUERY_INSERT = "INSERT INTO Documento (id_papel, id_responsable) VALUES ( @papelId, @responsable)";        

        public DocumentoDtoRepository(IMapper mapperDocumento) : base(mapperDocumento, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(Documento papel)
        {
            DocumentoDto documentoDto = (DocumentoDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, documentoDto);
        }

        protected override Dictionary<string, object> buildParametros(DocumentoDto documentoDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", documentoDto.idResponsable.ToString() },               
                { "@papelId", documentoDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
