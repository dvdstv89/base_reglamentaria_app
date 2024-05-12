using BRapp.Dto;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    internal interface IContratoService
    {
        DocumentoPDF getDocumentoPDFApliado(Contrato contrato);
        ContratoDto getByPapel(PapelDto papel);
        bool saveOrUpdate(Contrato papel);
    }
}
