using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class TiendasService: ITiendaService
    {      
        protected readonly ITiendaDtoRepository tiendaDtoRepository;
        private readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacion;     
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        protected readonly IDocumentoPdfRepository documentoPdfRepository;
        private readonly IComplejoService complejoService;
        protected List<Tienda> tiendas;

        public TiendasService(IComplejoService complejoService, ITiendaDtoRepository tiendaDtoRepository, ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacion,  ITipoGrupoDocumentacionService tipoGrupoDocumentacionService, IDocumentoPdfRepository documentoPdfRepository)
        {
            this.tiendaDtoRepository = tiendaDtoRepository;
            this.tiendaGrupoDocumentacion = tiendaGrupoDocumentacion;
            this.documentoPdfRepository = documentoPdfRepository;
            this.tipoGrupoDocumentacionService = tipoGrupoDocumentacionService;
            this.complejoService = complejoService;
            Populate();
        }

        private void Populate()
        {
            tiendas = new List<Tienda>();
            List<TiendaDto> tiendaDtos = tiendaDtoRepository.getAll();
            foreach (TiendaDto tienda in tiendaDtos)
            {
                DocumentoPDF documentoPDF = documentoPdfRepository.getById(tienda.idCertificadoComercial);
                List<TipoGrupoDocumentacion> grupoDocumentacions = getTiendaGrupoDocumentacionDtos(tienda);
                Complejo complejo = complejoService.getById(tienda.idComplejo);
                tiendas.Add(new Tienda(tienda, complejo, documentoPDF, grupoDocumentacions));
            }           
        }

        protected int getIndexById(Guid id)
        {
            return tiendas.FindIndex(doc => doc.Id == id);
        }

        public Tienda getById(Guid id)
        {
            return tiendas.FirstOrDefault(t => t.Id == id);
        }

        public List<Tienda> getTiendasByComplejo(Complejo complejo)
        {
            return tiendas.FindAll(t => t.Complejo.Id == complejo.Id);
        }

        private List<TipoGrupoDocumentacion> getTiendaGrupoDocumentacionDtos(TiendaDto tienda)
        {
            List<TipoGrupoDocumentacion> grupoDocumentacions = new List<TipoGrupoDocumentacion>();
            List<TiendaGrupoDocumentacionDto> tiendaGrupoDocumentacionDtos = tiendaGrupoDocumentacion.getAllByIdTienda(tienda.id);
            foreach (TiendaGrupoDocumentacionDto tiendaGrupoDocumentacion in tiendaGrupoDocumentacionDtos)
            {
                grupoDocumentacions.Add(tipoGrupoDocumentacionService.getById(tiendaGrupoDocumentacion.idTipoGrupoDocumentacion));
            }
            return grupoDocumentacions;
        }

        public DocumentoPDF getDocumentoPDFApliado(Tienda tienda)
        {
            return (tienda.CertificadoComercial != null) 
                ? documentoPdfRepository.getDocumentoApliado(tienda.CertificadoComercial.Id)
                : null;
        }

        public bool saveOrUpdate(Tienda tienda)
        {
            documentoPdfRepository.saveOrUpdate(tienda.CertificadoComercial);
            ActionResult actionResult = tiendaDtoRepository.saveOrUpdate(tienda);
            if (actionResult == ActionResult.CREATED)
            {
                tiendas.Add(tienda);
            }
            else if (actionResult == ActionResult.UPDATED)
            {
                int index = getIndexById(tienda.Id);
                if (index != -1)
                {
                    tiendas[index] = tienda;
                }
            }


            List<TiendaGrupoDocumentacionDto> gruposAntiguos = tiendaGrupoDocumentacion.getAllByIdTienda(tienda.Id);
            List<TipoGrupoDocumentacion> gruposNuevos = tienda.TipoGrupoDocumentacion;


            List<TiendaGrupoDocumentacionDto> gruposParaEliminar = gruposAntiguos
                 .Where(antiguo => !gruposNuevos.Any(nuevo => nuevo.Id == antiguo.idTipoGrupoDocumentacion))
                 .ToList();

            List<TipoGrupoDocumentacion> gruposParaGuardar = gruposNuevos
                .Where(nuevo => !gruposAntiguos.Any(antiguo => antiguo.idTipoGrupoDocumentacion == nuevo.Id))
                .ToList();

            foreach (var grupoEliminar in gruposParaEliminar)
            {
                tiendaGrupoDocumentacion.delete(grupoEliminar);
            }

            foreach (var grupoGuardar in gruposParaGuardar)
            {
                var grupoNuevo = new TiendaGrupoDocumentacionDto()
                {
                    idTienda = tienda.Id,
                    idTipoGrupoDocumentacion = grupoGuardar.Id
                };
                tiendaGrupoDocumentacion.save(grupoNuevo);
            }
            return true;
        }
    }
}
