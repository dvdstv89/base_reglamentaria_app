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
        private readonly string emptyRichTextBox;

        public VisorDocumentacionService(IGrupoDocumentacionService grupoDocumentacionService, IPapelService papelService)
        {
            this.grupoDocumentacionService = grupoDocumentacionService;
            this.papelService = papelService;          
            emptyRichTextBox =  "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang2057{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";

        }      

        public List<GrupoDocumentacion> GetGrupoDocumentacion(TipoGrupoDocumentacion tipo)
        {
            return grupoDocumentacionService.GetAllByTipoGrupoDocumentacion(tipo.Id);           
        }

        public bool IsEmptyRft(string rtf)
        {
            return emptyRichTextBox.Equals(rtf);
        }
    }
}
