using BRapp.Dto;
using BRapp.Interfaces;
using BRapp.Model.Nomenclador;
using System;

namespace BRapp.Model
{
    public class CertificadoComercial : Papel
    {
        public DateTime FechaVencimiento { get; set; }
        public string Numero { get; set; }      

        public CertificadoComercial(PapelDto papel, ArchivoPDF ArchivoPDF, CertificadoComercialDto certificadoComercialDto, TipoDocumentacion TipoDocumentacion)
           : base(papel, ArchivoPDF, TipoDocumentacion)
        {                     
            this.Numero = certificadoComercialDto.numero;
            this.FechaVencimiento= certificadoComercialDto.fechaVencimiento;                     
        }        

        public double getDiasRestantes()
        {
            return FechaVencimiento.Subtract(DateTime.Now).TotalDays;
        }       
        public bool isVencido()
        {
            return !(getDiasRestantes() > 0);
        }    

        public override string ToString()
        {
            return Numero + ": " + Name;
        }        
    }
}
