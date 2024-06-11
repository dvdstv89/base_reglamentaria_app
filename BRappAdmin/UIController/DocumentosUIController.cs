using BRapp.Enums;
using BRapp.Model;
using BRapp.UI;
using BRapp.UIControlers;
using BRapp.Messages;
using BRappAdmin.UI;
using BRappAdmin.UIController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.Model.Tiendas;
using BRappAdmin.Data;

namespace BRappAdmin.UIControlers
{
    internal class DocumentosUIController : BaseUIController<DocumentosUI>, IForm
    {
        private static DocumentosUIController instance;
        private readonly IPapelService documentosService;       
        private ListViewColumnSorter columnSorter;
        ListViewItem itemSeleccionado;
        private List<Papel> papeles;      
        private readonly Dictionary<ToolStripMenuItem, TipoCard> menuItemMappings = new Dictionary<ToolStripMenuItem, TipoCard>();

        private DocumentosUIController() : base(new DocumentosUI())
        {
            documentosService = AplicationAdminConfig.Component.Component.PapelService;
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
            menuItemMappings.Add(forma.sistemaToolStripMenuItem, TipoCard.SISTEMA);
            menuItemMappings.Add(forma.contratoToolStripMenuItem, TipoCard.CONTRATO);
            menuItemMappings.Add(forma.resoluciónToolStripMenuItem, TipoCard.RESOLUCION);
            menuItemMappings.Add(forma.documentoToolStripMenuItem, TipoCard.DOCUMENTO);                        
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
                modificarPapel(null, menuItemMappings[menuItem], papeles.Count+1, sender, e);
            }
        }

        protected override void initDataForm()
        {
            updateList();
        }

        private void updateList()
        {
            papeles = documentosService.GetAllWhitCard();
            forma.lwPapeles.Items.Clear();
            foreach (Papel papel in papeles)
            {
                var item = new ListViewItem(papel.ToString());
                item.SubItems.Add(papel.TipoDocumentacion.ToString());                
                bool hasPdf = papel.ArchivoPDF != null && papel.ArchivoPDF.hasDocumento();             
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
            actualizarActivo(true, sender, e);
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarActivo(false, sender, e);           
        }

        private void actualizarActivo(bool activo, object sender, EventArgs e)
        {
            var papel = getPapelSeleccionado();
            papel.IsActivo = activo;
            documentosService.SaveOrUpdate(papel);
            DialogUtil.INFORMATION(Mensajes.PAPEL_UPDATED_OK);
            txtSearch_TextChanged(sender, e);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var papelSeleccionado = getPapelSeleccionado();
             modificarPapel(papelSeleccionado, papelSeleccionado.TipoDocumentacion.TipoCard, papeles.FindIndex(doc => doc.Id == papelSeleccionado.Id), sender, e);
        }

        private void lwPapeles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var papelSeleccionado = getPapelSeleccionado();
               modificarPapel(papelSeleccionado, papelSeleccionado.TipoDocumentacion.TipoCard, papeles.FindIndex(doc => doc.Id == papelSeleccionado.Id), sender, e);
            }
        }

        private void modificarPapel(Papel papel, TipoCard tipoCard, int posicion, object sender, EventArgs e)
        {
            var papelUiController = new PapelUIController(papel, tipoCard, posicion, null);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                txtSearch_TextChanged(sender, e);
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
                //instance = (instance == null) ? new DocumentosUIController() : instance;
                //return instance;
                return new DocumentosUIController();
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
            forma.columnName.Width = RoundNumber((totalWidth * 0.6));
            forma.columnTipo.Width = RoundNumber((totalWidth * 0.3));
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
