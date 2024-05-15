using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewComplejoUIController : BaseUIController<NewComplejoUI>, IForm
    {       
        private readonly IComplejoServiceAdmin complejoService;
        private readonly IFileService fileLogoService;
        private Complejo complejo;         
        public NewComplejoUIController(Complejo complejo, IFileService fileLogoService) : base(new NewComplejoUI())
        {
            this.complejo = complejo;
            complejoService = ComplejoServiceAdmin.Instance;
            this.fileLogoService = fileLogoService;                      
        }

        public override NewComplejoUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarLogo.Click += new EventHandler(btnBuscarLogo_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            if (complejo != null)
            {
                forma.tbPJLogo.Text = complejo.Organigrama.Name;
                forma.tbPJName.Text = complejo.Name;
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            complejoService.saveOrUpdate(complejo);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            string name = forma.tbPJName.Text;
            Fichero logo = (Fichero)forma.tbPJLogo.Tag;
            if (complejo != null)
            {
                complejo.Name = name;              
                if (logo != null) complejo.Organigrama = logo;
            }
            else
            {
                complejo = new Complejo(name, logo);
            }
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
