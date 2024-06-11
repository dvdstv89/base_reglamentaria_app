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
    internal class ClasificacionDocumentacionUIController : BaseUIController<ClasificacionDocumentacionUI>, IForm
    {
        private static ClasificacionDocumentacionUIController instance;

        private readonly IClasificacionDocumentacionService clasificacionDocumentacionService;
        ListViewItem itemSeleccionado;
        int indexItemSeleccionado = -1;
        
        private List<ClasificacionDocumentacion> clasificacionDocumentacionList;

        private ClasificacionDocumentacionUIController() : base(new ClasificacionDocumentacionUI())
        {
            clasificacionDocumentacionService = AplicationAdminConfig.Component.Component.ClasificacionDocumentacionService;          
        }

        public override ClasificacionDocumentacionUI ejecutar()
        {           
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;           

            forma.listViewClasificacion.SelectedIndexChanged += listView_SelectedIndexChanged;
            forma.listViewClasificacion.MouseDoubleClick += listView_MouseDoubleClick;
            forma.listViewClasificacion.Layout += resizeMenusList;          


            forma.nuevoStripMenuItem1.Click += new EventHandler(nuevoStripMenuItem1_Click);
            forma.modificarStripMenuItem2.Click += new EventHandler(modificarToolStripMenuItem_Click);
            forma.eliminarToolStripMenuItem.Click += new EventHandler(eliminarToolStripMenuItem_Click);          
           

            return base.ejecutar();
        }       

        private void nuevoStripMenuItem1_Click(object sender, EventArgs e)
        {
            var clasificacionDocumentacionUIController = new NewClasificacionDocumentacionUIController(null);
            DialogResult dialogResult = clasificacionDocumentacionUIController.ejecutar().ShowDialog();
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
            clasificacionDocumentacionList = clasificacionDocumentacionService.GetAll();           
            forma.listViewClasificacion.Items.Clear();
            foreach (ClasificacionDocumentacion clasificacion in clasificacionDocumentacionList)
            {
                var item = new ListViewItem(clasificacion.TipoDocumentacion.Name);
                item.SubItems.Add(clasificacion.MenuDocumental.Name);
                item.Tag = clasificacion;
                forma.listViewClasificacion.Items.Add(item);
            }
            desmarcarItems();
        }       

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.listViewClasificacion.SelectedItems.Count == 1)
            {
                marcarItems();
            }
            else
            {
                desmarcarItems();
            }
        }
      
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            modificarMenus(getItemSeleccionado(), clasificacionDocumentacionList.FindIndex(doc => doc.Id == getItemSeleccionado().Id));
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clasificacionDocumentacionService.Delete(getItemSeleccionado().Id);
            updateList();
        }       

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {              
                modificarMenus(getItemSeleccionado(), clasificacionDocumentacionList.FindIndex(doc => doc.Id == getItemSeleccionado().Id));
            }
        }
        
        private void modificarMenus(ClasificacionDocumentacion clasificacion, int posicion)
        {
            var clasificacionDocumentacionUIController = new NewClasificacionDocumentacionUIController(clasificacion);         
            DialogResult dialogResult = clasificacionDocumentacionUIController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateList();
            }
        }
       
        private void marcarItems()
        {
            itemSeleccionado = forma.listViewClasificacion.SelectedItems[0];
            indexItemSeleccionado = forma.listViewClasificacion.Items.IndexOf(itemSeleccionado);
            forma.modificarStripMenuItem2.Enabled = true;
            forma.eliminarToolStripMenuItem.Enabled = true;           
        }
      
        private void desmarcarItems()
        {
            forma.modificarStripMenuItem2.Enabled = false;
            forma.eliminarToolStripMenuItem.Enabled = false;          
            itemSeleccionado = null;
            forma.listViewClasificacion.SelectedItems.Clear();           
        }    
      
        private ClasificacionDocumentacion getItemSeleccionado()
        {
            return getListViewItemSeleccionado<ClasificacionDocumentacion>(itemSeleccionado);
        }
     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateList();
            txtSearch_TextChanged(forma.tbBuscar.Text, forma.listViewClasificacion);
        }
      
        private void resizeMenusList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.listViewClasificacion.Width - 25;          
            forma.columnTipoDocumentacion.Width = RoundNumber((totalWidth * 0.5));
            forma.columnMenuDocumental.Width = RoundNumber((totalWidth * 0.5));
        }       

        public static ClasificacionDocumentacionUIController Instance
        {
            get
            {
                //instance = (instance == null) ? new TipoGrupoDocumentacionUIController() : instance;
                //return instance;
                return new ClasificacionDocumentacionUIController();
            }
        }
    }
}
