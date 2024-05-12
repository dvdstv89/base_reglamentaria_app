using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class IndexService: IIndexService
    {
        private static IndexService instance;
        protected readonly IAppRepository iAppRepository;

        protected IndexService(IAppRepository iAppRepository)
        {
            this.iAppRepository = iAppRepository;            
        }

        public string getFooter()
        {
           return buildFooter(iAppRepository.getApp());
        }

        public App getApp()
        {
            return iAppRepository.getApp();
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
                instance = (instance == null) ? new IndexService(AppRepository.Instance) : instance;
                return instance;
            }
        }
    }
}
