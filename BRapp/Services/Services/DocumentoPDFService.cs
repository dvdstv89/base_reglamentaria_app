using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;

namespace BRapp.Services.Services
{
    public class DocumentoPDFService : IDocumentoPdfService
    {
        private readonly IDocumentoPdfRepository documentoPdfRepository;
        private readonly IDocumentoPdfBlobRepository documentoPdfBlobRepository;
        public DocumentoPDFService(IDocumentoPdfRepository documentoPdfRepository, IDocumentoPdfBlobRepository documentoPdfBlobRepository) 
        { 
            this.documentoPdfRepository = documentoPdfRepository;
            this.documentoPdfBlobRepository= documentoPdfBlobRepository;
        }

        public ActionResult Delete(Guid id)
        {
            documentoPdfRepository.DeleteById(id);
            return documentoPdfBlobRepository.DeleteById(id);
        }

        public DocumentoPDFBlob GetDocumentoPDFApliado(Guid id)
        {
            return documentoPdfBlobRepository.GetById(id);
        }

        public DocumentoPDF GetById(Guid id)
        {
           return documentoPdfRepository.GetById(id);
        }

        public ActionResult SaveOrUpdate(ArchivoPDF tipo)
        {
            documentoPdfBlobRepository.SaveOrUpdate(tipo.GetDocumentoPDFBlob());
            ActionResult result = documentoPdfRepository.SaveOrUpdate(tipo.GetDocumentoPDF());
            tipo.CleanData();
            return result;
        }
    }
}
