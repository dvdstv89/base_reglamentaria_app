using BRapp.Model;
using BRapp.UI.Cards;
using BRapp.UIControlers.Components;
using BRapp.Utiles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UIControlers.CardUCController
{
    internal class DocumentoUCController : BaseUCController<DocumentoCard, Papel>, ICard
    {
        public DocumentoUCController(Papel documento) : base(new DocumentoCard(), documento)
        {

        }

        public override UserControl get()
        {
            card.btnPdf.Click += new EventHandler(btnPdf_Click);
            card.btnResponsable.Click += new EventHandler(btnResponsable_Click);
            card.btnPadre.Click += new EventHandler(btnDerrogadaPor_Click);
            return base.get();
        }

        public override void setInfo()
        {
            card.iconPrincipal.IconChar = objeto.getIcono();
            initNumeroActasAcuerdos();
            initReponsable();
            initFechas();
            initPadre();

            card.labelName.Text = objeto.ToString();
            card.labelDescripcion.Rtf = objeto.Descripcion;
            card.btnPdf.Visible = objeto.hasPdfName();
        }

        private void initReponsable()
        {
            if (objeto.TipoDocumentacion.HasResponsable())
            {
                card.tbCargoResponsable.Text = objeto.Responsable.GetCargo();
            }
            card.gbPanelResponsable.Visible = objeto.TipoDocumentacion.HasResponsable();
        }
        private void initFechas()
        {
            initFechaCreacion();
            initFechaVencimiento();
            card.gbPanelFechas.Visible = card.panelFechaVencimiento.Visible || card.panelFechaFirma.Visible;
        }
        private void initFechaCreacion()
        {
            if (objeto.TipoDocumentacion.HasFechaCreacion)
            {
                card.tbFechaFirma.Text = FechaUtil.getShortText(objeto.FechaFirma);
            }
            card.panelFechaFirma.Visible = objeto.TipoDocumentacion.HasFechaCreacion;
        }
        private void initFechaVencimiento()
        {
            if (objeto.TipoDocumentacion.HasFechaVencimiento)
            {
                card.tbFechaVencimiento.Text = FechaUtil.getShortText(objeto.FechaVencimiento);
                int diasRestantes = (int)objeto.getDiasRestantes();
                card.tbDiasRestantes.Text = (diasRestantes > -999) ? diasRestantes.ToString() : "???";
                if (objeto.isProximoVencerse())
                {
                    card.tbDiasRestantes.BackColor = Color.Red;
                    card.labelName.BackColor = Color.Red;
                    card.panelTitle.BackColor = Color.Red;
                    card.labelName.ForeColor = Color.White;
                    card.iconPrincipal.IconColor = Color.White;
                    card.tbDiasRestantes.ForeColor = Color.White;
                    card.btnPdf.IconColor = Color.White;
                }
                else if (objeto.isVencido())
                {
                    card.tbDiasRestantes.BackColor = Color.Black;
                    card.labelName.BackColor = Color.Black;
                    card.panelTitle.BackColor = Color.Black;
                    card.labelName.ForeColor = Color.White;
                    card.iconPrincipal.IconColor = Color.White;
                    card.tbDiasRestantes.ForeColor = Color.White;
                    card.btnPdf.IconColor = Color.White;
                }
            }
            card.panelFechaVencimiento.Visible = objeto.TipoDocumentacion.HasFechaVencimiento;
        }
        private void initNumeroActasAcuerdos()
        {
            initNumero();
            initActaAcuerdo();
            card.gbPanelNumeroActa.Visible = card.panelNumero.Visible || card.panelActaAcuerdo.Visible;
        }
        private void initNumero()
        {
            if (objeto.TipoDocumentacion.HasNumeracion)
            {
                card.tbNumero.Text = objeto.Numero;
            }
            card.panelNumero.Visible = objeto.TipoDocumentacion.HasNumeracion;
        }
        private void initActaAcuerdo()
        {
            if (objeto.TipoDocumentacion.HasActaAcuerdo)
            {
                card.tbActaAcuerdo.Text = objeto.getActaAcuerdo();
            }
            card.panelActaAcuerdo.Visible = objeto.TipoDocumentacion.HasActaAcuerdo;
        }
        private void initPadre()
        {
            if (objeto.TipoDocumentacion.HasPadre)
            {
                card.tbPadre.Text = objeto.HasPadre() ? objeto.Padre.Name : "";
            }
            card.gbPanelAdjunto.Visible = objeto.TipoDocumentacion.HasPadre && objeto.HasPadre();
        }



        private void btnPdf_Click(object sender, EventArgs e)
        {
            var visorDocumentosUIController = new VisorPDFUIController(objeto.ArchivoPDF);
            visorDocumentosUIController.showDialog();
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            PersonaNaturalUCController personaNaturalUCController = new PersonaNaturalUCController((PersonaNatural)objeto.Responsable);
            personaNaturalUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(personaNaturalUCController);
            CardDialogUIController.showDialog();
        }

        private void btnDerrogadaPor_Click(object sender, EventArgs e)
        {
            DocumentoUCController resolucionUCController = new DocumentoUCController(objeto.Padre);
            resolucionUCController.setInfo();
            var CardDialogUIController = new CardDialogUIController(resolucionUCController);
            CardDialogUIController.showDialog();
        }
    }
}
