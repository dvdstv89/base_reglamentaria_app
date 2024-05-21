using BRapp.Model;
using System;

namespace BRapp.Services.Interfaces
{
    public interface IVisorPDFService
    {
        DocumentoPDF getDocumentoPDFApliado(Guid id);
    }
}
