using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class SistemaUCController : BaseUCController<SistemaCard, Sistema>, ICard
    {       
        public SistemaUCController(Sistema documento) : base(new SistemaCard(), documento)
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
            card.iconPictureBox1.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.Name;
            card.labelCargoResponsable.Text = objeto.Responsable.Cargo;
            card.labelDescripcion.Rtf = objeto.Descripcion;
            card.btnPdf.Visible = objeto.hasPdfName();           
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
