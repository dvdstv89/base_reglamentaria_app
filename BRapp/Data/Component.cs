using BRapp.Mapper;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;


namespace BRapp.Data
{
    public class Component
    {
        //Service
        public IAppService AppService { get; set; }
        public IBienvenidaService BienvenidaService { get; set; }
        public IComplejoService ComplejoService { get; set; }
        public IContratoService ContratoService { get; set; }
        public IDepartamentoService DepartamentoService { get; set; }
        public IDGService DGService { get; set; }
        public IDirectorioService DirectorioService { get; set; }
        public IDocumentoService DocumentoService { get; set; }
        public IGrupoDocumentacionService GrupoDocumentacionService { get; set; }
        public IIndexService IndexService { get; set; }
        public IPapelService PapelService { get; set; }
        public IResolucionService ResolucionService { get; set; }
        public ISistemaService SistemaService { get; set; }
        public ISucursalService SucursalService { get; set; }       
        public ITiendaService TiendaService { get; set; }           
        public ITipoGrupoDocumentacionService TipoGrupoDocumentacionService { get; set; }
        public IVisorDocumentacionService VisorDocumentacionService { get; set; }
        public IVisorPDFService VisorPDFService { get; set; }
        public IFileService FileService { get; set; }

        //Mappers
        private IMapper AppMapper;
        private IMapper ComplejoMapper;
        private IMapper ContratoMapper;
        private IMapper DepartamentoGrupoDocumentacionMapper;
        private IMapper DepartamentoMapper;
        private IMapper DGMapper;
        private IMapper DocumentoMapper;
        private IMapper DocumentoPdfBlobMapper;
        private IMapper DocumentoPdfMapper;
        private IMapper GrupoDocumentacionMapper;
        private IMapper PapelMapper;
        private IMapper PersonaJuridicaMapper;
        private IMapper PersonaNaturalMapper;
        private IMapper ResolucionMapper;
        private IMapper SistemaMapper;
        private IMapper TiendaGrupoDocumentacionMapper;
        private IMapper TiendaMapper;
        private IMapper TipoGrupoDocumentacionMapper;

        //Repos
        public IAppRepository AppRepository {get; set;}
        private IComplejoRepository ComplejoRepository;
        private IContratoDtoRepository ContratoDtoRepository;
        private IDirectorioRepository DirectorioRepository;
        private IDocumentoPdfRepository DocumentoPdfRepository;
        private ITipoGrupoDocumentacionRepository TipoGrupoDocumentacionRepository;
        private ITiendaGrupoDocumentacionDtoRepository TiendaGrupoDocumentacionDtoRepository;
        private ITiendaDtoRepository TiendaDtoRepository;
        private IDepartamentoDtoRepository DepartamentoDtoRepository;
        private IDepartamentoGrupoDocumentacionDtoRepository DepartamentoGrupoDocumentacionDtoRepository;
        private IGrupoDocumentacionDtoRepository GrupoDocumentacionDtoRepository;
        private IDGDtoRepository DGDtoRepository;
        private IDocumentoDtoRepository DocumentoDtoRepository;
        private IPapelDtoRepository PapelDtoRepository;
        private IResolucionDtoRepository ResolucionDtoRepository;
        private ISistemaDtoRepository SistemaDtoRepository;

        public Component()
        {
            InitNoDependientes();
            InitMappers();
            InitRepository();
            InitServices();
        }

        private void InitNoDependientes()
        {
            this.FileService = new FileService();
            this.AppMapper = new AppMapper();
            this.ComplejoMapper = new ComplejoMapper();
            this.ContratoMapper = new ContratoMapper();
            this.DepartamentoGrupoDocumentacionMapper = new DepartamentoGrupoDocumentacionMapper();
            this.DepartamentoMapper = new DepartamentoMapper();
            this.DGMapper = new DGMapper();
            this.DocumentoMapper = new DocumentoMapper();
            this.DocumentoPdfBlobMapper = new DocumentoPdfBlobMapper();           
            this.GrupoDocumentacionMapper = new GrupoDocumentacionMapper();
            this.PapelMapper = new PapelMapper();           
            this.PersonaNaturalMapper = new PersonaNaturalMapper();
            this.ResolucionMapper = new ResolucionMapper();
            this.SistemaMapper = new SistemaMapper();
            this.TiendaGrupoDocumentacionMapper = new TiendaGrupoDocumentacionMapper();
            this.TiendaMapper = new TiendaMapper();
            this.TipoGrupoDocumentacionMapper = new TipoGrupoDocumentacionMapper();
        }

        private void InitMappers()
        {          
            this.DocumentoPdfMapper = new DocumentoPdfMapper(FileService);          
            this.PersonaJuridicaMapper = new PersonaJuridicaMapper(FileService);          
        }

        private void InitRepository()
        {
            this.AppRepository = new AppRepository(this.AppMapper);
            this.ComplejoRepository = new ComplejoRepository(ComplejoMapper);
            this.DirectorioRepository = new DirectorioRepository(PersonaJuridicaMapper, PersonaNaturalMapper, FileService);
            this.DocumentoPdfRepository = new DocumentoPdfRepository(DocumentoPdfMapper, DocumentoPdfBlobMapper);
            this.TipoGrupoDocumentacionRepository = new TipoGrupoDocumentacionRepository(TipoGrupoDocumentacionMapper);
            this.TiendaGrupoDocumentacionDtoRepository = new TiendaGrupoDocumentacionDtoRepository(TiendaGrupoDocumentacionMapper);
            this.TiendaDtoRepository = new TiendaDtoRepository(TiendaMapper);
            this.DepartamentoDtoRepository = new DepartamentoDtoRepository(DepartamentoMapper);
            this.DepartamentoGrupoDocumentacionDtoRepository = new DepartamentoGrupoDocumentacionDtoRepository(DepartamentoGrupoDocumentacionMapper);
            this.GrupoDocumentacionDtoRepository = new GrupoDocumentacionDtoRepository(GrupoDocumentacionMapper);
            this.ContratoDtoRepository = new ContratoDtoRepository(ContratoMapper);
            this.DGDtoRepository = new DgDtoRepository(DGMapper);
            this.DocumentoDtoRepository = new DocumentoDtoRepository(DocumentoMapper);
            this.PapelDtoRepository = new PapelDtoRepository(PapelMapper);
            this.ResolucionDtoRepository = new ResolucionDtoRepository(ResolucionMapper);
            this.SistemaDtoRepository = new SistemaDtoRepository(SistemaMapper);
        }

        private void InitServices()
        {
            this.AppService = new AppService(AppRepository);           
            this.SucursalService= new SucursalService(AppService);
            this.BienvenidaService = new BienvenidaService(SucursalService);
            this.ComplejoService = new ComplejoService(ComplejoRepository);
            this.ContratoService = new ContratoService(ContratoDtoRepository);
            this.TipoGrupoDocumentacionService = new TipoGrupoDocumentacionService(TipoGrupoDocumentacionRepository);
            this.DepartamentoService = new DepartamentoService(DepartamentoDtoRepository, DepartamentoGrupoDocumentacionDtoRepository, TipoGrupoDocumentacionService, ComplejoService);
            this.DGService = new DGService(DGDtoRepository);
            this.DirectorioService = new DirectorioService(DirectorioRepository);
            this.DocumentoService = new DocumentoService(DocumentoDtoRepository);
            this.IndexService = new IndexService(AppService);
            this.ResolucionService = new ResolucionService(ResolucionDtoRepository);
            this.SistemaService = new SistemaService(SistemaDtoRepository);            
            this.TiendaService = new TiendasService(ComplejoService, TiendaDtoRepository, TiendaGrupoDocumentacionDtoRepository, TipoGrupoDocumentacionService, DocumentoPdfRepository);
            this.PapelService = new PapelService(SistemaService, DGService, ResolucionService, ContratoService, DocumentoService, DirectorioService, PapelDtoRepository, DocumentoPdfRepository);
            this.GrupoDocumentacionService = new GrupoDocumentacionService(PapelService, TipoGrupoDocumentacionService, GrupoDocumentacionDtoRepository);
            this.VisorDocumentacionService = new VisorDocumentacionService(GrupoDocumentacionService, PapelService);
            this.VisorPDFService = new VisorPDFService(DocumentoPdfRepository);
        }
    }
}
