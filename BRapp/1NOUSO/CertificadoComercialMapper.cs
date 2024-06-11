using BRapp.Dto;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class CertificadoComercialMapper : IMapper
    {     
        public object Map(object objeto)
        {
            CertificadoComercial documento = (CertificadoComercial) objeto;
            return new CertificadoComercialDto()
            {
                idPapel = documento.Id,  
                fechaVencimiento = documento.FechaVencimiento,             
                numero = documento.Numero               
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new CertificadoComercialDto()
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                fechaVencimiento = Convert.ToDateTime(reader["fecha_vencimiento"].ToString()),
                numero = reader["numero"].ToString()               
            };
        }
    }
}
