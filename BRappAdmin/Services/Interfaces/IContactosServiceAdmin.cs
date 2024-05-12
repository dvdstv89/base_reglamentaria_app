
using BRapp.Model;
using System.Collections.Generic;

namespace BRappAdmin.Services.Interfaces
{
    internal interface IContactosServiceAdmin
    {
        List<Persona> getAll();
        List<PersonaNatural> getAllPersonaNatural();
        List<PersonaNatural> getAllPersonaNaturalInterno();
        List<PersonaNatural> getAllPersonaNaturalExterno();
        List<PersonaJuridica> getAllPersonaJuridica();
        List<PersonaJuridica> getAllPersonaJuridicaInterno();
        List<PersonaJuridica> getAllPersonaJuridicaExterno();
        bool saveOrUpdate(Persona persona);
    }
}
