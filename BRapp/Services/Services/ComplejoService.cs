
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
        private static ComplejoService instance;
        protected readonly IComplejoRepository complejoRepository;

        public ComplejoService()
        {
            complejoRepository = ComplejoRepository.Instance;
        }

        public static ComplejoService Instance
        {
            get
            {              
                instance = (instance == null) ? new ComplejoService() : instance;
                return instance;
            }
        }

        public List<Complejo> getAll()
        {
           return complejoRepository.getAll();            
        }

        public Complejo getById(Guid idComplejo)
        {
            return complejoRepository.getById(idComplejo);
        }
    }
}
