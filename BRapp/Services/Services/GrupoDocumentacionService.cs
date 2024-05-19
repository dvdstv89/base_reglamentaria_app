using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class GrupoDocumentacionService : IGrupoDocumentacionService
    {
        private static GrupoDocumentacionService instance;
        protected readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        protected readonly IGrupoDocumentacionDtoRepository grupoDocumentacionDtoRepository;
        protected readonly IPapelService papelService;       

        public GrupoDocumentacionService(IPapelService papelService)
        {
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionService.Instance;
            grupoDocumentacionDtoRepository = GrupoDocumentacionDtoRepository.Instance;
            this.papelService = papelService;
        }

        public static GrupoDocumentacionService Instance
        {
            get
            {              
                instance = (instance == null) ? new GrupoDocumentacionService(PapelService.Instance) : instance;
                return instance;
            }
        }

        public List<GrupoDocumentacion> getAll()
        {
            List<GrupoDocumentacion> grupoDocumentacions = new List<GrupoDocumentacion>();
            List<GrupoDocumentacionDto> grupoDocumentacionDtos = grupoDocumentacionDtoRepository.getAll();
            foreach (GrupoDocumentacionDto grupo in grupoDocumentacionDtos)
            {
                Documento documento = (Documento)papelService.getById(grupo.idDocumento);
                TipoGrupoDocumentacion tipoGrupoDocumentacion = tipoGrupoDocumentacionService.getById(grupo.idTipoGrupoDocumentacion);
                grupoDocumentacions.Add(new GrupoDocumentacion(grupo, tipoGrupoDocumentacion, documento));
            }
            return grupoDocumentacions;
        }
        public GrupoDocumentacion getById(Guid id)
        {
            return getAll().FirstOrDefault(g => g.Id == id);
        }

        public List<GrupoDocumentacion> getByIdTipoGrupoDocumentacion(Guid id)
        {
            return getAll().FindAll(tipo => tipo.TipoGrupoDocumentacion.Id == id).ToList();
        }
        public List<GrupoDocumentacion> getAllByTipoGrupoDocumentacion(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            return getAll().FindAll(grupo => grupo.TipoGrupoDocumentacion.Id == tipoGrupoDocumentacion.Id);
        }

        public bool saveOrUpdate(GrupoDocumentacion grupoDocumentacion)
        {
            return grupoDocumentacionDtoRepository.saveOrUpdate(grupoDocumentacion);
        }

        public void Delete(GrupoDocumentacion grupoDocumentacion)
        {
            grupoDocumentacionDtoRepository.Delete(grupoDocumentacion);
            papelService.Delete(grupoDocumentacion.Documento);
        }
    }
}
