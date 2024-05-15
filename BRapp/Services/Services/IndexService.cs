using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class IndexService: IIndexService
    {
        private static IndexService instance;
        protected readonly IAppService appService;

        protected IndexService()
        {
            this.appService = AppService.Instance;            
        }

        public string getFooter()
        {
           return buildFooter(appService.getApp());
        }       

        protected string buildFooter(App app)
        {
            return @"{\rtf1\ansi{\fonttbl\f0\fnil\fcharset0 Arial;}\pard\qc\fs20\cf0\vertalc © Copyright "
                     + app.CopyRight
                     + " Todos los Derechos Reservados \\b " +
                     app.Empresa + ". \\b0 Actualización: "
                     + app.FechaActualizacion
                     + "\\par}";
        }

        public static IndexService Instance
        {
            get
            {               
                instance = (instance == null) ? new IndexService() : instance;
                return instance;
            }
        }
    }
}
