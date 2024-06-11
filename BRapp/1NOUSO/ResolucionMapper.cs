using BRapp.Dto;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class ResolucionMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Resolucion documento = (Resolucion) objeto;
            return new ResolucionDto()
            {
                idPapel = documento.Id,
                idDerrogada = (documento.DerrogadaPor != null) ? documento.DerrogadaPor.Id : Guid.Empty,               
                idResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty,
                Numero= documento.Numero
            };
        }

        public object Map(SqliteDataReader reader)
        {
            ResolucionDto resolucionDto = new ResolucionDto()
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                idResponsable = Guid.Parse(reader["id_responsable"].ToString()),
                idDerrogada = Guid.Parse(reader["id_derrogada"].ToString()),
                Numero = reader["numero"].ToString()
            };
            return resolucionDto;
        }
    }
}
