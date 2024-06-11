using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class IndicacionDtoRepository : BaseRepository<IndicacionDto>, IIndicacionDtoRepository
    {       
        private static readonly string QUERY_DELETE = "Delete FROM DG where id_papel = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM DG";
        private static readonly string QUERY_UPDATE = "UPDATE DG SET id_responsable = @responsable, numero = @numero WHERE id_papel = @papelId";
        private static readonly string QUERY_INSERT = "INSERT INTO DG (id_papel, numero, id_responsable) VALUES ( @papelId, @numero, @responsable)";
      

        public IndicacionDtoRepository(IMapper mapper) : base(mapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(Indicacion papel)
        {
            IndicacionDto dgDto = (IndicacionDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, dgDto);
        }

        protected override Dictionary<string, object> buildParametros(IndicacionDto dGDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", dGDto.idResponsable.ToString() },
                { "@numero", dGDto.numero.ToString() },
                { "@papelId", dGDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
