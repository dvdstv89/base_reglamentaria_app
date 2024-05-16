using BRapp.Model;
using System;

namespace BRapp.Repositorios.Interfaces
{
    public interface IDocumentoPdfRepository
    {
        DocumentoPDF getDocumentoApliado(Guid id);
        DocumentoPDF getById(Guid id);
        bool saveOrUpdate(DocumentoPDF papel);
    }
}
