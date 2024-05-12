using BRapp.UI;
using BRapp.UI.Cards;

namespace BRapp.UIControlers.CardUCController
{
    internal class CardDialogUIController : BaseUIController<CardDialogUI>, IForm
    {           
        private readonly ICard Card;       

        public CardDialogUIController(ICard Card) : base(new CardDialogUI(), true)
        {      
            this.Card = Card;          
        }

        protected override void initDataForm()
        {           
            Card.setInfo();            
            forma.panelCard.Controls.Add(Card.get());           
            int Width = Card.get().Width + 18;
            int Height = Card.get().Height + 40;
            forma.Size = new System.Drawing.Size(Width, Height);
        }
    }
}
