using BRapp.Data;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    internal class VisorDocumentacionService : IVisorDocumentacionService
    {
        private static VisorDocumentacionService instance;

        private readonly IPapelService papelService;
        private readonly IGrupoDocumentacionService grupoDocumentacionService;
        private readonly Resolucion resolucion61;

        public VisorDocumentacionService()
        {
            grupoDocumentacionService = GrupoDocumentacionService.Instance;
            papelService = PapelService.Instance;
            resolucion61 = (Resolucion)papelService.getById(AplicationConfig.Resolucion61);


        }

        public Resolucion getRes61()
        {
            return resolucion61;
        }

        public List<GrupoDocumentacion> getGrupoDocumentacion(TipoGrupoDocumentacion tipo)
        {
            return grupoDocumentacionService.getByIdTipoGrupoDocumentacion(tipo.Id);           
        }

        public static VisorDocumentacionService Instance
        {
            get
            {
                instance = (instance == null) ? new VisorDocumentacionService() : instance;
                return instance;
            }
        }
    }
}
