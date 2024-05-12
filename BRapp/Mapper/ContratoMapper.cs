using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class ContratoMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Contrato documento = (Contrato) objeto;
            return new ContratoDto()
            {
                idPapel = documento.Id,
                idContratoPadre = (documento.ContratoPadre != null) ? documento.ContratoPadre.Id : Guid.Empty,
                idCliente = (documento.Cliente != null) ? documento.Cliente.Id : Guid.Empty,
                idResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty,
                fechaVencimiento = documento.FechaVencimiento,
                tipoContrato = documento.TipoContrato,
                numero = documento.Numero,
                acta = documento.NumeroActa,
                acuerdo = documento.NumeroAcuerdo
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new ContratoDto()
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                idContratoPadre = Guid.Parse(reader["id_contrato_padre"].ToString()),
                //idContratoPadre = reader.IsDBNull(reader.GetOrdinal("id_contrato_padre")) ? Guid.Empty : Guid.Parse(reader["id_contrato_padre"].ToString())
                idCliente = Guid.Parse(reader["id_cliente"].ToString()),
                idResponsable = Guid.Parse(reader["id_responsable"].ToString()),
                fechaVencimiento = Convert.ToDateTime(reader["fecha_vencimiento"].ToString()),
                numero = reader["numero"].ToString(),
                acta = Convert.ToInt32(reader["acta"].ToString()),
                acuerdo = Convert.ToInt32(reader["acuerdo"].ToString()),
                tipoContrato = (TipoContrato)Enum.Parse(typeof(TipoContrato), reader["tipo_contrato"].ToString()),
            };
        }
    }
}
