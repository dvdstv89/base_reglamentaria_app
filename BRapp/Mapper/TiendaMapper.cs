using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model.Tiendas;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class TiendaMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Tienda tienda = (Tienda) objeto;
            return new TiendaDto()
            {
                id = tienda.Id,
                name = tienda.Name,
                ubicacion = tienda.Ubicacion,
                telefono= tienda.Telefono,
                cantidadTrabajadores = tienda.CantidadTrabajadores,
                cantidadCajasRegistradoras= tienda.CantidadCajasRegistradoras,
                numeroRegistroComercial= tienda.NumeroRegistroComercial,
                CertificadoSCG= tienda.CertificadoSCG,
                CertificadoTMHS= tienda.CertificadoTMHS,
                CertificadoSANITARIA= tienda.CertificadoSANITARIA,
                IsActivo= tienda.IsActivo,
                tiendaTipo = tienda.TiendaTipo,
                tipoMoneda= tienda.TipoMoneda,
                idComplejo = (tienda.Complejo != null) ? tienda.Complejo.Id : Guid.Empty,
                idCertificadoComercial = (tienda.CertificadoComercial != null) ? tienda.CertificadoComercial.Id : Guid.Empty                
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new TiendaDto()
            {
                id = Guid.Parse(reader["id"].ToString()),
                name = reader["name"].ToString(),     
                ubicacion = reader["ubicacion"].ToString(),
                telefono = reader["telefono"].ToString(),
                cantidadTrabajadores = Convert.ToInt32(reader["cantidad_trabajadores"].ToString()),
                cantidadCajasRegistradoras = Convert.ToInt32(reader["cantidad_cajas_registradoras"].ToString()),
                numeroRegistroComercial = reader["numero_registro_comercial"].ToString(),
                CertificadoSCG = Convert.ToBoolean(reader["certificado_scg"]),
                CertificadoTMHS = Convert.ToBoolean(reader["certificado_tmhs"]),
                CertificadoSANITARIA = Convert.ToBoolean(reader["certificado_sanitaria"]),
                IsActivo = Convert.ToBoolean(reader["is_activo"]),
                tiendaTipo = (TipoTienda)Enum.Parse(typeof(TipoTienda), reader["tipo_tienda"].ToString()),
                tipoMoneda = (TipoMoneda)Enum.Parse(typeof(TipoMoneda), reader["tipo_moneda"].ToString()),
                idComplejo = Guid.Parse(reader["id_complejo"].ToString()),
                idCertificadoComercial = Guid.Parse(reader["id_certificado_comercial"].ToString()) 
            };
        }
    }
}
