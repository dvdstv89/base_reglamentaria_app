using BRapp.Model;
using BRapp.Services.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Text;

namespace BRapp.Mapper
{
    internal class DocumentoPdfBlobMapper : IMapper
    {
        public object Map(SqliteDataReader reader) {

            byte[] imagenData = Convert.FromBase64String(reader["blob_imagen"].ToString());           
            string image = reader["image"].ToString();
            Fichero logoPdf = new Fichero(image, imagenData);

            byte[] pdfData = Convert.FromBase64String(reader["blob_pdf"].ToString());
            string pdf = reader["pdf"].ToString();  
            Fichero ficheroPdf = new Fichero(pdf, pdfData);


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
