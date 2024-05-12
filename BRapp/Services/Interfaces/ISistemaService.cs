using BRapp.Dto;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    internal interface ISistemaService
    {
        DocumentoPDF getDocumentoPDFApliado(Sistema sistema);
        SistemaDto getByPapel(PapelDto papel);
        bool saveOrUpdate(Sistema papel);
    }
}
