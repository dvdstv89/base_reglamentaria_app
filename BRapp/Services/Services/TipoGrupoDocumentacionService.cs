using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class TipoGrupoDocumentacionService : ITipoGrupoDocumentacionService
    {       
        protected readonly ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository;

        public TipoGrupoDocumentacionService(ITipoGrupoDocumentacionRepository tipoGrupoDocumentacionRepository)
        {
            this.tipoGrupoDocumentacionRepository = tipoGrupoDocumentacionRepository;
        }

        public List<TipoGrupoDocumentacion> getAll()
        {
           return tipoGrupoDocumentacionRepository.getAll();            
        }

        public TipoGrupoDocumentacion getById(Guid id)
        {
            return tipoGrupoDocumentacionRepository.getById(id);
        }
        public bool saveOrUpdate(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            return tipoGrupoDocumentacionRepository.saveOrUpdate(tipoGrupoDocumentacion);
        }
    }
}
