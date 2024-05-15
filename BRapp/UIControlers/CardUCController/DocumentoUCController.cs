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
    internal class DocumentoUCController : BaseUCController<DocumentoCard, Documento>, ICard
    {      
        private readonly IPapelService papelService;
        private readonly VisorDocumentosUIController visorDocumentosUIController;
        private readonly IDocumentoService documentoService;
        private readonly DocumentoPDF documentoApliado;
        public DocumentoUCController(Documento documento, IPapelService papelService) : base(new DocumentoCard(), documento)
        {           
            this.papelService = papelService;
            this.documentoService = DocumentoService.Instance;
            this.documentoApliado = documentoService.getDocumentoPDFApliado(documento);
            this.visorDocumentosUIController = new VisorDocumentosUIController(documentoApliado);
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
            card.lbFecha.Text = FechaUtil.getLargeText(objeto.FechaFirma);
            if (documentoApliado.hasImagen())
            {
                using (MemoryStream ms = new MemoryStream(documentoApliado.Imagen.Data))
                {
                    card.panelImagen.BackgroundImage = Image.FromStream(ms);
                }
            }
            card.btnPdf.Visible = visorDocumentosUIController.hasPdf();

            if(objeto.TipoClasificacionDocumento == Enums.TipoClasificacionDocumento.DOCUMENTACION_BASICA)
            {
                card.panelFecha.Visible = false;
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
