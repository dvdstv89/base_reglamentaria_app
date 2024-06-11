using BRapp.Model;
using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IVisorDocumentacionService
    {       
        List<GrupoDocumentacion> GetGrupoDocumentacion(TipoGrupoDocumentacion tipo);
        bool IsEmptyRft(string rtf);
    }
}
