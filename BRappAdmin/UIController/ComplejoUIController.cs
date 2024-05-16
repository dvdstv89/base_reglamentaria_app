using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Messages;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComplejoUI = BRappAdmin.UI.ComplejoUI;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace BRappAdmin.UIControlers
{
    internal class ComplejoUIController : BaseUIController<ComplejoUI>, IForm
    {
        private static ComplejoUIController instance;
        private readonly IComplejoServiceAdmin complejoService;
        private readonly ITiendaServiceAdmin tiendaService;
        private readonly IDepartamentoServiceAdmin departamentoService;


        ListViewItem itemComplejoSeleccionado;
        ListViewItem itemDepartamentoSeleccionado;
        ListViewItem itemTiendaSeleccionado;

        private readonly IFileService fileLogoService;
        private readonly IFileService filePdfService;
        private List<Complejo> complejos;
        private List<Departamento> departamentos;
        private List<Tienda> tiendas;

        private ComplejoUIController() : base(new ComplejoUI())
        {
            complejoService = ComplejoServiceAdmin.Instance;
            tiendaService = TiendaServiceAdmin.Instance;
            departamentoService = DepartamentoServiceAdmin.Instance;
            fileLogoService = new FileService();
            filePdfService = new FileService();
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
            modificarComplejo(null);
        }
        private void nuevoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarDepartamento(null);
        }
        private void nuevoTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTienda(null);
        }


        private void modificarComplejoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            modificarComplejo(getComplejoSeleccionado());
        }
        private void modificarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarDepartamento(getDepartamentoSeleccionado());
        }
        private void modificarTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarTienda(getTiendaSeleccionado());
        }


        private void lwComplejo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Complejo complejo = getComplejoSeleccionado();
                if (complejo != null)
                {
                    modificarComplejo(complejo);
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
                    modificarDepartamento(departamento);
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
                    modificarTienda(getTiendaSeleccionado());
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
            forma.lwTiendas.Items.Clear();
            foreach (Tienda papel in tiendas)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwTiendas.Items.Add(item);
            }
            desmarcarTienda();
        }

       
        private void modificarComplejo(Complejo complejo)
        {
            var papelUiController = new NewComplejoUIController(complejo, fileLogoService);
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarComplejo.Text = "";
                updateListComplejos();
            }
        }
        private void modificarDepartamento(Departamento departamento)
        {
            var papelUiController = new NewDepartamentoUIController(departamento, getComplejoSeleccionado());
            DialogResult dialogResult = papelUiController.ejecutar().ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.PAPEL_SAVED_OK);
                forma.tbBuscarDepartamento.Text = "";
                updateListDepartamentos();
            }
        }
        private void modificarTienda(Tienda tienda)
        {
            var papelUiController = new NewTiendasUIController(tienda, fileLogoService, filePdfService, getComplejoSeleccionado());
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
            forma.modificarComplejoToolStripMenuItem.Enabled = true;
            forma.panelTiendas.Enabled = true;
            forma.panelDepartamentos.Enabled = true;
        }
        private void marcarDepartamento()
        {
            itemDepartamentoSeleccionado = forma.lwDepartamentos.SelectedItems[0];            
            forma.modificarDapartamentoToolStripMenuItem.Enabled = true;
        }
        private void marcarTienda()
        {
            itemTiendaSeleccionado = forma.lwTiendas.SelectedItems[0];           
            forma.modificarTiendaToolStripMenuItem.Enabled = true;
        }

        private void desmarcarComplejo()
        {
            forma.modificarComplejoToolStripMenuItem.Enabled = false;
            itemComplejoSeleccionado = null;
            forma.lwComplejos.SelectedItems.Clear();
            forma.panelTiendas.Enabled = false;
            forma.panelDepartamentos.Enabled = false;
        }
        private void desmarcarDepartamento()
        {
            forma.modificarDapartamentoToolStripMenuItem.Enabled = false;
            itemDepartamentoSeleccionado = null;
            forma.lwDepartamentos.SelectedItems.Clear();
        }
        private void desmarcarTienda()
        {
            forma.modificarTiendaToolStripMenuItem.Enabled = false;
            itemTiendaSeleccionado = null;
            forma.lwTiendas.SelectedItems.Clear();
        }
       
        private Complejo getComplejoSeleccionado()
        {
            try
            {
                return (Complejo)itemComplejoSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
        }
        private Departamento getDepartamentoSeleccionado()
        {
            try
            {
                return (Departamento)itemDepartamentoSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
        }
        private Tienda getTiendaSeleccionado()
        {
            try
            {
                return (Tienda)itemTiendaSeleccionado.Tag;
            }
            catch
            {
                return null;
            }
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
            string searchText = forma.tbBuscarComplejo.Text.ToLower();          
            foreach (ListViewItem item in forma.lwComplejos.Items)
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
                    forma.lwComplejos.Items.Remove(item);
                }
            }
        }
        private void txtSearchDepartamento_TextChanged(object sender, EventArgs e)
        {
            updateListDepartamentos();
            string searchText = forma.tbBuscarDepartamento.Text.ToLower();
            foreach (ListViewItem item in forma.lwDepartamentos.Items)
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
                    forma.lwDepartamentos.Items.Remove(item);
                }
            }
        }
        private void txtSearchTienda_TextChanged(object sender, EventArgs e)
        {
            updateListTiendas();
            string searchText = forma.tbBuscarTienda.Text.ToLower();
            foreach (ListViewItem item in forma.lwTiendas.Items)
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
                    forma.lwTiendas.Items.Remove(item);
                }
            }
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
