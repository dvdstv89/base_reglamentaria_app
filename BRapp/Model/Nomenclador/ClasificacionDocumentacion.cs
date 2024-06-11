using BRapp.Interfaces;
using System;

namespace BRapp.Model.Nomenclador
{
    public class ClasificacionDocumentacion: HasId
    {
        public Guid Id { get; set; }       
        public TipoDocumentacion TipoDocumentacion { get; set; }
        public MenuDocumental MenuDocumental { get; set; }
       
        public ClasificacionDocumentacion(Guid Id, TipoDocumentacion TipoDocumentacion, MenuDocumental MenuDocumental)
        {
            this.Id = Id;
            this.TipoDocumentacion = TipoDocumentacion;
            this.MenuDocumental = MenuDocumental;
        }

        public Guid getId()
        {
           return Id;
        }
    }
}
