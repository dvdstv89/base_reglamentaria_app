using BRapp.Model;
using BRapp.Services.Services;
using BRappAdmin.Services.Interfaces;
using BRapp.Enums;
using System.Collections.Generic;
using System.Linq;

namespace BRappAdmin.Services.Services
{
    internal class ContactoServiceAdmin : DirectorioService, IContactosServiceAdmin
    {
        private static ContactoServiceAdmin instance;

       public List<Persona> getAll()
        {
            return iDirectorioRepository.getAllPersonas();
        }       

        public bool saveOrUpdate(Persona persona)
        {
            return iDirectorioRepository.saveOrUpdate(persona);
        }

        public List<PersonaNatural> getAllPersonaNatural()
        {
            return iDirectorioRepository.getAllPersonas()
                .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo)
                .Cast<PersonaNatural>()
                .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalInterno()
        {
            return iDirectorioRepository.getAllPersonas()
                  .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && contacto.IsInterno)
                  .Cast<PersonaNatural>()
                  .ToList();
        }
        public List<PersonaNatural> getAllPersonaNaturalExterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.NATURAL && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaNatural>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridica()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaInterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }
        public List<PersonaJuridica> getAllPersonaJuridicaExterno()
        {
            return iDirectorioRepository.getAllPersonas()
                 .Where(contacto => contacto.TipoPersona == TipoPersona.JURIDICA && contacto.IsActivo && !contacto.IsInterno)
                 .Cast<PersonaJuridica>()
                 .ToList();
        }

        public static ContactoServiceAdmin Instance
        {
            get
            {
                instance = (instance == null) ? new ContactoServiceAdmin() : instance;
                return instance;
            }
        }
    }
}
