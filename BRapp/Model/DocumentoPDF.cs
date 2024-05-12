using System;

namespace BRapp.Model
{
    public class DocumentoPDF
    {
        public Guid Id { get; set; }       
        public Fichero PDF { get; set; }      
        public Fichero Imagen { get; set; }      

        public DocumentoPDF(Guid Id, Fichero PDF, Fichero Imagen)
        {
            this.Id = Id;
            this.PDF = PDF;
            this.Imagen = Imagen;          
        }
        public DocumentoPDF(Fichero PDF, Fichero Imagen)
        {
            Id = Guid.NewGuid();
            this.PDF = PDF;
            this.Imagen = Imagen;
        }

        public bool hasDocumento()
        {
            return PDF != null && !PDF.Name.Equals("");
        }
        public bool hasImagen()
        {
            return Imagen != null && !Imagen.Name.Equals("");
        }

        public DocumentoPDF clone() {

            Fichero pdfClonado = (this.PDF == null) ? null : this.PDF.clone();
            Fichero imagenClonado = (this.Imagen == null) ? null : this.Imagen.clone();
            return new DocumentoPDF(this.Id, pdfClonado, imagenClonado);
        }

        public void limpiarFicheros()
        {
            if (PDF != null) PDF.Data = null;
            if (Imagen != null) Imagen.Data = null;
        }
    }
}
