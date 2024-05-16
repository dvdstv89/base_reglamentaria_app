using BRapp.Enums;
using System;

namespace BRapp.Dto
{
    public class DepartamentoDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public TipoDepartamento tipoDepartamento { get; set; }       
        public Guid idComplejo { get; set; }   
        public string descripcion { get; set; }
    }
}
