using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Services;
using BRappAdmin.Services.Interfaces;
using System.Collections.Generic;

namespace BRappAdmin.Services.Services
{
    public class DocumentosServiceAdmin : PapelService, IDocumentosServiceAdmin
    {
        private static DocumentosServiceAdmin instance;
       
        public static DocumentosServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new DocumentosServiceAdmin() : instance;
                return instance;
            }
        }

        public List<Papel> getAll()
        {
            return geAllPapeles();
        }

        public List<Contrato> getAllContratoDistint(Papel papelActual)
        {
            List<Contrato> papelesFiltrados = new List<Contrato>();
            papeles.ForEach(papel =>
            {
            if (papel.getClasificacionDocumento().TipoDocumento == TipoDocumento.CONTRATO && papel.IsActivo && (papelActual == null || !papelActual.Id.Equals(papel.Id)))               
                    papelesFiltrados.Add((Contrato)papel);
            });
            return papelesFiltrados;
        }

        public List<Resolucion> getAllResolucionesDistint(Papel papelActual, TipoClasificacionDocumento tipoClasificacionDocumento)
        {
            List<Resolucion> papelesFiltrados = new List<Resolucion>();
            papeles.ForEach(papel =>
            {
                if (papel.TipoClasificacionDocumento == tipoClasificacionDocumento && papel.IsActivo && (papelActual == null || !papelActual.Id.Equals(papel.Id)))
                    papelesFiltrados.Add((Resolucion)papel);
            });
            return papelesFiltrados;
        }

        public override bool saveOrUpdate(Papel papel)
        {
            return base.saveOrUpdate(papel);
        }
    }
}
