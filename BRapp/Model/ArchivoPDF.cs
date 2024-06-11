using System;

namespace BRapp.Model
{
    public class ArchivoPDF
    {
        public Guid Id { get; set; } 
        public Fichero PDF { get; set; }
        public ArchivoPDF(Guid Id, Fichero PDF)
        {
            this.Id = Id;
            this.PDF = PDF;                  
        }

        public ArchivoPDF(Fichero PDF)
        {
            Id = Guid.NewGuid();
            this.PDF = PDF;
        }

        public DocumentoPDF GetDocumentoPDF()
        {
            return new DocumentoPDF(Id, PDF.Name);
        }
        public DocumentoPDFBlob GetDocumentoPDFBlob()
        {
            return new DocumentoPDFBlob(Id,PDF.Data);
        }

        public bool hasDocumento()
        {
            return PDF.hasDocumento();
        }

        public void CleanData()
        {
           PDF.CleanData();
        }
        public string GetName()
        {
            return PDF.Name;
        }
    }
}
