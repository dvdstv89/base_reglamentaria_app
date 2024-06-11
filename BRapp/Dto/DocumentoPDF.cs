using BRapp.Interfaces;
using System;

namespace BRapp.Model
{
    public class DocumentoPDF : HasId
    {
        public Guid Id { get;}
        public string Name { get; }        

        public DocumentoPDF(Guid Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;           
        }
        public DocumentoPDF(string Name)
        {
            Id = Guid.NewGuid();
            this.Name = Name;         
        }

        public Guid getId()
        {
           return Id;
        }

        public ArchivoPDF GetArchivoPDF()
        {
            return new ArchivoPDF(Id, new Fichero(Name, default));
        }
    }
}
