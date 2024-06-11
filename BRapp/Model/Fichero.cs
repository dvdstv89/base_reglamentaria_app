using System;

namespace BRapp.Model
{
    public class Fichero
    {
        public string Name { get; }     
        public byte[] Data { get; set; }
        public Fichero(string Name, byte[] Data)
        {
            this.Data = Data;
            this.Name = Name;
        }      

        public bool hasDataValid()
        {
            return Data != null && Data.Length > 0;
        }

        public bool hasDocumento()
        {
            return !Name.Equals(String.Empty);
        }
        public void CleanData()
        {
            Data = null;
        }
    }
}
