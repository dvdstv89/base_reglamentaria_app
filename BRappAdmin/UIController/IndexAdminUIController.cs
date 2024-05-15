using BRapp.Messages;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Services;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    public class IndexAdminUIController : IndexUIController
    {
        private static IndexAdminUIController instance;

        private IndexAdminUIController():base(IndexService.Instance)
        {
           
        }

        public override IndexUI ejecutar()
        {
            forma.appToolStripMenuItem.Click += new EventHandler(appToolStripMenuItem_Click);
            forma.contactosToolStripMenuItem.Click += new EventHandler(contactosToolStripMenuItem_Click);
            forma.documentosToolStripMenuItem.Click += new EventHandler(documentosToolStripMenuItem_Click);
            forma.complejosToolStripMenuItem.Click += new EventHandler(complejosToolStripMenuItem_Click);
            forma.tipoDeGruposDeDocumentacionToolStripMenuItem.Click += new EventHandler(tipoDeGruposDeDocumentacionToolStripMenuItem_Click);
            return base.ejecutar();
        }

        protected override void forma_Load(object sender, EventArgs e)
        {
            base.forma_Load(sender, e);
            complejosToolStripMenuItem_Click(sender, e);           
        }

        protected override void aplicarTema()
        {
            base.aplicarTema();            
            forma.adminToolStripMenuItem.Visible = true;
            forma.labelSlogan.Text += " Admin";
            forma.Text += " Admin";                 
        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = AppUIController.Instance(this);          
            formatearFormulario(forma.appToolStripMenuItem, forma.adminToolStripMenuItem, formulario, ButtonName.Administracion_App);
            formulario.ejecutar().Show();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = ContactosUIController.Instance;
            formatearFormulario(forma.contactosToolStripMenuItem, forma.adminToolStripMenuItem, formulario, ButtonName.Contactos_App);
            formulario.ejecutar().Show();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = DocumentosUIController.Instance;
            formatearFormulario(forma.documentosToolStripMenuItem, forma.adminToolStripMenuItem, formulario, ButtonName.Documentos_App);
            formulario.ejecutar().Show();
        }

        private void complejosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = ComplejoUIController.Instance;
            formatearFormulario(forma.complejosToolStripMenuItem, forma.adminToolStripMenuItem, formulario, ButtonName.Complejos_App);
            formulario.ejecutar().Show();
        }

        private void tipoDeGruposDeDocumentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TipoGrupoDocumentacionUIController.Instance;
            formatearFormulario(forma.tipoDeGruposDeDocumentacionToolStripMenuItem, forma.adminToolStripMenuItem, formulario, ButtonName.GrupoDocumentacion_App);
            formulario.ejecutar().Show();
        }

        public static new IndexUIController Instance
        {
            get
            {
                return (instance == null) ? new IndexAdminUIController() : instance;
            }
        }
    }
}
