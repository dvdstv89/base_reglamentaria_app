using BRapp.Mapper;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Dto;
using BRapp.Utiles;
using System;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class TiendaDtoRepository : BaseRepository<TiendaDto>, ITiendaDtoRepository
    {       
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Tienda order by orden";
        private static readonly string QUERY_UPDATE = @"UPDATE Tienda SET  name = @name, ubicacion = @ubicacion, telefono = @telefono, cantidad_trabajadores = @cantidad_trabajadores, 
                                                cantidad_cajas_registradoras = @cantidad_cajas_registradoras, certificado_scg = @certificado_scg, certificado_tmhs = @certificado_tmhs,
                                                certificado_sanitaria = @certificado_sanitaria, is_activo = @is_activo, tipo_tienda = @tipo_tienda, tipo_moneda = @tipo_moneda,
                                                id_complejo = @id_complejo, id_departamento = @id_departamento, id_certificado_comercial = @id_certificado_comercial, orden = @orden, logo = @logo WHERE id = @Id";
        private static readonly string QUERY_INSERT = @"INSERT INTO Tienda 
                                                (id,   name, ubicacion,  telefono,  cantidad_trabajadores,  cantidad_cajas_registradoras,  certificado_scg, certificado_tmhs, certificado_sanitaria, is_activo, tipo_tienda, tipo_moneda, id_complejo, id_certificado_comercial, orden, id_departamento, logo) 
                                         VALUES (@Id, @name, @ubicacion, @telefono, @cantidad_trabajadores, @cantidad_cajas_registradoras, @certificado_scg, @certificado_tmhs, @certificado_sanitaria, @is_activo, @tipo_tienda, @tipo_moneda, @id_complejo, @id_certificado_comercial, @orden, @id_departamento, @logo)";
        private static readonly string QUERY_DELETE = "Delete FROM Tienda WHERE id = @Id";

        private readonly ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionDtoRepository;

        public TiendaDtoRepository(IMapper tiendaMapper, ITiendaGrupoDocumentacionDtoRepository tiendaGrupoDocumentacionDtoRepository) : base(tiendaMapper, QUERY_DELETE, QUERY_SELECT_ALL) 
        {
            this.tiendaGrupoDocumentacionDtoRepository = tiendaGrupoDocumentacionDtoRepository;
        }

        public override ActionResult DeleteById(Guid id)
        {
            base.DeleteById(id);
            return tiendaGrupoDocumentacionDtoRepository.DeleteForTienda(id);
        }


        public ActionResult SaveOrUpdate(Tienda tienda)
        {
            TiendaDto tiendaDto = (TiendaDto)mapper.Map(tienda);
            ActionResult actionResult = saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, tiendaDto);
            List<TiendaGrupoDocumentacionDto> gruposAntiguos = tiendaGrupoDocumentacionDtoRepository.getAllByIdTienda(tienda.Id);
            List<TipoGrupoDocumentacion> gruposNuevos = tienda.TipoGrupoDocumentacion;


            List<TiendaGrupoDocumentacionDto> gruposParaEliminar = gruposAntiguos
                 .Where(antiguo => !gruposNuevos.Any(nuevo => nuevo.Id == antiguo.idTipoGrupoDocumentacion))
                 .ToList();

            List<TipoGrupoDocumentacion> gruposParaGuardar = gruposNuevos
                .Where(nuevo => !gruposAntiguos.Any(antiguo => antiguo.idTipoGrupoDocumentacion == nuevo.Id))
                .ToList();

            foreach (var grupoEliminar in gruposParaEliminar)
            {
                tiendaGrupoDocumentacionDtoRepository.Delete(grupoEliminar);
            }

            foreach (var grupoGuardar in gruposParaGuardar)
            {
                var grupoNuevo = new TiendaGrupoDocumentacionDto()
                {
                    idTienda = tienda.Id,
                    idTipoGrupoDocumentacion = grupoGuardar.Id
                };
                tiendaGrupoDocumentacionDtoRepository.Save(grupoNuevo);
            }
            return actionResult;
        }

        protected override Dictionary<string, object> buildParametros(TiendaDto tiendaDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", tiendaDto.name },
                { "@ubicacion", tiendaDto.ubicacion },
                { "@telefono", tiendaDto.telefono },
                { "@cantidad_trabajadores", tiendaDto.cantidadTrabajadores },
                { "@cantidad_cajas_registradoras", tiendaDto.cantidadCajasRegistradoras },              
                { "@certificado_scg", tiendaDto.CertificadoSCG },
                { "@certificado_tmhs", tiendaDto.CertificadoTMHS },
                { "@certificado_sanitaria", tiendaDto.CertificadoSANITARIA },
                { "@is_activo", tiendaDto.IsActivo },
                { "@tipo_tienda", tiendaDto.tiendaTipo },
                { "@tipo_moneda", tiendaDto.tipoMoneda },
                { "@id_complejo", tiendaDto.idComplejo },
                { "@id_departamento", tiendaDto.idDepartamento },
                { "@id_certificado_comercial", tiendaDto.idCertificadoComercial },
                { "@orden", tiendaDto.Orden },
                { "@logo", (tiendaDto.Logo != null && tiendaDto.Logo.hasDataValid()) ? ImageManager.GetBase64Image(tiendaDto.Logo.Data, 120, 138, 90) : ""},
                { "@Id", tiendaDto.id.ToString() }
        };          
            return parametros;
        }
    }
}
