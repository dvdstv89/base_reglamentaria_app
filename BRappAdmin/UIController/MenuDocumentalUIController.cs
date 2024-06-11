using BRapp.Messages;
using BRapp.Model.Nomenclador;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class MenuDocumentalUIController : BaseUIController<MenuDocumentalUI>, IForm
    {
        private static MenuDocumentalUIController instance;

        private readonly IMenuDocumentalService menuDocumentalService;
        ListViewItem itemMenuDocumentalSeleccionado;
        int indexItemMenuDocumentalSeleccionado = -1;
        
        private List<MenuDocumental> menuDocumentalList;

        private MenuDocumentalUIController() : base(new MenuDocumentalUI())
        {
            menuDocumentalService = AplicationAdminConfig.Component.Component.MenuDocumentalService;          
        }

        public override MenuDocumentalUI ejecutar()
        {           
            forma.tbBuscarDocumentos.TextChanged += txtDocumentoSearch_TextChanged;           

            forma.listViewMenus.SelectedIndexChanged += listViewMenus_SelectedIndexChanged;
            forma.listViewMenus.MouseDoubleClick += listViewMenus_MouseDoubleClick;
            forma.listViewMenus.Layout += resizeMenusList;          


            forma.nuevoDocumentoStripMenuItem1.Click += new EventHandler(nuevoMenusStripMenuItem1_Click);
            forma.modificarDocumentoStripMenuItem2.Click += new EventHandler(modificarMenusToolStripMenuItem_Click);
            forma.eliminarDocumentoToolStripMenuItem.Click += new EventHandler(eliminarMenusToolStripMenuItem_Click);
            forma.subirToolStripMenuItem.Click += new EventHandler(subirToolStripMenuItem_Click);
            forma.bajarToolStripMenuItem.Click += new EventHandler(bajarToolStripMenuItem_Click);
           

            return base.ejecutar();
        }       

        private void nuevoMenusStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newMenuDocumentalUIController = new NewMenuDocumentalUIController(null, menuDocumentalList.Count + 1);
            DialogResult dialogResult = newMenuDocumentalUIController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDocumentos.Text = "";
                updateMenusList();
            }
        }

        protected override void initDataForm()
        {
            updateMenusList();
        }

        private void updateMenusList()
        {
            menuDocumentalList = menuDocumentalService.GetAll();           
            forma.listViewMenus.Items.Clear();
            foreach (MenuDocumental menu in menuDocumentalList)
            {
                var item = new ListViewItem(menu.Name);
                item.SubItems.Add(menu.TipoUbicacionMenu.ToString());
                item.SubItems.Add(menu.ShowPanelBusqueda.ToString());
                item.SubItems.Add(menu.ShowArchivados.ToString());
                item.Tag = menu;
                forma.listViewMenus.Items.Add(item);
            }
            desmarcarMenus();
        }       

        private void listViewMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.listViewMenus.SelectedItems.Count == 1)
            {
                marcarMenus();
            }
            else
            {
                desmarcarMenus();
            }
        }
      
        private void modificarMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            modificarMenus(getMenusSeleccionado(), menuDocumentalList.FindIndex(doc => doc.Id == getMenusSeleccionado().Id));
        }

        private void eliminarMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuDocumentalService.Delete(getMenusSeleccionado().Id);
            updateMenusList();
        }       

        private void listViewMenus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                modificarMenus(getMenusSeleccionado(), menuDocumentalList.FindIndex(doc => doc.Id == getMenusSeleccionado().Id));
            }
        }
        
        private void modificarMenus(MenuDocumental menuDocumental, int posicion)
        {
            var newMenuDocumentalUIController = new NewMenuDocumentalUIController(menuDocumental, posicion);
            DialogResult dialogResult = newMenuDocumentalUIController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDocumentos.Text = "";
                updateMenusList();
            }
        }
       
        private void marcarMenus()
        {
            itemMenuDocumentalSeleccionado = forma.listViewMenus.SelectedItems[0];
            indexItemMenuDocumentalSeleccionado = forma.listViewMenus.Items.IndexOf(itemMenuDocumentalSeleccionado);
            forma.modificarDocumentoStripMenuItem2.Enabled = true;
            forma.eliminarDocumentoToolStripMenuItem.Enabled = true;
            forma.subirToolStripMenuItem.Visible = indexItemMenuDocumentalSeleccionado > 0;
            forma.bajarToolStripMenuItem.Visible = indexItemMenuDocumentalSeleccionado < forma.listViewMenus.Items.Count - 1;
        }
      
        private void desmarcarMenus()
        {
            forma.modificarDocumentoStripMenuItem2.Enabled = false;
            forma.eliminarDocumentoToolStripMenuItem.Enabled = false;          
            itemMenuDocumentalSeleccionado = null;
            forma.listViewMenus.SelectedItems.Clear();
            forma.subirToolStripMenuItem.Visible = false;
            forma.bajarToolStripMenuItem.Visible = false;
        }    
      
        private MenuDocumental getMenusSeleccionado()
        {
            return getListViewItemSeleccionado<MenuDocumental>(itemMenuDocumentalSeleccionado);
        }
     
        private void txtDocumentoSearch_TextChanged(object sender, EventArgs e)
        {
            updateMenusList();
            txtSearch_TextChanged(forma.tbBuscarDocumentos.Text, forma.listViewMenus);
        }
      
        private void resizeMenusList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.listViewMenus.Width - 25;          
            forma.columnDocumentoName.Width = RoundNumber((totalWidth * 0.5));
            forma.columnUbicacion.Width = RoundNumber((totalWidth * 0.3));
            forma.columnPanelBusqueda.Width = RoundNumber((totalWidth * 0.1));
            forma.columnMostrarArchivados.Width = RoundNumber((totalWidth * 0.1));
        }

        private void subirToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            int ordenActual = getMenusSeleccionado().Orden;
            cambiarOrden(itemMenuDocumentalSeleccionado, ordenActual - 1);
            cambiarOrden(forma.listViewMenus.Items[indexItemMenuDocumentalSeleccionado - 1], ordenActual);
            txtDocumentoSearch_TextChanged(sender, e);
        }

        private void bajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getMenusSeleccionado().Orden;
            cambiarOrden(itemMenuDocumentalSeleccionado, ordenActual + 1);
            cambiarOrden(forma.listViewMenus.Items[indexItemMenuDocumentalSeleccionado + 1], ordenActual);
            txtDocumentoSearch_TextChanged(sender, e);
        }

        private void cambiarOrden(ListViewItem item, int orden)
        {
            MenuDocumental grupo = getListViewItemSeleccionado<MenuDocumental>(item);
            grupo.Orden = orden;
            menuDocumentalService.SaveOrUpdate(grupo);
        }

        public static MenuDocumentalUIController Instance
        {
            get
            {
                //instance = (instance == null) ? new TipoGrupoDocumentacionUIController() : instance;
                //return instance;
                return new MenuDocumentalUIController();
            }
        }
    }
}
