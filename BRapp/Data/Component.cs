using BRapp.Mapper;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.Nomenclador;
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
        public IDepartamentoService DepartamentoService { get; set; }  
        public IDirectorioService DirectorioService { get; set; }      
        public IGrupoDocumentacionService GrupoDocumentacionService { get; set; }
        public IIndexService IndexService { get; set; }
        public IPapelService PapelService { get; set; }       
        public ISucursalService SucursalService { get; set; }       
        public ITiendaService TiendaService { get; set; }           
        public ITipoGrupoDocumentacionService TipoGrupoDocumentacionService { get; set; }
        public IVisorDocumentacionService VisorDocumentacionService { get; set; }
        public IVisorPDFService VisorPDFService { get; set; }
        public IFileService FileService { get; set; }
        public IDocumentoPdfService DocumentoPdfService { get; set; }
        public ITipoDocumentacionService TipoDocumentacionService { get; set; }
        public IMenuDocumentalService MenuDocumentalService { get; set; }
        public IClasificacionDocumentacionService ClasificacionDocumentacionService { get; set; }


        //Mappers
        private IMapper AppMapper;
        private IMapper ComplejoMapper;      
        private IMapper DepartamentoGrupoDocumentacionMapper;
        private IMapper DepartamentoMapper;     
        private IMapper DocumentoPdfBlobMapper;
        private IMapper DocumentoPdfMapper;
        private IMapper GrupoDocumentacionMapper;
        private IMapper PapelMapper;
        private IMapper PersonaMapper; 
        private IMapper TiendaGrupoDocumentacionMapper;
        private IMapper TiendaMapper;
        private IMapper TipoGrupoDocumentacionMapper;
        private IMapper TipoDocumentacionMapper;
        private IMapper MenuDocumentalMapper;
        private IMapper ClasificacionDocumentacionlMapper;

        //Repos
        public IAppRepository AppRepository {get; set;}
        private IComplejoRepository ComplejoRepository;      
        private IDirectorioRepository DirectorioRepository;
        private IDocumentoPdfBlobRepository DocumentoPdfBlobRepository;
        private IDocumentoPdfRepository DocumentoPdfRepository;
        private ITipoGrupoDocumentacionRepository TipoGrupoDocumentacionRepository;
        private ITiendaGrupoDocumentacionDtoRepository TiendaGrupoDocumentacionDtoRepository;
        private ITiendaDtoRepository TiendaDtoRepository;
        private IDepartamentoDtoRepository DepartamentoDtoRepository;
        private IDepartamentoGrupoDocumentacionDtoRepository DepartamentoGrupoDocumentacionDtoRepository;
        private IGrupoDocumentacionDtoRepository GrupoDocumentacionDtoRepository;   
        private IPapelDtoRepository PapelDtoRepository;      
        private ITipoDocumentacionRepository TipoDocumentacionRepository;
        private IMenuDocumentalRepository MenuDocumentalRepository;
        private IClasificacionDocumentacionRepository ClasificacionDocumentacionRepository;

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
            this.DepartamentoGrupoDocumentacionMapper = new DepartamentoGrupoDocumentacionMapper();
            this.DepartamentoMapper = new DepartamentoMapper();           
            this.DocumentoPdfMapper = new DocumentoPdfMapper();
            this.DocumentoPdfBlobMapper = new DocumentoPdfBlobMapper();           
            this.GrupoDocumentacionMapper = new GrupoDocumentacionMapper();
            this.PapelMapper = new PapelMapper();           
            this.TiendaGrupoDocumentacionMapper = new TiendaGrupoDocumentacionMapper();           
            this.TipoGrupoDocumentacionMapper = new TipoGrupoDocumentacionMapper();
            this.TipoDocumentacionMapper = new TipoDocumentacionMapper();
            this.MenuDocumentalMapper = new MenuDocumentalMapper();
            this.ClasificacionDocumentacionlMapper = new ClasificacionDocumentacionlMapper();
        }

        private void InitMappers()
        {      
            this.PersonaMapper = new PersonaMapper(FileService);
            this.TiendaMapper = new TiendaMapper(FileService);
        }

        private void InitRepository()
        {
            this.AppRepository = new AppRepository(this.AppMapper);
            this.ComplejoRepository = new ComplejoRepository(ComplejoMapper);
            this.DirectorioRepository = new DirectorioRepository(PersonaMapper);
            this.DocumentoPdfBlobRepository = new DocumentoPdfBlobRepository(DocumentoPdfBlobMapper);
            this.DocumentoPdfRepository = new DocumentoPdfRepository(DocumentoPdfMapper);
            this.TipoGrupoDocumentacionRepository = new TipoGrupoDocumentacionRepository(TipoGrupoDocumentacionMapper);
            this.TiendaGrupoDocumentacionDtoRepository = new TiendaGrupoDocumentacionDtoRepository(TiendaGrupoDocumentacionMapper);
            this.TiendaDtoRepository = new TiendaDtoRepository(TiendaMapper, TiendaGrupoDocumentacionDtoRepository);
            this.DepartamentoGrupoDocumentacionDtoRepository = new DepartamentoGrupoDocumentacionDtoRepository(DepartamentoGrupoDocumentacionMapper);
            this.DepartamentoDtoRepository = new DepartamentoDtoRepository(DepartamentoMapper, DepartamentoGrupoDocumentacionDtoRepository);          
            this.GrupoDocumentacionDtoRepository = new GrupoDocumentacionDtoRepository(GrupoDocumentacionMapper);
            this.PapelDtoRepository = new PapelDtoRepository(PapelMapper);        
            this.TipoDocumentacionRepository = new TipoDocumentacionRepository(TipoDocumentacionMapper);
            this.MenuDocumentalRepository = new MenuDocumentalRepository(MenuDocumentalMapper);
            this.ClasificacionDocumentacionRepository = new ClasificacionDocumentacionDtoRepository(ClasificacionDocumentacionlMapper);
        }

        private void InitServices()
        {
            this.TipoDocumentacionService = new TipoDocumentacionService(TipoDocumentacionRepository);
            this.MenuDocumentalService = new MenuDocumentalService(MenuDocumentalRepository);
            this.ClasificacionDocumentacionService = new ClasificacionDocumentacionService(ClasificacionDocumentacionRepository, TipoDocumentacionService, MenuDocumentalService);
            this.DocumentoPdfService = new DocumentoPDFService(DocumentoPdfRepository, DocumentoPdfBlobRepository);
            this.AppService = new AppService(AppRepository);           
            this.SucursalService= new SucursalService(AppService);
            this.BienvenidaService = new BienvenidaService(SucursalService);
            this.ComplejoService = new ComplejoService(ComplejoRepository);     
            this.TipoGrupoDocumentacionService = new TipoGrupoDocumentacionService(TipoGrupoDocumentacionRepository, DepartamentoGrupoDocumentacionDtoRepository, TiendaGrupoDocumentacionDtoRepository);
            this.DepartamentoService = new DepartamentoService(DepartamentoDtoRepository, TipoGrupoDocumentacionService, ComplejoService);           
            this.DirectorioService = new DirectorioService(DirectorioRepository);         
            this.IndexService = new IndexService(AppService);           
            this.PapelService = new PapelService( DirectorioService, PapelDtoRepository, DocumentoPdfService,TipoDocumentacionService, ClasificacionDocumentacionService);
            this.GrupoDocumentacionService = new GrupoDocumentacionService(PapelService, TipoGrupoDocumentacionService, GrupoDocumentacionDtoRepository, TipoGrupoDocumentacionRepository, TiendaGrupoDocumentacionDtoRepository, DepartamentoGrupoDocumentacionDtoRepository);
            this.VisorDocumentacionService = new VisorDocumentacionService(GrupoDocumentacionService, PapelService);
            this.TiendaService = new TiendasService(ComplejoService, TiendaDtoRepository, TipoGrupoDocumentacionService, PapelService, DepartamentoService);
            this.VisorPDFService = new VisorPDFService(DocumentoPdfService);
        }
    }
}
