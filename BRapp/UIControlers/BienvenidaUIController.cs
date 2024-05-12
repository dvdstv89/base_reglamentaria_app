using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;

namespace BRapp.UIControlers
{
    internal class BienvenidaUIController : BaseUIController<BienvenidaUI>, IForm
    {
        private static BienvenidaUIController instance;
        private readonly IBienvenidaService iBienvenidaService;
        private BienvenidaUIController() : base(new BienvenidaUI())
        {
            iBienvenidaService = BienvenidaService.Instance;
        }

        public override BienvenidaUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
           
        }       

        public static BienvenidaUIController Instance
        {
            get
            {
                return (instance == null) ? new BienvenidaUIController() : instance;                
            }
        }       
    }
}
