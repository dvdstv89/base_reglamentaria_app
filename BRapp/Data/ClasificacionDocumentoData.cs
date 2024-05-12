using BRapp.Enums;
using BRapp.Model.Papeles;
using System.Collections.Generic;
using BRapp.Enums.EnumsInstances;

namespace BRapp.Data
{
    public static class ClasificacionDocumentoData
    {
        private readonly static Dictionary<TipoClasificacionDocumento, ClasificacionDocumento> clasificacionesDocumentos;

        static ClasificacionDocumentoData()
        {
            clasificacionesDocumentos = new Dictionary<TipoClasificacionDocumento, ClasificacionDocumento>();
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.SISTEMA, new ClasificacionDocumento(TipoDocumento.SISTEMA, TipoDocumentoMenu.SISTEMA));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.CONTRATO, new ClasificacionDocumento(TipoDocumento.CONTRATO, TipoDocumentoMenu.DOC_CONTRATO));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.RESOLUCION_INTERNA, new ClasificacionDocumento(TipoDocumento.RESOLUCION, TipoDocumentoMenu.DOC_RESOLUCIONES_INDICOS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL, new ClasificacionDocumento(TipoDocumento.RESOLUCION, TipoDocumentoMenu.PRE_RESOLUCIONES_EMPRESARIALES));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.INDICO, new ClasificacionDocumento(TipoDocumento.INDICO, TipoDocumentoMenu.DOC_RESOLUCIONES_INDICOS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.MANUAL, new ClasificacionDocumento(TipoDocumento.MANUAL, TipoDocumentoMenu.PRE_MANUALES));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.PLAN_EMPRESARIAL, new ClasificacionDocumento(TipoDocumento.PLAN, TipoDocumentoMenu.PRE_PLANES_PROGRAMAS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.PLAN_INTERNO, new ClasificacionDocumento(TipoDocumento.PLAN, TipoDocumentoMenu.DOC_PLANES));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.PROCEDIMIENTO, new ClasificacionDocumento(TipoDocumento.PROCEDIMIENTO, TipoDocumentoMenu.PRE_PROCEDIMIENTOS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL, new ClasificacionDocumento(TipoDocumento.PROGRAMA, TipoDocumentoMenu.PRE_PLANES_PROGRAMAS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.PROGRAMA_INTERNO, new ClasificacionDocumento(TipoDocumento.PROGRAMA, TipoDocumentoMenu.DOC_PROGRAMAS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.REGLAMENTO, new ClasificacionDocumento(TipoDocumento.REGLAMENTO, TipoDocumentoMenu.PRE_REGLAMENTOS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.OTRO_DOCUMENTO, new ClasificacionDocumento(TipoDocumento.OTRO_DOCUMENTO, TipoDocumentoMenu.DOC_OTROS_DOCUMENTOS));
            clasificacionesDocumentos.Add(TipoClasificacionDocumento.DG, new ClasificacionDocumento(TipoDocumento.DG, TipoDocumentoMenu.PRE_DG));
        }

        public static ClasificacionDocumento getClasificacionDocumento(TipoClasificacionDocumento tipoClasificacion)
        {
            return clasificacionesDocumentos[tipoClasificacion];
        }
    }
}
