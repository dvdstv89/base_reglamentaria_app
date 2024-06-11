using BRapp.Data;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.UI.Cards;
using BRapp.UI;
using BRapp.UIControlers.CardUCController;
using BRapp.UIControlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BRapp.Model.Nomenclador;

internal class DocumentoUIController : BaseUIController<DocumentoUI>, IForm
{
    private static Dictionary<MenuDocumental, DocumentoUIController> instances = new Dictionary<MenuDocumental, DocumentoUIController>();
    private readonly IPapelService papelService;
    private readonly MenuDocumental menuDocumental;
    private int countUpdates;
    private readonly IndexUI indexUI;

    List<Control> documentos;
    List<Control> documentosNormales = new List<Control>();
    List<Control> documentosArchivados = new List<Control>();

    private DocumentoUIController(MenuDocumental menuDocumental, IndexUIController indexUIController) : base(new DocumentoUI(), true)
    {
        countUpdates = 0;
        this.menuDocumental = menuDocumental;
        papelService = AplicationConfig.Component.PapelService;
        indexUI = (IndexUI)indexUIController.getForm();
    }

    public override DocumentoUI ejecutar()
    {
        base.ejecutar();
        forma.VisibleChanged += new EventHandler(ActiveForm_VisibleChanged);
        indexUI.btnBuscar.Click += txtSearch_TextChanged;
        indexUI.cbArchivados.CheckedChanged += cbArchivados_CheckedChanged;
        indexUI.btnLimpiarBusqueda.Click += cbArchivados_CheckedChanged;
        return forma;
    }

    private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
    {
        indexUI.tbBuscar.Text = "";
        FiltrarDocumentos();
    }

    private ICard getICardPapel(Papel papel)
    {
        if (papel.TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.SISTEMA) return new SistemaUCController(papel);       
        else if (papel.TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.CONTRATO) return new ContratoUCController(papel);
        else if (papel.TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.DOCUMENTO 
            || papel.TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.RESOLUCION
            || papel.TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.NOTA) return new DocumentoUCController(papel);
        return null;
    }

    private Control renderICard(ICard iCard, Papel papel)
    {
        Control control = null;
        if (iCard is SistemaUCController) control = iCard.get() as SistemaCard;
        else if (iCard is DocumentoUCController) control = iCard.get() as DocumentoCard;       
        else if (iCard is ContratoUCController) control = iCard.get() as ContratoCard;      
        if (control != null)
        {
            control.Tag = papel;
        }
        return control;
    }

    private void ActiveForm_VisibleChanged(object sender, EventArgs e)
    {
        indexUI.cbArchivados.Visible = menuDocumental.ShowArchivados;
        indexUI.tbBuscar.Text = string.Empty;
        indexUI.cbArchivados.Checked = false;

        Form form = sender as Form;
        if (form != null && form.Visible && ((!AplicationConfig.APP_MODE_UPDATE && countUpdates < 1) || AplicationConfig.APP_MODE_UPDATE))
        {
            LLenarListaDocumentosIniciales();
            LLenarListaDocumentos();
            countUpdates++;
        }
    }
    private void LLenarListaDocumentosIniciales()
    {
        List<Papel> documentosAux = GetDocumentosOrdenados();
        List<Control> docsNormales = new List<Control>();
        List<Control> docsArchivados = new List<Control>();

        foreach (Papel papel in documentosAux)
        {
            ICard card = getICardPapel(papel);
            card.setInfo();
            Control control = renderICard(card, papel);
            if (control != null)
            {
                if (papel.IsArchivado())
                {
                    docsArchivados.Add(control);
                }
                else
                {
                    docsNormales.Add(control);
                }
            }
        }

        documentosNormales = docsNormales;
        documentosArchivados = docsArchivados;
        documentos = documentosNormales;
    }
    private void LLenarListaDocumentos()
    {
        forma.flowLayoutDocumentos.SuspendLayout();
        forma.flowLayoutDocumentos.Controls.Clear();
        foreach (Control control in documentos)
        {
            forma.flowLayoutDocumentos.Controls.Add(control);
        }
        for (int i = 0; i < 3; i++)
        {
            ExtraSpaceCard card = new ExtraSpaceCard();
            forma.flowLayoutDocumentos.Controls.Add(card);
        }
        forma.flowLayoutDocumentos.ResumeLayout();
    }


    private List<Papel> GetDocumentosOrdenados()
    {
        List<Papel> documentosAux = papelService.GetByMenuDocumental(menuDocumental);
        if (documentosAux.Count > 0 && documentosAux[0].TipoDocumentacion.TipoCard == BRapp.Enums.TipoCard.CONTRATO)
        {
            return documentosAux.OrderBy(contrato => contrato.getDiasRestantes()).Cast<Papel>().ToList();
        }
        return documentosAux;
    }

   

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        FiltrarDocumentos();
    }
    private void cbArchivados_CheckedChanged(object sender, EventArgs e)
    {
        documentos = indexUI.cbArchivados.Checked ? documentosArchivados : documentosNormales;
        LLenarListaDocumentos();
        FiltrarDocumentos();
    }  

    private void FiltrarDocumentos()
    {
        forma.flowLayoutDocumentos.SuspendLayout();
        string searchText = indexUI.tbBuscar.Text.ToLower();
        foreach (Control control in forma.flowLayoutDocumentos.Controls)
        {
            if (!(control is ExtraSpaceCard))
            {
                Papel papel = control.Tag as Papel;
                control.Visible = papel != null && papel.ToString().ToLower().Contains(searchText);
            }
        }
        forma.flowLayoutDocumentos.ResumeLayout();
    }

    public static DocumentoUIController GetInstance(MenuDocumental menuDocumental, IndexUIController indexUIController)
    {
        return new DocumentoUIController(menuDocumental, indexUIController);
    }
}