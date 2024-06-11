using BRapp.Messages;
using BRapp.Model.Nomenclador;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class TipoDocumentacionlUIController : BaseUIController<TipoDocumentacionUI>, IForm
    {
        private static TipoDocumentacionlUIController instance;

        private readonly ITipoDocumentacionService tipoDocumentacionService;
        ListViewItem itemSeleccionado;
        int indexItemSeleccionado = -1;
        
        private List<TipoDocumentacion> tipoDocumentacionList;

        private TipoDocumentacionlUIController() : base(new TipoDocumentacionUI())
        {
            tipoDocumentacionService = AplicationAdminConfig.Component.Component.TipoDocumentacionService;          
        }

        public override TipoDocumentacionUI ejecutar()
        {           
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;           

            forma.listViewDocumentacion.SelectedIndexChanged += listView_SelectedIndexChanged;
            forma.listViewDocumentacion.MouseDoubleClick += listView_MouseDoubleClick;
            forma.listViewDocumentacion.Layout += resizeList;          


            forma.nuevoStripMenuItem1.Click += new EventHandler(nuevoStripMenuItem1_Click);
            forma.modificarStripMenuItem2.Click += new EventHandler(modificarToolStripMenuItem_Click);
            forma.eliminarToolStripMenuItem.Click += new EventHandler(eliminarToolStripMenuItem_Click);  
            return base.ejecutar();
        }       

        private void nuevoStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newTipoDocumentacionUIController = new NewTipoDocumentacionUIController(null);
            DialogResult dialogResult = newTipoDocumentacionUIController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateList();
            }
        }

        protected override void initDataForm()
        {
            updateList();
        }

        private void updateList()
        {
            tipoDocumentacionList = tipoDocumentacionService.GetAll();           
            forma.listViewDocumentacion.Items.Clear();
            foreach (TipoDocumentacion tipo in tipoDocumentacionList)
            {
                var item = new ListViewItem(tipo.Name);
                item.SubItems.Add(tipo.TipoCard.ToString());
                item.SubItems.Add(tipo.HasPdf.ToString());
                item.SubItems.Add(tipo.TipoResponsable.ToString());
                item.SubItems.Add(tipo.HasNumeracion.ToString());
                item.SubItems.Add(tipo.HasFechaCreacion.ToString());
                item.SubItems.Add(tipo.HasFechaVencimiento.ToString());
                item.SubItems.Add(tipo.TipoCliente.ToString());
                item.SubItems.Add(tipo.HasOpcionalidad.ToString());
                item.SubItems.Add(tipo.HasTipo.ToString());
                item.SubItems.Add(tipo.HasPadre.ToString());
                item.SubItems.Add(tipo.HasActaAcuerdo.ToString());
                item.Tag = tipo;
                forma.listViewDocumentacion.Items.Add(item);
            }
            desmarcarItem();
        }       

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.listViewDocumentacion.SelectedItems.Count == 1)
            {
                marcarItem();
            }
            else
            {
                desmarcarItem();
            }
        }
      
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            modificarMenus(getItemSeleccionado(), tipoDocumentacionList.FindIndex(doc => doc.Id == getItemSeleccionado().Id));
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipoDocumentacionService.Delete(getItemSeleccionado().Id);
            updateList();
        }       

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                modificarMenus(getItemSeleccionado(), tipoDocumentacionList.FindIndex(doc => doc.Id == getItemSeleccionado().Id));
            }
        }
        
        private void modificarMenus(TipoDocumentacion grupoDocumentacion, int posicion)
        {
            var newTipoDocumentacionUIController = new NewTipoDocumentacionUIController(grupoDocumentacion);        
            DialogResult dialogResult = newTipoDocumentacionUIController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateList();
            }
        }
       
        private void marcarItem()
        {
            itemSeleccionado = forma.listViewDocumentacion.SelectedItems[0];
            indexItemSeleccionado = forma.listViewDocumentacion.Items.IndexOf(itemSeleccionado);
            forma.modificarStripMenuItem2.Enabled = true;
            forma.eliminarToolStripMenuItem.Enabled = true;           
        }
      
        private void desmarcarItem()
        {
            forma.modificarStripMenuItem2.Enabled = false;
            forma.eliminarToolStripMenuItem.Enabled = false;          
            itemSeleccionado = null;
            forma.listViewDocumentacion.SelectedItems.Clear();           
        }    
      
        private TipoDocumentacion getItemSeleccionado()
        {
            return getListViewItemSeleccionado<TipoDocumentacion>(itemSeleccionado);
        }
     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateList();
            txtSearch_TextChanged(forma.tbBuscar.Text, forma.listViewDocumentacion);
        }
      
        private void resizeList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.listViewDocumentacion.Width - 25;          
            forma.columnDocumentoName.Width = RoundNumber((totalWidth * 0.3));
            forma.columnTipoCard.Width = RoundNumber((totalWidth * 0.1));
            forma.columnHasPdf.Width = RoundNumber((totalWidth * 0.08));
            forma.columnResponsable.Width = RoundNumber((totalWidth * 0.08));
            forma.columnNumeracion.Width = RoundNumber((totalWidth * 0.08));
            forma.columnFechaCreacion.Width = RoundNumber((totalWidth * 0.08));
            forma.columnFechaVencimiento.Width = RoundNumber((totalWidth * 0.08));
            forma.columnHasCliente.Width = RoundNumber((totalWidth * 0.08));
            forma.columnHasOpcional.Width = RoundNumber((totalWidth * 0.08));
            forma.columnHasPadre.Width = RoundNumber((totalWidth * 0.08));
            forma.columnHasTipo.Width = RoundNumber((totalWidth * 0.08));
            forma.columnHasActaAcuerdo.Width = RoundNumber((totalWidth * 0.08));
        }

        public static TipoDocumentacionlUIController Instance
        {
            get
            {
                //instance = (instance == null) ? new TipoGrupoDocumentacionUIController() : instance;
                //return instance;
                return new TipoDocumentacionlUIController();
            }
        }
    }
}
