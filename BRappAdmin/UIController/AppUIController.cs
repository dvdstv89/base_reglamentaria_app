using BRapp.Model;
using BRapp.UI;
using BRapp.UIControlers;
using BRapp.Messages;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.UI;
using System;
using BRappAdmin.Data;

namespace BRappAdmin.UIControlers
{
    internal class AppUIController : BaseUIController<AppUI>, IForm
    {
        private readonly IndexAdminUIController indexAdminUIController;
        private readonly IAppServiceAdmin appServiceAdmin;      
        private App app;
        public AppUIController(IndexAdminUIController indexAdminUIController) : base(new AppUI())
        {
            appServiceAdmin = AplicationAdminConfig.Component.AppServiceAdmin;    
            this.indexAdminUIController = indexAdminUIController;            
        }       

        public override AppUI ejecutar()
        {          
            forma.btnActualizar.Click += new EventHandler(btnActualizar_Click);
            return base.ejecutar();
        }

        protected override void initDataForm()
        {
            app = appServiceAdmin.getApp();
            forma.tbEmpresa.Text = app.Empresa;
            forma.tbCopyRight.Text = app.CopyRight;
            forma.tbFecha.Text = app.FechaActualizacion;
            forma.tbMision.Rtf = app.Mision;
            forma.tbVision.Rtf = app.Vision;
            forma.tbValoresCompartidos.Rtf = app.ValoresCompartidos;
            forma.tbObjetoSocial.Rtf = app.ObjetoSocial;
            forma.tbBienvenida.Rtf = app.Bienvenida;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            app.Empresa = forma.tbEmpresa.Text;
            app.CopyRight = forma.tbCopyRight.Text;
            app.FechaActualizacion = forma.tbFecha.Text;
            app.Mision = forma.tbMision.Rtf;
            app.Vision = forma.tbVision.Rtf;
            app.ObjetoSocial = forma.tbObjetoSocial.Rtf;
            app.ValoresCompartidos= forma.tbValoresCompartidos.Rtf;
            app.Bienvenida = forma.tbBienvenida.Rtf;         
            appServiceAdmin.updateApp(app);
            indexAdminUIController.updateFooter();
            DialogUtil.INFORMATION(Mensajes.APP_UPDATED_OK);
        }
    }
}

