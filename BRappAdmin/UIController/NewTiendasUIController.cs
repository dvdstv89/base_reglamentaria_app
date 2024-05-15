using BRapp.Dto;
using BRapp.Enums;
using BRapp.Model;
using BRapp.Model.Tiendas;
using BRapp.Services.Interfaces;
using BRapp.Services.Services;
using BRapp.UI;
using BRapp.UIControlers;
using BRappAdmin.Services.Interfaces;
using BRappAdmin.Services.Services;
using BRappAdmin.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRappAdmin.UIControlers
{
    internal class NewTiendasUIController : BaseUIController<NewTiendasUI>, IForm
    {     
        private readonly ITiendaServiceAdmin tiendasService;
        private readonly IFileService fileLogoService;
        private readonly IFileService filePdfService;
        private readonly ITipoGrupoDocumentacionService tipoGrupoDocumentacionService;
        private Tienda tienda;
        private Complejo complejo;     


        public NewTiendasUIController(Tienda tienda, IFileService fileLogoService, IFileService filePdfService, Complejo complejo) : base(new NewTiendasUI())
        {
            this.tienda = tienda;
            this.fileLogoService = fileLogoService;
            tiendasService = TiendaServiceAdmin.Instance;
            tipoGrupoDocumentacionService = TipoGrupoDocumentacionServiceAdmin.Instance;
            this.filePdfService = filePdfService;
            this.complejo = complejo;
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
                forma.tbRegistroComercial.Text = tienda.NumeroRegistroComercial;
                forma.comboMoneda.Text = tienda.TipoMoneda.ToString();
                forma.comboTipo.Text = tienda.TiendaTipo.ToString();
                if (tienda.CertificadoComercial != null)
                {
                    forma.tbImagen.Text = (tienda.CertificadoComercial.Imagen != null) ? tienda.CertificadoComercial.Imagen.Name : "";
                    forma.tbPdf.Text = (tienda.CertificadoComercial.PDF != null) ? tienda.CertificadoComercial.PDF.Name : "";
                }
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
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = tipoGrupoDocumentacionService.getAll();
            forma.lwTipos.Items.Clear();
            forma.lwTipos.Width++;
            foreach (TipoGrupoDocumentacion papel in tipoGrupoDocumentacions)
            {
                var item = new ListViewItem(papel.ToString());
                item.Tag = papel;
                forma.lwTipos.Items.Add(item);
            }           
        }

        private void checkListTipoGrupoDocumentacion()
        {
            foreach (ListViewItem item in forma.lwTipos.Items)
            {
                TipoGrupoDocumentacion tipoGrupoDocumentacion = (TipoGrupoDocumentacion)item.Tag;
                item.Checked = tienda.TipoGrupoDocumentacion.Exists(tipo => tipo.Id == tipoGrupoDocumentacion.Id);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            tiendasService.saveOrUpdate(tienda);
            forma.DialogResult = DialogResult.OK;
            forma.Close();
        }

        private void CapturarDatos()
        {
            TiendaDto tiendaDto = CapturarTiendaDto();
            DocumentoPDF certificadoComercial = createOrUpdateDocumentoPdf();
            List<TipoGrupoDocumentacion> tipoGrupoDocumentacions = GetTipoGrupoDocumentacionsSelected();


            if (tienda != null)
            {
                tienda.Name = tiendaDto.name;
                tienda.Ubicacion = tiendaDto.ubicacion;
                tienda.Telefono = tiendaDto.telefono;
                tienda.CantidadTrabajadores = tienda.CantidadTrabajadores;
                tienda.CantidadCajasRegistradoras = tienda.CantidadCajasRegistradoras;
                tienda.TiendaTipo = tiendaDto.tiendaTipo;
                tienda.TipoMoneda = tiendaDto.tipoMoneda;
                tienda.NumeroRegistroComercial = tiendaDto.numeroRegistroComercial;
                tienda.CertificadoSCG = tiendaDto.CertificadoSCG;
                tienda.CertificadoTMHS = tiendaDto.CertificadoTMHS;
                tienda.CertificadoSANITARIA = tiendaDto.CertificadoSANITARIA;
                tienda.IsActivo = tiendaDto.IsActivo;
                tienda.CertificadoComercial = certificadoComercial;
                tienda.TipoGrupoDocumentacion = tipoGrupoDocumentacions;
            }
            else
            {
                tienda = new Tienda(tiendaDto, complejo, certificadoComercial, tipoGrupoDocumentacions);
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
                numeroRegistroComercial = forma.tbRegistroComercial.Text,
                CertificadoSCG = forma.cbSCG.Checked,
                CertificadoTMHS = forma.cbTMHS.Checked,
                CertificadoSANITARIA = forma.cbSANITARIA.Checked,
                IsActivo = forma.cbActiva.Checked
            };
        }

        private DocumentoPDF createOrUpdateDocumentoPdf()
        {
            Fichero imagen = (Fichero)forma.tbImagen.Tag;
            Fichero pdf = (Fichero)forma.tbPdf.Tag;
            if (tienda != null && tienda.CertificadoComercial != null)
            {
                tienda.CertificadoComercial.Imagen = imagen;
                tienda.CertificadoComercial.PDF = pdf;
                return tienda.CertificadoComercial;
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
                Fichero fichero = fileLogoService.guardarFichero(forma.openLogo.FileName);
                forma.tbImagen.Text = fichero.Name;
                forma.tbImagen.Tag = fichero;
            }
        }
        private void btnBuscarPdf_Click(object sender, EventArgs e)
        {
            if (forma.openPdf.ShowDialog() == DialogResult.OK)
            {
                Fichero fichero = filePdfService.guardarFichero(forma.openPdf.FileName);
                forma.tbPdf.Text = fichero.Name;
                forma.tbPdf.Tag = fichero;
            }
        }
        private void resizeListTipoGrupoDocumentacion(object sender, LayoutEventArgs e)
        {
            int totalWidth = forma.lwTipos.Width - 25;
            forma.columnName.Width = RoundNumber((totalWidth * 1));
        }
    }
}
