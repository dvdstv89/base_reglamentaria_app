using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using BRapp.Utiles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class ResolucionUCController : BaseUCController<ResolucionCard, Resolucion>, ICard
    {   
        private bool eventsSubscribed = false;
        public ResolucionUCController(Resolucion documento) 
            : base(new ResolucionCard(), documento) 
        { 
                 
        }

        public override UserControl get()
        {
            if (!eventsSubscribed)
            {
                card.btnPdf.Click += new EventHandler(btnPdf_Click);
                card.btnResponsable.Click += new EventHandler(btnResponsable_Click);
                card.btnDerrogadaPor.Click += new EventHandler(btnDerrogadaPor_Click);
                eventsSubscribed = true;
            }

            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.ToString();
            card.labelCargoResponsable.Text = objeto.Responsable.Cargo;
            card.labelDescripcion.Rtf = objeto.Descripcion;
            card.lbFecha.Text = FechaUtil.getLargeText(objeto.FechaFirma);          
           
            card.btnPdf.Visible = objeto.hasPdfName();
            if (objeto.DerrogadaPor != null)
            {
                card.panelDerrogadoPor.Visible = true;
                card.tbDerrogadoPor.Text = objeto.DerrogadaPor.GetNumero();
                card.panelTitle.BackColor = Color.Black;
            }
            else
            {
                card.panelDerrogadoPor.Visible = false;
            }
        }        

        private void btnPdf_Click(object sender, EventArgs e)
        {
            var visorDocumentosUIController = new VisorPDFUIController(objeto.DocumentoPDF);
            visorDocumentosUIController.showDialog();
        }
        private void btnResponsable_Click(object sender, EventArgs e)
        {
            PersonaNaturalUCController personaNaturalUCController = new PersonaNaturalUCController(objeto.Responsable);
            personaNaturalUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaNaturalUCController);
            CardDialogUIController.showDialog();
        }
        private void btnDerrogadaPor_Click(object sender, EventArgs e)
        {
            ResolucionUCController resolucionUCController = new ResolucionUCController(objeto.DerrogadaPor);
            resolucionUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(resolucionUCController);
            CardDialogUIController.showDialog();
        }
    }
}
