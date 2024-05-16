using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using BRapp.Utiles;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class ContratoUCController : BaseUCController<ContratoCard, Contrato>, ICard
    {      
        private readonly IPapelService papelService;
        private readonly VisorPDFUIController visorDocumentosUIController;
        private readonly IContratoService contratoService;
        private readonly DocumentoPDF documentoApliado;
        public ContratoUCController(Contrato documento, IPapelService papelService) : base(new ContratoCard(), documento)
        {           
            this.papelService = papelService;          
            this.contratoService = ContratoService.Instance;
            this.documentoApliado = contratoService.getDocumentoPDFApliado(documento);
            this.visorDocumentosUIController = new VisorPDFUIController(documentoApliado);
        }

        public override UserControl get()
        {
            card.btnPdf.Click += new EventHandler(btnPdf_Click);
            card.btnResponsable.Click += new EventHandler(btnResponsable_Click);
            card.btnContratoPadre.Click += new EventHandler(btnContratoPadre_Click);
            card.btnCliente.Click += new EventHandler(btnCliente_Click);
            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.Name;
            card.labelNumero.Text = objeto.Numero;
            card.tbActaAcuerdo.Text = objeto.getActaAcuerdo();
            card.tbCliente.Text = objeto.Cliente.Name;
            card.tbTipoContrato.Text = objeto.TipoContrato.ToString();
            card.tbResponsable.Text = objeto.Responsable.Name;
            card.tbFechaInicio.Text = FechaUtil.getShortText(objeto.FechaFirma);
            card.tbFechaFin.Text = FechaUtil.getShortText(objeto.FechaFirma);
            int diasRestantes = (int)objeto.getDiasRestantes();
            card.tbDiasRestantes.Text = (diasRestantes > -999) ? diasRestantes.ToString() : "???";
            if (documentoApliado.hasImagen())
            {
                using (MemoryStream ms = new MemoryStream(documentoApliado.Imagen.Data))
                {
                    card.panelImagen.BackgroundImage = Image.FromStream(ms);
                }
            }
            card.btnPdf.Visible = visorDocumentosUIController.hasPdf();
            if (objeto.isProximoVencerse())
            {
                card.tbDiasRestantes.BackColor= Color.Red;
                card.labelName.BackColor = Color.Red;
                card.panelTitle.BackColor = Color.Red;              
            }
            else if (objeto.isVencido())
            {
                card.tbDiasRestantes.BackColor = Color.Black;
                card.labelName.BackColor = Color.Black;
                card.panelTitle.BackColor = Color.Black;
            }

            if(objeto.ContratoPadre != null)
            {
                card.panelContratoPadre.Visible = true;
                card.tbContratoPadre.Text = objeto.ContratoPadre.ToString();
            }
            else
            {
                card.panelContratoPadre.Visible= false;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            visorDocumentosUIController.showDialog();
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            PersonaJuridicaUCController personaJuridicaUCController = new PersonaJuridicaUCController(objeto.Responsable);
            personaJuridicaUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaJuridicaUCController);
            CardDialogUIController.showDialog();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            PersonaJuridicaUCController personaJuridicaUCController = new PersonaJuridicaUCController(objeto.Cliente);
            personaJuridicaUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaJuridicaUCController);
            CardDialogUIController.showDialog();
        }

        private void btnContratoPadre_Click(object sender, EventArgs e)
        {
            ContratoUCController contratoUCController = new ContratoUCController(objeto.ContratoPadre, papelService);
            contratoUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(contratoUCController);
            CardDialogUIController.showDialog();
        }
    }
}
