using BRapp.Data;
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
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Complejo order by orden";
        private readonly string QUERY_UPDATE = "UPDATE Complejo SET name = @name, organigrama = @organigrama, orden = @orden, tipo_complejo = @tipo_complejo WHERE id = @Id";
        private readonly string QUERY_INSERT = "INSERT INTO Complejo (id, name, organigrama, orden, tipo_complejo) VALUES ( @Id, @name, @organigrama, @orden, @tipo_complejo)"; 
        private List<Complejo> complejos;      
        private readonly IMapper complejoMapper;

        public ComplejoRepository(IMapper complejoMapper) :base(AplicationConfig.ConnectionString, "Complejo")
        {
            this.complejoMapper = complejoMapper;  
            updateListApp();
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
                        apps.Add((Complejo)complejoMapper.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public Complejo getById(Guid id)
        {
            return complejos.FirstOrDefault(persona => persona.Id == id);
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


        protected void updateListApp()
        {
            complejos = getAll();
        }

        private int getIndexById(Guid id)
        {
            return complejos.FindIndex(doc => doc.Id == id);
        }

        private Dictionary<string, object> buildParametros(Complejo complejo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", complejo.Name },
                { "@organigrama", (complejo.Organigrama != null && complejo.Organigrama.Data.Length > 0) ? ImageManager.GetBase64Image(complejo.Organigrama.Data, 776, 393, 90) : "" },
                { "@orden", complejo.Orden },
                { "@tipo_complejo", complejo.TipoComplejo.ToString() },
                { "@Id", complejo.Id.ToString() }
            };          
            return parametros;
        }       
    }
}
