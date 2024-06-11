using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Nomenclador;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class PapelService : BaseListServicio<Papel, PapelDto>, IPapelService
    {     
        protected readonly IDirectorioService directorioService;       
        protected readonly IDocumentoPdfService documentoPdfService;
        protected readonly ITipoDocumentacionService tipoDocumentacionService;
        protected readonly IClasificacionDocumentacionService clasificacionDocumentacionService;

        public PapelService(IDirectorioService directorioService, IPapelDtoRepository papelDtoRepository, IDocumentoPdfService documentoPdfService,
             ITipoDocumentacionService tipoDocumentacionService, IClasificacionDocumentacionService clasificacionDocumentacionService)
         : base(papelDtoRepository)
        {            
            this.directorioService = directorioService;
            this.documentoPdfService = documentoPdfService;
            this.tipoDocumentacionService = tipoDocumentacionService;
            this.clasificacionDocumentacionService = clasificacionDocumentacionService;
            Populate();
        }      

        protected override void Populate()
        {           
            List<PapelDto> papelDtos = repository.GetAll();

            foreach (PapelDto papel in papelDtos)
            {
                DocumentoPDF documentoPDF = documentoPdfService.GetById(papel.IdPdf);
                TipoDocumentacion tipoDocumentacion = tipoDocumentacionService.GetById(papel.IdTipoDocumentacion);
                Persona cliente = directorioService.GetPersonaJuridica(papel.IdCliente);
                Persona responsable = directorioService.GetPersonaJuridica(papel.IdResponsable);
                Papel padre = GetById(papel.IdPadre);
                ArchivoPDF archivoPDF = documentoPDF!= null ? documentoPDF.GetArchivoPDF() : null;
                listado.Add(new Papel(papel, archivoPDF, tipoDocumentacion, responsable, cliente, padre));
            }           
        }
        public List<Papel> GetByMenuDocumental(MenuDocumental menuDocumental)
        {
            List<TipoDocumentacion> tipoDocumentacions = clasificacionDocumentacionService.GetTipoDocumentacionsByMenuDocumental(menuDocumental.Id);
            return listado.FindAll(p => p.IsActivo && tipoDocumentacions.Exists(tipo => tipo.Id == p.TipoDocumentacion.Id));
        }                  
        public List<Papel> GetAllByTipoDocumentacion(TipoDocumentacion tipoDocumentacion)
        {
            return listado.FindAll(p => p.TipoDocumentacion.Id == tipoDocumentacion.Id && p.IsActivo);
        }
        public List<Papel> GetAllWhitCard()
        {
            return listado.FindAll(p => p.TipoDocumentacion.TipoCard != TipoCard.NOTA);
        }
        public List<Papel> GetAllByTipoPapelDistint(Papel papelActual)
        {
            return papelActual == null
                ? new List<Papel>()
                : listado.FindAll(p => p.TipoDocumentacion.Id == papelActual.TipoDocumentacion.Id && p.IsActivo && p.Id != papelActual.Id);
        }
        public override ActionResult SaveOrUpdate(Papel papel)
        {
            ActionResult actionResult = base.SaveOrUpdate(papel);
            if (papel.ArchivoPDF != null)
            {
                return documentoPdfService.SaveOrUpdate(papel.ArchivoPDF);
            }
            return actionResult;
        }      
        public override ActionResult DeleteByTipo(Papel papel)
        {
            base.DeleteByTipo(papel);          
            return documentoPdfService.Delete(papel.ArchivoPDF.Id); 
        }
    }
}
