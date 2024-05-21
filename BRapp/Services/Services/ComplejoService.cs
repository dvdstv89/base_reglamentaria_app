
using BRapp.Data;
using BRapp.Model.Tiendas;
using BRapp.Repositorios.Interfaces;
using BRapp.Repositorios.Repos;
using BRapp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BRapp.Services.Services
{
    public class ComplejoService : IComplejoService
    {      
        protected readonly IComplejoRepository complejoRepository;

        public ComplejoService(IComplejoRepository complejoRepository)
        {
            this.complejoRepository = complejoRepository;
        }      

        public List<Complejo> getAll()
        {
           return complejoRepository.getAll();            
        }

        public Complejo getById(Guid idComplejo)
        {
            return complejoRepository.getById(idComplejo);
        }
        public bool saveOrUpdate(Complejo complejo)
        {
            return complejoRepository.saveOrUpdate(complejo);
        }
    }
}
