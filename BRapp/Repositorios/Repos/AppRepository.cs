using BRapp.Data;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos
{
    public class AppRepository : BaseRepository, IAppRepository
    {      
        private readonly string QUERY_SELECT = "SELECT * FROM App WHERE id = @Id";
        private readonly string QUERY_EDIT = "UPDATE App SET fecha_actualizacion = @fechaActualizacion, copyright = @copyright, empresa =@empresa, mision=@mision, vision=@vision, objeto_social=@objeto_social, valores_compartidos =@valores_compartidos, bienvenida = @bienvenida WHERE id = @Id";
        private readonly int AppId;
        private readonly IMapper AppMapper;
        private App App;
        public AppRepository(IMapper AppMapper) :base(AplicationConfig.ConnectionString, "App")
        {
            this.AppMapper = AppMapper;        
            this.AppId = Convert.ToInt32(AplicationConfig.AppId);
            CargarDatos();
        }       
     
        private void CargarDatos()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Id", AppId }
            };
            App = null;
            using (var reader = EjecutarConsulta(QUERY_SELECT, parametros))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        App = (App)AppMapper.Map(reader);
                        break;
                    }
                }
            }           
        }

        public bool updateApp(App app)
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
            bool result = ExecuteWriteOperation(QUERY_EDIT, parametros);   
            this.App= app;
            return result;
        }
       
        public App getApp()
        {            
            return App;
        }
    }
}
