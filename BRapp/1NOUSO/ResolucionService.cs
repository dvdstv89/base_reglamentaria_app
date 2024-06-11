using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class ResolucionService : BaseService<Resolucion, ResolucionDto>, IResolucionService
    {    
        public ResolucionService(IResolucionDtoRepository resolucionDtoRepository) : base(resolucionDtoRepository) { }

    }
}
