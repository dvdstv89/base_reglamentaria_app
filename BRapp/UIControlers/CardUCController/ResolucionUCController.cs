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
    internal class ResolucionUCController : BaseUCController<ResolucionCard, Resolucion>, ICard
    {      
        private readonly IPapelService papelService;
        private readonly VisorPDFUIController visorPDFUIController;
        private readonly IResolucionService resolucionService;
        private readonly DocumentoPDF documentoApliado;
        private bool eventsSubscribed = false;
        public ResolucionUCController(Resolucion documento) 
            : base(new ResolucionCard(), documento) 
        { 
            this.papelService = PapelService.Instance;
            this.resolucionService = ResolucionService.Instance;
            this.documentoApliado = resolucionService.getDocumentoPDFApliado(documento);
            this.visorPDFUIController = new VisorPDFUIController(documentoApliado);
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
            if (documentoApliado.hasImagen())
            {
                card.iconPictureBox1.Visible = false;
                using (MemoryStream ms = new MemoryStream(documentoApliado.Imagen.Data))
                {
                    using (Image originalImage = Image.FromStream(ms))
                    {
                        ResizeImage(card.panelImagen, originalImage);
                    }
                }
            }
            card.btnPdf.Visible = visorPDFUIController.hasPdf();
            if (objeto.DerrogadaPor != null)
            {
                card.panelDerrogadoPor.Visible = true;
                card.tbDerrogadoPor.Text = objeto.DerrogadaPor.ToString();
            }
            else
            {
                card.panelDerrogadoPor.Visible = false;
            }
        }        

        private void btnPdf_Click(object sender, EventArgs e)
        {
            visorPDFUIController.showDialog();
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
