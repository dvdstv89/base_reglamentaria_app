using BRapp.Model;
using BRapp.Utiles;
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
            try
            {
                var connection = new SqliteConnection(connectionString);
                connection.Open();
                var command = new SqliteCommand(query, connection);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (System.Exception)
            {                
                return null;
            }
          
        }

        protected SqliteDataReader EjecutarConsulta(string query, Dictionary<string, object> parameters)
        {
            try
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
            catch (System.Exception)
            {
                throw;
            }
            
        }

        protected bool ExecuteWriteOperation(string query, Dictionary<string, object> parameters)
        {
            try
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
            catch (System.Exception)
            {
                throw;
            }
            
        }

        protected bool ExisteTabla()
        {
            try
            {
                bool existe = false;
                string consulta = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'";
                using (var reader = EjecutarConsulta(consulta))
                {
                    existe = reader.HasRows;
                }
                return existe;
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}
