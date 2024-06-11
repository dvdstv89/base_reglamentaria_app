using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class TiendasService : BaseListServicio<Tienda, TiendaDto>, ITiendaService
    {
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        private readonly IPapelService papelService;
        private readonly IComplejoService complejoService;
        private readonly IDepartamentoService departamentoService;
      

        public TiendasService(IComplejoService complejoService, ITiendaDtoRepository tiendaDtoRepository, ITipoGrupoDocumentacionService tipoGrupoDocumentacionService, IPapelService papelService, IDepartamentoService departamentoService)
        : base(tiendaDtoRepository)
        {           
            this.papelService = papelService;
            this.tipoGrupoDocumentacionService = tipoGrupoDocumentacionService;
            this.complejoService = complejoService;           
            this.departamentoService = departamentoService;
            Populate();
        }

        protected override void Populate()
        {            
            List<TiendaDto> tiendaDtos = repository.GetAll();
            foreach (TiendaDto tienda in tiendaDtos)
            {
                Papel papel = papelService.GetById(tienda.idCertificadoComercial);
                List<TipoGrupoDocumentacion> grupoDocumentacions = tipoGrupoDocumentacionService.GetByIdTienda(tienda.id);
                Complejo complejo = complejoService.GetById(tienda.idComplejo);
                Departamento departamento = departamentoService.GetById(tienda.idDepartamento);
                listado.Add(new Tienda(tienda, complejo, departamento, papel, grupoDocumentacions));
            }           
        } 

        public List<Tienda> GetTiendasByComplejo(Complejo complejo)
        {
            return listado.FindAll(t => t.Complejo.Id == complejo.Id);
        }

        public override ActionResult SaveOrUpdate(Tienda tienda)
        {           
            base.SaveOrUpdate(tienda);
            return papelService.SaveOrUpdate(tienda.CertificadoComercial);           
        }

        public override ActionResult DeleteByTipo(Tienda tienda)
        {            
            base.DeleteById(tienda.Id);
            return papelService.Delete(tienda.CertificadoComercial.Id);
        }
    }
}
