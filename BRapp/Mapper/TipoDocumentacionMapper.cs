using BRapp.Enums;
using BRapp.Model.Nomenclador;
using FontAwesome.Sharp;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class TipoDocumentacionMapper : IMapper
    {
        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }

        public object Map(SqliteDataReader reader)
        {
            return new TipoDocumentacion()
            {
                Id = Guid.Parse(reader["id"].ToString()), 
                Name = reader["name"].ToString(),              
                TipoCard = (TipoCard)Enum.Parse(typeof(TipoCard), reader["tipo_card"].ToString()),
                Icon = (IconChar)Enum.Parse(typeof(IconChar), reader["icon"].ToString()),
                HasPdf = Convert.ToBoolean(reader["has_pdf"]),
                HasNumeracion = Convert.ToBoolean(reader["has_numeracion"]),
                HasFechaCreacion = Convert.ToBoolean(reader["has_fecha_creacion"]),
                HasFechaVencimiento = Convert.ToBoolean(reader["has_fecha_vencimiento"]),             
                HasOpcionalidad = Convert.ToBoolean(reader["has_es_obligatorio"]),
                HasTipo = Convert.ToBoolean(reader["has_tipo"]),
                HasPadre = Convert.ToBoolean(reader["has_padre"]),
                HasActaAcuerdo = Convert.ToBoolean(reader["has_acta_acuerdo"]),
                TipoResponsable = (TipoResponsable)Enum.Parse(typeof(TipoResponsable), reader["tipo_responsable"].ToString()),
                TipoCliente = (TipoResponsable)Enum.Parse(typeof(TipoResponsable), reader["tipo_cliente"].ToString()),
            };
        }
    }
}
