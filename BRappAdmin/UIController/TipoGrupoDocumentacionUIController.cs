using BRapp.Model.Tiendas;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Messages;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class TipoGrupoDocumentacionUIController : BaseUIController<TipoGrupoDocumentacionUI>, IForm
    {
        private static TipoGrupoDocumentacionUIController instance;
        private readonly ITipoGrupoDocumentacionServiceAdmin tipoGrupoDocumentacionServiceAdmin;
        private readonly IGrupoDocumentacionServiceAdmin grupoDocumentacionServiceAdmin;
        ListViewItem itemTipoSeleccionado;
        ListViewItem itemDocumentoSeleccionado;


        private List<TipoGrupoDocumentacion> tiposGruposDocumentacion;
        private List<GrupoDocumentacion> grupoDocumentacions;

        private TipoGrupoDocumentacionUIController() : base(new TipoGrupoDocumentacionUI())
        {
            tipoGrupoDocumentacionServiceAdmin = TipoGrupoDocumentacionServiceAdmin.Instance;
            grupoDocumentacionServiceAdmin = GrupoDocumentacionServiceAdmin.Instance;
        }

        public override TipoGrupoDocumentacionUI ejecutar()
        {
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;
            forma.tbBuscarDocumentos.TextChanged += txtDocumentoSearch_TextChanged;

            forma.lwTipos.SelectedIndexChanged += lwTipos_SelectedIndexChanged;
            forma.lwTipos.MouseDoubleClick += lwTipos_MouseDoubleClick;
            forma.lwTipos.Layout += resizeTiposList;

            forma.listViewDocumentos.SelectedIndexChanged += listViewDocumentos_SelectedIndexChanged;
            forma.listViewDocumentos.MouseDoubleClick += listViewDocumentos_MouseDoubleClick;
            forma.listViewDocumentos.Layout += resizeDocumentacionList;


            forma.nuevoToolStripMenuItem.Click += new EventHandler(nuevoToolStripMenuItem_Click);
            forma.modificarToolStripMenuItem.Click += new EventHandler(modificarTiposToolStripMenuItem_Click);           
          
            
            forma.nuevoDocumentoStripMenuItem1.Click += new EventHandler(nuevoDocumentoStripMenuItem1_Click);
            forma.modificarDocumentoStripMenuItem2.Click += new EventHandler(modificarDocumentacionToolStripMenuItem_Click);

           
            return base.ejecutar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTipo(null);
        }

        private void nuevoDocumentoStripMenuItem1_Click(object sender, EventArgs e)
        {
            modificarDocumento(null);
        }

        protected override void initDataForm()
        {
            updateTipoList();
        }

        private void updateTipoList()
        {
            tiposGruposDocumentacion = tipoGrupoDocumentacionServiceAdmin.getAll();
            forma.lwTipos.Items.Clear();
            foreach (TipoGrupoDocumentacion papel in tiposGruposDocumentacion)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwTipos.Items.Add(item);
            }
            desmarcarTipos();
        }

        private void updateDocumentosList()
        {
            grupoDocumentacions = grupoDocumentacionServiceAdmin.getAllByTipoGrupoDocumentacion(getTipoSeleccionado());
            forma.listViewDocumentos.Items.Clear();
            foreach (GrupoDocumentacion papel in grupoDocumentacions)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.listViewDocumentos.Items.Add(item);
            }
            desmarcarDocumentacion();
        }

        private void lwTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwTipos.SelectedItems.Count == 1)
            {
                marcarTipos();
                updateDocumentosList();
            }
            else
            {
                desmarcarDocumentacion();
                desmarcarTipos();
                forma.listViewDocumentos.Items.Clear();
            }
        }

        private void listViewDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.listViewDocumentos.SelectedItems.Count == 1)
            {
                marcarDocumentacion();
            }
            else
            {
                desmarcarDocumentacion();
            }
        }

        private void modificarTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            modificarTipo(getTipoSeleccionado());
        }

        private void modificarDocumentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            modificarDocumento(getDocumentacionSeleccionado());
        }

        private void lwTipos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                modificarTipo(getTipoSeleccionado());
            }
        }

        private void listViewDocumentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                modificarDocumento(getDocumentacionSeleccionado());
            }
        }

        private void modificarTipo(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            var papelUiController = new NewTipoGrupoDocumentacionUIController(tipoGrupoDocumentacion);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateTipoList();
            }
        }
        private void modificarDocumento(GrupoDocumentacion grupoDocumentacion)
        {
            var papelUiController = new NewGrupoDocumentacionUIController(grupoDocumentacion, getTipoSeleccionado());
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDocumentos.Text = "";
                updateDocumentosList();
            }
        }
        private void marcarTipos()
        {
            itemTipoSeleccionado = forma.lwTipos.SelectedItems[0];
            forma.modificarToolStripMenuItem.Enabled = true;
            forma.panelDocumentos.Enabled = true;
        }
        private void marcarDocumentacion()
        {
            itemDocumentoSeleccionado = forma.listViewDocumentos.SelectedItems[0];
            forma.modificarToolStripMenuItem.Enabled = true;
           
        }
        private void desmarcarTipos()
        {
            forma.modificarToolStripMenuItem.Enabled = false;
            itemTipoSeleccionado = null;
            forma.lwTipos.SelectedItems.Clear();          
            forma.panelDocumentos.Enabled = false;
        }
        private void desmarcarDocumentacion()
        {
            forma.modificarDocumentoStripMenuItem2.Enabled = false;
            itemDocumentoSeleccionado = null;
            forma.listViewDocumentos.SelectedItems.Clear();
        }
    
        private TipoGrupoDocumentacion getTipoSeleccionado()
        {
            try
            {
                return (TipoGrupoDocumentacion)itemTipoSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
        }
        private GrupoDocumentacion getDocumentacionSeleccionado()
        {
            try
            {
                return (GrupoDocumentacion)itemDocumentoSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
        }
      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateTipoList();
            string searchText = forma.tbBuscar.Text.ToLower();
            foreach (ListViewItem item in forma.lwTipos.Items)
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
                    forma.lwTipos.Items.Remove(item);
                }
            }
        }

        private void txtDocumentoSearch_TextChanged(object sender, EventArgs e)
        {
            updateDocumentosList();
            string searchText = forma.tbBuscarDocumentos.Text.ToLower();
            foreach (ListViewItem item in forma.listViewDocumentos.Items)
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
                    forma.listViewDocumentos.Items.Remove(item);
                }
            }
        }

        private void resizeTiposList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTipos.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 1));          
        }
        private void resizeDocumentacionList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTipos.Width - 25;          
            forma.columnDocumentoName.Width = RoundNumber((totalWidth * 1));
        }

        public static TipoGrupoDocumentacionUIController Instance
        {
            get
            {
                instance = (instance == null) ? new TipoGrupoDocumentacionUIController() : instance;
                return instance;
            }
        }
    }
}
