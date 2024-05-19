using System;
using System.Drawing;
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

        protected void ResizeImage(Panel panel,  Image image)
        {
            int width = panel.Width;
            int height = panel.Height;



            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            panel.BackgroundImage = destImage;            ;
        }
    }
}
