using BRapp.Enums.EnumsInstances;
using BRapp.Services.Interfaces;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    internal class TiendasService: ITiendaService
    {
        private static Dictionary<TipoTiendaInstance, TiendasService> instances = new Dictionary<TipoTiendaInstance, TiendasService>();
        private readonly TipoTiendaInstance tipoTiendaInstance;      

        private TiendasService(TipoTiendaInstance tipoTiendaInstance)
        {
            this.tipoTiendaInstance = tipoTiendaInstance;
        }

        public static TiendasService GetInstance(TipoTiendaInstance parametro)
        {
            if (!instances.ContainsKey(parametro))
            {
                instances[parametro] = new TiendasService(parametro);
            }
            return instances[parametro];            
        }
    }
}
