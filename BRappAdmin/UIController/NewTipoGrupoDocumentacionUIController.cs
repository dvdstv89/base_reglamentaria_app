using BRapp.Enums;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewTipoGrupoDocumentacionUIController : BaseUIController<NewTipoGrupoDocumentacionUI>, IForm
    {       
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionServiceAdmin;      
        private TipoGrupoDocumentacion tipoGrupoDocumentacion;         
        public NewTipoGrupoDocumentacionUIController(TipoGrupoDocumentacion tipoGrupoDocumentacion) : base(new NewTipoGrupoDocumentacionUI())
        {
            this.tipoGrupoDocumentacion = tipoGrupoDocumentacion;
            tipoGrupoDocumentacionServiceAdmin = AplicationAdminConfig.Component.Component.TipoGrupoDocumentacionService;
        }

        public override NewTipoGrupoDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);           
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            forma.comboBoxMostrar.DataSource = Enum.GetValues(typeof(LugarMostrarDocumentacion));
            if (tipoGrupoDocumentacion != null)
            {
                forma.tbDescripcion.Text = tipoGrupoDocumentacion.Descripcion;
                forma.tbPJName.Text = tipoGrupoDocumentacion.Name;
                forma.comboBoxMostrar.Text = tipoGrupoDocumentacion.LugarMostrarDocumentacion.ToString();
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            tipoGrupoDocumentacionServiceAdmin.SaveOrUpdate(tipoGrupoDocumentacion);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            LugarMostrarDocumentacion lugarMostrarDocumentacion;
            Enum.TryParse(forma.comboBoxMostrar.Text, out lugarMostrarDocumentacion);
            string name = forma.tbPJName.Text;
            string descripcion = forma.tbDescripcion.Text;
            if (tipoGrupoDocumentacion != null)
            {
                tipoGrupoDocumentacion.Name = name;              
                tipoGrupoDocumentacion.Descripcion = descripcion;
                tipoGrupoDocumentacion.LugarMostrarDocumentacion = lugarMostrarDocumentacion;
            }
            else
            {
                tipoGrupoDocumentacion = new TipoGrupoDocumentacion(name, descripcion, lugarMostrarDocumentacion);
            }
        }  
    }
}
