using BRapp.Enums;
using BRapp.Model;
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
    internal class NewComplejoUIController : BaseUIController<NewComplejoUI>, IForm
    {       
        private readonly IComplejoService complejoService;
        private readonly IFileService fileService;
        private Complejo complejo;
        private readonly int posicion;
        public NewComplejoUIController(Complejo complejo, int posicion) : base(new NewComplejoUI())
        {
            this.complejo = complejo;
            complejoService = AplicationAdminConfig.Component.Component.ComplejoService;
            this.fileService = AplicationAdminConfig.Component.Component.FileService;
            this.posicion = posicion;
        }

        public override NewComplejoUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarLogo.Click += new EventHandler(btnBuscarLogo_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            forma.comboTipoIndicacion.DataSource = Enum.GetValues(typeof(TipoComplejo));
            if (complejo != null)
            {
                forma.tbPJLogo.Text = complejo.Organigrama.Name;
                forma.tbPJName.Text = complejo.Name;
                forma.comboTipoIndicacion.Text = complejo.TipoComplejo.ToString();
                forma.tbDescripcion.Rtf = complejo.Descripcion;
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            complejoService.SaveOrUpdate(complejo);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            TipoComplejo tipoComplejo;
            Enum.TryParse(forma.comboTipoIndicacion.Text, out tipoComplejo);
            string name = forma.tbPJName.Text;
            Fichero logo = (Fichero)forma.tbPJLogo.Tag;
            string descripcion = forma.tbDescripcion.Rtf;
            if (complejo != null)
            {
                complejo.Name = name;  
                complejo.TipoComplejo= tipoComplejo;
                if (logo != null) complejo.Organigrama = logo;
                complejo.Descripcion= descripcion;
            }
            else
            {
                complejo = new Complejo(name, logo, tipoComplejo, posicion, descripcion);
            }
        }       

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        { 
            if (forma.openLogo.ShowDialog() == DialogResult.OK)
            {  
                Fichero fichero = fileService.GuardarFichero(forma.openLogo.FileName);
                forma.tbPJLogo.Text = fichero.Name;
                forma.tbPJLogo.Tag = fichero;
            }
        }
    }
}
