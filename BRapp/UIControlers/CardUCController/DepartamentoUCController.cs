using BRapp.Model.Tiendas;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class DepartamentoUCController : BaseUCController<DepartamentoCard, Departamento>, ICard
    {
        private readonly VisorDocumentacionUIController visorDocumentacionUIController;
        public DepartamentoUCController(Departamento departamento) : base(new DepartamentoCard(), departamento)
        {
            this.visorDocumentacionUIController = new VisorDocumentacionUIController(departamento);
        }

        public override UserControl get()
        {
            card.btnList.Click += new EventHandler(btnList_Click);          
            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.Name;
            card.btnList.Visible= objeto.TipoGrupoDocumentacion.Count > 0 || !String.IsNullOrEmpty(objeto.Descripcion);
        }        

        private void btnList_Click(object sender, EventArgs e)
        {
            visorDocumentacionUIController.showDialog();
        }
    }
}
