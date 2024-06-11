using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class CertificadoComercialDtoRepository : BaseRepository<CertificadoComercialDto>, ICertificadoComercialDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM CertificadoComercial";
        private static readonly string QUERY_DELETE = "Delete FROM CertificadoComercial Where id_papel = @Id";           
        private static readonly string QUERY_UPDATE = "UPDATE CertificadoComercial SET fecha_vencimiento = @fechaVencimiento, numero = @numero WHERE id_papel = @documentoId";
        private static readonly string QUERY_INSERT = "INSERT INTO CertificadoComercial (id_papel, fecha_vencimiento, numero) VALUES ( @documentoId, @fechaVencimiento, @numero)";      

        public CertificadoComercialDtoRepository(IMapper certidicadoComercialMapper) : base(certidicadoComercialMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }      

        public ActionResult SaveOrUpdate(CertificadoComercial papel)
        {
            CertificadoComercialDto certificadoComercialDto = (CertificadoComercialDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT ,QUERY_UPDATE, certificadoComercialDto);
        }

        protected override Dictionary<string, object> buildParametros(CertificadoComercialDto certificadoComercialDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {    
                { "@fechaVencimiento", certificadoComercialDto.fechaVencimiento },
                { "@numero", certificadoComercialDto.numero },              
                { "@documentoId", certificadoComercialDto.idPapel.ToString() }
            };
            return parametros;
        }       
    }
}
