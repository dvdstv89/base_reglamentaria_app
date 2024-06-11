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
    public class GrupoDocumentacionService : BaseListServicio<GrupoDocumentacion, GrupoDocumentacionDto>, IGrupoDocumentacionService
    {
        protected readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;       
        protected readonly ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository;
        protected readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionDtoRepository;
        protected readonly IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository;        
        protected readonly IPapelService papelService;       

        public GrupoDocumentacionService(IPapelService papelService, ITipoGrupoDocumentacionService tipoGrupoDocumentacionService, IGrupoDocumentacionDtoRepository grupoDocumentacionDtoRepository,
            ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository, ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionDtoRepository, IDepartamentoGrupoDocumentacionDtoRepository departamentoGrupoDocumentacionDtoRepository)
        :base(grupoDocumentacionDtoRepository)
        {
            this.tipoGrupoDocumentacionService = tipoGrupoDocumentacionService;           
            this.papelService = papelService;
            this.tipoGrupoDocumentacionRepository = tipoGrupoDocumentacionRepository;
            this.tiendaGrupoDocumentacionDtoRepository = tiendaGrupoDocumentacionDtoRepository;
            this.departamentoGrupoDocumentacionDtoRepository = departamentoGrupoDocumentacionDtoRepository;
            Populate();
        }

        protected override void Populate()
        {           
            List<GrupoDocumentacionDto> grupoDocumentacionDtos = repository.GetAll();
            foreach (GrupoDocumentacionDto grupo in grupoDocumentacionDtos)
            {
                Papel documento = papelService.GetById(grupo.idDocumento);
                TipoGrupoDocumentacion tipoGrupoDocumentacion = tipoGrupoDocumentacionService.GetById(grupo.idTipoGrupoDocumentacion);
                listado.Add(new GrupoDocumentacion(grupo, tipoGrupoDocumentacion, documento));
            }          
        }       

        public List<GrupoDocumentacion> GetAllByTipoGrupoDocumentacion(Guid idTipoGrupoDocumentacion)
        {
            return listado.FindAll(grupo => grupo.TipoGrupoDocumentacion != null && grupo.TipoGrupoDocumentacion.Id == idTipoGrupoDocumentacion);
        }

        public ActionResult DeleteTipo(Guid idTipoGrupoDocumentacion)
        {
            List<GrupoDocumentacion> grupos = GetAllByTipoGrupoDocumentacion(idTipoGrupoDocumentacion);
            foreach (GrupoDocumentacion grupo in grupos)
            {
                base.DeleteById(grupo.Id);
            }
            //asociacion con tienda
            tiendaGrupoDocumentacionDtoRepository.DeleteForGrupo(idTipoGrupoDocumentacion);
            //asociacion con departamento
            departamentoGrupoDocumentacionDtoRepository.DeleteForGrupo(idTipoGrupoDocumentacion);
            return tipoGrupoDocumentacionRepository.DeleteById(idTipoGrupoDocumentacion);            
        }       
    }
}
