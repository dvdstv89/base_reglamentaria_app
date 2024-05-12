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

        protected Papel(TipoClasificacionDocumento TipoClasificacionDocumento, string Name, DocumentoPDF DocumentoPDF, DateTime fechaFirma, string Descripcion)
        {
            Id = Guid.NewGuid();
            this.TipoClasificacionDocumento = TipoClasificacionDocumento;
            this.Name = Name;
            this.DocumentoPDF = DocumentoPDF;
            this.FechaFirma= fechaFirma;
            this.IsActivo = true;
            this.Descripcion = Descripcion;
        }

        protected Papel(PapelDto papel, DocumentoPDF DocumentoPDF)
        {
            this.Id = papel.idPapel;
            this.Name = papel.name;
            this.FechaFirma = papel.FechaFirma;
            this.IsActivo = papel.IsActivo;
            this.Descripcion = papel.Descripcion;
            this.TipoClasificacionDocumento = papel.tipoClasificacionDocumento;
            this.DocumentoPDF = DocumentoPDF;
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
    }
}
