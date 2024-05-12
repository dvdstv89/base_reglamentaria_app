using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class BaseUCController<Card, Objeto> where Card : UserControl
    {
        protected readonly Card card;
        protected bool selected;
        protected Objeto objeto;

        public BaseUCController(Card card, Objeto objeto)
        {
            this.card = card;
            this.selected = false;
            card.Cursor = Cursors.Default;
            this.objeto = objeto;
        }

        public virtual UserControl get()
        {
            card.Load += new EventHandler(forma_Load);
            return card;
        }

        protected virtual void forma_Load(object sender, EventArgs e)
        {          
            setInfo();
        }       

        public bool isSelected()
        {
            return selected;
        }

        protected virtual void selectCard()
        {
            return;
        }

        public virtual void setInfo()
        {
            return;
        }

        public virtual Object getObject()
        {
            return objeto;
        }

        protected void AlinearTextoEnCentroVertical(TextBox textBox)
        {
            int paddingTop = (textBox.Height - textBox.Font.Height) / 2;
            textBox.Padding = new Padding(0, paddingTop, 0, 0);
        }       
    }
}
