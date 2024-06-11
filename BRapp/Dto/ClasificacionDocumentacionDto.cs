using BRapp.Interfaces;
using System;

namespace BRapp.Dto
{
    public class ClasificacionDocumentacionDto : HasId
    {
        public Guid Id { get; set; }
        public Guid IdTipoDocumentacion { get; set; }
        public Guid IdMenuDocumental { get; set; }

        public Guid getId()
        {
            return Id;
        }
    }
}
