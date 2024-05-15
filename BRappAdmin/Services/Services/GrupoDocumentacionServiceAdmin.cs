using BRapp.Model.Tiendas;
using BRapp.Services.Services;
using BRappAdmin.Services.Interfaces;
using System.Collections.Generic;

namespace BRappAdmin.Services.Services
{
    internal class GrupoDocumentacionServiceAdmin : GrupoDocumentacionService, IGrupoDocumentacionServiceAdmin
    {
        private static GrupoDocumentacionServiceAdmin instance;
       
        public static GrupoDocumentacionServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new GrupoDocumentacionServiceAdmin() : instance;
                return instance;
            }
        }

        public List<GrupoDocumentacion> getAllByTipoGrupoDocumentacion(TipoGrupoDocumentacion tipoGrupoDocumentacion)
        {
            return getAll().FindAll(grupo => grupo.TipoGrupoDocumentacion.Id == tipoGrupoDocumentacion.Id);
        }

        public bool saveOrUpdate(GrupoDocumentacion grupoDocumentacion)
        {
            return grupoDocumentacionDtoRepository.saveOrUpdate(grupoDocumentacion);
        }
    }
}
