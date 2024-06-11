using BRapp.Dto;
using BRapp.Enums;
using BRapp.Interfaces;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

namespace BRapp.Model.Tiendas
{
    public class Tienda : ISeleccionable, IVisorDocumentacion, HasId
    {
        public Guid Id { get; set; }
        public Complejo Complejo { get; set; }
        public Departamento Departamento { get; set; }
        public Papel CertificadoComercial { get; set; }
        public List<TipoGrupoDocumentacion> TipoGrupoDocumentacion { get; set; }
        public string Name { get; set; }     
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public int CantidadTrabajadores { get; set; }
        public int CantidadCajasRegistradoras { get; set; }
        public TipoTienda TiendaTipo { get; set; }
        public TipoMoneda TipoMoneda { get; set; }      
        public bool CertificadoSCG { get; set; }
        public bool CertificadoTMHS { get; set; }
        public bool CertificadoSANITARIA { get; set; }
        public bool IsActivo { get; set; }
        public int Orden { get; set; }
        public Fichero Logo { get; set; }

        public IconChar getIcono()
        {
            switch (TiendaTipo)
            {
                case TipoTienda.LICORERA: return IconChar.WineBottle;
                case TipoTienda.PELETERIA: return IconChar.ShoePrints;
                case TipoTienda.CASA_HABANO: return IconChar.Joint;
                case TipoTienda.DEPORTIVA: return IconChar.Futbol;
                case TipoTienda.INFANTIL: return IconChar.BabyCarriage;
                case TipoTienda.MODA: return IconChar.TShirt;
                case TipoTienda.JOYERIA: return IconChar.Gem;
                case TipoTienda.ARTICULOS_VIAJE: return IconChar.SuitcaseRolling;
                case TipoTienda.TURISTICA: return IconChar.UmbrellaBeach;
                case TipoTienda.PERFUMERIA: return IconChar.PumpSoap;
                case TipoTienda.UTILES_HOGAR: return IconChar.Home;
                case TipoTienda.MERCADO: return IconChar.ShoppingCart;
                case TipoTienda.PHOTOCLUB: return IconChar.Camera;
                default: return IconChar.ShoppingBag;
            }
        }

        public Tienda(TiendaDto tiendaDto, Complejo Complejo, Departamento Departamento, Papel CertificadoComercial, List<TipoGrupoDocumentacion> TipoGrupoDocumentacion)
        {
            this.Id = tiendaDto.id;
            this.Name = tiendaDto.name;
            this.Ubicacion = tiendaDto.ubicacion;
            this.Telefono = tiendaDto.telefono;
            this.CantidadTrabajadores = tiendaDto.cantidadTrabajadores;
            this.CantidadCajasRegistradoras = tiendaDto.cantidadCajasRegistradoras;
            this.TiendaTipo = tiendaDto.tiendaTipo;
            this.TipoMoneda = tiendaDto.tipoMoneda;          
            this.CertificadoSCG = tiendaDto.CertificadoSCG;
            this.CertificadoTMHS = tiendaDto.CertificadoTMHS;
            this.CertificadoSANITARIA = tiendaDto.CertificadoSANITARIA;
            this.IsActivo = tiendaDto.IsActivo;
            this.Complejo = Complejo;
            this.CertificadoComercial = CertificadoComercial;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
            this.Orden = tiendaDto.Orden;
            this.Departamento = Departamento;
            this.Logo = tiendaDto.Logo;
        }       

        public override string ToString()
        {
            return Name + " ("+TipoMoneda.ToString()+")";
        }

        public string getNameSeleccionable()
        {
            return ToString();
        }

        public List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacion()
        {
            return TipoGrupoDocumentacion;
        }

        public string GetDescripcionRft()
        {
            return string.Empty;
        }

        public bool hasPdfName()
        {
            return CertificadoComercial != null && CertificadoComercial.hasPdfName();
        }

        public bool hasImageName()
        {
            return Logo != null && Logo.hasDataValid();
        }

        public Guid getId()
        {
            return Id;
        }

        public string COMBO
        {
            get { return ToString(); }
        }

        public string getNumeroCertificadoComercial()
        {
            return CertificadoComercial != null ? CertificadoComercial.Numero : "";
        }
    }
}
