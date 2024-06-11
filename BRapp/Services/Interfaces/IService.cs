using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using BRapp.Model.Nomenclador;

namespace BRapp.Services.Interfaces
{
    public interface IService<Tipo, Dto>
    {
        Dto GetById(Guid id);
        ActionResult SaveOrUpdate(Tipo tipo);
        ActionResult Delete(Guid id);
        List<Tipo> GetAll();
        List<Dto> GetAllDto();
    }
    public interface IComplejoService : IService<Complejo, Complejo> { } //ok    
    public interface IPapelService : IService<Papel, Papel> 
    {
        List<Papel> GetByMenuDocumental(MenuDocumental menuDocumental);       
        List<Papel> GetAllByTipoPapelDistint(Papel papelActual);
        List<Papel> GetAllByTipoDocumentacion(TipoDocumentacion tipoDocumentacion);
        List<Papel> GetAllWhitCard();
    }//ok  
    public interface ITipoGrupoDocumentacionService : IService<TipoGrupoDocumentacion, TipoGrupoDocumentacion>
    {
        List<TipoGrupoDocumentacion> GetByIdDepartamento(Guid id);
        List<TipoGrupoDocumentacion> GetByIdTienda(Guid id);
        List<TipoGrupoDocumentacion> GetAllForTienda();
        List<TipoGrupoDocumentacion> GetAllForDepartamentos();
    } //ok
    public interface IDepartamentoService : IService<Departamento, Departamento>
    {
        ActionResult DeleteByTipo(Departamento tipo);
        List<Departamento> GetDepartamentosByComplejo(Complejo complejo);
        List<Departamento> GetDepartamentosTiendaByComplejo(Complejo complejo);
    } //ok
    public interface ITiendaService : IService<Tienda, Tienda>
    {
        ActionResult DeleteByTipo(Tienda tipo);
        List<Tienda> GetTiendasByComplejo(Complejo complejo);
    }//ok
    public interface IGrupoDocumentacionService : IService<GrupoDocumentacion, GrupoDocumentacion>
    {      
        List<GrupoDocumentacion> GetAllByTipoGrupoDocumentacion(Guid idTipoGrupoDocumentacion);
        ActionResult DeleteTipo(Guid idTipoGrupoDocumentacion);
    }//ok
    public interface ITipoDocumentacionService : IService<TipoDocumentacion, TipoDocumentacion> 
    {
        List<TipoDocumentacion> GetAllByTipoCard(TipoCard tipoCard);
    } //ok    
    public interface IMenuDocumentalService : IService<MenuDocumental, MenuDocumental> 
    {
        List<MenuDocumental> GetAllByTipoUbicacionMenu(TipoUbicacionMenu tipoUbicacionMenu);
    } //ok    
    public interface IClasificacionDocumentacionService : IService<ClasificacionDocumentacion, ClasificacionDocumentacion> 
    {
        ActionResult DeleteByTipoDocumentacion(Guid id);
        ActionResult DeleteByMenuDocumental(Guid id);
        List<TipoDocumentacion> GetTipoDocumentacionsByMenuDocumental(Guid id);
    } //ok   

}
