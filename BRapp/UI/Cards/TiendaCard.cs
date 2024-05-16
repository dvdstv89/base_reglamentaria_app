using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class TiendaCard : UserControl
    {
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public TextBox tbUbicacion;
        private FontAwesome.Sharp.IconButton btnFechaInicio;
        public Panel panelContratoPadre;
        public TextBox tbTelefono;
        private FontAwesome.Sharp.IconButton btnContratoPadre;
        private Panel panel3;
        public FontAwesome.Sharp.IconButton btnCertificadoComercial;
        public TextBox tbRegistroComercial;
        public Panel panelImagen;
        public Panel panelTitle;
        public FontAwesome.Sharp.IconButton btnList;
        public Label labelName;
        private Panel panel4;
        public TextBox tbTrabajadores;
        private FontAwesome.Sharp.IconButton btnResponsable;
        public TextBox tbCajas;
        private FontAwesome.Sharp.IconButton btnTipoContrato;
        public Panel panelSanitaria;
        private Panel panel6;
        public Panel panelTMHS;
        public Panel panelSGC;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;

        public TiendaCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechaInicio = new FontAwesome.Sharp.IconButton();
            this.btnContratoPadre = new FontAwesome.Sharp.IconButton();
            this.btnCertificadoComercial = new FontAwesome.Sharp.IconButton();
            this.btnList = new FontAwesome.Sharp.IconButton();
            this.btnResponsable = new FontAwesome.Sharp.IconButton();
            this.btnTipoContrato = new FontAwesome.Sharp.IconButton();
            this.panelSanitaria = new System.Windows.Forms.Panel();
            this.panelTMHS = new System.Windows.Forms.Panel();
            this.panelSGC = new System.Windows.Forms.Panel();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.panelContratoPadre = new System.Windows.Forms.Panel();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbTrabajadores = new System.Windows.Forms.TextBox();
            this.tbCajas = new System.Windows.Forms.TextBox();
            this.tbRegistroComercial = new System.Windows.Forms.TextBox();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelContratoPadre.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechaInicio
            // 
            this.btnFechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaInicio.ForeColor = System.Drawing.Color.White;
            this.btnFechaInicio.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnFechaInicio.IconColor = System.Drawing.Color.Black;
            this.btnFechaInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaInicio.IconSize = 25;
            this.btnFechaInicio.Location = new System.Drawing.Point(190, 101);
            this.btnFechaInicio.Name = "btnFechaInicio";
            this.btnFechaInicio.Size = new System.Drawing.Size(38, 29);
            this.btnFechaInicio.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnFechaInicio, "Ubicación");
            this.btnFechaInicio.UseVisualStyleBackColor = true;
            // 
            // btnContratoPadre
            // 
            this.btnContratoPadre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContratoPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratoPadre.ForeColor = System.Drawing.Color.White;
            this.btnContratoPadre.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.btnContratoPadre.IconColor = System.Drawing.Color.Black;
            this.btnContratoPadre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContratoPadre.IconSize = 25;
            this.btnContratoPadre.Location = new System.Drawing.Point(0, 0);
            this.btnContratoPadre.Name = "btnContratoPadre";
            this.btnContratoPadre.Size = new System.Drawing.Size(38, 25);
            this.btnContratoPadre.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnContratoPadre, "Teléfono");
            this.btnContratoPadre.UseVisualStyleBackColor = true;
            // 
            // btnCertificadoComercial
            // 
            this.btnCertificadoComercial.BackColor = System.Drawing.SystemColors.Control;
            this.btnCertificadoComercial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCertificadoComercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificadoComercial.ForeColor = System.Drawing.Color.White;
            this.btnCertificadoComercial.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.btnCertificadoComercial.IconColor = System.Drawing.Color.Black;
            this.btnCertificadoComercial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCertificadoComercial.IconSize = 25;
            this.btnCertificadoComercial.Location = new System.Drawing.Point(0, 0);
            this.btnCertificadoComercial.Name = "btnCertificadoComercial";
            this.btnCertificadoComercial.Size = new System.Drawing.Size(38, 30);
            this.btnCertificadoComercial.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCertificadoComercial, "Número de registro comercial");
            this.btnCertificadoComercial.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.Color.Orange;
            this.btnList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnList.IconColor = System.Drawing.Color.White;
            this.btnList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnList.IconSize = 36;
            this.btnList.Location = new System.Drawing.Point(445, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(36, 48);
            this.btnList.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnList, "Ver documentación del sistema");
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnResponsable
            // 
            this.btnResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsable.ForeColor = System.Drawing.Color.White;
            this.btnResponsable.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnResponsable.IconColor = System.Drawing.Color.Black;
            this.btnResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResponsable.IconSize = 25;
            this.btnResponsable.Location = new System.Drawing.Point(78, 2);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(38, 25);
            this.btnResponsable.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnResponsable, "Trabajadores");
            this.btnResponsable.UseVisualStyleBackColor = true;
            // 
            // btnTipoContrato
            // 
            this.btnTipoContrato.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoContrato.ForeColor = System.Drawing.Color.White;
            this.btnTipoContrato.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnTipoContrato.IconColor = System.Drawing.Color.Black;
            this.btnTipoContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTipoContrato.IconSize = 25;
            this.btnTipoContrato.Location = new System.Drawing.Point(0, 0);
            this.btnTipoContrato.Name = "btnTipoContrato";
            this.btnTipoContrato.Size = new System.Drawing.Size(38, 30);
            this.btnTipoContrato.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnTipoContrato, "Cajas Registradoras");
            this.btnTipoContrato.UseVisualStyleBackColor = true;
            // 
            // panelSanitaria
            // 
            this.panelSanitaria.BackgroundImage = global::BRapp.Properties.Resources.SANITARIA;
            this.panelSanitaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSanitaria.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSanitaria.Location = new System.Drawing.Point(193, 0);
            this.panelSanitaria.Name = "panelSanitaria";
            this.panelSanitaria.Size = new System.Drawing.Size(88, 91);
            this.panelSanitaria.TabIndex = 52;
            this.toolTip1.SetToolTip(this.panelSanitaria, "Licencia sanitaria");
            // 
            // panelTMHS
            // 
            this.panelTMHS.BackgroundImage = global::BRapp.Properties.Resources.TMHS;
            this.panelTMHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTMHS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTMHS.Location = new System.Drawing.Point(105, 0);
            this.panelTMHS.Name = "panelTMHS";
            this.panelTMHS.Size = new System.Drawing.Size(88, 91);
            this.panelTMHS.TabIndex = 49;
            this.toolTip1.SetToolTip(this.panelTMHS, "Certificado Turísmo mas higienico y seguro");
            // 
            // panelSGC
            // 
            this.panelSGC.BackgroundImage = global::BRapp.Properties.Resources.SCG;
            this.panelSGC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSGC.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSGC.Location = new System.Drawing.Point(17, 0);
            this.panelSGC.Name = "panelSGC";
            this.panelSGC.Size = new System.Drawing.Size(88, 91);
            this.panelSGC.TabIndex = 53;
            this.toolTip1.SetToolTip(this.panelSGC, "Certificación de calidad");
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.BackColor = System.Drawing.Color.White;
            this.tbUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUbicacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbUbicacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUbicacion.Location = new System.Drawing.Point(231, 109);
            this.tbUbicacion.Multiline = true;
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.ReadOnly = true;
            this.tbUbicacion.Size = new System.Drawing.Size(250, 21);
            this.tbUbicacion.TabIndex = 21;
            this.tbUbicacion.TabStop = false;
            this.tbUbicacion.Text = "3ra y Paseo. Hotel Cohiba";
            // 
            // panelContratoPadre
            // 
            this.panelContratoPadre.BackColor = System.Drawing.Color.White;
            this.panelContratoPadre.Controls.Add(this.tbTelefono);
            this.panelContratoPadre.Controls.Add(this.btnContratoPadre);
            this.panelContratoPadre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContratoPadre.Location = new System.Drawing.Point(190, 78);
            this.panelContratoPadre.Name = "panelContratoPadre";
            this.panelContratoPadre.Size = new System.Drawing.Size(296, 25);
            this.panelContratoPadre.TabIndex = 51;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.White;
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTelefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(38, 3);
            this.tbTelefono.Multiline = true;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.ReadOnly = true;
            this.tbTelefono.Size = new System.Drawing.Size(217, 18);
            this.tbTelefono.TabIndex = 24;
            this.tbTelefono.TabStop = false;
            this.tbTelefono.Text = "78352436";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnCertificadoComercial);
            this.panel3.Controls.Add(this.tbRegistroComercial);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(190, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 30);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tbTrabajadores);
            this.panel4.Controls.Add(this.btnResponsable);
            this.panel4.Controls.Add(this.tbCajas);
            this.panel4.Controls.Add(this.btnTipoContrato);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(119, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 30);
            this.panel4.TabIndex = 51;
            // 
            // tbTrabajadores
            // 
            this.tbTrabajadores.BackColor = System.Drawing.Color.White;
            this.tbTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrabajadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTrabajadores.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrabajadores.Location = new System.Drawing.Point(117, 5);
            this.tbTrabajadores.Multiline = true;
            this.tbTrabajadores.Name = "tbTrabajadores";
            this.tbTrabajadores.ReadOnly = true;
            this.tbTrabajadores.Size = new System.Drawing.Size(36, 22);
            this.tbTrabajadores.TabIndex = 23;
            this.tbTrabajadores.TabStop = false;
            this.tbTrabajadores.Text = "4";
            // 
            // tbCajas
            // 
            this.tbCajas.BackColor = System.Drawing.Color.White;
            this.tbCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCajas.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCajas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCajas.Location = new System.Drawing.Point(44, 5);
            this.tbCajas.Multiline = true;
            this.tbCajas.Name = "tbCajas";
            this.tbCajas.ReadOnly = true;
            this.tbCajas.Size = new System.Drawing.Size(28, 19);
            this.tbCajas.TabIndex = 21;
            this.tbCajas.TabStop = false;
            this.tbCajas.Text = "1";
            // 
            // tbRegistroComercial
            // 
            this.tbRegistroComercial.BackColor = System.Drawing.Color.White;
            this.tbRegistroComercial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegistroComercial.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbRegistroComercial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistroComercial.Location = new System.Drawing.Point(41, 6);
            this.tbRegistroComercial.Multiline = true;
            this.tbRegistroComercial.Name = "tbRegistroComercial";
            this.tbRegistroComercial.ReadOnly = true;
            this.tbRegistroComercial.Size = new System.Drawing.Size(69, 19);
            this.tbRegistroComercial.TabIndex = 8;
            this.tbRegistroComercial.TabStop = false;
            this.tbRegistroComercial.Text = "A25100";
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.White;
            this.panelImagen.BackgroundImage = global::BRapp.Properties.Resources.logoCaracol;
            this.panelImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 48);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(190, 177);
            this.panelImagen.TabIndex = 47;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Orange;
            this.panelTitle.Controls.Add(this.btnList);
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Controls.Add(this.iconPrincipal);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(486, 48);
            this.panelTitle.TabIndex = 45;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(49, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(396, 48);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPrincipal.IconColor = System.Drawing.Color.White;
            this.iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPrincipal.IconSize = 48;
            this.iconPrincipal.Location = new System.Drawing.Point(0, 0);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(49, 48);
            this.iconPrincipal.TabIndex = 8;
            this.iconPrincipal.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelSGC);
            this.panel6.Controls.Add(this.panelTMHS);
            this.panel6.Controls.Add(this.panelSanitaria);
            this.panel6.Location = new System.Drawing.Point(188, 134);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 91);
            this.panel6.TabIndex = 53;
            // 
            // TiendaCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnFechaInicio);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.panelContratoPadre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TiendaCard";
            this.Size = new System.Drawing.Size(486, 225);
            this.panelContratoPadre.ResumeLayout(false);
            this.panelContratoPadre.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }       
    }
}
