using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRapp.Messages;
using BRappAdmin.UI;
using BRappAdmin.UIController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class ContactosUIController : BaseUIController<ContactosUI>, IForm
    {
        private static ContactosUIController instance;
        private readonly IDirectorioService contactosService;
        ListViewItem itemSeleccionado;
        private List<Persona> personas;
        private ListViewColumnSorter columnSorter;

        private ContactosUIController() : base(new ContactosUI())
        {
            contactosService = DirectorioService.Instance;            
            columnSorter = new ListViewColumnSorter();
        }

        public override ContactosUI ejecutar()
        {
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;
            forma.lwPersonas.ColumnClick += ListView_ColumnClick;
            forma.lwPersonas.ListViewItemSorter = columnSorter;
            forma.lwPersonas.MouseDoubleClick += lwPersonas_MouseDoubleClick;
            forma.lwPersonas.SelectedIndexChanged += new EventHandler(lwPersonas_SelectedIndexChanged);
            forma.activarToolStripMenuItem.Click += new EventHandler(activarToolStripMenuItem_Click);
            forma.desactivarToolStripMenuItem.Click += new EventHandler(desactivarToolStripMenuItem_Click);
            forma.modificarToolStripMenuItem.Click += new EventHandler(modificarToolStripMenuItem_Click);
            forma.personaJuridicaToolStripMenuItem.Click += new EventHandler(personaJuridicaToolStripMenuItem_Click);
            forma.personaNaturalToolStripMenuItem.Click += new EventHandler(personaNaturalToolStripMenuItem_Click);
            forma.lwPersonas.Layout += resizeList;
            return base.ejecutar();
        }

        protected override void initDataForm()
        {            
            updateList();            
        }

        private void updateList()
        {
            personas = contactosService.getAll();
            forma.lwPersonas.Items.Clear();
            foreach (Persona persona in personas)
            {
                var item = new ListViewItem(persona.Name);
                item.SubItems.Add(persona.Email);
                item.SubItems.Add(persona.getPhonesNumber());
                item.SubItems.Add(persona.TipoPersona.ToString());
                item.SubItems.Add(persona.IsInterno.ToString());
                item.SubItems.Add(persona.IsActivo.ToString());
                item.Tag = persona;
                forma.lwPersonas.Items.Add(item);
            }
            desmarcarContacto();
        }

        private void lwPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forma.lwPersonas.SelectedItems.Count == 1)
            {
                marcarContacto();
            }
            else
            {
                desmarcarContacto();
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
            var persona = getPersonaSeleccionada();
            persona.IsActivo = activo;
            contactosService.saveOrUpdate(persona);
            DialogUtil.INFORMATION(Mensajes.CONTACTO_UPDATED_OK);
            updateList();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personaSeleccionada = getPersonaSeleccionada();
            modificarPersona(personaSeleccionada, personaSeleccionada.TipoPersona);
        }

        private void lwPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var personaSeleccionada = getPersonaSeleccionada();
                modificarPersona(personaSeleccionada, personaSeleccionada.TipoPersona);
            }
        }

        private void personaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarPersona(null, TipoPersona.JURIDICA);           
        }

        private void personaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarPersona(null, TipoPersona.NATURAL);
        }

        private void modificarPersona(Persona persona, TipoPersona tipoPersona)
        {
            var personaUiController = new PersonaUIController(persona, tipoPersona);
            DialogResult dialogResult = personaUiController.ejecutar().ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                DialogUtil.INFORMATION(Mensajes.CONTACTO_SAVED_OK);
                forma.tbBuscar.Text = "";
                updateList();
            }
        }

        private void marcarContacto()
        {
            itemSeleccionado = forma.lwPersonas.SelectedItems[0];          
            var personaSeleccionada = getPersonaSeleccionada();           
            forma.activarToolStripMenuItem.Visible = !personaSeleccionada.IsActivo;
            forma.desactivarToolStripMenuItem.Visible = personaSeleccionada.IsActivo;
            forma.modificarToolStripMenuItem.Enabled = true;
        }

        private void desmarcarContacto()
        {
            forma.activarToolStripMenuItem.Visible = false;
            forma.desactivarToolStripMenuItem.Visible = false;
            forma.modificarToolStripMenuItem.Enabled = false;
            itemSeleccionado = null;
            forma.lwPersonas.SelectedItems.Clear();
        }

        public static ContactosUIController Instance
        {
            get
            {
                return (instance == null) ? new ContactosUIController() : instance;
            }
        }

        private Persona getPersonaSeleccionada()
        {
            try
            {
                return (Persona)itemSeleccionado.Tag;
            }
            catch
            {
                return null;
            }           
        }

        private void resizeList(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwPersonas.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 0.2));
            forma.columnEmail.Width= RoundNumber((totalWidth * 0.3));
            forma.columnPhone.Width= RoundNumber((totalWidth * 0.2));
            forma.columnTipo.Width= RoundNumber((totalWidth * 0.1));
            forma.columnInterno.Width = RoundNumber((totalWidth * 0.1));
            forma.columnActivo.Width= RoundNumber((totalWidth * 0.1));
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSorter.Sort(forma.lwPersonas, e.Column);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateList();
            string searchText = forma.tbBuscar.Text.ToLower();
            foreach (ListViewItem item in forma.lwPersonas.Items)
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
                    forma.lwPersonas.Items.Remove(item);
                }
            }
        }
    }
}
