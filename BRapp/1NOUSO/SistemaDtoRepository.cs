using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class SistemaDtoRepository : BaseRepository<SistemaDto>, ISistemaDtoRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Sistema where id_papel = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Sistema";
        private static readonly string QUERY_UPDATE = "UPDATE Sistema SET id_responsable = @responsable, tipo_sistema = @tiposistema WHERE id_papel = @papelId";
        private static readonly string QUERY_INSERT = "INSERT INTO Sistema (id_papel, id_responsable, tipo_sistema) VALUES ( @papelId, @responsable, @tiposistema)";       

        public SistemaDtoRepository(IMapper mapperSistema) : base(mapperSistema, QUERY_DELETE, QUERY_SELECT_ALL) { }        

        public ActionResult SaveOrUpdate(Sistema papel)
        {
            SistemaDto sistemaDto = (SistemaDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, sistemaDto);
        }

        protected override Dictionary<string, object> buildParametros(SistemaDto sistemaDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", sistemaDto.idResponsable.ToString() },
                { "@tiposistema", sistemaDto.tipoSistema.ToString() },
                { "@papelId", sistemaDto.idPapel.ToString() }
            };
            return parametros;
        }
    }
}
