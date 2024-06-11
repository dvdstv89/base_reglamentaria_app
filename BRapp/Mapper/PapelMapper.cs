using BRapp.Dto;
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
                IdPapel = documento.Id,
                IdPdf = (documento.ArchivoPDF != null) ? documento.ArchivoPDF.Id : Guid.Empty,
                Name = documento.Name,              
                FechaFirma = documento.FechaFirma,
                Descripcion = documento.Descripcion,
                IsActivo = documento.IsActivo,
                Orden = documento.Orden,
                IdTipoDocumentacion = (documento.TipoDocumentacion != null) ? documento.TipoDocumentacion.Id : Guid.Empty,
                IdPadre = (documento.Padre != null) ? documento.Padre.Id : Guid.Empty,
                IdCliente = (documento.Cliente != null) ? documento.Cliente.Id : Guid.Empty,
                IdResponsable = (documento.Responsable != null) ? documento.Responsable.Id : Guid.Empty,
                FechaVencimiento = documento.FechaVencimiento,
                Numero = documento.Numero,
                Acta = documento.NumeroActa,
                Acuerdo = documento.NumeroAcuerdo,
                Tipo = documento.Tipo,
                IsOpcional= documento.IsOpcional,
            };
        }

        public object Map(SqliteDataReader reader)
        {
            PapelDto papel = new PapelDto()
            {
                IdPapel = Guid.Parse(reader["id"].ToString()),
                IdPdf = Guid.Parse(reader["id_pdf"].ToString()),
                Name = reader["name"].ToString(),             
                FechaFirma = Convert.ToDateTime(reader["fecha"].ToString()),
                Descripcion = reader["descripcion"].ToString(),
                Orden = Convert.ToInt32(reader["orden"].ToString()),
                IsActivo = Convert.ToBoolean(reader["is_activo"]),
                IdTipoDocumentacion = Guid.Parse(reader["id_tipo_documentacion"].ToString()),
                IdPadre = Guid.Parse(reader["id_padre"].ToString()),
                IdCliente = Guid.Parse(reader["id_cliente"].ToString()),
                IdResponsable = Guid.Parse(reader["id_responsable"].ToString()),
                FechaVencimiento = Convert.ToDateTime(reader["fecha_vencimiento"].ToString()),
                Tipo = reader["tipo"].ToString(),
                Numero = reader["numero"].ToString(),
                Acta = reader["acta"].ToString(),
                IsOpcional = Convert.ToBoolean(reader["is_opcional"]),
                Acuerdo = reader["acuerdo"].ToString()
            };           
            return papel;
        }
    }
}
