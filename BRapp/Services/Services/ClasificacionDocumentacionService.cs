using BRapp.Dto;
using BRapp.Model.Nomenclador;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class ClasificacionDocumentacionService : BaseListServicio<ClasificacionDocumentacion, ClasificacionDocumentacionDto>, IClasificacionDocumentacionService
    {
        private readonly ITipoDocumentacionService TipoDocumentacionService;
        private readonly IMenuDocumentalService MenuDocumentalService;
        public ClasificacionDocumentacionService(IClasificacionDocumentacionRepository clasificacionDocumentacionRepository, ITipoDocumentacionService TipoDocumentacionService, IMenuDocumentalService MenuDocumentalService)
            : base(clasificacionDocumentacionRepository) 
        {
            this.TipoDocumentacionService = TipoDocumentacionService;
            this.MenuDocumentalService= MenuDocumentalService;
            Populate();
        }

        protected override void Populate()
        {
            List<ClasificacionDocumentacionDto> clasificacionDocumentacionDtos = repository.GetAll();
            foreach (ClasificacionDocumentacionDto clasificacion in clasificacionDocumentacionDtos)
            {
                TipoDocumentacion tipoDocumentacion = TipoDocumentacionService.GetById(clasificacion.IdTipoDocumentacion);
                MenuDocumental menuDocumental = MenuDocumentalService.GetById(clasificacion.IdMenuDocumental);
                listado.Add(new ClasificacionDocumentacion(clasificacion.Id, tipoDocumentacion, menuDocumental));
            }
        }

        public ActionResult DeleteByTipoDocumentacion(Guid id)
        {
            TipoDocumentacionService.Delete(id);
            return ((IClasificacionDocumentacionRepository)repository).DeleteByTipoDocumentacion(id);
        }
        public ActionResult DeleteByMenuDocumental(Guid id)
        {
            MenuDocumentalService.Delete(id);
            return ((IClasificacionDocumentacionRepository)repository).DeleteByMenuDocumental(id);
        }

        public List<TipoDocumentacion> GetTipoDocumentacionsByMenuDocumental(Guid id)
        {
            return listado.FindAll(c => c.MenuDocumental.Id == id)
                .Select(c => c.TipoDocumentacion)
                .ToList();
        }
    }
}
