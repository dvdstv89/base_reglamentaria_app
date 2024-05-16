using BRapp.Dto;
using BRapp.Model;
using BRapp.Utiles;

namespace BRapp.Services.Interfaces
{
    public interface IDGService
    {
        DGDto getByPapel(PapelDto papel);
        ActionResult saveOrUpdate(DG papel);
        DocumentoPDF getDocumentoPDFApliado(DG dg);
    }
}
