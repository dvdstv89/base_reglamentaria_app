using BRapp.Messages;
using BRapp.UI;
using BRapp.Utiles;
using BRapp.Enums.EnumsInstances;
using System;
using System.Windows.Forms;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.Data;

namespace BRapp.UIControlers
{
    public class IndexUIController : BaseUIController<IndexUI>
    {
        private static IndexUIController instance;
        protected readonly IIndexService iIndexService;

        IForm activeForm = null;
        ButtonSeleccionado botonActivo = null;
        protected IndexUIController(IIndexService iIndexService) : base(new IndexUI())
        {
            this.iIndexService = iIndexService;
        }

        public override IndexUI ejecutar()
        {
            forma.menuStrip1.Layout += centrarMenu;
            forma.Layout += centrarFormulario;
            forma.Resize += Forma_Resize;
            forma.bienvenidaToolStripMenuItem.Click += new EventHandler(bienvenidaToolStripMenuItem_Click);
            forma.sucursalToolStripMenuItem1.Click += new EventHandler(sucursalToolStripMenuItem1_Click);
            forma.dTHoteleroHabanaLibreToolStripMenuItem.Click += new EventHandler(dTHoteleroHabanaLibreToolStripMenuItem_Click);
            forma.dTHoteleroVedadoEsteToolStripMenuItem.Click += new EventHandler(dTHoteleroVedadoEsteToolStripMenuItem_Click);
            forma.dTHoteleroVedadoOesteToolStripMenuItem.Click += new EventHandler(dTHoteleroVedadoOesteToolStripMenuItem_Click);
            forma.dTExtrahoteleroLegendarioToolStripMenuItem.Click += new EventHandler(dTExtrahoteleroLegendarioToolStripMenuItem_Click);
            forma.dTExtrahoteleroAmazonaToolStripMenuItem.Click += new EventHandler(dTExtrahoteleroAmazonaToolStripMenuItem_Click);
            forma.sistemasToolStripMenuItem.Click += new EventHandler(sistemasToolStripMenuItem_Click);
           
            forma.manualesToolStripMenuItem.Click += new EventHandler(manualesToolStripMenuItem_Click);
            forma.reglamentosToolStripMenuItem.Click += new EventHandler(reglamentosToolStripMenuItem_Click);
            forma.procedimientosToolStripMenuItem.Click += new EventHandler(procedimientosToolStripMenuItem_Click);
            forma.planesYProgramasToolStripMenuItem.Click += new EventHandler(planesYProgramasToolStripMenuItem_Click);
            forma.resolucionesEmpresarialesToolStripMenuItem.Click += new EventHandler(resolucionesEmpresarialesToolStripMenuItem_Click);
            forma.dGToolStripMenuItem.Click += new EventHandler(dGToolStripMenuItem_Click);

            forma.planesToolStripMenuItem.Click += new EventHandler(planesToolStripMenuItem_Click);
            forma.programasToolStripMenuItem.Click += new EventHandler(programasToolStripMenuItem_Click);
            forma.resolucionesEIndicosToolStripMenuItem.Click += new EventHandler(resolucionesEIndicosToolStripMenuItem_Click);
            forma.otrosDocumentosToolStripMenuItem.Click += new EventHandler(otrosDocumentosToolStripMenuItem_Click);

            forma.contrataciónToolStripMenuItem.Click += new EventHandler(contrataciónToolStripMenuItem_Click);
            forma.consultorToolStripMenuItem.Click += new EventHandler(consultorToolStripMenuItem_Click);
            forma.directorioToolStripMenuItem.Click += new EventHandler(directorioToolStripMenuItem_Click);
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
            forma.adminToolStripMenuItem.Visible= false;
            forma.menuStrip1.Renderer = new MyRenderer();
            updateFooter();
            forma.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            forma.richTextBox1.TabStop = false;
        }

        public void updateFooter()
        {
            forma.richTextBox1.Rtf = iIndexService.getFooter();
        }

        protected override void forma_Load(object sender, EventArgs e)
        {
            //bienvenidaToolStripMenuItem_Click(sender, e);
            directorioToolStripMenuItem_Click(sender, e);
            base.forma_Load(sender, e);
        }       

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = BienvenidaUIController.Instance;
            formatearFormulario(forma.bienvenidaToolStripMenuItem, null, formulario, ButtonName.BienvenidaButton);
            formulario.ejecutar().Show();
        }

        private void sucursalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = SucursalUIController.Instance;
            formatearFormulario(forma.sucursalToolStripMenuItem1, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_SucursalButton);
            formulario.ejecutar().Show();
        }

        private void dTHoteleroHabanaLibreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TiendaUIController.GetInstance(TipoTiendaInstance.HLIBRE);
            formatearFormulario(forma.dTHoteleroHabanaLibreToolStripMenuItem, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_HLibreButton);
            formulario.ejecutar().Show();
        }

        private void dTHoteleroVedadoEsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TiendaUIController.GetInstance(TipoTiendaInstance.NACIONAL);
            formatearFormulario(forma.dTHoteleroVedadoEsteToolStripMenuItem, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_NacionalButton);
            formulario.ejecutar().Show();
        }

        private void dTHoteleroVedadoOesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TiendaUIController.GetInstance(TipoTiendaInstance.COHIBA);
            formatearFormulario(forma.dTHoteleroVedadoOesteToolStripMenuItem, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_CohibaButton);
            formulario.ejecutar().Show();
        }

        private void dTExtrahoteleroLegendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TiendaUIController.GetInstance(TipoTiendaInstance.LEGENDARIO);
            formatearFormulario(forma.dTExtrahoteleroLegendarioToolStripMenuItem, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_LegendarioButton);
            formulario.ejecutar().Show();
        }

        private void dTExtrahoteleroAmazonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = false;
            var formulario = TiendaUIController.GetInstance(TipoTiendaInstance.AMAZONA);
            formatearFormulario(forma.dTExtrahoteleroAmazonaToolStripMenuItem, forma.sucursalToolStripMenuItem, formulario, ButtonName.Sucursal_AmazonaButton);
            formulario.ejecutar().Show();
        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.SISTEMA, this);
            formatearFormulario(forma.sistemasToolStripMenuItem, null, formulario, ButtonName.SistemaButton);
            formulario.ejecutar().Show();
        }

        private void manualesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_MANUALES, this);
            formatearFormulario(forma.manualesToolStripMenuItem,forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_ManualesButton);
            formulario.ejecutar().Show();
        }

        private void reglamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_REGLAMENTOS, this);
            formatearFormulario(forma.reglamentosToolStripMenuItem, forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_ReglamentosButton);
            formulario.ejecutar().Show();
        }

        private void procedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_PROCEDIMIENTOS, this);
            formatearFormulario(forma.procedimientosToolStripMenuItem, forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_ProcedimientosButton);
            formulario.ejecutar().Show();
        }

        private void planesYProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_PLANES_PROGRAMAS, this);
            formatearFormulario(forma.planesYProgramasToolStripMenuItem, forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_PlanesProgramasButton);
            formulario.ejecutar().Show();
        }

        private void resolucionesEmpresarialesToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_RESOLUCIONES_EMPRESARIALES, this);
            formatearFormulario(forma.resolucionesEmpresarialesToolStripMenuItem, forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_ResolucionesButton);
            formulario.ejecutar().Show();
        }

        private void dGToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.PRE_DG, this);
            formatearFormulario(forma.dGToolStripMenuItem, forma.procedimientosYReglamentosEmpresarialesToolStripMenuItem, formulario, ButtonName.PRE_DG);
            formulario.ejecutar().Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.DOC_PLANES, this);
            formatearFormulario(forma.planesToolStripMenuItem, forma.documentosInternosToolStripMenuItem, formulario, ButtonName.DocumentosInternos_PlanesButton);
            formulario.ejecutar().Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.DOC_PROGRAMAS, this);
            formatearFormulario(forma.programasToolStripMenuItem, forma.documentosInternosToolStripMenuItem, formulario, ButtonName.DocumentosInternos_ProgramasButton);
            formulario.ejecutar().Show();
        }

        private void resolucionesEIndicosToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.DOC_RESOLUCIONES_INDICOS, this);
            formatearFormulario(forma.resolucionesEIndicosToolStripMenuItem, forma.documentosInternosToolStripMenuItem, formulario, ButtonName.DocumentosInternos_ResolucionesIndicosButton);
            formulario.ejecutar().Show();
        }

        private void otrosDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.DOC_OTROS_DOCUMENTOS, this);
            formatearFormulario(forma.otrosDocumentosToolStripMenuItem, forma.documentosInternosToolStripMenuItem, formulario, ButtonName.DocumentosInternos_DocumentosButton);
            formulario.ejecutar().Show();
        }

        private void contrataciónToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            forma.panelBusqueda.Visible = true;
            var formulario = DocumentoUIController.GetInstance(TipoDocumentoMenu.DOC_CONTRATO, this);
            formatearFormulario(forma.contrataciónToolStripMenuItem, forma.documentosInternosToolStripMenuItem, formulario, ButtonName.DocumentosInternos_ContratacionButton);
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
            foreach (ToolStripItem item in forma.menuStrip1.Items)
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

            int espacioWidth = (forma.menuStrip1.Width - totalWidth) / 2;

            forma.menuStrip1.Padding = new Padding(espacioWidth, 0, espacioWidth, 0);
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

        public static IndexUIController Instance
        {
            get
            {
                return (instance == null) ? new IndexUIController(IndexService.Instance) : instance;               
            }
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
