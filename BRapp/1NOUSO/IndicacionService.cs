using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class IndicacionService : BaseService<Indicacion, IndicacionDto>, IIndicacionService
    {   
        public IndicacionService(IIndicacionDtoRepository dGDtoRepository) : base(dGDtoRepository) { }
    }
}
