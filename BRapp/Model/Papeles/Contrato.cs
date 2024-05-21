using BRapp.Dto;
using BRapp.Enums;
using System;

namespace BRapp.Model
{
    public class Contrato : Papel
    {
        public Contrato ContratoPadre { get; set; }
        public PersonaJuridica Cliente { get; set; }
        public PersonaJuridica Responsable { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Numero { get; set; }
        public int NumeroActa { get; set; }
        public int NumeroAcuerdo { get; set; }
        public TipoContrato TipoContrato { get; set; }

        public Contrato(PapelDto papel, DocumentoPDF DocumentoPDF, ContratoDto contratoDto, PersonaJuridica Cliente, PersonaJuridica Responsable, Contrato ContratoPadre = null)
           : base(papel, DocumentoPDF)
        {
            this.ContratoPadre = ContratoPadre;
            this.Cliente = Cliente;
            this.Responsable = Responsable;
            if (contratoDto != null)
            {
                this.FechaVencimiento = contratoDto.fechaVencimiento;
                this.Numero = contratoDto.numero;
                this.NumeroActa = contratoDto.acta;
                this.NumeroAcuerdo = contratoDto.acuerdo;
                this.TipoContrato = contratoDto.tipoContrato;
            }           
        }       

        public bool HasContratoPadre()
        {
            return ContratoPadre != null;
        }

        public double getDiasRestantes()
        {
            return FechaVencimiento.Subtract(DateTime.Now).TotalDays;
        }

        public string getActaAcuerdo()
        {
            return "Acta "+ NumeroActa + " /Acuerdo "+ NumeroAcuerdo;
        }
        public bool isVencido()
        {
            return !(getDiasRestantes() > 0);
        }
        public bool isProximoVencerse()
        {
            double diasRestantes = getDiasRestantes();
            return diasRestantes > 0 && diasRestantes < 45;
        }

        public override string ToString()
        {
            return Numero + ": " + Name;
        }

        public override bool IsArchivado()
        {
            try
            {
                return isVencido();
            }
            catch
            {
                return true;
            }            
        }       
    }
}
