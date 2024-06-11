using BRapp.Enums;
using BRapp.Model.Nomenclador;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewMenuDocumentalUIController : BaseUIController<NewMenuDocumentalUI>, IForm
    {       
        private readonly IMenuDocumentalService menuDocumentalService;        
        private MenuDocumental menuDocumental;
        private readonly int posicion;
       
        public NewMenuDocumentalUIController(MenuDocumental menuDocumental, int posicion) : base(new NewMenuDocumentalUI())
        {
            this.menuDocumental = menuDocumental;
            this.posicion = posicion;
            menuDocumentalService = AplicationAdminConfig.Component.Component.MenuDocumentalService;          
        }

        public override NewMenuDocumentalUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);     
            forma.cbShowPanelBusqueda.CheckedChanged += new EventHandler(CbShowPanelBusqueda_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            forma.ComboBoxUbicacion.DataSource = Enum.GetValues(typeof(TipoUbicacionMenu));           
            if (menuDocumental != null)
            {                
                forma.tbName.Text = menuDocumental.Name;
                forma.tbDescripcion.Rtf = menuDocumental.Descripcion;
                forma.ComboBoxUbicacion.Text = menuDocumental.TipoUbicacionMenu.ToString();
                forma.cbShowPanelBusqueda.Checked = menuDocumental.ShowPanelBusqueda;
                forma.cbShowArchivados.Checked = menuDocumental.ShowArchivados;
                forma.cbIsRaiz.Checked = menuDocumental.IsRaiz;
                forma.cbAbrirPagina.Checked = menuDocumental.AbrirPagina;

            }
            else
            {
                forma.cbShowPanelBusqueda.Checked = false;
            }            
        }

        private void CbShowPanelBusqueda_Click(object sender, EventArgs e)
        {
            forma.cbShowArchivados.Enabled = forma.cbShowPanelBusqueda.Checked;
            if (!forma.cbShowPanelBusqueda.Checked)
            {
                forma.cbShowArchivados.Checked = false;
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            menuDocumentalService.SaveOrUpdate(menuDocumental);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            TipoUbicacionMenu tipoUbicacionMenu;
            Enum.TryParse(forma.ComboBoxUbicacion.Text, out tipoUbicacionMenu);
            string descripcion = forma.tbDescripcion.Rtf;            
            string name = forma.tbName.Text;
            bool showPanelBusqueda = forma.cbShowPanelBusqueda.Checked;
            bool showArchivados = forma.cbShowArchivados.Checked;
            bool isRaiz = forma.cbIsRaiz.Checked;
            bool abrirPagina = forma.cbAbrirPagina.Checked;

            if (menuDocumental != null)
            {
                menuDocumental.Name = name;  
                menuDocumental.Descripcion= descripcion;
                menuDocumental.TipoUbicacionMenu = tipoUbicacionMenu;
                menuDocumental.ShowPanelBusqueda= showPanelBusqueda;
                menuDocumental.ShowArchivados= showArchivados;
                menuDocumental.Orden = posicion;
                menuDocumental.IsRaiz= isRaiz;
                menuDocumental.AbrirPagina = abrirPagina;

            }
            else
            {
                menuDocumental = new MenuDocumental()
                {
                    Name = name,
                    Descripcion = descripcion,
                    TipoUbicacionMenu = tipoUbicacionMenu,
                    ShowArchivados = showArchivados,
                    ShowPanelBusqueda = showPanelBusqueda,
                    Orden = posicion,
                    IsRaiz = isRaiz,
                    AbrirPagina= abrirPagina,
                    Id = Guid.NewGuid()
                };
            }
        }              
    }
}
