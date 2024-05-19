using BRapp.Data;
using BRapp.Dto;
using BRapp.Mapper;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Repositorios.Repos
{
    internal class DocumentoPdfRepository : BaseRepository, IDocumentoPdfRepository
    {
        private static DocumentoPdfRepository instance;
        private readonly string QUERY_DELETE = "Delete FROM DocumentoPDF where id = @documentoId";
        private readonly string QUERY_SELECT_ALL_DOCUMENTOS_PDF = "SELECT id,pdf,image FROM DocumentoPDF";
        private readonly string QUERY_SELECT_DOCUMENTO_PDF_BLOBS = "SELECT * FROM DocumentoPDF WHERE id = @documentoId";
        private readonly string QUERY_UPDATE = "UPDATE DocumentoPDF SET pdf = @pdf, image = @image, blob_pdf = @blob_pdf, blob_imagen = @blob_imagen WHERE id = @documentoId";
        private readonly string QUERY_INSERT = "INSERT INTO DocumentoPDF (id, pdf, image, blob_pdf, blob_imagen) VALUES ( @documentoId, @pdf, @image, @blob_pdf, @blob_imagen)";

        private readonly List<DocumentoPDF> documentos;
        private readonly IMapper mapperDocumentoPDF;
        private readonly IMapper mapperDocumentoPDFBlob;
        private readonly IFileService filePdfLogoService;
        private readonly IFileService filePdfDocumentService;

        public DocumentoPdfRepository() : base(AplicationConfig.ConnectionString, "DocumentoPDF")
        {
            filePdfLogoService = new FileService();
            filePdfDocumentService = new FileService();
            mapperDocumentoPDF = new DocumentoPdfMapper(filePdfLogoService, filePdfDocumentService);
            mapperDocumentoPDFBlob = new DocumentoPdfBlobMapper();
            documentos = getAll();
        }

        public void Delete(DocumentoPDF documentoPDF)
        {           
            Dictionary<string, object> parametros = buildParametros(documentoPDF);
            int index = getIndexById(documentoPDF.Id);
            if (index != -1)
            {
                documentos.RemoveAt(index);
                ExecuteWriteOperation(QUERY_DELETE, parametros);
            }
        }

        private List<DocumentoPDF> getAll()
        {
            List<DocumentoPDF> pdfs = new List<DocumentoPDF>();
            using (var reader = EjecutarConsulta(QUERY_SELECT_ALL_DOCUMENTOS_PDF))
            {
                while (reader.Read())
                {
                    pdfs.Add((DocumentoPDF)mapperDocumentoPDF.Map(reader));
                }
            }
            return pdfs;
        }

        public DocumentoPDF getDocumentoApliado(Guid id)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@documentoId", id.ToString() }
                };

                DocumentoPDF documentoPDF = null;
                using (var reader = EjecutarConsulta(QUERY_SELECT_DOCUMENTO_PDF_BLOBS, parametros))
                {
                    while (reader.Read())
                    {
                        documentoPDF = (DocumentoPDF)mapperDocumentoPDFBlob.Map(reader);
                    }
                }
                return documentoPDF;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public DocumentoPDF getById(Guid id)
        {
            return documentos.FirstOrDefault(doc => doc.Id == id);
        }
        private int getIndexById(Guid id)
        {
            return documentos.FindIndex(doc => doc.Id == id);
        }

        public bool saveOrUpdate(DocumentoPDF documentoPDF)
        {           
            int index = getIndexById(documentoPDF.Id);
            if (index != -1)
            {               
                DocumentoPDF documentoAmpliado = getDocumentoApliado(documentoPDF.Id);
                DocumentoPDF documentoPDFClonado = documentoPDF.clone();
                documentoPDFClonado.PDF = (!documentoPDFClonado.hasDocumento() && documentoAmpliado.hasDocumento()) ? documentoAmpliado.PDF : documentoPDFClonado.PDF;
                documentoPDFClonado.Imagen = (!documentoPDFClonado.hasImagen() && documentoAmpliado.hasImagen()) ? documentoAmpliado.Imagen : documentoPDFClonado.Imagen;
                                
                Dictionary<string, object> parametros = buildParametros(documentoPDFClonado);
                documentoPDFClonado.limpiarFicheros();
                documentos[index] = documentoPDFClonado;
                return ExecuteWriteOperation(QUERY_UPDATE, parametros);
            }
            else
            {
                Dictionary<string, object> parametros = buildParametros(documentoPDF);
                bool result = ExecuteWriteOperation(QUERY_INSERT, parametros);
                documentoPDF.limpiarFicheros();
                documentos.Add(documentoPDF);
                return result;
            }
        }

        private Dictionary<string, object> buildParametros(DocumentoPDF documentoPDF)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@pdf",  (documentoPDF.PDF != null) ? documentoPDF.PDF.Name:"" },
                { "@image", (documentoPDF.Imagen != null) ? documentoPDF.Imagen.Name:"" },
                { "@blob_pdf", (documentoPDF.PDF != null && documentoPDF.PDF.Data != null && documentoPDF.PDF.Data.Length > 0) ? Convert.ToBase64String(documentoPDF.PDF.Data):"" },             
                { "@blob_imagen", (documentoPDF.Imagen != null && documentoPDF.Imagen.Data != null && documentoPDF.Imagen.Data.Length > 0) ? ImageManager.GetBase64Image(documentoPDF.Imagen.Data , 120, 138, 90) : ""},
                { "@documentoId", documentoPDF.Id.ToString() }
            };           
            return parametros;
        }


        public static DocumentoPdfRepository Instance
        {
            get
            {
                instance = (instance == null) ? new DocumentoPdfRepository() : instance;
                return instance;
            }
        } 
    }
}
