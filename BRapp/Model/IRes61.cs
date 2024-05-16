using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRapp.Model
{
    internal interface IRes61
    {
        List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacion();
        string GetDescripcionRft();
    }
}
