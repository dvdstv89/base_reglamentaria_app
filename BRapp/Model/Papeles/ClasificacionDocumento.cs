﻿using BRapp.Enums.EnumsInstances;
using BRapp.Enums;
using FontAwesome.Sharp;

namespace BRapp.Model.Papeles
{
    public class ClasificacionDocumento
    {
        public TipoDocumento TipoDocumento { get; set; }
        public TipoDocumentoMenu TipoDocumentoMenu { get; set; }
        public IconChar Icon { get; set; }
        public ClasificacionDocumento(TipoDocumento TipoDocumento, TipoDocumentoMenu TipoDocumentoMenu)
        {
            this.TipoDocumento = TipoDocumento;
            this.TipoDocumentoMenu = TipoDocumentoMenu;
        }
        public IconChar getIcono()
        {
            switch (TipoDocumento)
            {               
                case TipoDocumento.MANUAL: return IconChar.Edit;
                case TipoDocumento.REGLAMENTO: return IconChar.Tasks;
                case TipoDocumento.PROCEDIMIENTO: return IconChar.Pen;
                case TipoDocumento.PLAN: return IconChar.Sitemap;
                case TipoDocumento.PROGRAMA: return IconChar.ThumbsUp;
                case TipoDocumento.RESOLUCION: return IconChar.Legal;
                case TipoDocumento.INDICO: return IconChar.HandPointRight;
                case TipoDocumento.OTRO_DOCUMENTO: return IconChar.NoteSticky;
                case TipoDocumento.CONTRATO: return IconChar.Handshake;
                case TipoDocumento.DG: return IconChar.HandPointUp;
                default: return IconChar.NoteSticky;
            }           
        }
    }
}