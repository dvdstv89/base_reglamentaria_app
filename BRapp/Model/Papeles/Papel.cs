using BRapp.Data;
using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model.Papeles;
using FontAwesome.Sharp;
using System;

namespace BRapp.Model
{
    public abstract class Papel: ISeleccionable
    {
        public Guid Id { get; set; }
        public TipoClasificacionDocumento TipoClasificacionDocumento { get; set; }       
        public DocumentoPDF DocumentoPDF { get; set; }      
        public string Name { get; set; }
        public bool IsActivo { get; set; }
        public DateTime FechaFirma { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }     

        protected Papel(PapelDto papel, DocumentoPDF DocumentoPDF)
        {
            this.Id = papel.idPapel;
            this.Name = papel.name;
            this.FechaFirma = papel.FechaFirma;
            this.IsActivo = papel.IsActivo;
            this.Descripcion = papel.Descripcion;
            this.TipoClasificacionDocumento = papel.tipoClasificacionDocumento;
            this.DocumentoPDF = DocumentoPDF;
            this.Orden= papel.Orden;
        }

        public virtual IconChar getIcono()
        {
            return getClasificacionDocumento().getIcono();           
        }

        public ClasificacionDocumento getClasificacionDocumento()
        {
            return ClasificacionDocumentoData.getClasificacionDocumento(TipoClasificacionDocumento);
        }

        public virtual bool IsArchivado()
        {
            return false;
        }

        public string COMBO
        {
            get { return ToString(); }
        }
        public string getNameSeleccionable()
        {
            return ToString();
        }

        public bool hasPdfName()
        {
            return DocumentoPDF != null && DocumentoPDF.PDF != null && DocumentoPDF.PDF.Name != String.Empty;
        }
    }
}
