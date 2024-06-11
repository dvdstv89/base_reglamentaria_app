using BRapp.Model;
using System;

namespace BRapp.Services.Interfaces
{
    public interface IVisorPDFService
    {
        DocumentoPDFBlob GetDocumentoPDFApliado(Guid id);
    }
}
