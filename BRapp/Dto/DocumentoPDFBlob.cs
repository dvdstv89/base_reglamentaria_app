using BRapp.Interfaces;
using System;

namespace BRapp.Model
{
    public class DocumentoPDFBlob : HasId
    {
        public Guid Id { get; set; }
        public byte[] Data { get; set; }

        public DocumentoPDFBlob(Guid Id, byte[] Data)
        {
            this.Id = Id;
            this.Data = Data;           
        }
      

        public bool hasDataValid()
        {
            return Data != null && Data.Length > 0;
        }
       

        public Guid getId()
        {
           return Id;
        }
    }
}
