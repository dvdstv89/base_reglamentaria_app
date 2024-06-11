using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class ResolucionDtoRepository : BaseRepository<ResolucionDto>, IResolucionDtoRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Resolucion where id_papel = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Resolucion";
        private static readonly string QUERY_UPDATE = "UPDATE Resolucion SET id_responsable = @responsable, id_derrogada = @derrogada, numero = @numero WHERE id_papel = @papelId";
        private static readonly string QUERY_INSERT = "INSERT INTO Resolucion (id_papel, id_responsable, id_derrogada, numero) VALUES ( @papelId, @responsable, @derrogada, @numero)";        

        public ResolucionDtoRepository(IMapper mapperResolucion) : base(mapperResolucion, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(Resolucion papel)
        {
            ResolucionDto resolucionDto = (ResolucionDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, resolucionDto);
        }

        protected override Dictionary<string, object> buildParametros(ResolucionDto resolucionDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", resolucionDto.idResponsable.ToString() },
                { "@derrogada", resolucionDto.idDerrogada.ToString() },
                { "@numero", resolucionDto.Numero },
                { "@papelId", resolucionDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
