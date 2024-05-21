using BRapp.Data;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    internal class VisorDocumentacionService : IVisorDocumentacionService
    {
        private readonly IPapelService papelService;
        private readonly IGrupoDocumentacionService grupoDocumentacionService;
        private readonly Resolucion resolucion61;
        private readonly string emptyRichTextBox;

        public VisorDocumentacionService(IGrupoDocumentacionService grupoDocumentacionService, IPapelService papelService)
        {
            this.grupoDocumentacionService = grupoDocumentacionService;
            this.papelService = papelService;
            resolucion61 = (Resolucion)papelService.getById(AplicationConfig.Resolucion61);
            emptyRichTextBox =  "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang2057{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";

        }

        public Resolucion getRes61()
        {
            return resolucion61;
        }

        public List<GrupoDocumentacion> getGrupoDocumentacion(TipoGrupoDocumentacion tipo)
        {
            return grupoDocumentacionService.getByIdTipoGrupoDocumentacion(tipo.Id);           
        }

        public bool isEmptyRft(string rtf)
        {
            return emptyRichTextBox.Equals(rtf);
        }
    }
}
