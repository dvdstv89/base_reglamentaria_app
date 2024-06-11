using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;

namespace BRapp.Services.Services
{
    internal class CertificadoComercialService : BaseService<CertificadoComercial, CertificadoComercialDto>, ICertificadoComercialService
    {
        public CertificadoComercialService(ICertificadoComercialDtoRepository certificadoComercialDtoRepository): base(certificadoComercialDtoRepository) { }       
    }
}
