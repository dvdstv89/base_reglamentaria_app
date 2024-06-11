using BRapp.Enums;
using BRapp.Interfaces;
using BRapp.Model;
using System;

namespace BRapp.Dto
{
    public class DepartamentoDto : HasId
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public TipoDepartamento tipoDepartamento { get; set; }       
        public Guid idComplejo { get; set; }   
        public string descripcion { get; set; }
        public int Orden { get; set; }
        public int CantidadTrabajadores { get; set; }
        public Guid getId()
        {
            return id;
        }
    }
}
