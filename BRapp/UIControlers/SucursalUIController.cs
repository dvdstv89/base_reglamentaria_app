using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using System;
using System.Drawing;
using System.IO;

namespace BRapp.UIControlers
{
    internal class SucursalUIController : BaseUIController<SucursalUI>, IForm
    {
        private static SucursalUIController instance;
        private readonly ISucursalService iSucursalService;
        private readonly App app;       
        private SucursalUIController() : base(new SucursalUI())
        {
            iSucursalService = SucursalService.Instance;
            app = iSucursalService.GetApp();          
        }       

        protected override void aplicarTema()
        {
            forma.richTextBoxMision.Rtf = app.Mision;  
            forma.richTextBoxVision.Rtf = app.Vision;
            forma.richTextBoxValoresCompartidos.Rtf = app.ValoresCompartidos;
            forma.richTextBoxObjetoSocialIzquierdo.Rtf = app.ObjetoSocial;
            if (app.hasImagen())
            {
                forma.pictureBoxOrganigramaEmpresa.BackgroundImage = Image.FromStream(new MemoryStream(app.Organigrama.Data));
            }
        }       

        public static SucursalUIController Instance
        {
            get {
                instance = (instance == null) ? new SucursalUIController() : instance;
                return instance;
            }
            
        }       
    }
}
