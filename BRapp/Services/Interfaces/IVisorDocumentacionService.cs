using BRapp.Model;
using BRapp.Model.Tiendas;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IVisorDocumentacionService
    {
        Resolucion getRes61();
        List<GrupoDocumentacion> getGrupoDocumentacion(TipoGrupoDocumentacion tipo);
        bool isEmptyRft(string rtf);
    }
}
