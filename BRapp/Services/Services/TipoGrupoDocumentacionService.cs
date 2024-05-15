
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class TipoGrupoDocumentacionService : ITipoGrupoDocumentacionService
    {
        private static TipoGrupoDocumentacionService instance;
        protected readonly ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository;

        public TipoGrupoDocumentacionService()
        {
            tipoGrupoDocumentacionRepository = TipoGrupoDocumentacionRepository.Instance;
        }

        public static TipoGrupoDocumentacionService Instance
        {
            get
            {              
                instance = (instance == null) ? new TipoGrupoDocumentacionService() : instance;
                return instance;
            }
        }

        public List<TipoGrupoDocumentacion> getAll()
        {
           return tipoGrupoDocumentacionRepository.getAll();            
        }

        public TipoGrupoDocumentacion getById(Guid id)
        {
            return tipoGrupoDocumentacionRepository.getById(id);
        }
    }
}
