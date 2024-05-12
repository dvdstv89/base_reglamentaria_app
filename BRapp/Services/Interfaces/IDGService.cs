using BRapp.Dto;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    internal interface IDGService
    {
        DGDto getByPapel(PapelDto papel);
        bool saveOrUpdate(DG papel);
        DocumentoPDF getDocumentoPDFApliado(DG dg);
    }
}
