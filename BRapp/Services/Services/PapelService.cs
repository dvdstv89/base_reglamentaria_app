using BRapp.Dto;
using BRapp.Enums;
using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using BRapp.Model.Papeles;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Services.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    public class PapelService : IPapelService
    {
        protected readonly ISistemaService sistemaService;
        protected readonly IDGService dGService;
        protected readonly IResolucionService resolucionService;
        protected readonly IContratoService contratoService;
        protected readonly IDocumentoService documentoService;
        protected readonly IDirectorioService directorioService;
        protected readonly IPapelDtoRepository papelDtoRepository;
        protected readonly IDocumentoPdfRepository documentoPdfRepository;      

        protected List<Papel> papeles;       
        public PapelService(ISistemaService sistemaService, IDGService dGService, IResolucionService resolucionService, IContratoService contratoService, 
            IDocumentoService documentoService, IDirectorioService directorioService, IPapelDtoRepository papelDtoRepository, IDocumentoPdfRepository documentoPdfRepository)
        {
            this.dGService = dGService;
            this.directorioService = directorioService;
            this.sistemaService = sistemaService;
            this.resolucionService = resolucionService;
            this.contratoService = contratoService;
            this.documentoService = documentoService;
            this.papelDtoRepository = papelDtoRepository;
            this.documentoPdfRepository = documentoPdfRepository;
            geAllPapeles();
        }

        protected List<Papel> geAllPapeles()
        {
            papeles = new List<Papel>();
            List<PapelDto> papelDtos = papelDtoRepository.getAll();
            foreach (PapelDto papel in papelDtos)
            {               
                ClasificacionDocumento clasificacionDocumento = papel.GetClasificacionDocumento();
                switch (clasificacionDocumento.TipoDocumento)
                {
                    case TipoDocumento.SISTEMA:
                        papeles.Add(getSistemaByPapel(papel));
                        break;
                    case TipoDocumento.DG:
                        papeles.Add(getDGByPapel(papel));
                        break;
                    case TipoDocumento.RESOLUCION:
                        papeles.Add(getResolucionByPapel(papel));
                        break;                  
                    case TipoDocumento.CONTRATO:
                        papeles.Add(getContratoByPapel(papel));
                        break;
                    default:
                        papeles.Add(getDocumentoByPapel(papel));
                        break;
                }
                
            }
            return papeles;
        }

        private Documento getDocumentoByPapel(PapelDto papel)
        {
            DocumentoPDF documentoPDF = documentoPdfRepository.getById(papel.idPdf);
            DocumentoDto documentoDto = documentoService.getByPapel(papel);
            PersonaNatural responsable = directorioService.GetPersonaNatural(documentoDto.idResponsable);
            switch (papel.tipoClasificacionDocumento)
            {
                case TipoClasificacionDocumento.INDICO: 
                case TipoClasificacionDocumento.MANUAL:
                case TipoClasificacionDocumento.PLAN_EMPRESARIAL: 
                case TipoClasificacionDocumento.PLAN_INTERNO: 
                case TipoClasificacionDocumento.PROCEDIMIENTO: 
                case TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL:
                case TipoClasificacionDocumento.PROGRAMA_INTERNO: 
                case TipoClasificacionDocumento.REGLAMENTO: 
                case TipoClasificacionDocumento.OTRO_DOCUMENTO:
                case TipoClasificacionDocumento.DOCUMENTACION_BASICA:
                    return new Documento(papel, documentoPDF, responsable);
                default: return null;
            }
        }

        private Sistema getSistemaByPapel(PapelDto papel)
        {
            DocumentoPDF documentoPDF = documentoPdfRepository.getById(papel.idPdf);
            SistemaDto sistemaDto = sistemaService.getByPapel(papel);
            PersonaNatural responsable = directorioService.GetPersonaNatural(sistemaDto.idResponsable);
            return new Sistema(papel, documentoPDF, responsable, sistemaDto);
        }

        private DG getDGByPapel(PapelDto papel)
        {
            DocumentoPDF documentoPDF = documentoPdfRepository.getById(papel.idPdf);
            DGDto dGDto = dGService.getByPapel(papel);
            PersonaNatural responsable = directorioService.GetPersonaNatural(dGDto.idResponsable);
            return new DG(papel, documentoPDF, responsable, dGDto);
        }

        private Contrato getContratoByPapel(PapelDto papel)
        {
            DocumentoPDF documentoPDF = documentoPdfRepository.getById(papel.idPdf);
            ContratoDto contratoDto = contratoService.getByPapel(papel);           
            PersonaJuridica cliente = (contratoDto == null || contratoDto.idCliente == Guid.Empty) ? null : directorioService.GetPersonaJuridica(contratoDto.idCliente);
            PersonaJuridica responsable = (contratoDto == null || contratoDto.idResponsable == Guid.Empty) ? null : directorioService.GetPersonaJuridica(contratoDto.idResponsable);
            Contrato contratoPadre = (contratoDto == null || contratoDto.idContratoPadre == Guid.Empty) ? null : getContratoByPapel(papelDtoRepository.getById(contratoDto.idContratoPadre));
            return new Contrato(papel, documentoPDF, contratoDto, cliente, responsable, contratoPadre);
        }

        public Resolucion getResolucionByPapel(PapelDto papel)
        {
            ResolucionDto resolucionDto = resolucionService.getByPapel(papel);
            DocumentoPDF documentoPDF = documentoPdfRepository.getById(papel.idPdf);
            PersonaNatural responsable = directorioService.GetPersonaNatural(resolucionDto.idResponsable);
            Resolucion derrogada = (resolucionDto.idDerrogada == Guid.Empty) ? null : getResolucionByPapel(papelDtoRepository.getById(resolucionDto.idDerrogada));
            switch (papel.tipoClasificacionDocumento)
            {
                case TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL: 
                case TipoClasificacionDocumento.RESOLUCION_INTERNA: 
                    return new Resolucion(papel, documentoPDF, responsable, derrogada, resolucionDto.Numero);
                default: return null;
            }
        }

        public List<Papel> filtrarDocumentos(TipoDocumentoMenu tipoDocumentoMenu)
        {
            papeles = geAllPapeles();
            List<Papel> papelesFiltrados = new List<Papel>();
            papeles.ForEach(papel =>
            {
                if (papel.getClasificacionDocumento().TipoDocumentoMenu == tipoDocumentoMenu && papel.IsActivo) papelesFiltrados.Add(papel);
            });
            return papelesFiltrados;
        }      

      

        protected int getIndexById(Guid id)
        {
            return papeles.FindIndex(doc => doc.Id == id);
        }
        public Papel getById(Guid id)
        {
           return papeles.FirstOrDefault(papel => papel.Id == id);
        }
        public List<Papel> getAll()
        {
            return geAllPapeles();
        }

        public List<Documento> getAllByTipo(TipoDocumento tipoDocumento)
        {
            List<Documento> papelesFiltrados = new List<Documento>();
            papeles.ForEach(papel =>
            {
                if (papel.getClasificacionDocumento().TipoDocumento == tipoDocumento && papel.IsActivo)
                    papelesFiltrados.Add((Documento)papel);
            });
            return papelesFiltrados;
        }

        public List<Contrato> getAllContratoDistint(Papel papelActual)
        {
            List<Contrato> papelesFiltrados = new List<Contrato>();
            papeles.ForEach(papel =>
            {
                if (papel.getClasificacionDocumento().TipoDocumento == TipoDocumento.CONTRATO && papel.IsActivo && (papelActual == null || !papelActual.Id.Equals(papel.Id)))
                    papelesFiltrados.Add((Contrato)papel);
            });
            return papelesFiltrados;
        }

        public List<Resolucion> getAllResolucionesDistint(Papel papelActual, TipoClasificacionDocumento tipoClasificacionDocumento)
        {
            List<Resolucion> papelesFiltrados = new List<Resolucion>();
            papeles.ForEach(papel =>
            {
                if (papel.TipoClasificacionDocumento == tipoClasificacionDocumento && papel.IsActivo && (papelActual == null || !papelActual.Id.Equals(papel.Id)))
                    papelesFiltrados.Add((Resolucion)papel);
            });
            return papelesFiltrados;
        }

        public ActionResult saveOrUpdate(Papel papel)
        {
            documentoPdfRepository.saveOrUpdate(papel.DocumentoPDF);
            papelDtoRepository.saveOrUpdate(papel);

            ActionResult actionResult = ActionResult.FAILED;

            switch (papel.getClasificacionDocumento().TipoDocumento)
            {
                case TipoDocumento.SISTEMA: actionResult = sistemaService.saveOrUpdate((Sistema)papel); break;
                case TipoDocumento.RESOLUCION: actionResult = resolucionService.saveOrUpdate((Resolucion)papel); break;
                case TipoDocumento.CONTRATO: actionResult = contratoService.saveOrUpdate((Contrato)papel); break;
                case TipoDocumento.DG: actionResult = dGService.saveOrUpdate((DG)papel); break;
                default: actionResult = documentoService.saveOrUpdate((Documento)papel); break;
            }


            if (actionResult == ActionResult.CREATED)
            {
                papeles.Add(papel);
            }
            else if (actionResult == ActionResult.UPDATED)
            {
                int index = getIndexById(papel.Id);
                if (index != -1)
                {
                    papeles[index] = papel;
                }
            }
            return actionResult;
        }

        public void Delete(Papel papel)
        {
            documentoPdfRepository.Delete(papel.DocumentoPDF);
            papelDtoRepository.Delete(papel);
           
            switch (papel.getClasificacionDocumento().TipoDocumento)
            {
                case TipoDocumento.SISTEMA: sistemaService.Delete((Sistema)papel); break;
                case TipoDocumento.RESOLUCION: resolucionService.Delete((Resolucion)papel); break;
                case TipoDocumento.CONTRATO: contratoService.Delete((Contrato)papel); break;
                case TipoDocumento.DG: dGService.Delete((DG)papel); break;
                default: documentoService.Delete((Documento)papel); break;
            }

            int index = getIndexById(papel.Id);
            if (index != -1)
            {
                papeles.RemoveAt(index);
            }
        }

        public List<Papel> getAllDistintDocumentacion_Basica()
        {

            List<Papel> papelesFiltrados = new List<Papel>();
            papeles.ForEach(papel =>
            {
                if (papel.TipoClasificacionDocumento != TipoClasificacionDocumento.DOCUMENTACION_BASICA)
                    papelesFiltrados.Add(papel);
            });
            return papelesFiltrados;
        }      
    }
}
