using BRapp.Dto;
using BRapp.Model.Nomenclador;
using Microsoft.Data.Sqlite;
using System;

namespace BRapp.Mapper
{
    internal class ClasificacionDocumentacionlMapper : IMapper
    {
        public object Map(object objeto)
        {
            ClasificacionDocumentacion documento = (ClasificacionDocumentacion)objeto;
            return new ClasificacionDocumentacionDto()
            {
                Id = documento.Id,
                IdTipoDocumentacion = (documento.TipoDocumentacion != null) ? documento.TipoDocumentacion.Id : Guid.Empty,
                IdMenuDocumental = (documento.MenuDocumental != null) ? documento.MenuDocumental.Id : Guid.Empty               
            };
        }

        public object Map(SqliteDataReader reader)
        {
            return new ClasificacionDocumentacionDto()
            {
                Id = Guid.Parse(reader["id"].ToString()),
                IdTipoDocumentacion = Guid.Parse(reader["id_tipo_documentacion"].ToString()),
                IdMenuDocumental = Guid.Parse(reader["id_menu_documental"].ToString())
            };
        }
    }
}
