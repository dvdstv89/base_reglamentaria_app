using BRapp.Services;
using BRapp.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers
{
    internal class SistemaUIController : BaseUIController<SistemaUI>, IForm
    {
        private static SistemaUIController instance;
        private readonly SistemasService sistemasService;
        private SistemaUIController() : base(new SistemaUI())
        {
            sistemasService = SistemasService.Instance;
        }

        public override SistemaUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
           
        }       

        public static SistemaUIController Instance
        {
            get
            {
                instance = (instance == null) ? new SistemaUIController() : instance;
                return checkInstanceStatus(instance);
            }
        }

        private static SistemaUIController checkInstanceStatus(SistemaUIController instance)
        {
            if (instance.forma.IsDisposed)
            {
                instance.forma = new SistemaUI();
            }
            return instance;
        }

    }
}
