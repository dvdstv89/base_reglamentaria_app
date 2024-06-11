using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Nomenclador;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BRappAdmin.UIControlers
{
    internal class NewClasificacionDocumentacionUIController : BaseUIController<NewCLasificacionDocumentacionUI>, IForm
    {       
        private readonly ITipoDocumentacionService tipoDocumentacionService;
        private readonly IMenuDocumentalService menuDocumentalService;
        private readonly IClasificacionDocumentacionService clasificacionDocumentacionService;
        private ClasificacionDocumentacion clasificacionDocumentacion;
       
        public NewClasificacionDocumentacionUIController(ClasificacionDocumentacion clasificacionDocumentacion) : base(new NewCLasificacionDocumentacionUI())
        {
            this.clasificacionDocumentacion = clasificacionDocumentacion;
            tipoDocumentacionService = AplicationAdminConfig.Component.Component.TipoDocumentacionService;
            menuDocumentalService = AplicationAdminConfig.Component.Component.MenuDocumentalService;
            clasificacionDocumentacionService = AplicationAdminConfig.Component.Component.ClasificacionDocumentacionService;
        }

        public override NewCLasificacionDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);    
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            ConfigCombo(forma.ComboTipoDocumentacion, tipoDocumentacionService.GetAll());
            ConfigCombo(forma.ComboMenuDocumental, menuDocumentalService.GetAll());
            if (clasificacionDocumentacion != null)
            {
                forma.ComboTipoDocumentacion.Text = clasificacionDocumentacion.TipoDocumentacion.Name;
                forma.ComboMenuDocumental.Text = clasificacionDocumentacion.MenuDocumental.Name;
            }                  
        }       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            clasificacionDocumentacionService.SaveOrUpdate(clasificacionDocumentacion);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            TipoDocumentacion tipoDocumentacion = (TipoDocumentacion)forma.ComboTipoDocumentacion.SelectedItem;
            MenuDocumental menuDocumental = (MenuDocumental)forma.ComboMenuDocumental.SelectedItem;
            if (clasificacionDocumentacion != null)
            {
                clasificacionDocumentacion.TipoDocumentacion = tipoDocumentacion;  
                clasificacionDocumentacion.MenuDocumental= menuDocumental;              
            }
            else
            {
                clasificacionDocumentacion = new ClasificacionDocumentacion(Guid.NewGuid(), tipoDocumentacion, menuDocumental);                
            }
        }              
    }
}
