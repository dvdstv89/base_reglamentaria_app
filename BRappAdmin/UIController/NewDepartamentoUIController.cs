using BRapp.Enums;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewDepartamentoUIController : BaseUIController<NewDepartamentoUI>, IForm
    {        
        private readonly IDepartamentoServiceAdmin departamentoService;
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        private Departamento departamento;
        private Complejo complejo;

        public NewDepartamentoUIController(Departamento departamento, Complejo complejo) : base(new NewDepartamentoUI())
        {
            this.complejo= complejo;
            this.departamento = departamento;
            departamentoService = DepartamentoServiceAdmin.Instance;
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionServiceAdmin.Instance;
        }

        public override NewDepartamentoUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.lwTipos.Layout += resizeListTipoGrupoDocumentacion;
            return base.ejecutar();
        }
        protected override void initDataForm()
        {
            updateListTipoGrupoDocumentacion();
            forma.cbTipo.DataSource = Enum.GetValues(typeof(TipoDepartamento));
            forma.tbComplejo.Text = complejo.ToString();
            if (departamento != null)
            {
                checkListTipoGrupoDocumentacion();
                forma.tbName.Text = departamento.Name;
                forma.cbTipo.Text = departamento.DepartamentoTipo.ToString();
            }
        }

        private void updateListTipoGrupoDocumentacion()
        {
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = tipoGrupoDocumentacionService.getAll();
            forma.lwTipos.Items.Clear();
            forma.lwTipos.Width++;
            foreach (TipoGrupoDocumentacion papel in tipoGrupoDocumentacions)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwTipos.Items.Add(item);
            }
        }
        private void checkListTipoGrupoDocumentacion()
        {
            foreach (ListViewItem item in forma.lwTipos.Items)
            {
                TipoGrupoDocumentacion tipoGrupoDocumentacion = (TipoGrupoDocumentacion)item.Tag;
                item.Checked = departamento.TipoGrupoDocumentacion.Exists(tipo => tipo.Id == tipoGrupoDocumentacion.Id);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            departamentoService.saveOrUpdate(departamento);
            forma.DialogResult = DialogResult.OK;
            forma.Close();
        }

        private void CapturarDatos()
        {
            string name = forma.tbName.Text;
            TipoDepartamento tipoDepartamento;
            Enum.TryParse(forma.cbTipo.Text, out tipoDepartamento);

            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = GetTipoGrupoDocumentacionsSelected();

            if (departamento != null)
            {
                departamento.Name = name;
                departamento.DepartamentoTipo = tipoDepartamento;
                departamento.TipoGrupoDocumentacion = tipoGrupoDocumentacions;
            }
            else
            {
                departamento = new Departamento(name, complejo, tipoDepartamento, tipoGrupoDocumentacions);
            }
        }

        private List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacionsSelected()
        {
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = new List<TipoGrupoDocumentacion>();
            foreach (var item in forma.lwTipos.Items)
            {
                ListViewItem listItem = (ListViewItem)item;
                if (listItem.Checked)
                {
                    if (listItem.Tag is TipoGrupoDocumentacion tipoGrupoDocumentacion)
                    {
                        tipoGrupoDocumentacions.Add(tipoGrupoDocumentacion);
                    }
                }
            }
            return tipoGrupoDocumentacions;
        }

        private void resizeListTipoGrupoDocumentacion(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTipos.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 1));
        }
    }
}
