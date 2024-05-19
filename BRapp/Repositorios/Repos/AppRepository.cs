using BRapp.Data;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos
{
    public class AppRepository : BaseRepository, IAppRepository
    {
        private static AppRepository instance; 
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM App";
        private readonly string QUERY_EDIT = "UPDATE App SET fecha_actualizacion = @fechaActualizacion, copyright = @copyright, empresa =@empresa, mision=@mision, vision=@vision, objeto_social=@objeto_social, valores_compartidos =@valores_compartidos WHERE id = @Id";
        private List<App> aplications;
        private readonly int AppId;
        private readonly IMapper mapperApp;

        protected AppRepository():base(AplicationConfig.ConnectionString, "App")
        {
            mapperApp = new AppMapper();            
            AppId = Convert.ToInt32(AplicationConfig.AppId);
            updateListApp();

        }

        protected void updateListApp()
        {
            try
            {
                aplications = getAll();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        protected List<App> getAll()
        {
            List<App> apps = new List<App>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((App)mapperApp.Map(reader));
                    }
                }
            }
            return apps;
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
                { "@valores_compartidos", app.ValoresCompartidos }
            };
            bool result = ExecuteWriteOperation(QUERY_EDIT, parametros);
            updateListApp();
            return result;
        }

        public App getApp()
        {
            return aplications.Find(app => app.Id == AppId);
        }

        public static AppRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new AppRepository() : instance;
                return instance;
            }
        } 
    }
}
