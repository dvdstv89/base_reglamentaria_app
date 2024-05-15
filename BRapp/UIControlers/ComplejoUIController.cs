using BRapp.UI;
using System.Collections.Generic;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.Model.Tiendas;
using System.IO;
using System.Drawing;

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
            //lista de pepartamentos

            List<Departamento> departamentos = departamentoService.getDepartamentosByComplejo(complejo);
            //forma.panelDepartamentos;

            //lista de tiendas
            List<Tienda> tiedas = tiendaService.getTiendasByComplejo(complejo);
            //forma.panelTiendas;


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
