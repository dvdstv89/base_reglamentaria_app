using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface IContratoService
    {
        DocumentoPDF getDocumentoPDFApliado(Contrato contrato);
        ContratoDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(Contrato papel);
        void Delete(Contrato papel);
    }
}
