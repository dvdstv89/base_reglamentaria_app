using BRapp.UI;
using System.Collections.Generic;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.Model.Tiendas;
using System.IO;
using System.Drawing;
using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.CardUCController;
using System.Windows.Forms;

namespace BRapp.UIControlers
{

    internal class ComplejoUIController : BaseUIController<ComplejoUI>, IForm
    {
        private static Dictionary<Complejo, ComplejoUIController> instances = new Dictionary<Complejo, ComplejoUIController>();        
        private readonly ITiendaService tiendaService;
        private readonly IDepartamentoService departamentoService;
        private readonly Complejo complejo;
        private ComplejoUIController(Complejo complejo) : base(new ComplejoUI(), true)
        {
            this.complejo = complejo;
            tiendaService = TiendasService.Instance;
            departamentoService = DepartamentoService.Instance;
        }

        public override ComplejoUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {         
            if (complejo.hasImagen())
            {
                forma.pictureBoxOrganigramaEmpresa.BackgroundImage = Image.FromStream(new MemoryStream(complejo.Organigrama.Data));
            }
            //lista de departamentos
            LLenarListaDepartamentos();
            LLenarListaTiendas();
        }

        private void LLenarListaDepartamentos()
        {
            List<Departamento> departamentos = departamentoService.getDepartamentosByComplejo(complejo);
            forma.panelDepartamentos.Controls.Clear();
            foreach (Departamento departamento in departamentos)
            {
                ICard card = new DepartamentoUCController(departamento);
                card.setInfo();
                Control control = card.get();
                control.Tag = departamento;
                forma.panelDepartamentos.Controls.Add(control);               
            }
            ExtraSpaceCard extraCard = new ExtraSpaceCard();
            forma.panelDepartamentos.Controls.Add(extraCard);
        }
        private void LLenarListaTiendas()
        {
            List<Tienda> tiendas = tiendaService.getTiendasByComplejo(complejo);         
            forma.panelTiendas.Controls.Clear();
            foreach (Tienda tienda in tiendas)
            {              
                ICard card = new TiendaUCController(tienda);
                card.setInfo();
                Control control = card.get();
                control.Tag = tienda;
                forma.panelTiendas.Controls.Add(control);
            }
            ExtraSpaceCard extraCard = new ExtraSpaceCard();
            forma.panelTiendas.Controls.Add(extraCard);
        }

        public static ComplejoUIController GetInstance(Complejo complejo)
        {
            if (!instances.ContainsKey(complejo))
            {
                instances[complejo] = new ComplejoUIController(complejo);
            }
            return instances[complejo];
        }       
    }
}
