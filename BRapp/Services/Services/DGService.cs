using BRapp.Dto;
using BRapp.Model;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Interfaces.Dto;
using BRapp.Repositorios.Repos;
using BRapp.Repositorios.Repos.ReposDto;
using BRapp.Services.Interfaces;
using System;

namespace BRapp.Services.Services
{
    internal class DGService : IDGService
    {
        private static DGService instance;       
        private readonly IDGDtoRepository dGDtoRepository;
        private readonly IDocumentoPdfRepository documentoPdfRepository;

        private DGService()
        {
            dGDtoRepository = DgDtoRepository.Instance;
            documentoPdfRepository = DocumentoPdfRepository.Instance;
        }      

        public DGDto getByPapel(PapelDto papel)
        {   
            return dGDtoRepository.getById(papel.idPapel);
        }

        public bool saveOrUpdate(DG papel)
        {           
            return dGDtoRepository.saveOrUpdate(papel);
        }

        public DocumentoPDF getDocumentoPDFApliado(DG dg)
        {
            return documentoPdfRepository.getDocumentoApliado(dg.DocumentoPDF.Id);
        }

        public static DGService Instance
        {
            get
            {
                instance = (instance == null) ? new DGService() : instance;
                return instance;
            }
        }                   
    }
}
