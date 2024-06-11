using BRapp.Enums;
using BRapp.Interfaces;
using FontAwesome.Sharp;
using System;

namespace BRapp.Model.Nomenclador
{
    public class TipoDocumentacion : HasId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TipoCard TipoCard { get; set; }
        public IconChar Icon { get; set; }
        public bool HasPdf { get; set; }
        public TipoResponsable TipoResponsable { get; set; }
        public TipoResponsable TipoCliente { get; set; }
        public bool HasNumeracion { get; set; }
        public bool HasFechaCreacion { get; set; }
        public bool HasFechaVencimiento { get; set; }      
        public bool HasOpcionalidad { get; set; }
        public bool HasTipo { get; set; }
        public bool HasPadre { get; set; }
        public bool HasActaAcuerdo { get; set; }

        public Guid getId()
        {
            return Id;
        }
        public string COMBO
        {
            get { return Name; }
        }

        public override string ToString()
        {
            return Name;
        }

        public bool HasResponsable()
        {
            return TipoResponsable != TipoResponsable.Sin_Responsable;
        }
        public bool HasCliente()
        {
            return TipoCliente != TipoResponsable.Sin_Responsable;
        }

        public Type getTipoEnum()
        {
            switch (TipoCard)
            {
                case TipoCard.SISTEMA: return typeof(TipoSistema);               
                case TipoCard.CONTRATO: return typeof(TipoContrato);
                default: return null;
            }
        }
    }
}
