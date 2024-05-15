using BRapp.Dto;
using BRapp.Enums;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;

namespace BRapp.Model.Tiendas
{
    public class Departamento : ISeleccionable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Complejo Complejo { get; set; }
        public TipoDepartamento DepartamentoTipo { get; set; }
        public List<TipoGrupoDocumentacion> TipoGrupoDocumentacion { get; set; }

        public IconChar getIcono()
        {
            switch (DepartamentoTipo)
            {
                case TipoDepartamento.DIRECCION: return IconChar.UserTie;
                case TipoDepartamento.ECONOMIA: return IconChar.ChartLine;
                case TipoDepartamento.CAJA_CENTRAL: return IconChar.Vault;
                case TipoDepartamento.SEGURIRDAD: return IconChar.ShieldAlt;
                case TipoDepartamento.PANTRY: return IconChar.Coffee;
                case TipoDepartamento.ALMACEN: return IconChar.Dolly;
                case TipoDepartamento.GRUPO_TIENDA: return IconChar.Store;                       
                default: return IconChar.StoreAlt;
            }
        }

        public Departamento(string Name, Complejo Complejo, TipoDepartamento DepartamentoTipo, List<TipoGrupoDocumentacion> TipoGrupoDocumentacion)
        {
            Id = Guid.NewGuid();          
            this.Name = Name;
            this.Complejo = Complejo;
            this.DepartamentoTipo = DepartamentoTipo;
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;           
        }

        public Departamento(DepartamentoDto departamento, Complejo Complejo, List<TipoGrupoDocumentacion> TipoGrupoDocumentacion)
        {
            this.Id = departamento.id;
            this.Name = departamento.name;
            this.DepartamentoTipo = departamento.tipoDepartamento;
            this.Complejo = Complejo;           
            this.TipoGrupoDocumentacion = TipoGrupoDocumentacion;
        }

        public override string ToString()
        {
            return Name;
        }

        public string getNameSeleccionable()
        {
            return ToString();
        }
    }
}
