using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class SistemaService : BaseService<Sistema, SistemaDto>, ISistemaService
    {       
        public SistemaService(ISistemaDtoRepository sistemaDtoRepository) : base(sistemaDtoRepository) { }       
    }
}
