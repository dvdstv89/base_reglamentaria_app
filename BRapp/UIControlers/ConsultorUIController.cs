using BRapp.Data;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using System;

namespace BRapp.UIControlers
{
    internal class ConsultorUIController : BaseUIController<ConsultorUI>, IForm
    {
        private static ConsultorUIController instance;
        private readonly IConsultorService iConsultorService;
        private ConsultorUIController() : base(new ConsultorUI())
        {
            iConsultorService = ConsultorService.Instance;
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
