using BRapp.Messages;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using ComplejoUI = BRappAdmin.UI.ComplejoUI;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class ComplejoUIController : BaseUIController<ComplejoUI>, IForm
    {
        private static ComplejoUIController instance;
        private readonly IComplejoService complejoService;
        private readonly ITiendaService tiendaService;
        private readonly IDepartamentoService departamentoService;

        ListViewItem itemComplejoSeleccionado;
        ListViewItem itemDepartamentoSeleccionado;
        ListViewItem itemTiendaSeleccionado;
        int indexItemComplejoSeleccionado = -1;
        int indexItemDepartamentoSeleccionado = -1;
        int indexItemTiendaSeleccionado = -1;
        private List<Complejo> complejos;
        private List<Departamento> departamentos;
        private List<Tienda> tiendas;

        private ComplejoUIController() : base(new ComplejoUI())
        {
            complejoService = ComplejoService.Instance;
            tiendaService = TiendasService.Instance;
            departamentoService = DepartamentoService.Instance;          
    }

    public override ComplejoUI ejecutar()
        {
            forma.tbBuscarComplejo.TextChanged += txtSearchComplejo_TextChanged;
            forma.tbBuscarDepartamento.TextChanged += txtSearchDepartamento_TextChanged;
            forma.tbBuscarTienda.TextChanged += txtSearchTienda_TextChanged;

            forma.lwComplejos.SelectedIndexChanged += lwComplejo_SelectedIndexChanged;
            forma.lwDepartamentos.SelectedIndexChanged += lwDepartamento_SelectedIndexChanged;
            forma.lwTiendas.SelectedIndexChanged += lwTienda_SelectedIndexChanged;

            forma.lwComplejos.MouseDoubleClick += lwComplejo_MouseDoubleClick;
            forma.lwDepartamentos.MouseDoubleClick += lwDepartamento_MouseDoubleClick;
            forma.lwTiendas.MouseDoubleClick += lwTiendas_MouseDoubleClick;

            forma.modificarComplejoToolStripMenuItem.Click += new EventHandler(modificarComplejoToolStripMenuItem_Click);
            forma.modificarDapartamentoToolStripMenuItem.Click += new EventHandler(modificarDepartamentoToolStripMenuItem_Click);
            forma.modificarTiendaToolStripMenuItem.Click += new EventHandler(modificarTiendaToolStripMenuItem_Click);

            forma.nuevoComplejoToolStripMenuItem.Click += new EventHandler(nuevoComplejoToolStripMenuItem_Click);
            forma.nuevoDepartamentoToolStripMenuItem.Click += new EventHandler(nuevoDepartamentoToolStripMenuItem_Click);
            forma.nuevaTiendaToolStripMenuItem.Click += new EventHandler(nuevoTiendaToolStripMenuItem_Click);

            forma.subirComplejoToolStripMenuItem.Click += new EventHandler(subirComplejoToolStripMenuItem_Click);
            forma.bajarComplejoToolStripMenuItem.Click += new EventHandler(bajarComplejoToolStripMenuItem_Click);

            forma.subirDepartamentoToolStripMenuItem.Click += new EventHandler(subirDepartamentoToolStripMenuItem_Click);
            forma.bajarDepartamentoToolStripMenuItem.Click += new EventHandler(bajarDepartamentoToolStripMenuItem_Click);

            forma.subirTiendaToolStripMenuItem.Click += new EventHandler(subirTiendaToolStripMenuItem_Click);
            forma.bajarTiendaToolStripMenuItem.Click += new EventHandler(bajarTiendaToolStripMenuItem_Click);


            forma.lwComplejos.Layout += resizeListComplejo;
            forma.lwDepartamentos.Layout += resizeListDepartamento;
            forma.lwTiendas.Layout += resizeListTienda;

            forma.Resize += Forma_Resize;
            return base.ejecutar();
        }      
        protected override void initDataForm()
        {
            updateListComplejos();
        }


        private void nuevoComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarComplejo(null, complejos.Count+1);
        }
        private void nuevoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarDepartamento(null, departamentos.Count+1);
        }
        private void nuevoTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTienda(null, tiendas.Count+1);
        }


        private void modificarComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            modificarComplejo(getComplejoSeleccionado(), complejos.FindIndex(doc => doc.Id == getComplejoSeleccionado().Id));
        }
        private void modificarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarDepartamento(getDepartamentoSeleccionado(), departamentos.FindIndex(doc => doc.Id == getDepartamentoSeleccionado().Id));
        }
        private void modificarTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTienda(getTiendaSeleccionado(), tiendas.FindIndex(doc => doc.Id == getTiendaSeleccionado().Id));
        }


        private void lwComplejo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Complejo complejo = getComplejoSeleccionado();
                if (complejo != null)
                {
                    modificarComplejo(complejo, complejos.FindIndex(doc => doc.Id == complejo.Id));
                }
            }
        }
        private void lwDepartamento_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Departamento departamento = getDepartamentoSeleccionado();
                if (departamento != null)
                {
                    modificarDepartamento(departamento, departamentos.FindIndex(doc => doc.Id == departamento.Id));
                }
            }
        }
        private void lwTiendas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Tienda tienda = getTiendaSeleccionado();
                if(tienda != null)
                {
                    modificarTienda(getTiendaSeleccionado(), tiendas.FindIndex(doc => doc.Id == tienda.Id));
                }                
            }
        }

        private void lwComplejo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwComplejos.SelectedItems.Count == 1)
            {
                marcarComplejo();
                updateListDepartamentos();
                updateListTiendas();
            }
            else
            {
                desmarcarDepartamento();
                desmarcarTienda();
                desmarcarComplejo();
                forma.lwDepartamentos.Items.Clear();
                forma.lwTiendas.Items.Clear();
            }
        }
        private void lwDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwDepartamentos.SelectedItems.Count == 1)
            {
                marcarDepartamento();
            }
            else
            {
                desmarcarDepartamento();
            }
        }
        private void lwTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwTiendas.SelectedItems.Count == 1)
            {
                marcarTienda();
            }
            else
            {
                desmarcarTienda();
            }
        }


        private void updateListComplejos()
        {
            complejos = complejoService.getAll();
            complejos = complejos.OrderBy(t => t.Orden).ToList();
            forma.lwComplejos.Items.Clear();
            foreach (Complejo papel in complejos)
            {
                var item = new ListViewItem(papel.ToString());               
                item.Tag = papel;
                forma.lwComplejos.Items.Add(item);
            }
            desmarcarComplejo();
        }
        private void updateListDepartamentos()
        {
            departamentos = departamentoService.getDepartamentosByComplejo(getComplejoSeleccionado());
            departamentos = departamentos.OrderBy(t => t.Orden).ToList();
            forma.lwDepartamentos.Items.Clear();
            foreach (Departamento papel in departamentos)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwDepartamentos.Items.Add(item);
            }
            desmarcarDepartamento();
        }
        private void updateListTiendas()
        {
            tiendas = tiendaService.getTiendasByComplejo(getComplejoSeleccionado());
            tiendas= tiendas.OrderBy(t=> t.Orden).ToList();

            forma.lwTiendas.Items.Clear();
            foreach (Tienda papel in tiendas)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwTiendas.Items.Add(item);
            }
            desmarcarTienda();
        }

       
        private void modificarComplejo(Complejo complejo, int posicion)
        {
            var papelUiController = new NewComplejoUIController(complejo, posicion);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarComplejo.Text = "";
                updateListComplejos();
            }
        }
        private void modificarDepartamento(Departamento departamento, int posicion)
        {
            var papelUiController = new NewDepartamentoUIController(departamento, getComplejoSeleccionado(), posicion);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDepartamento.Text = "";
                updateListDepartamentos();
            }
        }
        private void modificarTienda(Tienda tienda, int posicion)
        {
            var papelUiController = new NewTiendasUIController(tienda, getComplejoSeleccionado(), posicion);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarTienda.Text = "";
                updateListTiendas();
            }
        }

        private void marcarComplejo()
        {
            itemComplejoSeleccionado = forma.lwComplejos.SelectedItems[0];
            indexItemComplejoSeleccionado = forma.lwComplejos.Items.IndexOf(itemComplejoSeleccionado);
            forma.modificarComplejoToolStripMenuItem.Enabled = true;
            forma.panelTiendas.Enabled = true;
            forma.panelDepartamentos.Enabled = true;

            forma.subirComplejoToolStripMenuItem.Visible = indexItemComplejoSeleccionado > 0;
            forma.bajarComplejoToolStripMenuItem.Visible = indexItemComplejoSeleccionado < forma.lwComplejos.Items.Count - 1;
        }
        private void marcarDepartamento()
        {
            itemDepartamentoSeleccionado = forma.lwDepartamentos.SelectedItems[0];
            indexItemDepartamentoSeleccionado = forma.lwDepartamentos.Items.IndexOf(itemDepartamentoSeleccionado);
            forma.modificarDapartamentoToolStripMenuItem.Enabled = true;

            forma.subirDepartamentoToolStripMenuItem.Visible = indexItemDepartamentoSeleccionado > 0;
            forma.bajarDepartamentoToolStripMenuItem.Visible = indexItemDepartamentoSeleccionado < forma.lwDepartamentos.Items.Count - 1;
        }
        private void marcarTienda()
        {
            itemTiendaSeleccionado = forma.lwTiendas.SelectedItems[0];
            indexItemTiendaSeleccionado = forma.lwTiendas.Items.IndexOf(itemTiendaSeleccionado);
            forma.modificarTiendaToolStripMenuItem.Enabled = true;

            forma.subirTiendaToolStripMenuItem.Visible = indexItemTiendaSeleccionado > 0;
            forma.bajarTiendaToolStripMenuItem.Visible = indexItemTiendaSeleccionado < forma.lwTiendas.Items.Count - 1;
        }

        private void desmarcarComplejo()
        {
            forma.modificarComplejoToolStripMenuItem.Enabled = false;
            itemComplejoSeleccionado = null;
            forma.lwComplejos.SelectedItems.Clear();
            forma.panelTiendas.Enabled = false;
            forma.panelDepartamentos.Enabled = false;
            forma.subirComplejoToolStripMenuItem.Visible = false;
            forma.bajarComplejoToolStripMenuItem.Visible = false;
            forma.subirDepartamentoToolStripMenuItem.Visible = false;
            forma.bajarDepartamentoToolStripMenuItem.Visible = false;
            forma.subirTiendaToolStripMenuItem.Visible = false;
            forma.bajarTiendaToolStripMenuItem.Visible = false;
        }
        private void desmarcarDepartamento()
        {
            forma.modificarDapartamentoToolStripMenuItem.Enabled = false;
            itemDepartamentoSeleccionado = null;
            forma.lwDepartamentos.SelectedItems.Clear();
            forma.subirDepartamentoToolStripMenuItem.Visible = false;
            forma.bajarDepartamentoToolStripMenuItem.Visible = false;
        }
        private void desmarcarTienda()
        {
            forma.modificarTiendaToolStripMenuItem.Enabled = false;
            itemTiendaSeleccionado = null;
            forma.lwTiendas.SelectedItems.Clear();
            forma.subirTiendaToolStripMenuItem.Visible = false;
            forma.bajarTiendaToolStripMenuItem.Visible = false;
        }
       
        private Complejo getComplejoSeleccionado()
        {
            return getListViewItemSeleccionado<Complejo>(itemComplejoSeleccionado);            
        }
        private Departamento getDepartamentoSeleccionado()
        {
            return getListViewItemSeleccionado<Departamento>(itemDepartamentoSeleccionado);            
        }
        private Tienda getTiendaSeleccionado()
        {
            return getListViewItemSeleccionado<Tienda>(itemTiendaSeleccionado);
        }

        private void resizeListComplejo(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwComplejos.Width - 25;
            forma.columnNameComplejo.Width = RoundNumber((totalWidth * 1));           
        }
        private void resizeListDepartamento(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwDepartamentos.Width - 25;
            forma.columnNombreDepartamento.Width = RoundNumber((totalWidth * 1));
        }
        private void resizeListTienda(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTiendas.Width - 25;
            forma.columnNombreTienda.Width = RoundNumber((totalWidth * 1));
        }

        private void txtSearchComplejo_TextChanged(object sender, EventArgs e)
        {
            updateListComplejos();
            txtSearch_TextChanged(forma.tbBuscarComplejo.Text, forma.lwComplejos);
        }
        private void txtSearchDepartamento_TextChanged(object sender, EventArgs e)
        {
            updateListDepartamentos();
            txtSearch_TextChanged(forma.tbBuscarDepartamento.Text, forma.lwDepartamentos);
        }
        private void txtSearchTienda_TextChanged(object sender, EventArgs e)
        {
            updateListTiendas();
            txtSearch_TextChanged(forma.tbBuscarTienda.Text, forma.lwTiendas);
        }

        private void subirComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            int ordenActual = getComplejoSeleccionado().Orden;
            cambiarOrdenComplejo(itemComplejoSeleccionado, ordenActual - 1);
            cambiarOrdenComplejo(forma.lwComplejos.Items[indexItemComplejoSeleccionado - 1], ordenActual);
            txtSearchComplejo_TextChanged(sender, e);
        }
        private void bajarComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getComplejoSeleccionado().Orden;
            cambiarOrdenComplejo(itemComplejoSeleccionado, ordenActual + 1);
            cambiarOrdenComplejo(forma.lwComplejos.Items[indexItemComplejoSeleccionado + 1], ordenActual);
            txtSearchComplejo_TextChanged(sender, e);
        }
        private void cambiarOrdenComplejo(ListViewItem item, int orden)
        {
            Complejo grupo = getListViewItemSeleccionado<Complejo>(item);
            grupo.Orden = orden;
            complejoService.saveOrUpdate(grupo);
        }

        private void subirTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getTiendaSeleccionado().Orden;
            cambiarOrdenTienda(itemTiendaSeleccionado, ordenActual - 1);
            cambiarOrdenTienda(forma.lwTiendas.Items[indexItemTiendaSeleccionado - 1], ordenActual);
            txtSearchTienda_TextChanged(sender, e);

        }
        private void bajarTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getTiendaSeleccionado().Orden;
            cambiarOrdenTienda(itemTiendaSeleccionado, ordenActual + 1);
            cambiarOrdenTienda(forma.lwTiendas.Items[indexItemTiendaSeleccionado + 1], ordenActual);
            txtSearchTienda_TextChanged(sender, e);
        }
        private void cambiarOrdenTienda(ListViewItem item, int orden)
        {
            Tienda grupo = getListViewItemSeleccionado<Tienda>(item);
            grupo.Orden = orden;
            tiendaService.saveOrUpdate(grupo);
        }

        private void subirDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ordenActual = getDepartamentoSeleccionado().Orden;
            cambiarOrdenDepartamento(itemDepartamentoSeleccionado, ordenActual - 1);
            cambiarOrdenDepartamento(forma.lwDepartamentos.Items[indexItemDepartamentoSeleccionado - 1], ordenActual);
            txtSearchDepartamento_TextChanged(sender, e);
        }
        private void bajarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            int ordenActual = getDepartamentoSeleccionado().Orden;
            cambiarOrdenDepartamento(itemDepartamentoSeleccionado, ordenActual + 1);
            cambiarOrdenDepartamento(forma.lwDepartamentos.Items[indexItemDepartamentoSeleccionado + 1], ordenActual);
            txtSearchDepartamento_TextChanged(sender, e);
        }
        private void cambiarOrdenDepartamento(ListViewItem item, int orden)
        {
            Departamento grupo = getListViewItemSeleccionado<Departamento>(item);
            grupo.Orden = orden;
            departamentoService.saveOrUpdate(grupo);
        }

        private void Forma_Resize(object sender, EventArgs e)
        {
            int totalWidth = forma.Width - 5;
            int width = RoundNumber((totalWidth / 2));
            forma.panelTiendaAfuera.Width = width;
            forma.panelDptoAfuera.Width = width;
        }
        public static ComplejoUIController Instance
        {
            get
            {
                instance = (instance == null) ? new ComplejoUIController() : instance;
                return instance;
            }
        }
    }
}
