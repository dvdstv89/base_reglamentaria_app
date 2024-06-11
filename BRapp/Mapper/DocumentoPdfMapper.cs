using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DocumentoPdfMapper : IMapper
    {

        public object Map(SqliteDataReader reader)
        {
            return new DocumentoPDF
                   (
                      Guid.Parse(reader["id"].ToString()),
                       reader["pdf"].ToString()
                   );
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
