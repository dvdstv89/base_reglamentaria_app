using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class ContratoDtoRepository : BaseRepository<ContratoDto>, IContratoDtoRepository
    {
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Contrato";
        private static readonly string QUERY_DELETE = "Delete FROM Contrato where id_papel = @Id";        
        private static readonly string QUERY_UPDATE = "UPDATE Contrato SET id_contrato_padre = @idContratoPadre, id_cliente = @idCliente , id_responsable = @idResponsable, " +
            " fecha_vencimiento = @fechaVencimiento, numero = @numero , acta = @acta, acuerdo = @acuerdo, tipo_contrato = @tipoContrato WHERE id_papel = @documentoId";
        private static readonly string QUERY_INSERT = "INSERT INTO Contrato (id_papel, id_contrato_padre, id_cliente, id_responsable, fecha_vencimiento, numero, acta, acuerdo, tipo_contrato) " +
            "VALUES ( @documentoId, @idContratoPadre,  @idCliente, @idResponsable, @fechaVencimiento, @numero, @acta, @acuerdo, @tipoContrato)";       

        public ContratoDtoRepository(IMapper contratoMapper) : base(contratoMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }
        
        public ActionResult SaveOrUpdate(Contrato papel)
        {
            ContratoDto contratoDto = (ContratoDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, contratoDto);
        }

        protected override Dictionary<string, object> buildParametros(ContratoDto contratoDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@idContratoPadre", contratoDto.idContratoPadre.ToString() },
                { "@idCliente", contratoDto.idCliente.ToString() },
                { "@idResponsable", contratoDto.idResponsable.ToString() },
                { "@fechaVencimiento", contratoDto.fechaVencimiento },
                { "@numero", contratoDto.numero },
                { "@acta", contratoDto.acta },
                { "@acuerdo", contratoDto.acuerdo },
                { "@tipoContrato", contratoDto.tipoContrato.ToString() },
                { "@documentoId", contratoDto.idPapel.ToString() }
            };
            return parametros;
        }    
    }
}
