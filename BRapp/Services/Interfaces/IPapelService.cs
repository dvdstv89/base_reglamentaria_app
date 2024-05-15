using BRapp.Enums.EnumsInstances;
using BRapp.Model;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Interfaces
{
    public interface IPapelService
    {
        List<Papel> filtrarDocumentos(TipoDocumentoMenu tipoDocumentoMenu);
        Papel getById(Guid id);
    }
}
