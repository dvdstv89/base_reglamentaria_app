using Microsoft.Data.Sqlite;

namespace BRapp.Mapper
{
    public interface IMapper
    {
        object Map(SqliteDataReader reader);
        object Map(object objeto);
    }
}
