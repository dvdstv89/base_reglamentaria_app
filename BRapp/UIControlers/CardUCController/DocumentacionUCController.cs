using BRapp.Model.Tiendas;
using BRapp.UI.Cards;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class DocumentacionUCController : BaseUCController<DocumentacionCard, GrupoDocumentacion>, ICard
    {      
        int orden;
        public DocumentacionUCController(GrupoDocumentacion grupoDocumentacion, int orden) : base(new DocumentacionCard(), grupoDocumentacion)
        {
            this.orden = orden;
            
        }

        public override UserControl get()
        {
            card.btnList.Click += new EventHandler(btnDocumento_Click);          
            card.labelName.SizeChanged += LabelContent_SizeChanged;
            return base.get();
        }

        public override void setInfo()
        {
            card.lbNumero.Text = orden.ToString();
            card.labelName.Text = objeto.Name;          
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            DocumentoUCController documentoUCController = new DocumentoUCController(objeto.Documento);
            documentoUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(documentoUCController);
            CardDialogUIController.showDialog();
        }      

        private void LabelContent_SizeChanged(object sender, EventArgs e)
        {
            card.panelContainer.Height = card.labelName.Height;
            AdjustFormHeight();
        }
        private void AdjustFormHeight()
        {          
            int totalHeight = card.panelContainer.Height;           
            card.Height = totalHeight + card.Padding.Top + card.Padding.Bottom;
        }
    }
}
