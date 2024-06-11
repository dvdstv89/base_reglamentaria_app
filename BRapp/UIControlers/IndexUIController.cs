using BRapp.Messages;
using BRapp.UI;
using BRapp.Utiles;
using System;
using System.Windows.Forms;
using BRapp.Services.Interfaces;
using BRapp.Data;
using BRapp.Model.Tiendas;
using System.Collections.Generic;
using BRapp.Model.Nomenclador;
using System.Linq;
using BRapp.Enums;
using System.Drawing;

namespace BRapp.UIControlers
{
    public class IndexUIController : BaseUIController<IndexUI>
    {
        protected readonly IIndexService indexService;
        private readonly IComplejoService complejoService;
        private readonly IMenuDocumentalService menuDocumentalService;

        Dictionary<ToolStripMenuItem, Complejo> complejosItemMappings;
        Dictionary<ToolStripMenuItem, MenuDocumental> documentacionItemMappings;       

        IForm activeForm = null;
        ButtonSeleccionado botonActivo = null;
        public IndexUIController() : base(new IndexUI())
        {
            indexService = AplicationConfig.Component.IndexService;
            complejoService = AplicationConfig.Component.ComplejoService;
            menuDocumentalService = AplicationConfig.Component.MenuDocumentalService;

            complejosItemMappings = new Dictionary<ToolStripMenuItem, Complejo>();
            documentacionItemMappings = new Dictionary<ToolStripMenuItem, MenuDocumental>();            
        }

        public override IndexUI ejecutar()
        {
            forma.menuStripPrincipal.Layout += centrarMenu;
            forma.Layout += centrarFormulario;
            forma.Resize += Forma_Resize;
            forma.btnLimpiarBusqueda.Click += new EventHandler(btnLimpiarBusqueda_Click);
            forma.bienvenidaToolStripMenuItem.Click += new EventHandler(bienvenidaToolStripMenuItem_Click);           
            forma.consultorToolStripMenuItem.Click += new EventHandler(consultorToolStripMenuItem_Click);
            forma.directorioToolStripMenuItem.Click += new EventHandler(directorioToolStripMenuItem_Click);           

            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
            cargarComplejos();
            cargarDocumentacionSeccion(3, TipoUbicacionMenu.SISTEMA);
            cargarDocumentacionSeccion(4, TipoUbicacionMenu.EXTERNO);
            cargarDocumentacionSeccion(5, TipoUbicacionMenu.INTERNO);
            forma.adminToolStripMenuItem.Visible= false;
            forma.menuStripPrincipal.Renderer = new MyRenderer();
            updateFooter();
            forma.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            forma.richTextBox1.TabStop = false;
        }

        private void cargarComplejos()
        {
            List<Complejo> complejos = complejoService.GetAll();
            foreach (Complejo complejo in complejos)
            {
                ToolStripMenuItem buttonMenu = new ToolStripMenuItem();
                buttonMenu.Text= complejo.ToString();
                buttonMenu.Click += ComplejoToolStripMenuItem_Click;
                forma.sucursalToolStripMenuItem.DropDownItems.Add(buttonMenu);
                complejosItemMappings.Add(buttonMenu, complejo);
            }
        }

        private void cargarDocumentacionSeccion(int positionMenu, Enums.TipoUbicacionMenu tipoUbicacion)
        {
            List<MenuDocumental> menuDocumentals = menuDocumentalService.GetAllByTipoUbicacionMenu(tipoUbicacion);
            ToolStripMenuItem buttonPadre = null;
            foreach (MenuDocumental menu in menuDocumentals)
            {
                ToolStripMenuItem buttonMenu = new ToolStripMenuItem();
                buttonMenu.Text = menu.ToString();
                if (menu.AbrirPagina)
                {
                    buttonMenu.Click += DocumentacionToolStripMenuItem_Click;
                }
                buttonPadre = buttonPadre == null? GetButtonPadre(tipoUbicacion): buttonPadre;
                if(buttonPadre != null)
                {
                    buttonPadre.DropDownItems.Add(buttonMenu);
                }
                documentacionItemMappings.Add(buttonMenu, menu);
            }

            buttonPadre = buttonPadre == null ? GetButtonPadre(tipoUbicacion) : buttonPadre;
            if (buttonPadre != null)
            {
                buttonPadre.ForeColor = Color.White;
                forma.menuStripPrincipal.Items.Insert(positionMenu, buttonPadre);             
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            forma.tbBuscar.Text = "";            
        }

        private void ComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && complejosItemMappings.ContainsKey(menuItem))
            {
                complejoSeccion(menuItem, complejosItemMappings[menuItem]);
            }
        }

        private void DocumentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && documentacionItemMappings.ContainsKey(menuItem))
            {
                documentacionSeccion(menuItem, documentacionItemMappings[menuItem]);
            }
        }

        private void complejoSeccion(ToolStripMenuItem buttonMenu, Complejo complejo)
        {
            forma.panelBusqueda.Visible = false;
            if (complejo.TipoComplejo == Enums.TipoComplejo.COMPLEJO)
            {
                var formulario = ComplejoUIController.GetInstance(complejo);
                formatearFormulario(buttonMenu, forma.sucursalToolStripMenuItem, formulario, complejo.ToString());
                formulario.ejecutar().Show();
            }
            else
            {
                var formulario = SucursalUIController.GetInstance(complejo);
                formatearFormulario(buttonMenu, forma.sucursalToolStripMenuItem, formulario, complejo.ToString());
                formulario.ejecutar().Show();
            }           
        }
        private void documentacionSeccion(ToolStripMenuItem buttonMenu, MenuDocumental menu)
        {
            forma.panelBusqueda.Visible = menu.ShowPanelBusqueda;           
            var formulario = DocumentoUIController.GetInstance(menu, this);          
            formatearFormulario(buttonMenu, GetButtonPadre(menu.TipoUbicacionMenu), formulario, menu.Name);
            formulario.ejecutar().Show();
        }

        public ToolStripMenuItem GetButtonPadre(Enums.TipoUbicacionMenu tipoUbicacion)
        {
            return documentacionItemMappings
                .FirstOrDefault(kvp => kvp.Value.TipoUbicacionMenu == tipoUbicacion && kvp.Value.IsRaiz).Key;
        }

        public void updateFooter()
        {
            forma.richTextBox1.Rtf = indexService.GetFooter();
        }

        protected override void forma_Load(object sender, EventArgs e)
        {
            bienvenidaToolStripMenuItem_Click(sender, e);           
            base.forma_Load(sender, e);
        }       

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = BienvenidaUIController.Instance;
            formatearFormulario(forma.bienvenidaToolStripMenuItem, null, formulario, ButtonName.BienvenidaButton);
            formulario.ejecutar().Show();
        }                    

        private void consultorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = ConsultorUIController.Instance;
            formatearFormulario(forma.consultorToolStripMenuItem, null, formulario, ButtonName.ConsultorButton);
            formulario.ejecutar().Show();
        }

        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = DirectorioUIController.Instance;
            formatearFormulario(forma.directorioToolStripMenuItem,null, formulario, ButtonName.DirectorioButton);
            formulario.ejecutar().Show();
        }

        protected void formatearFormulario(ToolStripMenuItem buttonSeleccionado, ToolStripMenuItem buttonPadre, IForm form, string menuTitle)
        {
            setHeaderText(menuTitle);           
            openChildForm(form );
            cambiarBotonActivo(new ButtonSeleccionado(buttonSeleccionado, buttonPadre));
        }
        private void openChildForm(IForm baseUIController)
        {
            if (activeForm != null)
            {               
                activeForm.hide();
            }
            activeForm = baseUIController;
            baseUIController.configurarFormularioComoPanel();
            Form form = baseUIController.getForm();
            forma.panelMain.Controls.Add(form);
            forma.panelMain.Tag = form;

            bool useScrolls = baseUIController.viewHasScrolls();
            forma.panelMain.AutoScroll = !useScrolls;
            if (useScrolls)
            {
                form.Height = forma.panelMain.ClientSize.Height;
            }            
        }
        protected void setHeaderText(string text)
        {
            forma.labelMenuSeleccionado.Text = text;           
        }
        protected void cambiarBotonActivo(ButtonSeleccionado button)
        {
            if (botonActivo != null)
            {
                botonActivo.desmarcarBoton();                
            }
            botonActivo = button;
            if (botonActivo != null)
            {
                botonActivo.marcarBoton();
            }
        }
        protected void centrarMenu(object sender, LayoutEventArgs e)
        {
            int totalWidth = 0;
            foreach (ToolStripItem item in forma.menuStripPrincipal.Items)
            {
                if (AplicationConfig.APP_MODE_UPDATE)
                {
                    totalWidth += item.Width;
                }
                else
                {
                    if (item != forma.adminToolStripMenuItem)
                        totalWidth += item.Width;
                }
                totalWidth += 10;
            }

            int espacioWidth = (forma.menuStripPrincipal.Width - totalWidth) / 2;

            forma.menuStripPrincipal.Padding = new Padding(espacioWidth, 0, espacioWidth, 0);
        }
        private void centrarFormulario(object sender, LayoutEventArgs e)
        {
            int anchoDisponible = forma.ClientSize.Width - AplicationConfig.ANCHO_PANTALLA;

            // Calcular el ancho deseado para cada panel lateral
            int anchoPanelLateral = anchoDisponible / 2;

            // Establecer el nuevo ancho para los paneles laterales
            forma.panelIzquierdo.Width = anchoPanelLateral;
            forma.panelDerecha.Width = anchoPanelLateral;
        }

        private void Forma_Resize(object sender, EventArgs e)
        {            
            if (activeForm != null && activeForm.getForm() != null && activeForm.viewHasScrolls())
            {               
                activeForm.getForm().Height = forma.panelMain.ClientSize.Height;
            }
        }
    }
}
