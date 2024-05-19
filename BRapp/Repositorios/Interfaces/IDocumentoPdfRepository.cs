using BRapp.Model;
using BRapp.Model.Tiendas;
using System;

namespace BRapp.Repositorios.Interfaces
{
    public interface IDocumentoPdfRepository
    {
        DocumentoPDF getDocumentoApliado(Guid id);
        DocumentoPDF getById(Guid id);
        bool saveOrUpdate(DocumentoPDF papel);
        void Delete(DocumentoPDF papel);
    }
}
