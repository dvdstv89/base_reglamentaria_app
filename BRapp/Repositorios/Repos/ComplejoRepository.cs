using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Utiles;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;

namespace BRapp.Repositorios.Repos
{
    public class ComplejoRepository : BaseRepository<Complejo>, IComplejoRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Complejo WHERE id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Complejo order by orden";
        private static readonly string QUERY_UPDATE = "UPDATE Complejo SET name = @name, organigrama = @organigrama, orden = @orden, tipo_complejo = @tipo_complejo, descripcion = @descripcion WHERE id = @Id";
        private static readonly string QUERY_INSERT = "INSERT INTO Complejo (id, name, organigrama, orden, tipo_complejo, descripcion) VALUES ( @Id, @name, @organigrama, @orden, @tipo_complejo, @descripcion)";        

        public ComplejoRepository(IMapper complejoMapper) : base(complejoMapper, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(Complejo complejo)
        {         
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, complejo);
        }

        protected override Dictionary<string, object> buildParametros(Complejo complejo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", complejo.Name },
                { "@organigrama", (complejo.Organigrama != null && complejo.Organigrama.Data.Length > 0) ? ImageManager.GetBase64Image(complejo.Organigrama.Data, 776, 393, 90) : "" },
                { "@orden", complejo.Orden },
                { "@tipo_complejo", complejo.TipoComplejo.ToString() },
                { "@descripcion", complejo.Descripcion },
                { "@Id", complejo.Id.ToString() }
            };          
            return parametros;
        }       
    }
}
