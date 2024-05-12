﻿using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI.Cards;
using System;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class PersonaJuridicaUCController : BaseUCController<PersonaJuridicaCard, PersonaJuridica>, ICard
    {      
        private readonly IDirectorioService iDirectorioService;
        public PersonaJuridicaUCController(PersonaJuridica persona) : base(new PersonaJuridicaCard(), persona)
        {           
            this.iDirectorioService = DirectorioService.Instance;
        }

        public override UserControl get()
        {
            card.iconButton1.Click += new EventHandler(iconButton1_Click);
            return base.get();
        }

        public override void setInfo()
        {
            actualizarEstrella();                
            card.labelName.Text = objeto.Name;
            card.labelContacto.Text = objeto.Contacto;
            card.labelEmail.Text = objeto.Email;
            card.labelPhones.Text = objeto.getPhonesNumber();
            card.textBoxLocation.Text = objeto.Address;
            AlinearTextoEnCentroVertical(card.textBoxLocation);
        }       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            objeto.IsFavorito = !objeto.IsFavorito;
            actualizarEstrella();
            iDirectorioService.saveOrUpdate(objeto);
        }

        private void actualizarEstrella()
        {
            card.iconButton1.IconFont = (objeto.IsFavorito) ? FontAwesome.Sharp.IconFont.Solid : FontAwesome.Sharp.IconFont.Regular;
        }       
    }
}