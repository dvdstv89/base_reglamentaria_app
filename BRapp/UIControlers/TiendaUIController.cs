using BRapp.UI;
using BRapp.Enums.EnumsInstances;
using System.Collections.Generic;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;

namespace BRapp.UIControlers
{

    internal class TiendaUIController : BaseUIController<TiendaUI>, IForm
    {
        private static Dictionary<TipoTiendaInstance, TiendaUIController> instances = new Dictionary<TipoTiendaInstance, TiendaUIController>();        
        private readonly ITiendaService iTiendasService;
        private readonly TipoTiendaInstance tipoTiendaInstance;
        private TiendaUIController(TipoTiendaInstance tipoTiendaInstance) : base(new TiendaUI())
        {
            this.tipoTiendaInstance = tipoTiendaInstance;
            iTiendasService = TiendasService.GetInstance(tipoTiendaInstance);
        }

        public override TiendaUI ejecutar()
        {                     
            return base.ejecutar();
        }

        protected override void aplicarTema()
        {
           
        }       

        public static TiendaUIController GetInstance(TipoTiendaInstance parametro)
        {
            if (!instances.ContainsKey(parametro))
            {
                instances[parametro] = new TiendaUIController(parametro);
            }
            return instances[parametro];
        }       
    }
}
