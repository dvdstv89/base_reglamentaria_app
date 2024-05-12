using BRapp.Dto;
using BRapp.Enums;
using FontAwesome.Sharp;

namespace BRapp.Model
{
    public class Sistema : Documento
    {
        public TipoSistema TipoSistema { get; set; }             

        public Sistema(PapelDto papel, DocumentoPDF DocumentoPDF, PersonaNatural Responsable, SistemaDto sistemaDto)
              :base(papel, DocumentoPDF, Responsable)           
        {
            this.TipoSistema = sistemaDto.tipoSistema;   
        }

        public override IconChar getIcono()
        {
            if (TipoSistema == TipoSistema.ORGANIZACION_GENERAL) return IconChar.Compass;
            if (TipoSistema == TipoSistema.METODOS_ESTILOS_DIRECCION) return IconChar.Pen;
            if (TipoSistema == TipoSistema.ATENCION_HOMBRE) return IconChar.Glasses;
            if (TipoSistema == TipoSistema.ORGANIZACION_PRODUCCION_BIENES_SERVICIOS) return IconChar.ChartBar;
            if (TipoSistema == TipoSistema.GESTION_CALIDAD) return IconChar.ThumbsUp;
            if (TipoSistema == TipoSistema.GESTION_CAPITAL_HUMANO) return IconChar.UserFriends;
            if (TipoSistema == TipoSistema.GESTION_AMBIENTAL) return IconChar.Tree;
            if (TipoSistema == TipoSistema.GESTION_INNOVACION) return IconChar.Edit;
            if (TipoSistema == TipoSistema.PLANIFICACION) return IconChar.ProjectDiagram;
            if (TipoSistema == TipoSistema.CONTRATACION_ECONOMICA) return IconChar.Handshake;
            if (TipoSistema == TipoSistema.CONTABILIDAD) return IconChar.CashRegister;
            if (TipoSistema == TipoSistema.CONTROL_INTERNO) return IconChar.Tasks;
            if (TipoSistema == TipoSistema.RELACIONES_FINANCIERAS) return IconChar.CommentDollar;
            if (TipoSistema == TipoSistema.COSTOS) return IconChar.ChartPie;
            if (TipoSistema == TipoSistema.PRECIOS) return IconChar.Tags;
            if (TipoSistema == TipoSistema.INFORMATIVO) return IconChar.PhoneVolume;
            if (TipoSistema == TipoSistema.MERCADOTECNIA) return IconChar.Globe;
            if (TipoSistema == TipoSistema.COMUNICACION_EMPRESARIAL) return IconChar.Sitemap;
            if (TipoSistema == TipoSistema.CAPITAL_HUMANO) return IconChar.AddressCard;
            return IconChar.NoteSticky;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
