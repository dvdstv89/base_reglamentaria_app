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
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewTiendasUIController : BaseUIController<NewTiendasUI>, IForm
    {     
        private readonly ITiendaService tiendasService;
        private readonly IFileService fileService;      
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        private readonly IDepartamentoService departamentoService;
        private readonly ITipoDocumentacionService tipoDocumentacionService;
        private Tienda tienda;
        private Complejo complejo;
        private readonly int posicion;


        public NewTiendasUIController(Tienda tienda, Complejo complejo, int posicion) : base(new NewTiendasUI())
        {
            this.tienda = tienda;            
            tiendasService = AplicationAdminConfig.Component.Component.TiendaService;
            tipoGrupoDocumentacionService = AplicationAdminConfig.Component.Component.TipoGrupoDocumentacionService;
            tipoDocumentacionService = AplicationAdminConfig.Component.Component.TipoDocumentacionService;
            fileService = AplicationAdminConfig.Component.Component.FileService;
            departamentoService = AplicationAdminConfig.Component.Component.DepartamentoService;
            this.complejo = complejo;
            this.posicion = posicion;
        }

        public override NewTiendasUI ejecutar()
        {
            forma.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            forma.btnBuscarImagen.Click += new EventHandler(btnBuscarLogo_Click);
            forma.btnBuscarPdf.Click += new EventHandler(btnBuscarPdf_Click);
            forma.lwTipos.Layout += resizeListTipoGrupoDocumentacion;
            return base.ejecutar();
        }

        protected override void initDataForm()
        {

            updateListTipoGrupoDocumentacion();
            ConfigCombo(forma.comboDepartamentos, departamentoService.GetDepartamentosTiendaByComplejo(complejo));
            ConfigCombo(forma.ComboTipoDocumentacion, tipoDocumentacionService.GetAll());
            forma.comboMoneda.DataSource = Enum.GetValues(typeof(TipoMoneda));
            forma.comboTipo.DataSource = Enum.GetValues(typeof(TipoTienda));
            forma.tbComplejo.Text = complejo.ToString();
            if (tienda != null)
            {
                checkListTipoGrupoDocumentacion();
                forma.tbName.Text = tienda.Name;
                forma.tbUbicacion.Text = tienda.Ubicacion;
                forma.tbTelefono.Text = tienda.Telefono;
                forma.tbTrabajadores.Value = tienda.CantidadTrabajadores;
                forma.tbCajas.Value = tienda.CantidadCajasRegistradoras;
                if(tienda.CertificadoComercial != null)
                {
                    forma.tbRegistroComercial.Text = tienda.CertificadoComercial.Numero;
                    forma.dtFechaVencimientoContrato.Value = tienda.CertificadoComercial.FechaVencimiento;
                    if (tienda.CertificadoComercial.TipoDocumentacion != null)
                    {
                        forma.ComboTipoDocumentacion.Text = tienda.CertificadoComercial.TipoDocumentacion.Name;
                    }
                   
                    if (tienda.hasPdfName())
                    {
                        forma.tbPdf.Text = tienda.CertificadoComercial.Name;
                        forma.tbPdf.Tag = tienda.CertificadoComercial.ArchivoPDF.PDF;
                    }
                }


             
                forma.comboMoneda.Text = tienda.TipoMoneda.ToString();
                forma.comboTipo.Text = tienda.TiendaTipo.ToString();
                forma.comboDepartamentos.Text = tienda.Departamento != null ? tienda.Departamento.Name : "";
                forma.tbImagen.Text = tienda.hasImageName() ? tienda.Logo.Name : "";
                forma.cbSCG.Checked= tienda.CertificadoSCG;
                forma.cbTMHS.Checked = tienda.CertificadoTMHS;
                forma.cbSANITARIA.Checked = tienda.CertificadoSANITARIA;
                forma.cbActiva.Checked = tienda.IsActivo;
            }
            else
            {
                forma.cbActiva.Checked = true;
            }
        }

        private void updateListTipoGrupoDocumentacion()
        {
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = tipoGrupoDocumentacionService.GetAllForTienda();
            forma.lwTipos.Items.Clear();
            forma.lwTipos.Width++;
            foreach (TipoGrupoDocumentacion grupo in tipoGrupoDocumentacions)
            {
                var item = new ListViewItem(grupo.ToString());
                item.SubItems.Add(grupo.Descripcion);
                item.Tag = grupo;
                forma.lwTipos.Items.Add(item);
            }           
        }

        private void checkListTipoGrupoDocumentacion()
        {
            foreach (ListViewItem item in forma.lwTipos.Items)
            {
                TipoGrupoDocumentacion tipoGrupoDocumentacion = (TipoGrupoDocumentacion)item.Tag;
                item.Checked = tienda.TipoGrupoDocumentacion.Exists(tipo => tipo!= null && tipo.Id == tipoGrupoDocumentacion.Id);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            tiendasService.SaveOrUpdate(tienda);
            forma.DialogResult = DialogResult.OK;
            forma.Close();
        }

        private void CapturarDatos()
        {
            TiendaDto tiendaDto = CapturarTiendaDto();
            Papel certificadoComercial = CapturarCertificadoComercial();         
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = GetTipoGrupoDocumentacionsSelected();
            Departamento departamento = (Departamento)forma.comboDepartamentos.SelectedItem;

            if (tienda != null)
            {
                tienda.Name = tiendaDto.name;
                tienda.Ubicacion = tiendaDto.ubicacion;
                tienda.Telefono = tiendaDto.telefono;
                tienda.CantidadTrabajadores = tienda.CantidadTrabajadores;
                tienda.CantidadCajasRegistradoras = tienda.CantidadCajasRegistradoras;
                tienda.TiendaTipo = tiendaDto.tiendaTipo;
                tienda.TipoMoneda = tiendaDto.tipoMoneda;              
                tienda.CertificadoSCG = tiendaDto.CertificadoSCG;
                tienda.CertificadoTMHS = tiendaDto.CertificadoTMHS;
                tienda.CertificadoSANITARIA = tiendaDto.CertificadoSANITARIA;
                tienda.IsActivo = tiendaDto.IsActivo;
                tienda.CertificadoComercial = certificadoComercial;
                tienda.TipoGrupoDocumentacion = tipoGrupoDocumentacions;
                tienda.Orden = tiendaDto.Orden;
                tienda.Departamento = departamento;
                tienda.Logo = tiendaDto.Logo;
            }
            else
            {
                tienda = new Tienda(tiendaDto, complejo, departamento, certificadoComercial, tipoGrupoDocumentacions);
            }
        }

        private List<TipoGrupoDocumentacion> GetTipoGrupoDocumentacionsSelected()
        {
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = new List<TipoGrupoDocumentacion>();
            foreach (var item in forma.lwTipos.Items)
            {
                ListViewItem listItem = (ListViewItem)item;
                if (listItem.Checked)
                {
                    if (listItem.Tag is TipoGrupoDocumentacion tipoGrupoDocumentacion)
                    {
                        tipoGrupoDocumentacions.Add(tipoGrupoDocumentacion);
                    }
                }
            }
            return tipoGrupoDocumentacions;
        }

        private TiendaDto CapturarTiendaDto()
        {           
            TipoMoneda tipoMoneda;
            Enum.TryParse(forma.comboMoneda.Text, out tipoMoneda);
            TipoTienda tipoTienda;
            Enum.TryParse(forma.comboTipo.Text, out tipoTienda);
            Fichero imagen = (Fichero)forma.tbImagen.Tag;

            return new TiendaDto()
            {
                id = tienda != null ? tienda.Id : Guid.NewGuid(),
                name = forma.tbName.Text,
                ubicacion = forma.tbUbicacion.Text,
                telefono = forma.tbTelefono.Text,
                cantidadTrabajadores = (int)forma.tbTrabajadores.Value,
                cantidadCajasRegistradoras = (int)forma.tbCajas.Value,
                tiendaTipo = tipoTienda,
                tipoMoneda= tipoMoneda,                
                CertificadoSCG = forma.cbSCG.Checked,
                CertificadoTMHS = forma.cbTMHS.Checked,
                CertificadoSANITARIA = forma.cbSANITARIA.Checked,
                IsActivo = forma.cbActiva.Checked,
                Orden = posicion,
                Logo = imagen
            };
        }

        private Papel CapturarCertificadoComercial()
        {
            Fichero pdf = (Fichero)forma.tbPdf.Tag;   
            PapelDto papel = CapturarPapelDto();
            TipoDocumentacion tipoDocumentacion = (TipoDocumentacion)forma.ComboTipoDocumentacion.SelectedItem;

            if (tienda != null && tienda.CertificadoComercial != null)
            {
                tienda.CertificadoComercial.ArchivoPDF.PDF = pdf;
                tienda.CertificadoComercial.Numero = papel.Numero;                            
                tienda.CertificadoComercial.FechaVencimiento = papel.FechaVencimiento;
                tienda.CertificadoComercial.Name = papel.Name;
                tienda.CertificadoComercial.TipoDocumentacion = tipoDocumentacion;
                return tienda.CertificadoComercial;
            }
            else
            {                
                ArchivoPDF documentoPDF = new ArchivoPDF(pdf);               
                return new Papel(papel, documentoPDF, tipoDocumentacion, null, null, null);
            }
        }      

        private PapelDto CapturarPapelDto()
        {
            PapelDto papelDto = new PapelDto();
            papelDto.IdPapel = tienda.CertificadoComercial != null ? tienda.CertificadoComercial.Id : Guid.NewGuid();
            papelDto.Name = forma.tbPdf.Text;
            papelDto.IsActivo = true;
            papelDto.Descripcion = "";
            papelDto.FechaFirma =DateTime.Now;
            papelDto.FechaVencimiento = forma.dtFechaVencimientoContrato.Value;
            papelDto.Numero = forma.tbRegistroComercial.Text;          
            papelDto.Orden = 1000;
            return papelDto;
        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        {
            if (forma.openLogo.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = fileService.GuardarFichero(forma.openLogo.FileName);
                forma.tbImagen.Text = fichero.Name;
                forma.tbImagen.Tag = fichero;
            }
        }
        private void btnBuscarPdf_Click(object sender, EventArgs e)
        {
            if (forma.openPdf.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = fileService.GuardarFichero(forma.openPdf.FileName);
                forma.tbPdf.Text = fichero.Name;
                forma.tbPdf.Tag = fichero;
            }
        }
        private void resizeListTipoGrupoDocumentacion(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTipos.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 0.5));
            forma.columnDescripcion.Width = RoundNumber((totalWidth * 0.5));
        }
    }
}
