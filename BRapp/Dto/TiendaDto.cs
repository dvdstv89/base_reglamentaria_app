using BRapp.Enums;
using BRapp.Interfaces;
using BRapp.Model;
using System;

namespace BRapp.Dto
{
    public class TiendaDto : HasId
    {
        public Guid id { get; set; }
        public Guid idComplejo { get; set; }
        public Guid idDepartamento { get; set; }
        public Guid idCertificadoComercial { get; set; }      
        public string name { get; set; }
        public string ubicacion { get; set; }
        public string telefono { get; set; }
        public int cantidadTrabajadores { get; set; }
        public int cantidadCajasRegistradoras { get; set; }       
        public bool CertificadoSCG { get; set; }
        public bool CertificadoTMHS { get; set; }
        public bool CertificadoSANITARIA { get; set; }
        public bool IsActivo { get; set; }
        public TipoTienda tiendaTipo { get; set; }
        public TipoMoneda tipoMoneda { get; set; }
        public int Orden { get; set; }
        public Fichero Logo { get; set; }
        public Guid getId()
        {
            return id;
        }
    }
}
