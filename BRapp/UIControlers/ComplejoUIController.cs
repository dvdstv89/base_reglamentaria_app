﻿using BRapp.UI;
using System.Collections.Generic;
using BRapp.Services.Interfaces;
using BRapp.Model.Tiendas;
using System.IO;
using System.Drawing;
using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.CardUCController;
using System.Windows.Forms;
using BRapp.Data;

namespace BRapp.UIControlers
{
    internal class ComplejoUIController : BaseUIController<ComplejoUI>, IForm
    {
        private static Dictionary<Complejo, ComplejoUIController> instances = new Dictionary<Complejo, ComplejoUIController>();        
        private readonly ITiendaService tiendaService;
        private readonly IDepartamentoService departamentoService;
        private readonly ISucursalService sucursalService;
        private readonly Complejo complejo;
        private ComplejoUIController(Complejo complejo) : base(new ComplejoUI(), true)
        {
            this.complejo = complejo;
            tiendaService = AplicationConfig.Component.TiendaService;
            departamentoService = AplicationConfig.Component.DepartamentoService;
            sucursalService = AplicationConfig.Component.SucursalService;
        }      

        protected override void aplicarTema()
        {         
            if (complejo.hasImagen())
            {
                forma.iconPictureBox1.Visible= false;
                forma.pictureBoxOrganigramaEmpresa.BackgroundImage = Image.FromStream(new MemoryStream(complejo.Organigrama.Data));
            }
           
            LLenarListaDepartamentos();
            if(complejo.TipoComplejo == Enums.TipoComplejo.SUCURSAL)
            {

                forma.panelTiendasHeader.Visible = false;
                forma.panelTiendas.Visible = false;
               

                App app = app = sucursalService.GetApp();
                forma.richTextBoxMision.Rtf = app.Mision;
                forma.richTextBoxVision.Rtf = app.Vision;
                forma.richTextBoxValoresCompartidos.Rtf = app.ValoresCompartidos;
                forma.richTextBoxObjetoSocialIzquierdo.Rtf = app.ObjetoSocial;
            }
            else
            {
                forma.panelSucursal.Visible = false;
                forma.panelTiendas.Dock = DockStyle.Fill;
                LLenarListaTiendas();
            }
        }

        private void LLenarListaDepartamentos()
        {
            List<Departamento> departamentos = departamentoService.getDepartamentosByComplejo(complejo);
            forma.panelDepartamentos.Controls.Clear();
            foreach (Departamento departamento in departamentos)
            {
                ICard card = new DepartamentoUCController(departamento);
                card.setInfo();
                Control control = card.get();
                control.Tag = departamento;
                forma.panelDepartamentos.Controls.Add(control);               
            }
            ExtraSpaceCard extraCard = new ExtraSpaceCard();
            forma.panelDepartamentos.Controls.Add(extraCard);
        }
        private void LLenarListaTiendas()
        {
            List<Tienda> tiendas = tiendaService.getTiendasByComplejo(complejo);         
            forma.panelTiendas.Controls.Clear();
            foreach (Tienda tienda in tiendas)
            {              
                ICard card = new TiendaUCController(tienda);
                card.setInfo();
                Control control = card.get();
                control.Tag = tienda;
                forma.panelTiendas.Controls.Add(control);
            }
            for (int i = 0; i < 3; i++)
            {
                ExtraSpaceCard card = new ExtraSpaceCard();
                forma.panelTiendas.Controls.Add(card);
            }
        }

        public static ComplejoUIController GetInstance(Complejo complejo)
        {
            //if (!instances.ContainsKey(complejo))
            //{
            //    instances[complejo] = new ComplejoUIController(complejo);
            //}
            //return instances[complejo];
            return new ComplejoUIController(complejo);
        }       
    }
}
