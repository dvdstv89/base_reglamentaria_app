using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using BRapp.Utiles;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class DocumentoUCController : BaseUCController<DocumentoCard, Documento>, ICard
    {           
        public DocumentoUCController(Documento documento) : base(new DocumentoCard(), documento)
        {           
          
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
            card.labelName.Text = objeto.ToString();
            card.labelCargoResponsable.Text = objeto.Responsable.Cargo;
            card.labelDescripcion.Rtf = objeto.Descripcion;
            card.lbFecha.Text = FechaUtil.getLargeText(objeto.FechaFirma);           
            card.btnPdf.Visible = objeto.hasPdfName();

            if(objeto.TipoClasificacionDocumento == Enums.TipoClasificacionDocumento.DOCUMENTACION_BASICA)
            {
                card.panelResponsable.Visible = false;
                card.panelFecha.Visible = false;
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
    }
}
