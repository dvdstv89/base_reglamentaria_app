using BRapp.Dto;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DGMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Indicacion documento = (Indicacion) objeto;
            return new IndicacionDto()
            {
                idPapel = documento.Id,                        
                numero = documento.Numero,
               idResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty,
            };
        }

        public object Map(SqliteDataReader reader)
        {
            IndicacionDto dgDto = new IndicacionDto()
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                idResponsable = Guid.Parse(reader["id_responsable"].ToString()),
                numero = reader["numero"].ToString()               
            };
            return dgDto;
        }
    }
}
