using BRapp.Services;
using BRapp.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers
{
    internal class ContratoUIController : BaseUIController<ContratoUI>, IForm
    {
        private static ContratoUIController instance;
        private readonly ContratoService contratoService;
        private ContratoUIController() : base(new ContratoUI())
        {
            contratoService = ContratoService.Instance;
        }

        public override ContratoUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
           
        }      

        public static ContratoUIController Instance
        {
            get
            {
                instance = (instance == null) ? new ContratoUIController() : instance;
                return checkInstanceStatus(instance);
            }
        }

        private static ContratoUIController checkInstanceStatus(ContratoUIController instance)
        {
            if (instance.forma.IsDisposed)
            {
                instance.forma = new ContratoUI();
            }
            return instance;
        }

    }
}
