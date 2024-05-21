using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class PersonaUIController : BaseUIController<PersonaUI>, IForm
    {       
        private readonly IDirectorioService contactosService;
        private readonly IFileService fileService;
        private Persona persona;
        private readonly TipoPersona tipoPersona;       
        public PersonaUIController(Persona persona, TipoPersona tipoPersona) : base(new PersonaUI())
        {
            this.tipoPersona = tipoPersona;
            this.persona = persona;
            contactosService = AplicationAdminConfig.Component.Component.DirectorioService;
            this.fileService = AplicationAdminConfig.Component.Component.FileService;
        }

        public override PersonaUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarLogo.Click += new EventHandler(btnBuscarLogo_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            if (tipoPersona == TipoPersona.NATURAL)
            {
                forma.tabControlPersonas.TabPages.Remove(forma.tabPersonaJuridica);
                forma.cbPNTitulo.DataSource = Enum.GetValues(typeof(TipoTituloPersonal));
                if (persona != null)
                {
                    initUpdatePersonaNatural();
                }
            }
            else
            {
                forma.tabControlPersonas.TabPages.Remove(forma.tabPersonaNatural);
                if (persona != null)
                {
                    initUpdatePersonaJuridica();
                }
            }
        }         
        private void initUpdatePersonaNatural()
        {
            PersonaNatural personaNatural = (PersonaNatural)persona;
            forma.tbPNNombre.Text = personaNatural.Name;
            forma.tbPNEmail.Text = personaNatural.Email;
            forma.tbPNCargo.Text = personaNatural.Cargo;
            forma.tbPNTelefono.Text = personaNatural.Phone;
            forma.tbPNMovil.Text = personaNatural.Cell;
            forma.tbPNDireccion.Text = personaNatural.Address;
            forma.cbInterno.Checked = personaNatural.IsInterno;
            forma.cbPNTitulo.Text = personaNatural.TipoTituloPersonal.ToString();
        }    
        private void initUpdatePersonaJuridica()
        {
            PersonaJuridica personaJuridica = (PersonaJuridica)persona;
            forma.tbPJName.Text = personaJuridica.Name;
            forma.tbPJEmail.Text = personaJuridica.Email;           
            forma.tbPJTelefono.Text = personaJuridica.Phone;           
            forma.tbPJDireccion.Text = personaJuridica.Address;
            forma.tbPJContacto.Text = personaJuridica.Contacto;
            forma.tbPJLogo.Text = personaJuridica.Logo.Name;
            forma.cbInterno.Checked = personaJuridica.IsInterno;          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tipoPersona == TipoPersona.NATURAL)
            {
                CapturarDatosPersonaNatural();
            }
            else
            {
                CapturarDatosPersonaJuridica();
            }
            contactosService.saveOrUpdate(persona);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatosPersonaNatural()
        {
            string name = forma.tbPNNombre.Text;
            string email = forma.tbPNEmail.Text;
            string phone = forma.tbPNTelefono.Text;
            string address = forma.tbPNDireccion.Text;
            bool isInterno = forma.cbInterno.Checked;
            string cargo = forma.tbPNCargo.Text;
            string cell = forma.tbPNMovil.Text;
            TipoTituloPersonal tipoTituloPersonal;
            Enum.TryParse(forma.cbPNTitulo.Text, out tipoTituloPersonal);

            if (persona != null)
            {
                persona.Name = name;
                persona.Email = email;
                persona.Phone = phone;
                persona.Address = address;
                persona.IsInterno = isInterno;
                PersonaNatural personaNatural = (PersonaNatural)persona;
                personaNatural.Cargo = cargo;
                personaNatural.Cell = cell;
                personaNatural.TipoTituloPersonal = tipoTituloPersonal;
            }
            else
            {
                persona = new PersonaNatural(name, email, phone, address, isInterno, cargo,cell,tipoTituloPersonal);
            }
        }
        private void CapturarDatosPersonaJuridica()
        {           
            string name = forma.tbPJName.Text;
            string email = forma.tbPJEmail.Text;
            string phone = forma.tbPJTelefono.Text;
            string address = forma.tbPJDireccion.Text;
            bool isInterno = forma.cbInterno.Checked;
            string contacto = forma.tbPJContacto.Text;
            Fichero logo = (Fichero)forma.tbPJLogo.Tag;           

            if (persona != null)
            {
                persona.Name = name;
                persona.Email = email;
                persona.Phone = phone;
                persona.Address = address;
                persona.IsInterno = isInterno;
                PersonaJuridica personaJuridica = (PersonaJuridica)persona;
                personaJuridica.Contacto = contacto;
                if (logo != null) personaJuridica.Logo = logo;
            }
            else
            {
                persona = new PersonaJuridica(name, email, phone, address, isInterno, contacto, logo);
            }
        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        { 
            if (forma.openLogo.ShowDialog() == DialogResult.OK)
            {  
                Fichero fichero = fileService.guardarFichero(forma.openLogo.FileName);
                forma.tbPJLogo.Text = fichero.Name;
                forma.tbPJLogo.Tag = fichero;
            }
        }
    }
}
