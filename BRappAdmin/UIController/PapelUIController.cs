using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Nomenclador;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Data;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class PapelUIController : BaseUIController<PapelUI>, IForm
    {       
        private readonly IPapelService documentosService;
        private readonly ITipoDocumentacionService tipoDocumentacionService;
        private readonly IFileService fileSevice;
        private readonly IDirectorioService contactosService;
        private GrupoDocumentacion grupoDocumentacion;
        private int formHeigth;

        private Papel papel;       
        private readonly int orden;
        private readonly TipoCard TipoCard;

        public PapelUIController(Papel papel, TipoCard TipoCard, int orden, GrupoDocumentacion grupoDocumentacion) : base(new PapelUI())
        {
            this.papel = papel;
            this.TipoCard = TipoCard;
            this.orden = orden;
            this.grupoDocumentacion= grupoDocumentacion;
            this.documentosService = AplicationAdminConfig.Component.Component.PapelService;
            this.tipoDocumentacionService = AplicationAdminConfig.Component.Component.TipoDocumentacionService;
            this.fileSevice = AplicationAdminConfig.Component.Component.FileService;            
            this.contactosService = AplicationAdminConfig.Component.Component.DirectorioService;            
        }

        public override PapelUI ejecutar()
        {
            forma.btnBuscarResponsable.Click += new EventHandler(btnBuscarResponsable_Click);
            forma.btnBuscarCliente.Click += new EventHandler(btnBuscarCliente_Click);
            forma.btnBuscarPadre.Click += new EventHandler(btnBuscarContratoPadre_Click);          
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);          
            forma.btnBuscarPdf.Click += new EventHandler(btnBuscarPdf_Click);
            forma.cbTienePadre.CheckedChanged += new EventHandler(cbTienePadre_CheckedChanged);
            forma.ComboTipoDocumentacion.SelectedIndexChanged += new EventHandler(ComboTipoDocumentacion_SelectedIndexChanged);
            return base.ejecutar();
        }       
        protected override void initDataForm()
        {
            base.initDataForm();
            forma.Text = TipoCard.ToString(); 
            ConfigCombo(forma.ComboTipoDocumentacion, tipoDocumentacionService.GetAllByTipoCard(TipoCard));
            if (papel != null)
            {
                forma.tbNombre.Text = papel.Name;
                forma.tbDescripcion.Rtf = papel.Descripcion;
                forma.ComboTipoDocumentacion.Text = papel.TipoDocumentacion.Name;
            }
        }

        //cambiar tipo de documentacion
        private void ComboTipoDocumentacion_SelectedIndexChanged(object sender, EventArgs e)
        {           
            TipoDocumentacion TipoDocumentacionSelected = (TipoDocumentacion)forma.ComboTipoDocumentacion.SelectedItem;
            refreshInterfaceForm(TipoDocumentacionSelected);
        }
        private void refreshInterfaceForm(TipoDocumentacion TipoDocumentacionSelected)
        {
            formHeigth = 280;
            initTipo(TipoDocumentacionSelected);
            initNumero(TipoDocumentacionSelected);
            initActaAcuerdo(TipoDocumentacionSelected);
            initFechaFirma(TipoDocumentacionSelected);
            initFechaVencimiento(TipoDocumentacionSelected);
            initResponsable(TipoDocumentacionSelected);
            initCliente(TipoDocumentacionSelected);
            initPadre(TipoDocumentacionSelected);
            initPDF(TipoDocumentacionSelected);
            initEsObligatorio(TipoDocumentacionSelected);
            forma.Height = formHeigth;           
        }

        private void initTipo(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasTipo;
            forma.gbTipo.Visible = visibilidad;
            Type tipo = TipoDocumentacionSelected.getTipoEnum();           
            if (visibilidad && tipo != null)
            {
                forma.gbTipo.Text = tipo.Name;
                formHeigth += 55;
                forma.cbTipo.DataSource = Enum.GetValues(tipo);  
                if(papel!= null)
                {
                    forma.cbTipo.Text = papel.Tipo;
                }
            }
        }
        private void initNumero(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasNumeracion;
            forma.gbNumero.Visible = visibilidad;           
            if (visibilidad)
            {
                formHeigth += 55;              
                if (papel != null)
                {
                    forma.tbNumero.Text = papel.Numero;
                }
            }
        }
        private void initActaAcuerdo(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasActaAcuerdo;
            forma.gbActaAcuerdo.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                if (papel != null)
                {
                    forma.tbActa.Text = papel.NumeroActa;
                    forma.tbAcuerdo.Text = papel.NumeroAcuerdo;
                }
            }
        }
        private void initFechaFirma(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasFechaCreacion;
            forma.gbFechaFirma.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                if (papel != null)
                {
                    forma.dtFechaFirma.Value = papel.FechaFirma;
                }
            }
        }
        private void initFechaVencimiento(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasFechaVencimiento;
            forma.gbFechaVencimiento.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                if (papel != null)
                {
                    forma.dtFechaVencimiento.Value = papel.FechaVencimiento;
                }
            }
        }
        private void initResponsable(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasResponsable();
            forma.gbResponsable.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                ConfigCombo(forma.cbResponsable, contactosService.GetAllPersonaByTipoResponsable(TipoDocumentacionSelected.TipoResponsable));
                if (papel != null)
                {
                    forma.cbResponsable.Text = papel.Responsable.Name;
                }
            }
        }
        private void initCliente(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasCliente();
            forma.gbCliente.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                ConfigCombo(forma.cbCliente, contactosService.GetAllPersonaByTipoResponsable(TipoDocumentacionSelected.TipoCliente));
                if (papel != null)
                {
                    forma.cbCliente.Text = papel.Cliente.Name;
                }
            }
        }
        private void initPadre(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasPadre;
            forma.gbPadre.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                forma.gbPadre.Text = TipoCard == TipoCard.CONTRATO ? "Contrato padre" : "Derrogado por";
                ConfigCombo(forma.cbPadre, documentosService.GetAllByTipoPapelDistint(papel));
                if (papel != null)
                {
                    forma.cbTienePadre.Checked = papel.HasPadre();
                    forma.cbPadre.Text = papel.Padre.Name;
                }
            }
        }
        private void initPDF(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasPdf;
            forma.gbPDF.Visible = visibilidad;
            if (visibilidad)
            {
                formHeigth += 55;
                if (papel != null)
                {
                    forma.tbPdf.Text = (papel.ArchivoPDF.PDF != null) ? papel.ArchivoPDF.PDF.Name : "";
                    forma.tbPdf.Tag = (papel.ArchivoPDF.PDF != null) ? papel.ArchivoPDF.PDF : null;
                }
            }
        }
        private void initEsObligatorio(TipoDocumentacion TipoDocumentacionSelected)
        {
            bool visibilidad = TipoDocumentacionSelected.HasOpcionalidad && grupoDocumentacion != null;
            forma.cbObligatorio.Visible = visibilidad;
            if (visibilidad && papel != null)
            {
                forma.cbObligatorio.Checked = papel.IsOpcional;
            }
        }       
        private void cbTienePadre_CheckedChanged(object sender, EventArgs e)
        {
            forma.cbPadre.Enabled = forma.cbTienePadre.Checked;
            forma.btnBuscarPadre.Enabled = forma.cbTienePadre.Checked;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            documentosService.SaveOrUpdate(papel);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        } 

        private PapelDto CapturarPapelDto()
        {
            PapelDto papelDto = new PapelDto();
            papelDto.IdPapel = papel != null ? papel.Id : Guid.NewGuid();
            papelDto.IsActivo = true;
            papelDto.Name = forma.tbNombre.Text;           
            papelDto.Descripcion = forma.tbDescripcion.Rtf;
            papelDto.Tipo = forma.cbTipo.Text;
            papelDto.Numero=forma.tbNumero.Text;
            papelDto.Acta = forma.tbActa.Text;
            papelDto.Acuerdo = forma.tbAcuerdo.Text;
            papelDto.FechaFirma = forma.dtFechaFirma.Value;
            papelDto.FechaVencimiento = forma.dtFechaVencimiento.Value;
            papelDto.Orden = orden;
            papelDto.IsOpcional = forma.cbObligatorio.Checked;
            return papelDto;
        }       
        private void CapturarDatos()
        {
            PapelDto papelDto = CapturarPapelDto();          
            TipoDocumentacion tipoDocumentacion = (TipoDocumentacion)forma.ComboTipoDocumentacion.SelectedItem;
            Persona responsable = (Persona)forma.cbResponsable.SelectedItem;
            Persona cliente = (Persona)forma.cbCliente.SelectedItem;
            Papel padre = (Papel)forma.cbPadre.SelectedItem;
            ArchivoPDF documentoPDF = tipoDocumentacion.HasPdf ? createOrUpdateDocumentoPdf() : null;
            if (papel != null)
            {               
                papel.Name = papelDto.Name;
                papel.Descripcion = papelDto.Descripcion;
                papel.TipoDocumentacion = tipoDocumentacion;
                papel.Orden= orden;
                papel.IsActivo = papelDto.IsActivo;
                papel.Tipo = papelDto.Tipo;
                papel.Numero  = papelDto.Numero;
                papel.NumeroActa = papelDto.Acta;
                papel.NumeroAcuerdo= papelDto.Acuerdo;
                papel.FechaFirma = papelDto.FechaFirma;
                papel.FechaVencimiento = papelDto.FechaVencimiento;
                papel.Responsable = responsable;
                papel.Cliente = cliente;
                papel.Padre = padre;               
                papel.ArchivoPDF = documentoPDF;
                papel.IsOpcional = papelDto.IsOpcional;
            }
            else
            {
                papel = new Papel(papelDto, documentoPDF, tipoDocumentacion, responsable, cliente, padre);               
            }
        }
       
        private ArchivoPDF createOrUpdateDocumentoPdf()
        {           
            Fichero pdf = (Fichero)forma.tbPdf.Tag;
            if (papel != null && papel.ArchivoPDF != null)
            {              
                papel.ArchivoPDF.PDF = pdf;
                return papel.ArchivoPDF;
            }
            else
            {
                return new ArchivoPDF(pdf);
            }
        }
       
        private void btnBuscarPdf_Click(object sender, EventArgs e)
        {
            if (forma.openPdf.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = fileSevice.GuardarFichero(forma.openPdf.FileName);
                forma.tbPdf.Text = fichero.Name;
                forma.tbPdf.Tag = fichero;
            }
        }    
        private void btnBuscarResponsable_Click(object sender, EventArgs e)
        {           
            seleccionarCombo<Persona>(forma.cbResponsable);            
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            seleccionarCombo<Persona>(forma.cbCliente);
        }
        private void btnBuscarContratoPadre_Click(object sender, EventArgs e)
        {           
           seleccionarCombo<Papel>(forma.cbPadre);
        }     

        public Papel GetPapel() { return papel; }
    }
}
