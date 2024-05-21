using BRapp.Dto;
using BRapp.Enums;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

namespace BRapp.Model.Tiendas
{
    public class Departamento : ISeleccionable, IRes61
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Complejo Complejo { get; set; }
        public string Descripcion { get; set; }
        public TipoDepartamento DepartamentoTipo { get; set; }
        public List<TipoGrupoDocumentacion> TipoGrupoDocumentacion { get; set; }
        public int Orden { get; set; }
        public int CantidadTrabajadores { get; set; }


        public IconChar getIcono()
        {
            switch (DepartamentoTipo)
            {
                case TipoDepartamento.DIRECCION: return IconChar.UserTie;
                case TipoDepartamento.ECONOMIA: return IconChar.ChartLine;
                case TipoDepartamento.CAJA_CENTRAL: return IconChar.Vault;
                case TipoDepartamento.SEGURIDAD: return IconChar.ShieldAlt;
                case TipoDepartamento.PANTRY: return IconChar.Coffee;
                case TipoDepartamento.ALMACEN: return IconChar.Dolly;
                case TipoDepartamento.GRUPO_TIENDA: return IconChar.Store;
                case TipoDepartamento.DIR_SUCURSAL: return IconChar.UserTie;
                case TipoDepartamento.SUBDIR_COMERCIAL: return IconChar.Globe;
                case TipoDepartamento.SUBDIR_CONTABILIDAD: return IconChar.ChartLine;
                case TipoDepartamento.SUBDIR_ASEGURAMIENTO: return IconChar.Truck;
                case TipoDepartamento.SUBDIR_RRHH: return IconChar.UserFriends;
                case TipoDepartamento.DPTO_TIENDAS: return IconChar.Store;
                default: return IconChar.StoreAlt;
            }
        }

        public Departamento(string Name, Complejo Complejo, TipoDepartamento DepartamentoTipo, string Descripcion, List<TipoGrupoDocumentacion> TipoGrupoDocumentacion, int Orden, int CantidadTrabajadores)
        {
            Id = Guid.NewGuid();          
            this.Name = Name;
            this.Complejo = Complejo;
            this.DepartamentoTipo = DepartamentoTipo;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;         
            this.Descripcion = Descripcion;
            this.Orden = Orden;
            this.CantidadTrabajadores = CantidadTrabajadores;
        }

        public Departamento(DepartamentoDto departamento, Complejo Complejo, List<TipoGrupoDocumentacion> TipoGrupoDocumentacion)
        {
            this.Id = departamento.id;
            this.Name = departamento.name;
            this.DepartamentoTipo = departamento.tipoDepartamento;
            this.Complejo = Complejo;           
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
            this.Descripcion = departamento.descripcion;
            this.Orden = departamento.Orden;
            this.CantidadTrabajadores = departamento.CantidadTrabajadores;
        }

        public override string ToString()
        {
            return Name;
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
            return Descripcion;
        }
    }
}
