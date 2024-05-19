using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;

namespace BRapp.UIControlers
{
    internal class BienvenidaUIController : BaseUIController<BienvenidaUI>, IForm
    {
        private static BienvenidaUIController instance;
        private readonly IBienvenidaService bienvenidaService;
        private BienvenidaUIController() : base(new BienvenidaUI())
        {
            bienvenidaService = BienvenidaService.Instance;
        }

        public override BienvenidaUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
           forma.richTextBox1.Rtf = bienvenidaService.getBienvenida();
        }       

        public static BienvenidaUIController Instance
        {
            get
            {
                instance = (instance == null) ? new BienvenidaUIController() : instance;    
                return instance;
            }
        }       
    }
}
