using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;

namespace BRappAdmin.UIControlers
{
    internal class TiendasUIController : BaseUIController<TiendasUI>, IForm
    {
        private static TiendasUIController instance;
        private readonly ITiendasServiceAdmin tiendasService;
       
        private TiendasUIController() : base(new TiendasUI())
        {
            tiendasService = TiendasServiceAdmin.Instance;            
        }

        public override TiendasUI ejecutar()
        {
            //forma.btnActualizar.Click += new EventHandler(iconButton1_Click);
            return base.ejecutar();
        }

        protected override void initDataForm()
        {
           
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
        }

        public static TiendasUIController Instance
        {
            get
            {
                return (instance == null) ? new TiendasUIController() : instance;
            }
        }

    }
}
