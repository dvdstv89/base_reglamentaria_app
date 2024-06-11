using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System.Collections.Generic;
using System;

namespace BRapp.Services.Services
{  
    public class BaseService<Tipo, Dto>
    {       
        protected readonly IRepository<Tipo, Dto> repository;

        public BaseService(IRepository<Tipo, Dto> repository)
        {
            this.repository = repository;          
        }

        public virtual List<Dto> GetAllDto()
        {
            return repository.GetAll();
        }

        public virtual List<Tipo> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Dto GetById(Guid id)
        {
            return repository.GetById(id);
        }      

        public ActionResult SaveOrUpdate(Tipo tipo)
        {          
            return repository.SaveOrUpdate(tipo);
        }

        public ActionResult Delete(Guid id)
        {
            return repository.DeleteById(id);
        }
    }
}
