using BRapp.Interfaces;
using System;

namespace BRapp.Model
{
    public class App : HasId
    {
        public int Id { get; set; }
        public string FechaActualizacion { get; set; }
        public string CopyRight { get; set; }
        public string Empresa { get; set; }
        public string Bienvenida { get; set; }       
        public string Mision { get; set; }
        public string Vision { get; set; }
        public string ObjetoSocial { get; set; }
        public string ValoresCompartidos { get; set; }       

        public App(int ID, string FechaActualizacion, string CopyRight, string Empresa, string Mision, string Vision, string ObjetoSocial, string ValoresCompartidos, string Bienvenida) 
        {
            this.Id = ID;
            this.Empresa = Empresa;
            this.CopyRight = CopyRight;
            this.FechaActualizacion= FechaActualizacion;
            this.Mision = Mision; 
            this.Vision = Vision;
            this.ObjetoSocial = ObjetoSocial;
            this.ValoresCompartidos= ValoresCompartidos;   
            this.Bienvenida= Bienvenida;
        }

        public Guid getId()
        {
            throw new NotImplementedException();
        }
    }
}
