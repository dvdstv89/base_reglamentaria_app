using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
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
        private readonly VisorPDFUIController visorPDFUIController;
        private readonly VisorDocumentacionUIController visorDocumentacionUIController;
        private readonly ITiendaService tiendaService;
        private readonly DocumentoPDF documentoApliado;
        public TiendaUCController(Tienda tienda) : base(new TiendaCard(), tienda)
        {                        
            this.tiendaService = TiendasService.Instance;
            this.documentoApliado = tiendaService.getDocumentoPDFApliado(tienda);
            this.visorPDFUIController = new VisorPDFUIController(documentoApliado);
            this.visorDocumentacionUIController = new VisorDocumentacionUIController(tienda);
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

            if (documentoApliado.hasImagen())
            {
                using (MemoryStream ms = new MemoryStream(documentoApliado.Imagen.Data))
                {                   
                    card.panelImagen.BackgroundImage = Image.FromStream(ms);
                }
            }           
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            if (documentoApliado.hasDocumento())
            {
                visorPDFUIController.showDialog();
            }
           
        }
        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            visorDocumentacionUIController.showDialog();
        }
    }
}
