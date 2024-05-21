using BRapp.Data;
using BRapp.UI;
using System;

namespace BRapp.UIControlers
{
    internal class ConsultorUIController : BaseUIController<ConsultorUI>, IForm
    {
        private static ConsultorUIController instance;
      
        private ConsultorUIController() : base(new ConsultorUI())
        {
           
        }

        protected override void forma_Load(object sender, EventArgs e)
        {
            base.forma_Load(sender, e);


            forma.webView21.Source = new Uri(AplicationConfig.ConsultorWeb);
            
        }

        public static ConsultorUIController Instance
        {
            get
            {
                instance = (instance == null) ? new ConsultorUIController() : instance;
                return instance;
            }
        }
    }
}
