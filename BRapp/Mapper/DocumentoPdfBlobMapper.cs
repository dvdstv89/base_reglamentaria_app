using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DocumentoPdfBlobMapper : IMapper
    {
        public object Map(SqliteDataReader reader)
        {

            return new DocumentoPDFBlob
                    (
                       Guid.Parse(reader["id"].ToString()),
                       Convert.FromBase64String(reader["blob_pdf"].ToString())
                    );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
