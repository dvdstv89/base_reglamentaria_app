using BRapp.Dto;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using System.Collections.Generic;
using System;
using BRapp.Model.Nomenclador;

namespace BRapp.Repositorios.Interfaces
{
    public interface IRepository<Tipo, Dto>  {  
        ActionResult SaveOrUpdate(Tipo tipo);
        Dto GetById(Guid id);
        ActionResult DeleteById(Guid id);
        List<Dto> GetAll();
    }
    //public interface ICertificadoComercialDtoRepository : IRepository<CertificadoComercial, CertificadoComercialDto> { } //ok
    //public interface IContratoDtoRepository : IRepository<Contrato, ContratoDto> { } //ok
    public interface IDepartamentoDtoRepository : IRepository<Departamento, DepartamentoDto> { }//ok
    //public interface IDocumentoDtoRepository : IRepository<Documento, DocumentoDto> { } //ok
    public interface IGrupoDocumentacionDtoRepository : IRepository<GrupoDocumentacion, GrupoDocumentacionDto> { } //ok
    //public interface IIndicacionDtoRepository : IRepository<Indicacion, IndicacionDto> { } //ok
    public interface IPapelDtoRepository : IRepository<Papel, PapelDto> { } //ok
    //public interface IResolucionDtoRepository : IRepository<Resolucion, ResolucionDto> { } //ok
    //public interface ISistemaDtoRepository : IRepository<Sistema, SistemaDto> { }   //ok
    public interface ITiendaDtoRepository : IRepository<Tienda, TiendaDto> { }  //ok
    public interface IComplejoRepository : IRepository<Complejo, Complejo> { }  //ok
    public interface IDirectorioRepository : IRepository<Persona, Persona> { } //ok
    public interface ITipoGrupoDocumentacionRepository : IRepository<TipoGrupoDocumentacion, TipoGrupoDocumentacion> { } //ok
    public interface IDocumentoPdfRepository : IRepository<DocumentoPDF, DocumentoPDF> { } //ok
    public interface IDocumentoPdfBlobRepository : IRepository<DocumentoPDFBlob, DocumentoPDFBlob> { } //ok
    public interface ITipoDocumentacionRepository : IRepository<TipoDocumentacion, TipoDocumentacion> { }  //ok
    public interface IMenuDocumentalRepository : IRepository<MenuDocumental, MenuDocumental> { }  //ok
    public interface IClasificacionDocumentacionRepository : IRepository<ClasificacionDocumentacion, ClasificacionDocumentacionDto> 
    {
        ActionResult DeleteByTipoDocumentacion(Guid IdTipoDocumentacion);
        ActionResult DeleteByMenuDocumental(Guid IdMenuDocumental);
    }   //ok
}
