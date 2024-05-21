using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class PapelMapper : IMapper
    {     
        public object Map(object objeto)
        {
            Papel documento = (Papel) objeto;
            return new PapelDto()
            {
                idPapel = documento.Id,
                idPdf = (documento.DocumentoPDF != null) ? documento.DocumentoPDF.Id : Guid.Empty,
                name = documento.Name,
                tipoClasificacionDocumento = documento.TipoClasificacionDocumento,
                FechaFirma = documento.FechaFirma,
                Descripcion = documento.Descripcion,
                IsActivo = documento.IsActivo,
                Orden = documento.Orden,

            };
        }

        public object Map(SqliteDataReader reader)
        {
            PapelDto papel = new PapelDto()
            {
                idPapel = Guid.Parse(reader["id"].ToString()),
                idPdf = Guid.Parse(reader["id_pdf"].ToString()),
                name = reader["name"].ToString(),
                tipoClasificacionDocumento = (TipoClasificacionDocumento)Enum.Parse(typeof(TipoClasificacionDocumento), reader["tipo_clasificacion_documento"].ToString()),
                FechaFirma = Convert.ToDateTime(reader["fecha"].ToString()),
                Descripcion = reader["descripcion"].ToString(),
                Orden = Convert.ToInt32(reader["orden"].ToString())
            };
            papel.IsActivo = Convert.ToBoolean(reader["is_activo"]);
            return papel;
        }
    }
}
