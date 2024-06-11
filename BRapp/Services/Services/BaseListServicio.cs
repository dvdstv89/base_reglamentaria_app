using BRapp.Interfaces;
using BRapp.Repositorios.Interfaces;
using BRapp.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRapp.Services.Services
{
    //DTO solo se utiliza para poder representar el repositorio, para mas nada sirve
    public abstract class BaseListServicio<Tipo, DTO> where Tipo : HasId
    {
        protected IRepository<Tipo, DTO> repository;
        protected List<Tipo> listado;
        public BaseListServicio(IRepository<Tipo, DTO> repository)
        {
            this.repository = repository;
            listado = new List<Tipo>();
        }

        protected abstract void Populate();

        public virtual Tipo GetById(Guid id)
        {
            return listado.FirstOrDefault(t => t.getId() == id);
        }

        protected int getIndexById(Guid id)
        {
            return listado.FindIndex(doc => doc.getId() == id);
        }

        public virtual ActionResult DeleteByTipo(Tipo tipo)
        {            
            return DeleteById(tipo.getId());
        }
        protected virtual ActionResult DeleteById(Guid id)
        {
            ActionResult actionResult = repository.DeleteById(id);
            if (actionResult == ActionResult.DELETED)
            {
                int index = getIndexById(id);
                if (index != -1)
                {
                    listado.RemoveAt(index);
                }
            }
            return actionResult;
        }

        public ActionResult Delete(Guid id)
        {
           return DeleteById(id);
        }

        public virtual ActionResult SaveOrUpdate(Tipo tipo)
        {
            ActionResult actionResult = repository.SaveOrUpdate(tipo);
            if (actionResult == ActionResult.CREATED)
            {
                listado.Add(tipo);
            }
            else if (actionResult == ActionResult.UPDATED)
            {
                int index = getIndexById(tipo.getId());
                if (index != -1)
                {
                    listado[index] = tipo;
                }
            }
            return actionResult;
        }

        public virtual List<Tipo> GetAll()
        {
            return listado;
        }

        public virtual List<Tipo> GetAllDto()
        {
            throw new NotImplementedException();
        }
    }
}
