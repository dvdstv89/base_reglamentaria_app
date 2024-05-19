using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class SistemaUCController : BaseUCController<SistemaCard, Sistema>, ICard
    {      
        private readonly IPapelService papelService;
        private readonly VisorPDFUIController visorDocumentosUIController;
        private readonly ISistemaService sistemaService;
        private readonly DocumentoPDF documentoApliado;
        public SistemaUCController(Sistema documento, IPapelService papelService) : base(new SistemaCard(), documento)
        {           
            this.papelService = papelService;
            this.sistemaService = SistemaService.Instance;
            this.documentoApliado = sistemaService.getDocumentoPDFApliado(documento);
            this.visorDocumentosUIController = new VisorPDFUIController(documentoApliado);
        }

        public override UserControl get()
        {
            card.btnPdf.Click += new EventHandler(btnPdf_Click);
            card.btnResponsable.Click += new EventHandler(btnResponsable_Click);
            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.Name;
            card.labelCargoResponsable.Text = objeto.Responsable.Cargo;
            card.labelDescripcion.Rtf = objeto.Descripcion;
            card.btnPdf.Visible = visorDocumentosUIController.hasPdf();
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
        }        

        private void btnPdf_Click(object sender, EventArgs e)
        {
            visorDocumentosUIController.showDialog();
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            PersonaNaturalUCController personaNaturalUCController = new PersonaNaturalUCController(objeto.Responsable);
            personaNaturalUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaNaturalUCController);
            CardDialogUIController.showDialog();
        }
    }
}
