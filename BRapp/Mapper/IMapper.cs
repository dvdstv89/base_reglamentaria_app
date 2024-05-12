using Microsoft.Data.Sqlite;

namespace BRapp.Mapper
{
    internal interface IMapper
    {
        object Map(SqliteDataReader reader);
        object Map(object objeto);
    }
}
