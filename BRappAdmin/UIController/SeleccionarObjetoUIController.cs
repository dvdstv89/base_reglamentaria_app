using BRapp.Model;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class SeleccionarObjetoUIController : BaseUIController<SeleccionarObjetoUI>, IForm
    {      
        List<ISeleccionable> seleccionables;

        public SeleccionarObjetoUIController(List<ISeleccionable> seleccionables) : base(new SeleccionarObjetoUI())
        {              
            this.seleccionables= seleccionables;
        }

        public override SeleccionarObjetoUI ejecutar()
        {
            forma.lwPapeles.MouseDoubleClick += lwPapeles_MouseDoubleClick;
            forma.tbBuscar.TextChanged += txtSearch_TextChanged;
            return base.ejecutar();
        }      

        protected override void initDataForm()
        {
            updateList();
        }

        private void updateList()
        {           
            forma.lwPapeles.Items.Clear();
            foreach (ISeleccionable seleccionable in seleccionables)
            {
                var item = new ListViewItem(seleccionable.getNameSeleccionable());              
                item.Tag = seleccionable;
                forma.lwPapeles.Items.Add(item);
            }          
        }  

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateList();
            string searchText = forma.tbBuscar.Text.ToLower();          
            foreach (ListViewItem item in forma.lwPapeles.Items)
            {      
                if (!item.Text.ToLower().Contains(searchText))
                {
                    forma.lwPapeles.Items.Remove(item);                    
                }
            }
        }

        private void lwPapeles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (forma.lwPapeles.SelectedItems.Count > 0)
                {
                    object objetoSeleccionado = forma.lwPapeles.SelectedItems[0].Tag;
                    CerrarFormularioConObjeto(objetoSeleccionado);
                }
            }
        }

        private void CerrarFormularioConObjeto(object objeto)
        {
            forma.DialogResult = DialogResult.OK;
            forma.Tag = objeto;
            forma.Close();
        }
    }
}
