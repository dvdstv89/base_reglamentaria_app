using BRapp.Data;
using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.UI;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class ContratoDtoRepository : BaseRepository, IContratoDtoRepository
    {
        
        private readonly string QUERY_DELETE = "Delete FROM Contrato where id_papel = @documentoId";
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Contrato";
        private readonly string QUERY_UPDATE = "UPDATE Contrato SET id_contrato_padre = @idContratoPadre, id_cliente = @idCliente , id_responsable = @idResponsable, " +
            " fecha_vencimiento = @fechaVencimiento, numero = @numero , acta = @acta, acuerdo = @acuerdo, tipo_contrato = @tipoContrato WHERE id_papel = @documentoId";
        private readonly string QUERY_INSERT = "INSERT INTO Contrato (id_papel, id_contrato_padre, id_cliente, id_responsable, fecha_vencimiento, numero, acta, acuerdo, tipo_contrato) " +
            "VALUES ( @documentoId, @idContratoPadre,  @idCliente, @idResponsable, @fechaVencimiento, @numero, @acta, @acuerdo, @tipoContrato)";
        private List<ContratoDto> contratoDtos;
        private readonly IMapper contratoMapper;

        public ContratoDtoRepository(IMapper contratoMapper) : base(AplicationConfig.ConnectionString, "Contrato")
        {
            this.contratoMapper = contratoMapper;
            contratoDtos = getAll_ContratosDto();
        }

        public void Delete(Contrato papel)
        {
            ContratoDto contratoDto = (ContratoDto)contratoMapper.Map(papel);
            Dictionary<string, object> parametros = buildParametros(contratoDto);
            int index = getIndexById(contratoDto.idPapel);
            if (index != -1)
            {
                contratoDtos.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }


        private List<ContratoDto> getAll_ContratosDto()
        {
            List<ContratoDto> contratos = new List<ContratoDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                while (reader.Read())
                {
                    contratos.Add((ContratoDto)contratoMapper.Map(reader));
                }
            }
            return contratos;
        }


        public ContratoDto getById(Guid id)
        {
            return contratoDtos.FirstOrDefault(doc => doc.idPapel == id);
        }

        private int getIndexById(Guid id)
        {
            return contratoDtos.FindIndex(doc => doc.idPapel == id);
        }

        public ActionResult saveOrUpdate(Contrato papel)
        {
            ContratoDto contratoDto = (ContratoDto)contratoMapper.Map(papel);          
            Dictionary<string, object> parametros = buildParametros(contratoDto);
            int index = getIndexById(contratoDto.idPapel);
            if (index != -1)
            {
                contratoDtos[index] = contratoDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                contratoDtos.Add(contratoDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(ContratoDto contratoDto)
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
