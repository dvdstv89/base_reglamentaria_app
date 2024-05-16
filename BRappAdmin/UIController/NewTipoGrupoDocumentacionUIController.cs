using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
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
            tipoGrupoDocumentacionServiceAdmin = TipoGrupoDocumentacionService.Instance;                        
        }

        public override NewTipoGrupoDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);           
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            if (tipoGrupoDocumentacion != null)
            {
                forma.tbDescripcion.Rtf = tipoGrupoDocumentacion.Descripcion;
                forma.tbPJName.Text = tipoGrupoDocumentacion.Name;
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            tipoGrupoDocumentacionServiceAdmin.saveOrUpdate(tipoGrupoDocumentacion);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            string name = forma.tbPJName.Text;
            string descripcion = forma.tbDescripcion.Rtf;
            if (tipoGrupoDocumentacion != null)
            {
                tipoGrupoDocumentacion.Name = name;              
                tipoGrupoDocumentacion.Descripcion = descripcion;
            }
            else
            {
                tipoGrupoDocumentacion = new TipoGrupoDocumentacion(name, descripcion);
            }
        }  
    }
}
