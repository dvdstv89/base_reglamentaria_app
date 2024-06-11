using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class PapelDtoRepository : BaseRepository<PapelDto>, IPapelDtoRepository
    {
        private static readonly string QUERY_DELETE = "Delete FROM Papel where id = @Id";
        private static readonly string QUERY_SELECT_ALL = "SELECT * FROM Papel order by orden desc";
        private static readonly string QUERY_UPDATE = "UPDATE Papel SET  id_pdf = @id_pdf, name = @name, is_activo = @is_activo, fecha = @fecha, descripcion = @descripcion, orden = @orden, id_tipo_documentacion = @id_tipo_documentacion,"
                                        + "id_padre = @idPadre, id_Cliente = @idCliente, id_responsable = @idResponsable, fecha_vencimiento = @fechaVencimiento, numero = @numero, acta = @acta, acuerdo = @acuerdo, tipo = @tipo, is_opcional = @is_opcional WHERE id = @documentoId";
        private static readonly string QUERY_INSERT = "INSERT INTO Papel (id, id_pdf, name, is_activo, fecha, descripcion, orden, id_tipo_documentacion, id_padre, id_Cliente, id_responsable, fecha_vencimiento, numero, acta, acuerdo, tipo, is_opcional) VALUES ( @documentoId, @id_pdf, @name, @is_activo, @fecha, @descripcion, @orden, @id_tipo_documentacion, @idPadre, @idCliente, @idResponsable, @fechaVencimiento, @numero, @acta, @acuerdo, @tipo, @is_opcional)";
        
        public PapelDtoRepository(IMapper mapperPapel) : base(mapperPapel, QUERY_DELETE, QUERY_SELECT_ALL) { }

        public ActionResult SaveOrUpdate(Papel papel)
        {
            PapelDto papelDto = (PapelDto)mapper.Map(papel);
            return saveOrUpdate(QUERY_INSERT, QUERY_UPDATE, papelDto);
        }
        protected override Dictionary<string, object> buildParametros(PapelDto papelDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {               
                { "@id_pdf", papelDto.IdPdf.ToString() },
                { "@name", papelDto.Name},
                { "@is_activo", papelDto.IsActivo},
                { "@fecha", papelDto.FechaFirma },
                { "@descripcion", papelDto.Descripcion},
                { "@orden", papelDto.Orden},
                { "@id_tipo_documentacion", papelDto.IdTipoDocumentacion},
                { "@idPadre", papelDto.IdPadre.ToString() },
                { "@idCliente", papelDto.IdCliente.ToString() },
                { "@idResponsable", papelDto.IdResponsable.ToString() },
                { "@fechaVencimiento", papelDto.FechaVencimiento },
                { "@numero", papelDto.Numero },
                { "@acta", papelDto.Acta },
                { "@acuerdo", papelDto.Acuerdo },
                { "@tipo", papelDto.Tipo },
                { "@is_opcional", papelDto.IsOpcional },
                { "@documentoId", papelDto.IdPapel.ToString() }
            };
            return parametros;
        }
    }
}
