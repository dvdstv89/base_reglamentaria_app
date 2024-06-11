using BRapp.Data;
using BRapp.Services.Interfaces;
using BRapp.UI;

namespace BRapp.UIControlers
{
    public class BienvenidaUIController : BaseUIController<BienvenidaUI>, IForm
    {
        private static BienvenidaUIController instance;
        private readonly IBienvenidaService bienvenidaService;
        private BienvenidaUIController() : base(new BienvenidaUI())
        {
            bienvenidaService = AplicationConfig.Component.BienvenidaService;
        }

        public override BienvenidaUI ejecutar()
        {
            forma.bRichTextBox1.KeyPress += BRichTextBox1_TabIndexChanged;
            return base.ejecutar();
        }

        private void BRichTextBox1_TabIndexChanged(object sender, System.EventArgs e)
        {
            aplicarTema();
        }

        protected override void aplicarTema()
        {
            forma.bRichTextBox1.Rtf = bienvenidaService.GetBienvenida();           
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
