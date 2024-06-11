using BRapp.Model;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    public class IndexService: IIndexService
    {      
        protected readonly IAppService appService;

        public IndexService(IAppService appService)
        {
            this.appService = appService;            
        }

        public string GetFooter()
        {
           return buildFooter(appService.GetApp());
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
    }
}
