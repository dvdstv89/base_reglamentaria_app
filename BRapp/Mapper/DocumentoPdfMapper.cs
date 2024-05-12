using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DocumentoPdfMapper : IMapper
    {
        private readonly IFileService filePdfLogoService;
        private readonly IFileService filePdfDocumentService;

        public DocumentoPdfMapper(IFileService filePdfLogoService, IFileService filePdfDocumentService)
        {
            this.filePdfLogoService = filePdfLogoService;
            this.filePdfDocumentService = filePdfDocumentService;
        }


        public object Map(SqliteDataReader reader) {
            string url = reader["pdf"].ToString();
            string image = reader["image"].ToString();

            Fichero ficheroPdf = filePdfDocumentService.extraerFichero(url);
            Fichero logoPdf = filePdfLogoService.extraerFichero(image);

            DocumentoPDF documentoPDF = new DocumentoPDF
                   (
                      Guid.Parse(reader["id"].ToString()),
                      ficheroPdf,
                      logoPdf                                                
                   );
            return documentoPDF;
        }

        public object Map(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
