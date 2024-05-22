﻿using BRapp.Data;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class TiendaUCController : BaseUCController<TiendaCard, Tienda>, ICard
    {
        private readonly IVisorPDFService visorDocumentosService;
        DocumentoPDF documentoPDF;
        public TiendaUCController(Tienda tienda) : base(new TiendaCard(), tienda)
        {
            this.visorDocumentosService = AplicationConfig.Component.VisorPDFService;
            this.documentoPDF = null;
        }

        public override UserControl get()
        {
            card.btnCertificadoComercial.Click += new EventHandler(btnCertificado_Click);
            card.btnList.Click += new EventHandler(btnDocumentacion_Click);           
            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            card.labelName.Text = objeto.ToString();
          
            card.tbRegistroComercial.Text = objeto.NumeroRegistroComercial;
            card.tbCajas.Text = objeto.CantidadCajasRegistradoras.ToString();          
            card.tbTrabajadores.Text = objeto.CantidadTrabajadores.ToString();
            card.tbTelefono.Text = objeto.Telefono;
            card.tbUbicacion.Text = objeto.Ubicacion;
            card.panelSGC.Visible = objeto.CertificadoSCG;
            card.panelTMHS.Visible = objeto.CertificadoTMHS;
            card.panelSanitaria.Visible = objeto.CertificadoSANITARIA;
            card.btnList.Visible = objeto.TipoGrupoDocumentacion.Count > 0;


            if (objeto.TipoMoneda == Enums.TipoMoneda.MLC)
            {              
                card.labelName.BackColor = Color.Green;
                card.panelTitle.BackColor = Color.Green;   
                card.btnList.ForeColor= Color.Green;
            }
            else
            {               
                card.labelName.BackColor = Color.Blue;
                card.panelTitle.BackColor = Color.Blue;
                card.btnList.ForeColor = Color.Blue;
            }

            if (objeto.hasImageName())
            {
                card.iconPictureBox1.Visible = false;
                documentoPDF = visorDocumentosService.getDocumentoPDFApliado(objeto.CertificadoComercial.Id);
                using (MemoryStream ms = new MemoryStream(documentoPDF.Imagen.Data))
                {
                    using (Image originalImage = Image.FromStream(ms))
                    {
                        ResizeImage(card.panelImagen, originalImage);
                    }
                }
            }
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            if (objeto.hasPdfName())
            {
                var visorDocumentosUIController = documentoPDF != null ? new VisorPDFUIController(documentoPDF) : new VisorPDFUIController(objeto.CertificadoComercial);
                visorDocumentosUIController.showDialog();
            }
           
        }
        private void btnDocumentacion_Click(object sender, EventArgs e)
        {

            var visorDocumentacionUIController = new VisorDocumentacionUIController(objeto);
            visorDocumentacionUIController.showDialog();
        }
    }
}
