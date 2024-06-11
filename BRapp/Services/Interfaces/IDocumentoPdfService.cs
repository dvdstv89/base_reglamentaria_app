using BRapp.Utiles;
using System;
using BRapp.Model;

namespace BRapp.Services.Interfaces
{
    public interface IDocumentoPdfService
    {
        DocumentoPDF GetById(Guid id);
        DocumentoPDFBlob GetDocumentoPDFApliado(Guid id);
        ActionResult SaveOrUpdate(ArchivoPDF tipo);
        ActionResult Delete(Guid id); 
    }
}
