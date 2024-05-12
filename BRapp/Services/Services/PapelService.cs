using BRapp.Dto;
using BRapp.Enums;
using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using BRapp.Model.Papeles;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class PapelService : IPapelService
    {
        private static PapelService instance; 
        private readonly ISistemaService sistemaService;
        private readonly IDGService dGService;
        private readonly IResolucionService resolucionService;
        private readonly IContratoService contratoService;
        private readonly IDocumentoService documentoService;
        private readonly IDirectorioService directorioService;
        private readonly IPapelDtoRepository papelDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;      

        protected List<Papel> papeles;       
        protected PapelService()
        {
            dGService = DGService.Instance;
            directorioService = DirectorioService.Instance;
            sistemaService = SistemaService.Instance;
            resolucionService = ResolucionService.Instance;
            contratoService = ContratoService.Instance;
            documentoService = DocumentoService.Instance;
            papelDtoRepository = PapelDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
            papeles = geAllPapeles();
        }

        protected List<Papel> geAllPapeles()
        {
            List<Papel> papeles = new List<Papel>();
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

        public static PapelService Instance
        {
            get
            {
                instance = (instance == null) ? new PapelService() : instance;
                return instance;
            }
        }

        public virtual bool saveOrUpdate(Papel papel)
        {
            documentoPdfRepository.saveOrUpdate(papel.DocumentoPDF);          
            papelDtoRepository.saveOrUpdate(papel);

            switch (papel.getClasificacionDocumento().TipoDocumento)
            {
                case TipoDocumento.SISTEMA:return sistemaService.saveOrUpdate((Sistema)papel);                   
                case TipoDocumento.RESOLUCION: return resolucionService.saveOrUpdate((Resolucion)papel);
                case TipoDocumento.CONTRATO: return contratoService.saveOrUpdate((Contrato)papel);
                case TipoDocumento.DG: return dGService.saveOrUpdate((DG)papel);
                default: return documentoService.saveOrUpdate((Documento)papel);
            }
        }
    }
}
