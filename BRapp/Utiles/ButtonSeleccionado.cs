using BRapp.Utiles.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.Utiles
{
    public class ButtonSeleccionado
    {
        private ToolStripMenuItem botonSeleccionado = null;
        private ToolStripMenuItem botonPadre = null;
        private bool isSubmenu = false;

        public ButtonSeleccionado(ToolStripMenuItem botonSeleccionado, ToolStripMenuItem botonPadre = null)
        {
            this.botonSeleccionado=botonSeleccionado;
            this.botonPadre=botonPadre;
            isSubmenu = botonPadre != null;
        }

        public void marcarBoton()
        {
            if (isSubmenu == false)
            {
                marcarBotonMenu(botonSeleccionado);
            }
            else
            {                
                marcarBotonSubMenu(botonSeleccionado, botonPadre);
            }
        }

        public void desmarcarBoton()
        {
            if (isSubmenu == false)
            {
                desmarcarBotonMenu(botonSeleccionado);
            }
            else
            {               
                desmarcarBotonSubMenu(botonSeleccionado, botonPadre);
            }
        }

        private void desmarcarBotonMenu(ToolStripMenuItem boton)
        {
            boton.Font = Styles.MyFontStyle.MAIN_MENU_FONT_BUTTON_NORMAL;
            boton.ForeColor = Color.White;
            boton.Enabled = true;
        }

        private void marcarBotonMenu(ToolStripMenuItem boton)
        {
            boton.Font = Styles.MyFontStyle.MAIN_MENU_FONT_BUTTON_SELECTED;
            boton.ForeColor = Color.Black;
            boton.Enabled = false;
        }

        private void desmarcarBotonSubMenu(ToolStripMenuItem boton, ToolStripMenuItem padre)
        {            
            padre.ForeColor = Color.White;

            boton.Font = Styles.MyFontStyle.MAIN_MENU_FONT_BUTTON_NORMAL;          
            boton.Enabled = true;
        }

        private void marcarBotonSubMenu(ToolStripMenuItem boton, ToolStripMenuItem padre)
        {          
            padre.ForeColor = Color.Black;

            boton.Font = Styles.MyFontStyle.MAIN_MENU_FONT_BUTTON_SELECTED;          
            boton.Enabled = false;
        }

        public ToolStripMenuItem getButton()
        {
            return botonSeleccionado;
        }
    }
}
