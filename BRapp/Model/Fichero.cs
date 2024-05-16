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

        public Fichero clone()
        {
            return new Fichero(this.Name, this.Data);
        }

        public bool hasDataValid()
        {
            return Data != null && Data.Length > 0;
        }
    }
}
