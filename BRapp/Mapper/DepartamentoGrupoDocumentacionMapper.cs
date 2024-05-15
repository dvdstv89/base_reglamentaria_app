using BRapp.Dto;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DepartamentoGrupoDocumentacionMapper : IMapper
    {   
        public object Map(SqliteDataReader reader)
        {
            return new DepartamentoGrupoDocumentacionDto()
            {
                idDepartamento = Guid.Parse(reader["id_departamento"].ToString()),
                idTipoGrupoDocumentacion = Guid.Parse(reader["id_tipo_grupo_documentacion"].ToString())
            };
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
