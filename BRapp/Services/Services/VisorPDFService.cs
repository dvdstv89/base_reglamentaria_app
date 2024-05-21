using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System;

namespace BRapp.Services.Services
{
    internal class VisorPDFService: IVisorPDFService
    {
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        public VisorPDFService(IDocumentoPdfRepository documentoPdfRepository)
        {
            this.documentoPdfRepository = documentoPdfRepository;
        }

        public DocumentoPDF getDocumentoPDFApliado(Guid id)
        {
            return documentoPdfRepository.getDocumentoApliado(id);
        }     
    }
}
