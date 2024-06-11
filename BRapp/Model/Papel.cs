using BRapp.Dto;
using BRapp.Interfaces;
using BRapp.Model.Nomenclador;
using FontAwesome.Sharp;
using System;

namespace BRapp.Model
{
    public class Papel: ISeleccionable, HasId
    {
        public Guid Id { get; set; }      
        public TipoDocumentacion TipoDocumentacion { get; set; } //****
        public ArchivoPDF ArchivoPDF { get; set; }      //**
        public string Name { get; set; } //**
        public bool IsActivo { get; set; } //NO
        public DateTime FechaFirma { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public Persona Responsable { get; set; }
        public Persona Cliente { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Numero { get; set; }
        public string NumeroActa { get; set; }
        public string NumeroAcuerdo { get; set; }
        public Papel Padre { get; set; }
        public string Tipo { get; set; }
        public bool IsOpcional { get; set; }

        public Papel(PapelDto papel, ArchivoPDF ArchivoPDF, TipoDocumentacion TipoDocumentacion, Persona Responsable, Persona Cliente, Papel Padre)
        {
            this.Id = papel.IdPapel;
            this.Name = papel.Name;
            this.FechaFirma = papel.FechaFirma;
            this.IsActivo = papel.IsActivo;
            this.Descripcion = papel.Descripcion;          
            this.ArchivoPDF = ArchivoPDF;
            this.Orden = papel.Orden;
            this.IsOpcional = papel.IsOpcional;
            this.TipoDocumentacion = TipoDocumentacion;
            this.FechaVencimiento = papel.FechaVencimiento;
            this.Numero = papel.Numero;
            this.NumeroActa = papel.Acta;
            this.NumeroAcuerdo = papel.Acuerdo;
            this.Tipo = papel.Tipo;
            this.Responsable = Responsable;
            this.Cliente = Cliente;
            this.Padre= Padre;
        }

        public virtual IconChar getIcono()
        {
            return TipoDocumentacion.Icon;           
        }

        public virtual bool IsArchivado()
        {
            if (TipoDocumentacion.HasFechaVencimiento)
                return isVencido();
            if(TipoDocumentacion.TipoCard == Enums.TipoCard.RESOLUCION)
                return HasPadre();
            return false;
        }
        public string COMBO
        {
            get { return ToString(); }
        }
        public string getNameSeleccionable()
        {
            return ToString();
        }
        public bool hasPdfName()
        {
            return ArchivoPDF != null && ArchivoPDF.hasDocumento();
        }
        public Guid getId()
        {
            return Id;
        }
        public T GetTipoAsEnum<T>() where T: Enum
        {
            return (T)Enum.Parse(typeof(T), Tipo);
        }
        public double getDiasRestantes()
        {
            return FechaVencimiento.Subtract(DateTime.Now).TotalDays;
        }
        public bool isProximoVencerse()
        {
            double diasRestantes = getDiasRestantes();
            return diasRestantes > -1 && diasRestantes < 45;
        }
        public bool isVencido()
        {
            return !(getDiasRestantes() > -1);
        }
        public bool HasPadre()
        {
            return Padre != null;
        }
        public override string ToString()
        {
            return Name;
        }
        public string getActaAcuerdo()
        {
            return "Acta " + NumeroActa + " /Acuerdo " + NumeroAcuerdo;
        }
    }
}
