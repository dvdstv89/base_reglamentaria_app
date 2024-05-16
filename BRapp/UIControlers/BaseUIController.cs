using BRapp.Messages;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.UI;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRapp.UIControlers
{
    public class BaseUIController<Forma> where Forma : Form
    {
        protected Forma forma { get; set; }
        public bool dialogResultOk;
        public bool formularioModoModificar;
        private bool hasScrolls;
        public BaseUIController(Forma forma, bool hasScrolls = false)
        {
            try
            {
                this.forma = forma;
                this.dialogResultOk = false;
                this.hasScrolls = hasScrolls;
            }
            catch (Exception ex)
            {
                DialogUtil.EXCEPTION(ex.Message);
            }
        }
        protected virtual void forma_Load(object sender, EventArgs e)
        {
            aplicarTema();
            initDataForm();
        }
        protected virtual void aplicarTema()
        {
            return;
        }
        protected virtual void initDataForm()
        {
            return;
        }
        public virtual Forma ejecutar()
        {
            forma.Load += new EventHandler(forma_Load);
            return forma;
        }
        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                forma.Close();
                forma.DialogResult = DialogResult.Cancel;
                if (forma.Owner != null)
                {
                    forma.Owner.Enabled = true;
                }
                return;
            }
            catch (Exception ex)
            {
                DialogUtil.EXCEPTION(ex.Message);
            }
        }
        protected Forma getForma()
        {
            return forma;
        }
        public void cerrarFormulario()
        {
            try
            {
                if (forma.Owner != null)
                {
                    forma.Owner.Enabled = true;
                }
                forma.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void configurarFormularioComoPanel()
        {
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Top;
            forma.BringToFront();
        }
        public Form getForm()
        {
            return forma;
        }
        public DialogResult showDialog()
        {
            return ejecutar().ShowDialog();
        }
        public void show()
        {
            ejecutar().Show();
        }
        public void mostrar()
        {
            forma.Show();
        }
        public void hide()
        {
            forma.Hide();
        }
        public bool viewHasScrolls()
        {
            return hasScrolls;
        }
        protected int RoundNumber(double number)
        {
            return (int)Math.Round(number, MidpointRounding.ToEven);
        }

        protected void ConfigCombo<T>(ComboBox comboBox, List<T> datasourse)
        {
            comboBox.DataSource = datasourse;
            comboBox.DisplayMember = "COMBO";
            comboBox.ValueMember = "Id";
        }

        protected void seleccionarCombo<T>(ComboBox comboBox) where T : ISeleccionable
        {
            IEnumerable<T> datos = comboBox.DataSource as IEnumerable<T>;
            List<ISeleccionable> seleccionables = new List<ISeleccionable>();
            foreach (T elemento in datos)
            {
                seleccionables.Add(elemento);
            }
            var selectionDialog = new SeleccionarObjetoUIController(seleccionables);
            DialogResult dialogResult = selectionDialog.showDialog();
            ISeleccionable objetoSeleccionado = (dialogResult == DialogResult.OK)
                ? (ISeleccionable)selectionDialog.getForm().Tag
                : null;
            if (objetoSeleccionado != null)
            {
                comboBox.SelectedItem = objetoSeleccionado;
            }
        }

        protected T getListViewItemSeleccionado<T>(ListViewItem itemDocumentoSeleccionado)
        {
            object objeto = itemDocumentoSeleccionado !=null ? itemDocumentoSeleccionado.Tag: null;
            return objeto != null ? (T)objeto : default;
        }

        protected void txtSearch_TextChanged(string texto, ListView listView)
        {           
            string searchText = texto.ToLower();
            foreach (ListViewItem item in listView.Items)
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
                    listView.Items.Remove(item);
                }
            }
        }       
    }
}
