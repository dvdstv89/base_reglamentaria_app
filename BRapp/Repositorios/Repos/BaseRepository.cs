using BRapp.Data;
using BRapp.Interfaces;
using BRapp.Mapper;
using BRapp.Utiles;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    public abstract class BaseRepository<Tipo> where Tipo: HasId
    {
        private readonly string QUERY_DELETE;
        private readonly string QUERY_SELECT_ALL;
        protected readonly string connectionString;       
        protected List<Tipo> listado;
        protected readonly IMapper mapper;
        public BaseRepository(IMapper mapper, string QUERY_DELETE = "", string QUERY_SELECT_ALL = "")
        {           
            this.QUERY_DELETE= QUERY_DELETE;
            this.QUERY_SELECT_ALL= QUERY_SELECT_ALL;
            this.connectionString = AplicationConfig.ConnectionString;           
            this.mapper = mapper;
            Inicializations();
            listado = populateListado();
        }

        protected virtual void Inicializations() {}

        protected virtual List<Tipo> populateListado()
        {
            return getAll(QUERY_SELECT_ALL);
        }        

        public virtual List<Tipo> GetAll()
        {
            return listado;
        }

        protected virtual List<Tipo> getAll(string QUERY_SELECT_ALL)
        {
            List<Tipo> results = new List<Tipo>();           
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                while (reader.Read())
                {
                    results.Add((Tipo)mapper.Map(reader));
                }
            }
            return results;
        }

        public virtual ActionResult DeleteById(Guid id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", id.ToString() }
            };
           
            int index = getIndexById(id);
            if (index != -1)
            {
                listado.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
                return ActionResult.DELETED;
            }
            return ActionResult.FAILED;
        }

        public ActionResult saveOrUpdate(string QUERY_INSERT, string QUERY_UPDATE, Tipo tipo)
        {
            Dictionary<string, object> parametros = buildParametros(tipo);
            int index = getIndexById(tipo.getId());
            if (index != -1)
            {
                listado[index] = tipo;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                listado.Add(tipo);
                return ActionResult.CREATED;
            }
        }

        protected int getIndexById(Guid id)
        {
            return listado.FindIndex(doc => doc.getId() == id);
        }

        public virtual Tipo GetById(Guid id)
        {
            return listado.FirstOrDefault(doc => doc.getId() == id);
        }

        protected abstract Dictionary<string, object> buildParametros(Tipo tipo); 


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
     
    }
}
