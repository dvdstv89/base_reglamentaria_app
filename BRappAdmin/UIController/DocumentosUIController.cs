using BRapp.Data;
using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Messages;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using BRappAdmin.UIController;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class DocumentosUIController : BaseUIController<DocumentosUI>, IForm
    {
        private static DocumentosUIController instance;
        private readonly IDocumentosServiceAdmin documentosService;
        private readonly IFileService filePdfLogoService;
        private readonly IFileService filePdfDocumentService;
        private ListViewColumnSorter columnSorter;
        ListViewItem itemSeleccionado;
        private List<Papel> papeles;      
        private readonly Dictionary<ToolStripMenuItem, TipoClasificacionDocumento> menuItemMappings = new Dictionary<ToolStripMenuItem, TipoClasificacionDocumento>();

        private DocumentosUIController() : base(new DocumentosUI())
        {
            documentosService = DocumentosServiceAdmin.Instance;
            filePdfLogoService = new FileService();
            filePdfDocumentService = new FileService();
            columnSorter = new ListViewColumnSorter();
        }

        public override DocumentosUI ejecutar()
        {
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;
            forma.lwPapeles.ColumnClick += ListView_ColumnClick;
            forma.lwPapeles.ListViewItemSorter = columnSorter;
            forma.lwPapeles.SelectedIndexChanged += lwPapeles_SelectedIndexChanged;
            forma.lwPapeles.MouseDoubleClick += lwPapeles_MouseDoubleClick;
            forma.activarToolStripMenuItem.Click += new EventHandler(activarToolStripMenuItem_Click);
            forma.desactivarToolStripMenuItem.Click += new EventHandler(desactivarToolStripMenuItem_Click);
            forma.modificarToolStripMenuItem.Click += new EventHandler(modificarToolStripMenuItem_Click);
            menuItemMappings.Add(forma.sistemaToolStripMenuItem, TipoClasificacionDocumento.SISTEMA);
            menuItemMappings.Add(forma.contratoToolStripMenuItem, TipoClasificacionDocumento.CONTRATO);
            menuItemMappings.Add(forma.resolucionInternaToolStripMenuItem, TipoClasificacionDocumento.RESOLUCION_INTERNA);
            menuItemMappings.Add(forma.resolucionEmpresarialToolStripMenuItem, TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL);
            menuItemMappings.Add(forma.indicoToolStripMenuItem, TipoClasificacionDocumento.INDICO);
            menuItemMappings.Add(forma.manualToolStripMenuItem, TipoClasificacionDocumento.MANUAL);
            menuItemMappings.Add(forma.dGToolStripMenuItem, TipoClasificacionDocumento.DG);
            menuItemMappings.Add(forma.planEmpresarialToolStripMenuItem, TipoClasificacionDocumento.PLAN_EMPRESARIAL);
            menuItemMappings.Add(forma.planInternoToolStripMenuItem, TipoClasificacionDocumento.PLAN_INTERNO);
            menuItemMappings.Add(forma.procedimientoToolStripMenuItem, TipoClasificacionDocumento.PROCEDIMIENTO);
            menuItemMappings.Add(forma.programaEmpresarialToolStripMenuItem, TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL);
            menuItemMappings.Add(forma.programaInternoToolStripMenuItem, TipoClasificacionDocumento.PROGRAMA_INTERNO);
            menuItemMappings.Add(forma.reglamentoToolStripMenuItem, TipoClasificacionDocumento.REGLAMENTO);
            menuItemMappings.Add(forma.otrosDocumentosToolStripMenuItem, TipoClasificacionDocumento.OTRO_DOCUMENTO);
            menuItemMappings.Add(forma.documentaciónBásicaToolStripMenuItem, TipoClasificacionDocumento.DOCUMENTACION_BASICA);
            foreach (var menuItem in menuItemMappings.Keys)
            {
                menuItem.Click += ButtonToolStripMenuItem_Click;
            }
            forma.lwPapeles.Layout += resizeList;
            return base.ejecutar();
        }

        private void ButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItemMappings.ContainsKey(menuItem))
            {               
                modificarPapel(null, menuItemMappings[menuItem]); ;
            }
        }

        protected override void initDataForm()
        {
            updateList();
        }

        private void updateList()
        {
            papeles = documentosService.getAll();
            forma.lwPapeles.Items.Clear();
            foreach (Papel papel in papeles)
            {
                var item = new ListViewItem(papel.ToString());
                item.SubItems.Add(papel.TipoClasificacionDocumento.ToString());                
                bool hasPdf = papel.DocumentoPDF != null && papel.DocumentoPDF.hasDocumento();
                item.SubItems.Add(hasPdf.ToString());
                item.SubItems.Add(papel.IsActivo.ToString());
                item.Tag = papel;
                forma.lwPapeles.Items.Add(item);
            }
            desmarcarPapel();
        }

        private void lwPapeles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwPapeles.SelectedItems.Count == 1)
            {
                marcarPapel();
            }
            else
            {
                desmarcarPapel();
            }
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarActivo(true);            
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarActivo(false);
        }

        private void actualizarActivo(bool activo)
        {
            var papel = getPapelSeleccionado();
            papel.IsActivo = activo;
            documentosService.saveOrUpdate(papel);
            DialogUtil.INFORMATION(Mensajes.PAPEL_UPDATED_OK);
            updateList();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var papelSeleccionado = getPapelSeleccionado();
            modificarPapel(papelSeleccionado, papelSeleccionado.TipoClasificacionDocumento);
        }

        private void lwPapeles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var papelSeleccionado = getPapelSeleccionado();
                modificarPapel(papelSeleccionado, papelSeleccionado.TipoClasificacionDocumento);
            }
        }

        private void modificarPapel(Papel papel, TipoClasificacionDocumento tipoClasificacionDocumento)
        {
            var papelUiController = new PapelUIController(papel, tipoClasificacionDocumento, filePdfLogoService, filePdfDocumentService);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateList();
            }
        }
        private void marcarPapel()
        {
            itemSeleccionado = forma.lwPapeles.SelectedItems[0];
            var papelSeleccionado = getPapelSeleccionado();
            forma.activarToolStripMenuItem.Visible = !papelSeleccionado.IsActivo;
            forma.desactivarToolStripMenuItem.Visible = papelSeleccionado.IsActivo;
            forma.modificarToolStripMenuItem.Enabled = true;
        }
        private void desmarcarPapel()
        {
            forma.activarToolStripMenuItem.Visible = false;
            forma.desactivarToolStripMenuItem.Visible = false;
            forma.modificarToolStripMenuItem.Enabled = false;
            itemSeleccionado = null;
            forma.lwPapeles.SelectedItems.Clear();
        }
        public static DocumentosUIController Instance
        {
            get
            {
                return (instance == null) ? new DocumentosUIController() : instance;
            }
        }
        private Papel getPapelSeleccionado()
        {
            try
            {
                return (Papel)itemSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
        }
        private void resizeList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwPapeles.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 0.5));
            forma.columnTipo.Width = RoundNumber((totalWidth * 0.3));         
            forma.columnPDF.Width = RoundNumber((totalWidth * 0.1));
            forma.columnActivo.Width = RoundNumber((totalWidth * 0.1));
        }
        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSorter.Sort(forma.lwPapeles, e.Column);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateList();
            string searchText = forma.tbBuscar.Text.ToLower();          
            foreach (ListViewItem item in forma.lwPapeles.Items)
            {               
                bool containsSearchTerm = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        containsSearchTerm = true;
                        break;
                    }
                }             
                if (!containsSearchTerm)
                {                 
                    forma.lwPapeles.Items.Remove(item);
                }
            }
        }
    }
}
