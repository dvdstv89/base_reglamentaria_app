using BRapp.Dto;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class DepartamentoService : BaseListServicio<Departamento, DepartamentoDto>, IDepartamentoService
    {      
       
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService; 
        private readonly IComplejoService complejoService;

        public DepartamentoService(IDepartamentoDtoRepository departamentoDtoRepository, ITipoGrupoDocumentacionService tipoGrupoDocumentacionService, IComplejoService complejoService)
            : base(departamentoDtoRepository)
        {   
            this.tipoGrupoDocumentacionService = tipoGrupoDocumentacionService;
            this.complejoService = complejoService;
            Populate();
        }

        protected override void Populate()
        {           
            List<DepartamentoDto> departamentosDto = repository.GetAll();
            foreach (DepartamentoDto dpto in departamentosDto)
            {              
                List<TipoGrupoDocumentacion> grupoDocumentacions = tipoGrupoDocumentacionService.GetByIdDepartamento(dpto.id);
                Complejo complejo = complejoService.GetById(dpto.idComplejo);
                listado.Add(new Departamento(dpto, complejo, grupoDocumentacions));
            }           
        }       
       
        public List<Departamento> GetDepartamentosByComplejo(Complejo complejo)
        {
            return listado.FindAll(t => t.Complejo.Id == complejo.Id);
        }
        public List<Departamento> GetDepartamentosTiendaByComplejo(Complejo complejo)
        {
            return listado.FindAll(t => t.Complejo.Id == complejo.Id && t.DepartamentoTipo == Enums.TipoDepartamento.GRUPO_TIENDA);
        }      
    }
}
