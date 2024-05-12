using BRapp.Model;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

namespace BRapp.Repositorios.Repos
{
    public abstract class BaseRepository
    {  
        protected readonly string connectionString;
        protected readonly string tableName;
        public BaseRepository(string connectionString, string tableName)
        {           
            this.connectionString = connectionString;
            this.tableName = tableName;
        }

        protected SqliteDataReader EjecutarConsulta(string query)
        {          
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = new SqliteCommand(query, connection);
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        protected SqliteDataReader EjecutarConsulta(string query, Dictionary<string, object> parameters)
        {
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = new SqliteCommand(query, connection);
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        protected bool ExecuteWriteOperation(string query, Dictionary<string, object> parameters)
        {
            using (var connection = new SqliteConnection(connectionString))
            { 
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        protected bool ExisteTabla()
        {
            bool existe = false;
            string consulta = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'";
            using (var reader = EjecutarConsulta(consulta))
            {
                existe = reader.HasRows;
            }
            return existe;
        }
    }
}
