using BRapp.Data;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos
{
    public class AppRepository : BaseRepository<App>, IAppRepository
    {
        private static readonly string QUERY_VACUUM = "VACUUM";
        private static readonly string QUERY_SELECT = "SELECT * FROM App WHERE id = @Id";
        private static readonly string QUERY_EDIT = "UPDATE App SET fecha_actualizacion = @fechaActualizacion, copyright = @copyright, empresa =@empresa, mision=@mision, vision=@vision, objeto_social=@objeto_social, valores_compartidos =@valores_compartidos, bienvenida = @bienvenida WHERE id = @Id";
        private int AppId;    
       
        public AppRepository(IMapper AppMapper) :base(AppMapper, "", QUERY_SELECT) { }

        protected override void Inicializations()
        {
            this.AppId = Convert.ToInt32(AplicationConfig.AppId);
        }

        protected override List<App> getAll(string QUERY_SELECT_ALL)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", AppId }
            };
            List<App> results = new List<App>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL, parametros))
            {
                while (reader.Read())
                {
                    results.Add((App)mapper.Map(reader));
                }
            }
            return results;
        }     

        public ActionResult UpdateApp(App app)
        {
            Dictionary<string, object> parametros = buildParametros(app);
            bool result = ExecuteWriteOperation(QUERY_EDIT, parametros);
            listado[0] = app;
            return ActionResult.UPDATED;
        }
       
        public App GetApp()
        {
            return listado.FirstOrDefault(doc => doc.Id == AppId);
        }

        protected override Dictionary<string, object> buildParametros(App app)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", app.Id },
                { "@fechaActualizacion", app.FechaActualizacion },
                { "@copyright", app.CopyRight },
                { "@empresa", app.Empresa },
                { "@mision", app.Mision },
                { "@vision", app.Vision },
                { "@objeto_social", app.ObjetoSocial },
                { "@valores_compartidos", app.ValoresCompartidos },
                { "@bienvenida", app.Bienvenida }
            };
            return parametros;
        }

        public ActionResult vacumm()
        {
            ExecuteWriteOperation(QUERY_VACUUM, new Dictionary<string, object>());
            return ActionResult.UPDATED;
        }
    }
}
