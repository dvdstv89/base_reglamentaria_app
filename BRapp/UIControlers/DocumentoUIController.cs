using BRapp.UI;
using BRapp.Enums.EnumsInstances;
using System.Collections.Generic;
using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.CardUCController;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using System.Windows.Forms;
using System;
using BRapp.Data;

namespace BRapp.UIControlers
{
    internal class DocumentoUIController : BaseUIController<DocumentoUI>, IForm
    {
        private static Dictionary<TipoDocumentoMenu, DocumentoUIController> instances = new Dictionary<TipoDocumentoMenu, DocumentoUIController>();
        private readonly IPapelService papelService;
        private readonly TipoDocumentoMenu tipoDocumentoInstance;
        private int countUpdates;
        private readonly IndexUI indexUI;
        private bool verDocumentosArchivados;

        List<ICard> documentos = new List<ICard>();
       

        private DocumentoUIController(TipoDocumentoMenu tipoDocumentoInstance, IndexUIController indexUIController) : base(new DocumentoUI(), true)
        {
            countUpdates = 0;
            this.tipoDocumentoInstance = tipoDocumentoInstance;
            papelService = PapelService.Instance;
            indexUI = (IndexUI)indexUIController.getForm();
        }

        public override DocumentoUI ejecutar()
        {
            base.ejecutar();
            forma.VisibleChanged += new EventHandler(ActiveForm_VisibleChanged);
            indexUI.tbBuscar.TextChanged += txtSearch_TextChanged;
            indexUI.cbArchivados.CheckedChanged += cbArchivados_CheckedChanged;
          //  forma.flowLayoutDocumentos.Visible = false;
            return forma;
        }   

        private void LLenarListaDocumentos()
        {          
            List<Papel> documentosAux = papelService.filtrarDocumentos(tipoDocumentoInstance);
            forma.flowLayoutDocumentos.Controls.Clear();           
            foreach (Papel papel in documentosAux)
            {
                ICard card = getICardPapel(papel);
                card.setInfo();
                Control control = renderICard(card, papel);
                if (indexUI.cbArchivados.Visible && papel.IsArchivado())
                {
                    control.Visible = false;
                }
                forma.flowLayoutDocumentos.Controls.Add(control);
                documentos.Add(card);               
            }
            for (int i = 0; i < 3; i++)
            {
                ExtraSpaceCard card = new ExtraSpaceCard();
                forma.flowLayoutDocumentos.Controls.Add(card);
            }           
        }

        private ICard getICardPapel(Papel papel)
        {
            if (papel is Sistema) return new SistemaUCController(papel as Sistema, papelService);           
            else if (papel is Resolucion) return new ResolucionUCController(papel as Resolucion);
            else if (papel is Contrato) return new ContratoUCController(papel as Contrato, papelService);
            else if (papel is DG) return new DgUCController(papel as DG, papelService);
            else if (papel is Documento) return new DocumentoUCController(papel as Documento);
            return null;
        }

        private Control renderICard(ICard iCard, Papel papel)
        {
            Control control = null;
            if (iCard is SistemaUCController) control = iCard.get() as SistemaCard;
            else if (iCard is DocumentoUCController) control = iCard.get() as DocumentoCard;
            else if (iCard is ResolucionUCController) control = iCard.get() as ResolucionCard;
            else if (iCard is ContratoUCController) control = iCard.get() as ContratoCard;
            else if (iCard is DgUCController) control = iCard.get() as DGCard;
            if (control != null)
            {
                control.Tag = papel;               
            }
            return control;
        }

        private void ActiveForm_VisibleChanged(object sender, EventArgs e)
        {   
            indexUI.cbArchivados.Visible = (tipoDocumentoInstance == TipoDocumentoMenu.PRE_RESOLUCIONES_EMPRESARIALES 
                || tipoDocumentoInstance == TipoDocumentoMenu.DOC_CONTRATO
                || tipoDocumentoInstance == TipoDocumentoMenu.DOC_RESOLUCIONES_INDICOS) 
                ? true :false;
            indexUI.tbBuscar.Text= string.Empty;
            indexUI.cbArchivados.Checked= false;
            verDocumentosArchivados = false;

            Form form = sender as Form;
            if (form != null && form.Visible && ((!AplicationConfig.APP_MODE_UPDATE && countUpdates < 1) || AplicationConfig.APP_MODE_UPDATE))
            {                
                LLenarListaDocumentos();
                countUpdates++;              
            }
           // forma.flowLayoutDocumentos.Visible = true;
        }

        public static DocumentoUIController GetInstance(TipoDocumentoMenu parametro, IndexUIController indexUIController)
        {
            //if (!instances.ContainsKey(parametro))
            //{
            //    instances[parametro] = new DocumentoUIController(parametro, indexUIController);
            //}
            //return instances[parametro];

            return new DocumentoUIController(parametro, indexUIController);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FiltrarDocumentos();
        }
        private void cbArchivados_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarDocumentos();
        }

        private void FiltrarDocumentos()
        {
            string searchText = indexUI.tbBuscar.Text.ToLower();

            foreach (Control control in forma.flowLayoutDocumentos.Controls)
            {
                if (!(control is ExtraSpaceCard))
                {
                    Papel papel = (Papel)control.Tag;

                    control.Visible = (papel.IsArchivado() && indexUI.cbArchivados.Checked) ? true : false;
                    control.Visible = (control.Visible && papel.ToString().ToLower().Contains(searchText))
                        ? true : false;
                }
            }
        }
    }
}
