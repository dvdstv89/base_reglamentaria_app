using BRapp.Enums;
using BRapp.Model.Nomenclador;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using FontAwesome.Sharp;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewTipoDocumentacionUIController : BaseUIController<NewTipoDocumentacionUI>, IForm
    {       
        private readonly ITipoDocumentacionService tipoDocumentacionService;        
        private TipoDocumentacion tipoDocumentacion;
       
        public NewTipoDocumentacionUIController(TipoDocumentacion tipoDocumentacion) : base(new NewTipoDocumentacionUI())
        {
            this.tipoDocumentacion = tipoDocumentacion;
            tipoDocumentacionService = AplicationAdminConfig.Component.Component.TipoDocumentacionService;          
        }

        public override NewTipoDocumentacionUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);     
            forma.comboBoxIcon.SelectedIndexChanged += new EventHandler(SelectedIndexChanged_Click);
            return base.ejecutar();
        }       

        protected override void initDataForm()
        {
            forma.comboBoxCard.DataSource = Enum.GetValues(typeof(TipoCard));
            forma.comboBoxIcon.DataSource = Enum.GetValues(typeof(IconChar));
            forma.comboBoxResponsable.DataSource = Enum.GetValues(typeof(TipoResponsable));
            forma.comboBoxCliente.DataSource = Enum.GetValues(typeof(TipoResponsable));
            if (tipoDocumentacion != null)
            {                
                forma.tbName.Text = tipoDocumentacion.Name;
                forma.comboBoxCard.Text = tipoDocumentacion.TipoCard.ToString();
                forma.comboBoxIcon.Text = tipoDocumentacion.Icon.ToString();
                forma.comboBoxResponsable.Text = tipoDocumentacion.TipoResponsable.ToString();
                forma.cbHasPDF.Checked = tipoDocumentacion.HasPdf;               
                forma.cbHasNumeracion.Checked = tipoDocumentacion.HasNumeracion;
                forma.cbHasFechaCreacion.Checked = tipoDocumentacion.HasFechaCreacion;
                forma.cbHasFechaVencimiento.Checked = tipoDocumentacion.HasFechaVencimiento;                  
                forma.comboBoxCliente.Text = tipoDocumentacion.TipoCliente.ToString();
                forma.cbHasObligatorio.Checked = tipoDocumentacion.HasOpcionalidad;
                forma.cbHasTipo.Checked = tipoDocumentacion.HasTipo;
                forma.cbHasPadre.Checked = tipoDocumentacion.HasPadre;
                forma.cbHasActaAcuerdo.Checked = tipoDocumentacion.HasActaAcuerdo;
            }
            else
            {
                forma.comboBoxIcon.Text = IconChar.None.ToString();
            }            
        }

        private void SelectedIndexChanged_Click(object sender, EventArgs e)
        {
            IconChar icon;
            Enum.TryParse(forma.comboBoxIcon.Text, out icon);
            forma.iconPictureBox.IconChar = icon;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            tipoDocumentacionService.SaveOrUpdate(tipoDocumentacion);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        }
       
        private void CapturarDatos()
        {
            TipoCard tipoCard;
            Enum.TryParse(forma.comboBoxCard.Text, out tipoCard);
            TipoResponsable tipoResponsable;
            Enum.TryParse(forma.comboBoxResponsable.Text, out tipoResponsable);
            TipoResponsable tipoCliente;
            Enum.TryParse(forma.comboBoxCliente.Text, out tipoCliente);
            IconChar icon = forma.iconPictureBox.IconChar;
            bool HasPDF = forma.cbHasPDF.Checked;          
            bool HasNumeracion = forma.cbHasNumeracion.Checked;
            bool HasFechaCreacion = forma.cbHasFechaCreacion.Checked;
            bool HasFechaVencimiento = forma.cbHasFechaVencimiento.Checked;          
            bool HasEsObligatorio = forma.cbHasObligatorio.Checked;
            bool HasTipo = forma.cbHasTipo.Checked;
            bool HasPadre = forma.cbHasPadre.Checked;
            bool HasActaAcuerdo = forma.cbHasActaAcuerdo.Checked;

            string name = forma.tbName.Text;
           
            if (tipoDocumentacion != null)
            {
                tipoDocumentacion.Name = name;  
                tipoDocumentacion.Icon= icon;
                tipoDocumentacion.TipoCard = tipoCard;
                tipoDocumentacion.HasPdf = HasPDF;
                tipoDocumentacion.TipoResponsable = tipoResponsable;
                tipoDocumentacion.HasNumeracion = HasNumeracion;
                tipoDocumentacion.HasFechaCreacion = HasFechaCreacion;
                tipoDocumentacion.HasFechaVencimiento = HasFechaVencimiento;
                tipoDocumentacion.TipoCliente= tipoCliente;
                tipoDocumentacion.HasOpcionalidad= HasEsObligatorio;
                tipoDocumentacion.HasTipo= HasTipo;
                tipoDocumentacion.HasPadre= HasPadre;
                tipoDocumentacion.HasActaAcuerdo= HasActaAcuerdo;
            }
            else
            {
                tipoDocumentacion = new TipoDocumentacion()
                {
                    Name = name,
                    Icon = icon,
                    TipoCard = tipoCard,
                    HasPdf = HasPDF,
                    TipoResponsable = tipoResponsable,
                    HasNumeracion = HasNumeracion,
                    HasFechaCreacion = HasFechaCreacion,
                    HasFechaVencimiento = HasFechaVencimiento,
                    TipoCliente= tipoCliente,
                    HasOpcionalidad= HasEsObligatorio,
                    HasTipo= HasTipo,
                    HasPadre= HasPadre,
                    HasActaAcuerdo= HasActaAcuerdo,
                    Id = Guid.NewGuid()
                };
            }
        }              
    }
}
