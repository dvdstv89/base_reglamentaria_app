using BRapp.Enums;
using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Utiles;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IPapelService
    {
        List<Papel> filtrarDocumentos(TipoDocumentoMenu tipoDocumentoMenu);
        Papel getById(Guid id);
        List<Papel> getAll();
        List<Papel> getAllDistintDocumentacion_Basica();
        List<Resolucion> getAllResolucionesDistint(Papel papel, TipoClasificacionDocumento tipoClasificacionDocumento);
        List<Contrato> getAllContratoDistint(Papel papel);
        List<Documento> getAllByTipo(TipoDocumento tipoDocumento);
        ActionResult saveOrUpdate(Papel papel);
        void Delete(Papel papel);
    }
}
