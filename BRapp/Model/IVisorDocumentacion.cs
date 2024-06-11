using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRapp.Model
{
    internal interface IVisorDocumentacion
    {
        List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacion();
        string GetDescripcionRft();
    }
}
