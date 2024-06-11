using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using BRapp.Utiles;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class ContratoUCController : BaseUCController<ContratoCard, Papel>, ICard
    {
        public ContratoUCController(Papel documento) : base(new ContratoCard(), documento)
        {

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
            card.tbActaAcuerdo.Text = objeto.NumeroAcuerdo.ToString();
            card.tbCliente.Text = objeto.Cliente.Name;
            card.tbTipoContrato.Text = objeto.Tipo;
            card.tbResponsable.Text = objeto.Responsable.Name;
            card.tbFechaInicio.Text = FechaUtil.getShortText(objeto.FechaFirma);
            card.tbFechaFin.Text = FechaUtil.getShortText(objeto.FechaVencimiento);
            int diasRestantes = (int)objeto.getDiasRestantes();
            card.tbDiasRestantes.Text = (diasRestantes > -999) ? diasRestantes.ToString() : "???";
            if (((PersonaJuridica)objeto.Cliente).hasLogo())
            {
                card.iconPictureBox1.Visible = false;
                using (MemoryStream ms = new MemoryStream(((PersonaJuridica)objeto.Cliente).Logo.Data))
                {
                    using (Image originalImage = Image.FromStream(ms))
                    {
                        ResizeImage(card.panelImagen, originalImage);
                    }
                }
            }
            card.btnPdf.Visible = objeto.hasPdfName();
            if (objeto.isProximoVencerse() || objeto.isVencido())
            {
                card.tbDiasRestantes.BackColor= Color.Red;
                card.labelName.BackColor = Color.Red;
                card.panelTitle.BackColor = Color.Red;
                card.labelName.ForeColor = Color.White;
                card.iconPrincipal.IconColor = Color.White;
                card.tbDiasRestantes.ForeColor= Color.White;
                card.tbDiasRestantes.ForeColor = Color.White;
            }
            else if (objeto.isVencido())
            {
                card.tbDiasRestantes.BackColor = Color.Black;
                card.labelName.BackColor = Color.Black;
                card.panelTitle.BackColor = Color.Black;
                card.labelName.ForeColor = Color.White;
                card.iconPrincipal.IconColor = Color.White;
                card.tbDiasRestantes.ForeColor = Color.White;
            }

            if(objeto.Padre != null)
            {
                card.panelContratoPadre.Visible = true;
                card.tbContratoPadre.Text = objeto.Padre.Numero;               
            }
            else
            {
                card.panelContratoPadre.Visible= false;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {           
            var visorDocumentosUIController = new VisorPDFUIController(objeto.ArchivoPDF);
            visorDocumentosUIController.showDialog();
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            PersonaJuridicaUCController personaJuridicaUCController = new PersonaJuridicaUCController((PersonaJuridica)objeto.Responsable);
            personaJuridicaUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaJuridicaUCController);
            CardDialogUIController.showDialog();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            PersonaJuridicaUCController personaJuridicaUCController = new PersonaJuridicaUCController((PersonaJuridica)objeto.Cliente);
            personaJuridicaUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaJuridicaUCController);
            CardDialogUIController.showDialog();
        }

        private void btnContratoPadre_Click(object sender, EventArgs e)
        {
            ContratoUCController contratoUCController = new ContratoUCController(objeto.Padre);
            contratoUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(contratoUCController);
            CardDialogUIController.showDialog();
        }
    }
}
