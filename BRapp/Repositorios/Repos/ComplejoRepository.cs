using BRapp.Data;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Utiles;
using BRapp.Model.Tiendas;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    public class ComplejoRepository : BaseRepository, IComplejoRepository
    {
        private static ComplejoRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Complejo";
        private readonly string QUERY_UPDATE = "UPDATE Complejo SET name = @name, organigrama = @organigrama WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO Complejo (id, name, organigrama) VALUES ( @Id, @name, @organigrama)"; 
        private List<Complejo> complejos;      
        private readonly IMapper mapperComplejo;

        protected ComplejoRepository():base(AplicationConfig.ConnectionString, "Complejo")
        {
            mapperComplejo = new ComplejoMapper();  
            updateListApp();

        }

        protected void updateListApp()
        {
            complejos = getAll();
        }

        public List<Complejo> getAll()
        {
            List<Complejo> apps = new List<Complejo>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((Complejo)mapperComplejo.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public Complejo getById(Guid id)
        {
            return complejos.FirstOrDefault(persona => persona.Id == id);
        }

        private int getIndexById(Guid id)
        {
            return complejos.FindIndex(doc => doc.Id == id);
        }

        public bool saveOrUpdate(Complejo complejo)
        {
            Dictionary<string, object> parametros = buildParametros(complejo);
            int index = getIndexById(complejo.Id);
            if (index != -1)
            {
                complejos[index] = complejo;
                return ExecuteWriteOperation(QUERY_UPDATE, parametros);
            }
            else
            {
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                complejos.Add(complejo);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(Complejo complejo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", complejo.Name },
                { "@organigrama", (complejo.Organigrama != null && complejo.Organigrama.Data.Length > 0) ? ImageManager.GetBase64Image(complejo.Organigrama.Data, 776, 393, 90) : "" },
                { "@Id", complejo.Id.ToString() }
            };          
            return parametros;
        }

        public static ComplejoRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new ComplejoRepository() : instance;
                return instance;
            }
        } 
    }
}
