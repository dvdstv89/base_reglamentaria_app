using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewGrupoDocumentacionUIController : BaseUIController<NewGrupoDocumentacionUI>, IForm
    {       
        private readonly IGrupoDocumentacionServiceAdmin grupoDocumentacionServiceAdmin;
        private readonly IDocumentosServiceAdmin documentosServiceAdmin;
        private GrupoDocumentacion grupoDocumentacion;
        private TipoGrupoDocumentacion tipoGrupoDocumentacion;
        public NewGrupoDocumentacionUIController(GrupoDocumentacion grupoDocumentacion, TipoGrupoDocumentacion tipoGrupoDocumentacion) : base(new NewGrupoDocumentacionUI())
        {
            this.tipoGrupoDocumentacion= tipoGrupoDocumentacion;
            this.grupoDocumentacion = grupoDocumentacion;
            grupoDocumentacionServiceAdmin = GrupoDocumentacionServiceAdmin.Instance;
            documentosServiceAdmin = DocumentosServiceAdmin.Instance;
        }

        public override NewGrupoDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnResolucionDerrogadaPor.Click += new EventHandler(btnResolucionDerrogadaPor_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            ConfigCombo(forma.cbResolucionDerrogada, documentosServiceAdmin.getAllByTipo(TipoDocumento.DOCUMENTACION_BASICA));
            forma.tbTipoGrupo.Text = tipoGrupoDocumentacion.ToString();
            if (grupoDocumentacion != null)
            {
                forma.cbResolucionDerrogada.Text = (grupoDocumentacion.Documento != null)? grupoDocumentacion.Documento.ToString():"";
                forma.tbPJName.Text = grupoDocumentacion.Name;
                forma.cbOpcional.Checked = grupoDocumentacion.IsOpcional;
            }          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            grupoDocumentacionServiceAdmin.saveOrUpdate(grupoDocumentacion);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            string name = forma.tbPJName.Text;
            bool esOpcional = forma.cbOpcional.Checked;
            Documento documento = (Documento)forma.cbResolucionDerrogada.SelectedItem;
            if (grupoDocumentacion != null)
            {
                grupoDocumentacion.Name = name;
                grupoDocumentacion.IsOpcional = esOpcional;
                grupoDocumentacion.Documento = documento;
                grupoDocumentacion.TipoGrupoDocumentacion = tipoGrupoDocumentacion;
            }
            else
            {
                grupoDocumentacion = new GrupoDocumentacion(name, tipoGrupoDocumentacion, documento, esOpcional);
            }
        }       

        private void btnResolucionDerrogadaPor_Click(object sender, EventArgs e)
        {
            seleccionarCombo<Documento>(forma.cbResolucionDerrogada);

        }
        
    }
}
