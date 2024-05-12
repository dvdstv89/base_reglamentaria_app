using BRapp.Utiles.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers
{
    internal class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = e.Item.Selected ? Colors.MAIN_MENU_COLOR_SELECTED : Colors.MAIN_MENU_COLOR_NORMAL;
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
        }
    }
}
