
using BRapp.Enums;
using BRapp.Model;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IDocumentosServiceAdmin
    {
        List<Papel> getAll();
        List<Resolucion> getAllResolucionesDistint(Papel papel,TipoClasificacionDocumento tipoClasificacionDocumento);
        List<Contrato> getAllContratoDistint(Papel papel);
        List<Documento> getAllByTipo(TipoDocumento tipoDocumento);
        bool saveOrUpdate(Papel papel);
    }
}
