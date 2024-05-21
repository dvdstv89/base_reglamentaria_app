using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class DocumentoPdfMapper : IMapper
    {      
        private readonly IFileService fileService;

        public DocumentoPdfMapper(IFileService fileService)
        {
            this.fileService = fileService;           
        }


        public object Map(SqliteDataReader reader) {
            string url = reader["pdf"].ToString();
            string image = reader["image"].ToString();

            Fichero ficheroPdf = fileService.extraerFichero(url);
            Fichero logoPdf = fileService.extraerFichero(image);

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
