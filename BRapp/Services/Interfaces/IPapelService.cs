using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    internal interface IPapelService
    {
        List<Papel> filtrarDocumentos(TipoDocumentoMenu tipoDocumentoMenu);
    }
}
