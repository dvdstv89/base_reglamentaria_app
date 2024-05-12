using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Messages;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class AppUIController : BaseUIController<AppUI>, IForm
    {
        private static AppUIController instance;
        private readonly IndexAdminUIController indexAdminUIController;
        private readonly IAppServiceAdmin appServiceAdmin;
        private readonly IFileService fileLogoService;
        private App app;
        private AppUIController(IndexAdminUIController indexAdminUIController) : base(new AppUI())
        {
            appServiceAdmin = AppServiceAdmin.Instance;    
            this.indexAdminUIController = indexAdminUIController;
            fileLogoService = new FileService();
        }

        public override AppUI ejecutar()
        {
            forma.btnBuscarLogo.Click += new EventHandler(btnBuscarLogo_Click);
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
            forma.tbPJLogo.Text = app.Organigrama.Name;
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
            Fichero logo = (Fichero)forma.tbPJLogo.Tag;
            if (logo != null) app.Organigrama = logo;

            appServiceAdmin.updateApp(app);
            indexAdminUIController.updateFooter();
            DialogUtil.INFORMATION(Mensajes.APP_UPDATED_OK);
        }

        public static AppUIController Instance(IndexAdminUIController indexAdminUIController)
        {
            return (instance == null) ? new AppUIController(indexAdminUIController) : instance;
        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        {
            if (forma.openLogo.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = fileLogoService.guardarFichero(forma.openLogo.FileName);
                forma.tbPJLogo.Text = fichero.Name;
                forma.tbPJLogo.Tag = fichero;
            }
        }

    }
}
