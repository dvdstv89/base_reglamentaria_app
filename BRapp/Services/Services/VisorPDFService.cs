using BRapp.Model;
using BRapp.Services.Interfaces;
using System;

namespace BRapp.Services.Services
{
    internal class VisorPDFService: IVisorPDFService
    {
        private readonly IDocumentoPdfService documentoPdfService;

        public VisorPDFService(IDocumentoPdfService documentoPdfService)
        {
            this.documentoPdfService = documentoPdfService;
        }

        public DocumentoPDFBlob GetDocumentoPDFApliado(Guid id)
        {
            return documentoPdfService.GetDocumentoPDFApliado(id);
        }     
    }
}
