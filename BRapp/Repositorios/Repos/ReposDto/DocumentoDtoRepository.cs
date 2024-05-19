using BRapp.Data;
using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos.ReposDto
{
    internal class DocumentoDtoRepository : BaseRepository, IDocumentoDtoRepository
    {
        private static DocumentoDtoRepository instance;
        private readonly string QUERY_DELETE = "Delete FROM Documento where id_papel = @papelId";
        private readonly string QUERY_SELECT_ALL = "SELECT * FROM Documento";
        private readonly string QUERY_UPDATE = "UPDATE Documento SET id_responsable = @responsable WHERE id_papel = @papelId";
        private readonly string QUERY_INSERT = "INSERT INTO Documento (id_papel, id_responsable) VALUES ( @papelId, @responsable)";
        private readonly List<DocumentoDto> documentoDtos;
        private readonly IMapper mapperDocumento;

        private DocumentoDtoRepository() : base(AplicationConfig.ConnectionString, "Documento")
        {
            mapperDocumento = new DocumentoMapper();
            documentoDtos = getAll_DocumentosDto();
        }

        public void Delete(Documento papel)
        {
            DocumentoDto documentoDto = (DocumentoDto)mapperDocumento.Map(papel);
            Dictionary<string, object> parametros = buildParametros(documentoDto);
            int index = getIndexById(documentoDto.idPapel);
            if (index != -1)
            {
                documentoDtos.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }

        private List<DocumentoDto> getAll_DocumentosDto()
        {
            List<DocumentoDto> documentos = new List<DocumentoDto>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL))
            {
                while (reader.Read())
                {
                    documentos.Add((DocumentoDto)mapperDocumento.Map(reader));
                }
            }
            return documentos;
        }


        public DocumentoDto getById(Guid id)
        {
            return documentoDtos.FirstOrDefault(doc => doc.idPapel == id);
        }

        private int getIndexById(Guid id)
        {
            return documentoDtos.FindIndex(doc => doc.idPapel == id);
        }

        public ActionResult saveOrUpdate(Documento papel)
        {
            DocumentoDto documentoDto = (DocumentoDto)mapperDocumento.Map(papel);
            Dictionary<string, object> parametros = buildParametros(documentoDto);
            int index = getIndexById(documentoDto.idPapel);
            if (index != -1)
            {
                documentoDtos[index] = documentoDto;
                ExecuteWriteOperation(QUERY_UPDATE, parametros);
                return ActionResult.UPDATED;
            }
            else
            {
                ExecuteWriteOperation(QUERY_INSERT, parametros);
                documentoDtos.Add(documentoDto);
                return ActionResult.CREATED;
            }
        }

        private Dictionary<string, object> buildParametros(DocumentoDto documentoDto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@responsable", documentoDto.idResponsable.ToString() },               
                { "@papelId", documentoDto.idPapel.ToString() }
            };
            return parametros;
        }

        public static DocumentoDtoRepository Instance
        {
            get
            {
                instance = (instance == null) ? new DocumentoDtoRepository() : instance;
                return instance;
            }
        } 
    }
}
