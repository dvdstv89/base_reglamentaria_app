using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.UI;
using BRapp.UIControlers;
using BRapp.Messages;
using BRappAdmin.UI;
using FontAwesome.Sharp;
using System;
using System.Windows.Forms;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;

namespace BRappAdmin.UIControlers
{
    internal class NewGrupoDocumentacionUIController : BaseUIController<NewGrupoDocumentacionUI>, IForm
    {       
        private readonly IGrupoDocumentacionService grupoDocumentacionServiceAdmin;
        private readonly IPapelService documentosServiceAdmin;       
        private TipoGrupoDocumentacion tipoGrupoDocumentacion;
        public NewGrupoDocumentacionUIController(TipoGrupoDocumentacion tipoGrupoDocumentacion) : base(new NewGrupoDocumentacionUI())
        {
            this.tipoGrupoDocumentacion= tipoGrupoDocumentacion;            
            grupoDocumentacionServiceAdmin = GrupoDocumentacionService.Instance;
            documentosServiceAdmin = PapelService.Instance;
        }

        public override NewGrupoDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarDocumento.Click += new EventHandler(btnBuscarDocumento_Click);
            forma.btnNuevo.Click += new EventHandler(btnNuevo_Click);
            forma.btnGuardar.IconChar= IconChar.Save;
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            updateList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            grupoDocumentacionServiceAdmin.saveOrUpdate(CapturarDatos());
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private GrupoDocumentacion CapturarDatos()
        {          
            Documento documento = (Documento)forma.cbResolucionDerrogada.SelectedItem;
            return new GrupoDocumentacion(tipoGrupoDocumentacion, documento, false);
        }       

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            seleccionarCombo<Documento>(forma.cbResolucionDerrogada);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var papelUiController = new PapelUIController(null, TipoClasificacionDocumento.DOCUMENTACION_BASICA);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);              
                updateList();
                forma.cbResolucionDerrogada.SelectedItem = papelUiController.GetPapel();
            }
        }

        private void updateList()
        {
            ConfigCombo(forma.cbResolucionDerrogada, documentosServiceAdmin.getAllByTipo(TipoDocumento.DOCUMENTACION_BASICA));
        }
    }
}
