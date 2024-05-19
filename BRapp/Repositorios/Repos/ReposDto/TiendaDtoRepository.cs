using BRapp.Data;
using BRapp.Mapper;
using System;
using System.Collections.Generic;
using BRapp.Model.Tiendas;
using System.Linq;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Dto;
using BRapp.Utiles;

namespace BRapp.Repositorios.Repos.ReposDto
{
    public class TiendaDtoRepository : BaseRepository, ITiendaDtoRepository
    {
        private static TiendaDtoRepository instance; 

        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Tienda order by orden";
        private readonly string QUERY_UPDATE = @"UPDATE Tienda SET  name = @name, ubicacion = @ubicacion, telefono = @telefono, cantidad_trabajadores = @cantidad_trabajadores, 
                                                cantidad_cajas_registradoras = @cantidad_cajas_registradoras, numero_registro_comercial = @numero_registro_comercial, certificado_scg = @certificado_scg, certificado_tmhs = @certificado_tmhs,
                                                certificado_sanitaria = @certificado_sanitaria, is_activo = @is_activo, tipo_tienda = @tipo_tienda, tipo_moneda = @tipo_moneda,
                                                id_complejo = @id_complejo, id_certificado_comercial = @id_certificado_comercial, orden = @orden WHERE id = @Id";
        private readonly string QUERY_INSERT = @"INSERT INTO Tienda 
                                                (id,   name, ubicacion,  telefono,  cantidad_trabajadores,  cantidad_cajas_registradoras,  numero_registro_comercial, certificado_scg, certificado_tmhs, certificado_sanitaria, is_activo, tipo_tienda, tipo_moneda, id_complejo, id_certificado_comercial, orden) 
                                         VALUES (@Id, @name, @ubicacion, @telefono, @cantidad_trabajadores, @cantidad_cajas_registradoras, @numero_registro_comercial, @certificado_scg, @certificado_tmhs, @certificado_sanitaria, @is_activo, @tipo_tienda, @tipo_moneda, @id_complejo, @id_certificado_comercial, @orden)"; 
        private List<TiendaDto> tiendaDtos;      
        private readonly IMapper mapperTienda;

        protected TiendaDtoRepository():base(AplicationConfig.ConnectionString, "Tienda")
        {
            mapperTienda = new TiendaMapper();  
            updateListApp();

        }

        protected void updateListApp()
        {
            tiendaDtos = getAll();
        }

        public List<TiendaDto> getAll()
        {
            List<TiendaDto> apps = new List<TiendaDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        apps.Add((TiendaDto)mapperTienda.Map(reader));
                    }
                }
            }
            return apps;
        }      

        public TiendaDto getById(Guid id)
        {
            return tiendaDtos.FirstOrDefault(persona => persona.id == id);
        }

        private int getIndexById(Guid id)
        {
            return tiendaDtos.FindIndex(doc => doc.id == id);
        }

        public ActionResult saveOrUpdate(Tienda tienda)
        {
            TiendaDto tiendaDto = (TiendaDto)mapperTienda.Map(tienda);
            Dictionary<string, object> parametros = buildParametros(tiendaDto);
            int index = getIndexById(tiendaDto.id);
            if (index != -1)
            {
                tiendaDtos[index] = tiendaDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                tiendaDtos.Add(tiendaDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(TiendaDto tiendaDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@name", tiendaDto.name },
                { "@ubicacion", tiendaDto.ubicacion },
                { "@telefono", tiendaDto.telefono },
                { "@cantidad_trabajadores", tiendaDto.cantidadTrabajadores },
                { "@cantidad_cajas_registradoras", tiendaDto.cantidadCajasRegistradoras },
                { "@numero_registro_comercial", tiendaDto.numeroRegistroComercial },
                { "@certificado_scg", tiendaDto.CertificadoSCG },
                { "@certificado_tmhs", tiendaDto.CertificadoTMHS },
                { "@certificado_sanitaria", tiendaDto.CertificadoSANITARIA },
                { "@is_activo", tiendaDto.IsActivo },
                { "@tipo_tienda", tiendaDto.tiendaTipo },
                { "@tipo_moneda", tiendaDto.tipoMoneda },
                { "@id_complejo", tiendaDto.idComplejo },
                { "@id_certificado_comercial", tiendaDto.idCertificadoComercial },
                { "@orden", tiendaDto.Orden },
                { "@Id", tiendaDto.id.ToString() }
            };          
            return parametros;
        }

        public static TiendaDtoRepository Instance
        {
            get
            {                
                instance = (instance == null) ? new TiendaDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
