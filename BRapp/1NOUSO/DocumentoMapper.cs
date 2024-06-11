using BRapp.Dto;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DocumentoMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Documento documento = (Documento) objeto;
            return new DocumentoDto()
            {
                idPapel = documento.Id,               
                idResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty
            };
        }

        public object Map(SqliteDataReader reader)
        {

            DocumentoDto documentoDto = new DocumentoDto
            {
                idPapel = Guid.Parse(reader["id_papel"].ToString()),
                idResponsable = Guid.Parse(reader["id_responsable"].ToString())
            };
            return documentoDto;
        }
    }
}
