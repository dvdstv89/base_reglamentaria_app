using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class TiendasService: ITiendaService
    {
        private static TiendasService instance;
        protected readonly ITiendaDtoRepository tiendaDtoRepository;
        private readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacion;
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        private readonly IDocumentoPdfRepository documentoPdfRepository;
        private readonly IComplejoService complejoService;
        protected List<Tienda> tiendas;

        protected TiendasService()
        {
            tiendaDtoRepository = TiendaDtoRepository.Instance;
            tiendaGrupoDocumentacion = TiendaGrupoDocumentacionDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionService.Instance;
            complejoService = ComplejoService.Instance;
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

        public static TiendasService Instance
        {
            get
            {
                instance = (instance == null) ? new TiendasService() : instance;
                return instance;
            }
        }
    }
}
