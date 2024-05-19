using BRapp.Enums;
using BRapp.Messages;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
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
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionServiceAdmin;
        private readonly IGrupoDocumentacionService grupoDocumentacionServiceAdmin;
        ListViewItem itemTipoSeleccionado;
        ListViewItem itemDocumentoSeleccionado;
        int indexItemDocumentoSeleccionado = -1;


        private List<TipoGrupoDocumentacion> tiposGruposDocumentacion;
        private List<GrupoDocumentacion> grupoDocumentacions;

        private TipoGrupoDocumentacionUIController() : base(new TipoGrupoDocumentacionUI())
        {
            tipoGrupoDocumentacionServiceAdmin = TipoGrupoDocumentacionService.Instance;
            grupoDocumentacionServiceAdmin = GrupoDocumentacionService.Instance;
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
            forma.eliminarDocumentoToolStripMenuItem.Click += new EventHandler(eliminarDocumentoToolStripMenuItem_Click);
            forma.subirToolStripMenuItem.Click += new EventHandler(subirToolStripMenuItem_Click);
            forma.bajarToolStripMenuItem.Click += new EventHandler(bajarToolStripMenuItem_Click);


            forma.obligatorioToolStripMenuItem.Click += new EventHandler(obligatorioToolStripMenuItem_Click);
            forma.opcionalToolStripMenuItem.Click += new EventHandler(opcionalToolStripMenuItem_Click);

            return base.ejecutar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTipo(null);
        }

        private void nuevoDocumentoStripMenuItem1_Click(object sender, EventArgs e)
        {
            var papelUiController = new PapelUIController(null, TipoClasificacionDocumento.DOCUMENTACION_BASICA);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {                
                Documento documento = (Documento)papelUiController.GetPapel();
                GrupoDocumentacion grupo = new GrupoDocumentacion(getTipoSeleccionado(), documento, false, grupoDocumentacions.Count+1);
                grupoDocumentacionServiceAdmin.saveOrUpdate(grupo);
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDocumentos.Text = "";
                updateDocumentosList();
            }
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

        private void eliminarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupoDocumentacionServiceAdmin.Delete(getDocumentacionSeleccionado());
            updateDocumentosList();
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
            var papelUiController = new PapelUIController(grupoDocumentacion.Documento, TipoClasificacionDocumento.DOCUMENTACION_BASICA);
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
            indexItemDocumentoSeleccionado = forma.listViewDocumentos.Items.IndexOf(itemDocumentoSeleccionado);
            forma.modificarDocumentoStripMenuItem2.Enabled = true;
            forma.eliminarDocumentoToolStripMenuItem.Enabled = true;
            forma.obligatorioToolStripMenuItem.Visible = !getDocumentacionSeleccionado().IsOpcional;
            forma.opcionalToolStripMenuItem.Visible = getDocumentacionSeleccionado().IsOpcional;           

            forma.subirToolStripMenuItem.Visible = indexItemDocumentoSeleccionado > 0;
            forma.bajarToolStripMenuItem.Visible = indexItemDocumentoSeleccionado < forma.listViewDocumentos.Items.Count - 1;
        }
        private void desmarcarTipos()
        {
            forma.modificarToolStripMenuItem.Enabled = false;
            itemTipoSeleccionado = null;
            forma.lwTipos.SelectedItems.Clear();          
            forma.panelDocumentos.Enabled = false;
            desmarcarDocumentacion();
        }
        private void desmarcarDocumentacion()
        {
            forma.modificarDocumentoStripMenuItem2.Enabled = false;
            forma.eliminarDocumentoToolStripMenuItem.Enabled = false;
            forma.obligatorioToolStripMenuItem.Visible = false;
            forma.opcionalToolStripMenuItem.Visible = false;
            itemDocumentoSeleccionado = null;
            forma.listViewDocumentos.SelectedItems.Clear();

            forma.subirToolStripMenuItem.Visible = false;
            forma.bajarToolStripMenuItem.Visible = false;
        }
    
        private TipoGrupoDocumentacion getTipoSeleccionado()
        {
            return getListViewItemSeleccionado<TipoGrupoDocumentacion>(itemTipoSeleccionado);           
        }
        private GrupoDocumentacion getDocumentacionSeleccionado()
        {
            return getListViewItemSeleccionado<GrupoDocumentacion>(itemDocumentoSeleccionado);
        }
      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateTipoList();
            txtSearch_TextChanged(forma.tbBuscar.Text, forma.lwTipos);
        }
        private void txtDocumentoSearch_TextChanged(object sender, EventArgs e)
        {
            updateDocumentosList();
            txtSearch_TextChanged(forma.tbBuscarDocumentos.Text, forma.listViewDocumentos);
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

        private void obligatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cambiarOpcional(true);
        }

        private void opcionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarOpcional(false);
        }

        private void cambiarOpcional(bool value)
        {
            var grupoDocumentoSeleccionado = getDocumentacionSeleccionado();
            if (grupoDocumentoSeleccionado != null)
            {
                grupoDocumentoSeleccionado.IsOpcional= value;
                grupoDocumentacionServiceAdmin.saveOrUpdate(grupoDocumentoSeleccionado);
                updateDocumentosList();
            }           
        }


        private void subirToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            int ordenActual = getDocumentacionSeleccionado().Orden;
            cambiarOrden(itemDocumentoSeleccionado, ordenActual - 1);
            cambiarOrden(forma.listViewDocumentos.Items[indexItemDocumentoSeleccionado - 1], ordenActual);
            txtDocumentoSearch_TextChanged(sender, e);
        }

        private void bajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getDocumentacionSeleccionado().Orden;
            cambiarOrden(itemDocumentoSeleccionado, ordenActual + 1);
            cambiarOrden(forma.listViewDocumentos.Items[indexItemDocumentoSeleccionado + 1], ordenActual);
            txtDocumentoSearch_TextChanged(sender, e);
        }

        private void cambiarOrden(ListViewItem item, int orden)
        {
            GrupoDocumentacion grupo = getListViewItemSeleccionado<GrupoDocumentacion>(item);
            grupo.Orden = orden;
            grupoDocumentacionServiceAdmin.saveOrUpdate(grupo);
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
