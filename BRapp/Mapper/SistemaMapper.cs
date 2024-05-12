using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class SistemaMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Sistema documento = (Sistema) objeto;
            return new SistemaDto()
            {
                idPapel = documento.Id,
                idResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty,             
                tipoSistema = documento.TipoSistema
            };
        }

        public object Map(SqliteDataReader reader)
        {
            SistemaDto sistemaDto = new SistemaDto()
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                idResponsable = Guid.Parse(reader["id_responsable"].ToString()),
                tipoSistema = (TipoSistema)Enum.Parse(typeof(TipoSistema), reader["tipo_sistema"].ToString()),
            };
            return sistemaDto;
        }
    }
}
