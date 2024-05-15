using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using BRapp.Services.Interfaces;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class PapelUIController : BaseUIController<PapelUI>, IForm
    {       
        private readonly IDocumentosServiceAdmin documentosService;
        private readonly IFileService filePdfLogoService;
        private readonly IFileService filePdfDocumentService;
        private Papel papel;
        private readonly TipoClasificacionDocumento tipoClasificacionDocumento;
        private readonly IContactosServiceAdmin contactosService;
        
        public PapelUIController(Papel papel, TipoClasificacionDocumento tipoClasificacionDocumento,
            IFileService filePdfLogoService, IFileService filePdfDocumentService) : base(new PapelUI())
        {            
            this.tipoClasificacionDocumento = tipoClasificacionDocumento;
            this.papel = papel;
            documentosService = DocumentosServiceAdmin.Instance; ;
            this.filePdfLogoService = filePdfLogoService;
            this.filePdfDocumentService = filePdfDocumentService;
            this.contactosService = ContactoServiceAdmin.Instance;
        }

        public override PapelUI ejecutar()
        {
            forma.btnBuscarResponsable.Click += new EventHandler(btnBuscarResponsable_Click);
            forma.btnBuscarCliente.Click += new EventHandler(btnBuscarCliente_Click);
            forma.btnBuscarContratoPadre.Click += new EventHandler(btnBuscarContratoPadre_Click);
            forma.btnResolucionDerrogadaPor.Click += new EventHandler(btnResolucionDerrogadaPor_Click);
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarImagen.Click += new EventHandler(btnBuscarLogo_Click);
            forma.btnBuscarPdf.Click += new EventHandler(btnBuscarPdf_Click);
            forma.cbTieneContratoPadre.CheckedChanged += new EventHandler(cbTieneContratoPadre_CheckedChanged);
            forma.cbResolucionEsDerrogada.CheckedChanged += new EventHandler(cbResolucionEsDerrogada_CheckedChanged);
            return base.ejecutar();
        }       
        protected override void initDataForm()
        {
            base.initDataForm();
            forma.Text = tipoClasificacionDocumento.ToString();           

            switch (tipoClasificacionDocumento)
            {
                case TipoClasificacionDocumento.SISTEMA:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalInterno());  
                        forma.cbTipoSistema.DataSource = Enum.GetValues(typeof(TipoSistema));
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabContrato);                      
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabResolucion);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabPageDG);
                        if (papel != null)
                        {
                            initUpdateSistema();
                        }
                        break;
                    }
                case TipoClasificacionDocumento.CONTRATO:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaJuridicaInterno());
                        ConfigCombo(forma.cbClienteContrato, contactosService.getAllPersonaJuridicaExterno());
                        ConfigCombo(forma.cbContratoPadre, documentosService.getAllContratoDistint(papel));
                        forma.cbTipoContrato.DataSource = Enum.GetValues(typeof(TipoContrato));
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabSistema);                       
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabResolucion);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabPageDG);
                        if (papel != null)
                        {
                            initUpdateContrato();
                        }
                        break;
                    }
                case TipoClasificacionDocumento.DG:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalExterno());
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabSistema);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabResolucion);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabContrato);
                        if (papel != null)
                        {
                            initUpdateDG();
                        }
                        break;
                    }
                case TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalExterno());
                        ConfigCombo(forma.cbResolucionDerrogada, documentosService.getAllResolucionesDistint(papel, tipoClasificacionDocumento));
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabContrato);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabSistema);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabPageDG);
                        if (papel != null)
                        {
                            initUpdateResolucion();
                        }
                        break;
                    }
                case TipoClasificacionDocumento.RESOLUCION_INTERNA:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalInterno());
                        ConfigCombo(forma.cbResolucionDerrogada, documentosService.getAllResolucionesDistint(papel, tipoClasificacionDocumento));
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabContrato);                       
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabSistema);
                        forma.tabControTiposPapeles.TabPages.Remove(forma.tabPageDG);
                        if (papel != null)
                        {
                            initUpdateResolucion();
                        }
                        break;
                    }
                case TipoClasificacionDocumento.MANUAL:
                case TipoClasificacionDocumento.REGLAMENTO:
                case TipoClasificacionDocumento.PROCEDIMIENTO:
                case TipoClasificacionDocumento.PLAN_EMPRESARIAL:
                case TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalExterno());                      
                        forma.tabControTiposPapeles.Visible = false;
                        forma.btnGuardar.Location = new System.Drawing.Point(327, 320);
                        forma.Size = new System.Drawing.Size(434, 391);
                        if (papel != null)
                        {
                            initUpdateDocumento();
                        }
                        break;
                    }
                default:
                    {
                        ConfigCombo(forma.cbResponsable, contactosService.getAllPersonaNaturalInterno());
                        forma.tabControTiposPapeles.Visible = false;
                        forma.btnGuardar.Location = new System.Drawing.Point(327, 320);
                        forma.Size = new System.Drawing.Size(434, 391);
                        if (papel != null)
                        {
                            initUpdateDocumento();
                        }
                        break;
                    }
            }
        }  

        private void initUpdateComun()
        {
            forma.tbNombre.Text = papel.Name;
            forma.dtFecha.Value = papel.FechaFirma;
            forma.tbDescripcion.Rtf = papel.Descripcion;
            if (papel.DocumentoPDF != null)
            {
                forma.tbImagen.Text = (papel.DocumentoPDF.Imagen != null) ? papel.DocumentoPDF.Imagen.Name: "";
                forma.tbPdf.Text = (papel.DocumentoPDF.PDF != null) ? papel.DocumentoPDF.PDF.Name : "";
            }
        }
        private void initUpdateDocumento()
        {
            initUpdateComun();
            Documento documento = (Documento)papel;
            forma.cbResponsable.Text = documento.Responsable.Name;
        }
        private void initUpdateSistema()
        {
            initUpdateDocumento();
            Sistema sistema = (Sistema)papel;
            forma.cbTipoSistema.Text = sistema.TipoSistema.ToString();
        }
        private void initUpdateDG()
        {
            initUpdateDocumento();
            DG dg = (DG)papel;
            forma.tbDGNumero.Text = dg.Numero;
        }
        private void initUpdateResolucion()
        {
            initUpdateDocumento();
            Resolucion resolucion = (Resolucion)papel;
            forma.tbResolucionNumero.Text = resolucion.Numero;
            if (resolucion.IsDerrogada())
            {
                forma.cbResolucionDerrogada.Text = resolucion.DerrogadaPor.Name;
                forma.cbResolucionEsDerrogada.Checked = true;
                forma.btnResolucionDerrogadaPor.Enabled = true;
            }
        }
        private void initUpdateContrato()
        {
            initUpdateComun();
            Contrato contrato = (Contrato)papel;
            forma.dtFecha.Value = contrato.FechaVencimiento;
            forma.cbTipoContrato.Text = contrato.TipoContrato.ToString();
            forma.tbNumeroContrato.Text = contrato.Numero;
            forma.tbActaContrato.Value = contrato.NumeroActa;
            forma.tbAcuerdoContrato.Value = contrato.NumeroAcuerdo;
            forma.cbClienteContrato.Text = contrato.Cliente.Name;
            if (contrato.HasContratoPadre())
            {
                forma.cbContratoPadre.Text = contrato.ContratoPadre.Name;
                forma.cbTieneContratoPadre.Checked = true;
                forma.btnBuscarContratoPadre.Enabled = true;
            }
        }
        private void cbTieneContratoPadre_CheckedChanged(object sender, EventArgs e)
        {
            forma.cbContratoPadre.Enabled = forma.cbTieneContratoPadre.Checked;
            forma.btnBuscarContratoPadre.Enabled = forma.cbTieneContratoPadre.Checked;
        }
        private void cbResolucionEsDerrogada_CheckedChanged(object sender, EventArgs e)
        {
            forma.cbResolucionDerrogada.Enabled = forma.cbResolucionEsDerrogada.Checked;
            forma.btnResolucionDerrogadaPor.Enabled = forma.cbResolucionEsDerrogada.Checked;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (tipoClasificacionDocumento)
            {
                case TipoClasificacionDocumento.SISTEMA:
                    {
                        CapturarDatosSistema();
                        break;
                    }
                case TipoClasificacionDocumento.DG:
                    {
                        CapturarDatosDG();
                        break;
                    }
                case TipoClasificacionDocumento.CONTRATO:
                    {
                        CapturarDatosContratos();
                        break;
                    }
                case TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL:
                case TipoClasificacionDocumento.RESOLUCION_INTERNA:
                    {
                        CapturarDatosResoluciones();
                        break;
                    }
                default:
                    {
                        CapturarDatosDocumentos();                       
                        break;
                    }
            }
            documentosService.saveOrUpdate(papel);
            forma.DialogResult= DialogResult.OK;
            forma.Close();
        } 

        private PapelDto CapturarPapelDto()
        {
            PapelDto papelDto = new PapelDto();
            papelDto.idPapel = papel != null ? papel.Id : Guid.NewGuid();
            papelDto.name = forma.tbNombre.Text;
            papelDto.IsActivo = true;
            papelDto.FechaFirma = forma.dtFecha.Value;
            papelDto.Descripcion = forma.tbDescripcion.Rtf;
            papelDto.tipoClasificacionDocumento = tipoClasificacionDocumento;
            return papelDto;
        }
        private SistemaDto CapturarSistemaDto()
        {
            SistemaDto sistemaDto = new SistemaDto();
            TipoSistema tipoSistema;
            Enum.TryParse(forma.cbTipoSistema.Text, out tipoSistema);
            sistemaDto.tipoSistema = tipoSistema;
            return sistemaDto;
        }
        private DGDto CapturarDGDto()
        {
            DGDto dGDto = new DGDto();          
            dGDto.numero = forma.tbDGNumero.Text;
            return dGDto;
        }
        private ContratoDto CapturarContratoDto()
        {
            ContratoDto contratoDto = new ContratoDto();          
            contratoDto.fechaVencimiento = forma.dtFechaVencimientoContrato.Value;
            TipoContrato tipoContrato;
            Enum.TryParse(forma.cbTipoContrato.Text, out tipoContrato);
            contratoDto.tipoContrato= tipoContrato;
            contratoDto.numero = forma.tbNumeroContrato.Text;
            contratoDto.acta = (int)forma.tbActaContrato.Value;
            contratoDto.acuerdo = (int)forma.tbAcuerdoContrato.Value;
            return contratoDto;
        }
        private void CapturarDatosDocumentos()
        {
            PapelDto papelDto = CapturarPapelDto();           
            DocumentoPDF documentoPDF = createOrUpdateDocumentoPdf();
            PersonaNatural responsable = (PersonaNatural)forma.cbResponsable.SelectedItem;

            if (papel != null)
            {
                Documento documento = (Documento)papel;
                documento.Name = papelDto.name;
                documento.FechaFirma = papelDto.FechaFirma;
                documento.Descripcion = papelDto.Descripcion;
                documento.Responsable = responsable;
            }
            else
            {
                Guid Id = Guid.NewGuid();
                switch (tipoClasificacionDocumento)
                {
                    case TipoClasificacionDocumento.INDICO:
                    case TipoClasificacionDocumento.MANUAL:
                    case TipoClasificacionDocumento.PLAN_EMPRESARIAL:
                    case TipoClasificacionDocumento.PLAN_INTERNO:
                    case TipoClasificacionDocumento.PROCEDIMIENTO:
                    case TipoClasificacionDocumento.PROGRAMA_EMPRESARIAL:
                    case TipoClasificacionDocumento.PROGRAMA_INTERNO:
                    case TipoClasificacionDocumento.REGLAMENTO:
                    case TipoClasificacionDocumento.OTRO_DOCUMENTO:
                    case TipoClasificacionDocumento.DOCUMENTACION_BASICA:
                        papel = new Documento(papelDto, documentoPDF, responsable); 
                        break;
                }
            }
        }
        private void CapturarDatosSistema()
        {
            PapelDto papelDto = CapturarPapelDto();
            DocumentoPDF documentoPDF = createOrUpdateDocumentoPdf();
            PersonaNatural responsable = (PersonaNatural)forma.cbResponsable.SelectedItem;
            SistemaDto sistemaDto = CapturarSistemaDto();

            if (papel != null)
            {
                Sistema sistema = (Sistema)papel;
                sistema.Name = papelDto.name;
                sistema.FechaFirma = papelDto.FechaFirma;
                sistema.Responsable = responsable;
                sistema.Descripcion = papelDto.Descripcion;               
                sistema.TipoSistema = sistemaDto.tipoSistema;
            }
            else
            {
                papel = new Sistema(papelDto, documentoPDF,responsable, sistemaDto);
            }
        }
        private void CapturarDatosDG()
        {
            PapelDto papelDto = CapturarPapelDto();
            DocumentoPDF documentoPDF = createOrUpdateDocumentoPdf();
            PersonaNatural responsable = (PersonaNatural)forma.cbResponsable.SelectedItem;
            DGDto dGDto = CapturarDGDto();

            if (papel != null)
            {
                DG dg = (DG)papel;
                dg.Name = papelDto.name;
                dg.FechaFirma = papelDto.FechaFirma;
                dg.Responsable = responsable;
                dg.Descripcion = papelDto.Descripcion;
                dg.Numero = dGDto.numero;
            }
            else
            {
                papel = new DG(papelDto, documentoPDF, responsable, dGDto);
            }
        }
        private void CapturarDatosResoluciones()
        {
            PapelDto papelDto = CapturarPapelDto();
            DocumentoPDF documentoPDF = createOrUpdateDocumentoPdf();
            PersonaNatural responsable = (PersonaNatural)forma.cbResponsable.SelectedItem;
            Resolucion derrogadaPor = (Resolucion)forma.cbResolucionDerrogada.Tag;
            string numeroResolucion = forma.tbResolucionNumero.Text;

            if (papel != null)
            {
                Resolucion resolucion = (Resolucion)papel;
                resolucion.Name = papelDto.name;
                resolucion.FechaFirma = papelDto.FechaFirma;
                resolucion.Descripcion = papelDto.Descripcion;
                resolucion.DerrogadaPor = derrogadaPor;
                resolucion.Responsable = responsable;
                resolucion.Numero= numeroResolucion;
            }
            else
            {
                switch (tipoClasificacionDocumento)
                {
                    case TipoClasificacionDocumento.RESOLUCION_INTERNA:
                    case TipoClasificacionDocumento.RESOLUCION_EMPRESARIAL: 
                        papel = new Resolucion(papelDto, documentoPDF, responsable, derrogadaPor, numeroResolucion); break;
                }
            }
        }
        private void CapturarDatosContratos()
        {
            PapelDto papelDto = CapturarPapelDto();
            ContratoDto contratoDto = CapturarContratoDto();
            DocumentoPDF documentoPDF = createOrUpdateDocumentoPdf();
            PersonaJuridica responsable = (PersonaJuridica)forma.cbResponsable.SelectedItem;
            PersonaJuridica cliente = (PersonaJuridica)forma.cbClienteContrato.SelectedItem;            
            Contrato contratoPadre = (Contrato)forma.cbContratoPadre.Tag;

            if (papel != null)
            {
                Contrato contrato = (Contrato)papel;
                contrato.Name = papelDto.name;
                contrato.FechaFirma = papelDto.FechaFirma;
                contrato.Descripcion = papelDto.Descripcion;
                contrato.Responsable = responsable;
                contrato.Cliente = cliente;
                contrato.FechaVencimiento = contratoDto.fechaVencimiento;
                contrato.TipoContrato = contratoDto.tipoContrato;
                contrato.Numero = contratoDto.numero;
                contrato.NumeroActa = contratoDto.acta;
                contrato.NumeroAcuerdo = contratoDto.acuerdo;
                contrato.ContratoPadre = contratoPadre;
            }
            else
            {
                papel = new Contrato(papelDto, documentoPDF, contratoDto, cliente, responsable, contratoPadre);
            }
        }
        private DocumentoPDF createOrUpdateDocumentoPdf()
        {
            Fichero imagen = (Fichero)forma.tbImagen.Tag;
            Fichero pdf = (Fichero)forma.tbPdf.Tag;
            if (papel != null && papel.DocumentoPDF != null)
            {
                papel.DocumentoPDF.Imagen = imagen;
                papel.DocumentoPDF.PDF = pdf;
                return papel.DocumentoPDF;
            }
            else
            {
                return new DocumentoPDF(pdf, imagen);
            }
        }
        private void btnBuscarLogo_Click(object sender, EventArgs e)
        { 
            if (forma.openLogo.ShowDialog() == DialogResult.OK)
            {  
                Fichero fichero = filePdfLogoService.guardarFichero(forma.openLogo.FileName);
                forma.tbImagen.Text = fichero.Name;
                forma.tbImagen.Tag = fichero;
            }
        }
        private void btnBuscarPdf_Click(object sender, EventArgs e)
        {
            if (forma.openPdf.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = filePdfDocumentService.guardarFichero(forma.openPdf.FileName);
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
            seleccionarCombo<Persona>(forma.cbClienteContrato);
        }
        private void btnBuscarContratoPadre_Click(object sender, EventArgs e)
        {           
           seleccionarCombo<Contrato>(forma.cbContratoPadre);
        }
        private void btnResolucionDerrogadaPor_Click(object sender, EventArgs e)
        {    
            seleccionarCombo<Resolucion>(forma.cbResolucionDerrogada);
            
        }   
    }
}
