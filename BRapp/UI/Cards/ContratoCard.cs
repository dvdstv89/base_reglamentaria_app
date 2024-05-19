using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class ContratoCard : UserControl
    {
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnNumero;
        private Panel panel2;
        public Panel panelTitle;
        public FontAwesome.Sharp.IconButton btnPdf;
        private Panel panel3;
        public FontAwesome.Sharp.IconButton btnCliente;
        public TextBox tbCliente;
        public TextBox tbActaAcuerdo;
        private FontAwesome.Sharp.IconButton btnActaAcuerdo;
        public TextBox labelNumero;
        private Panel panel4;
        public TextBox tbResponsable;
        public FontAwesome.Sharp.IconButton btnResponsable;
        public TextBox tbTipoContrato;
        private FontAwesome.Sharp.IconButton btnTipoContrato;
        private Panel panel5;
        public TextBox tbFechaFin;
        private FontAwesome.Sharp.IconButton btnFechaFin;
        public TextBox tbFechaInicio;
        private FontAwesome.Sharp.IconButton btnFechaInicio;
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public Label labelName;
        public TextBox tbDiasRestantes;
        public Panel panelContratoPadre;
        public FontAwesome.Sharp.IconButton btnContratoPadre;
        public TextBox tbContratoPadre;
        public Panel panelImagen;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;

        public ContratoCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbActaAcuerdo = new System.Windows.Forms.TextBox();
            this.btnActaAcuerdo = new FontAwesome.Sharp.IconButton();
            this.labelNumero = new System.Windows.Forms.TextBox();
            this.btnNumero = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.tbDiasRestantes = new System.Windows.Forms.TextBox();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.btnResponsable = new FontAwesome.Sharp.IconButton();
            this.tbTipoContrato = new System.Windows.Forms.TextBox();
            this.btnTipoContrato = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.btnFechaFin = new FontAwesome.Sharp.IconButton();
            this.tbFechaInicio = new System.Windows.Forms.TextBox();
            this.btnFechaInicio = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnContratoPadre = new FontAwesome.Sharp.IconButton();
            this.panelContratoPadre = new System.Windows.Forms.Panel();
            this.tbContratoPadre = new System.Windows.Forms.TextBox();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelContratoPadre.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbActaAcuerdo);
            this.panel1.Controls.Add(this.btnActaAcuerdo);
            this.panel1.Controls.Add(this.labelNumero);
            this.panel1.Controls.Add(this.btnNumero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(120, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 25);
            this.panel1.TabIndex = 29;
            // 
            // tbActaAcuerdo
            // 
            this.tbActaAcuerdo.BackColor = System.Drawing.Color.White;
            this.tbActaAcuerdo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActaAcuerdo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActaAcuerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbActaAcuerdo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActaAcuerdo.Location = new System.Drawing.Point(210, 0);
            this.tbActaAcuerdo.Multiline = true;
            this.tbActaAcuerdo.Name = "tbActaAcuerdo";
            this.tbActaAcuerdo.ReadOnly = true;
            this.tbActaAcuerdo.Size = new System.Drawing.Size(150, 25);
            this.tbActaAcuerdo.TabIndex = 23;
            this.tbActaAcuerdo.TabStop = false;
            this.tbActaAcuerdo.Text = "Acta 1/Acuerdo 3";
            // 
            // btnActaAcuerdo
            // 
            this.btnActaAcuerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActaAcuerdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActaAcuerdo.ForeColor = System.Drawing.Color.White;
            this.btnActaAcuerdo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnActaAcuerdo.IconColor = System.Drawing.Color.Black;
            this.btnActaAcuerdo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActaAcuerdo.IconSize = 25;
            this.btnActaAcuerdo.Location = new System.Drawing.Point(172, 0);
            this.btnActaAcuerdo.Name = "btnActaAcuerdo";
            this.btnActaAcuerdo.Size = new System.Drawing.Size(38, 25);
            this.btnActaAcuerdo.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnActaAcuerdo, "Números de acta y acuerdo");
            this.btnActaAcuerdo.UseVisualStyleBackColor = true;
            // 
            // labelNumero
            // 
            this.labelNumero.BackColor = System.Drawing.Color.White;
            this.labelNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(38, 0);
            this.labelNumero.Multiline = true;
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.ReadOnly = true;
            this.labelNumero.Size = new System.Drawing.Size(134, 25);
            this.labelNumero.TabIndex = 21;
            this.labelNumero.TabStop = false;
            this.labelNumero.Text = "401/23";
            // 
            // btnNumero
            // 
            this.btnNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero.ForeColor = System.Drawing.Color.White;
            this.btnNumero.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.btnNumero.IconColor = System.Drawing.Color.Black;
            this.btnNumero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNumero.IconSize = 25;
            this.btnNumero.Location = new System.Drawing.Point(0, 0);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(38, 25);
            this.btnNumero.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnNumero, "Número del contrato");
            this.btnNumero.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 10);
            this.panel2.TabIndex = 27;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Orange;
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Controls.Add(this.tbDiasRestantes);
            this.panelTitle.Controls.Add(this.iconPrincipal);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(483, 60);
            this.panelTitle.TabIndex = 26;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(52, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(431, 60);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiasRestantes
            // 
            this.tbDiasRestantes.BackColor = System.Drawing.Color.Orange;
            this.tbDiasRestantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiasRestantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiasRestantes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbDiasRestantes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiasRestantes.ForeColor = System.Drawing.Color.White;
            this.tbDiasRestantes.Location = new System.Drawing.Point(0, 0);
            this.tbDiasRestantes.Name = "tbDiasRestantes";
            this.tbDiasRestantes.ReadOnly = true;
            this.tbDiasRestantes.Size = new System.Drawing.Size(46, 19);
            this.tbDiasRestantes.TabIndex = 23;
            this.tbDiasRestantes.TabStop = false;
            this.tbDiasRestantes.Text = "150";
            this.tbDiasRestantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPrincipal.IconColor = System.Drawing.Color.White;
            this.iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPrincipal.IconSize = 39;
            this.iconPrincipal.Location = new System.Drawing.Point(3, 18);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(43, 39);
            this.iconPrincipal.TabIndex = 6;
            this.iconPrincipal.TabStop = false;
            // 
            // btnPdf
            // 
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPdf.IconColor = System.Drawing.Color.Black;
            this.btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdf.IconSize = 36;
            this.btnPdf.Location = new System.Drawing.Point(437, 173);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(43, 33);
            this.btnPdf.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnPdf, "Ver contrato");
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnCliente);
            this.panel3.Controls.Add(this.tbCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(120, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 25);
            this.panel3.TabIndex = 33;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 25;
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(38, 25);
            this.btnCliente.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCliente, "Cliente");
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.Color.White;
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(38, 0);
            this.tbCliente.Multiline = true;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(322, 25);
            this.tbCliente.TabIndex = 8;
            this.tbCliente.TabStop = false;
            this.tbCliente.Text = "MPYME Alimentos Núñez-Veulens";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tbResponsable);
            this.panel4.Controls.Add(this.btnResponsable);
            this.panel4.Controls.Add(this.tbTipoContrato);
            this.panel4.Controls.Add(this.btnTipoContrato);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(120, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 25);
            this.panel4.TabIndex = 34;
            // 
            // tbResponsable
            // 
            this.tbResponsable.BackColor = System.Drawing.Color.White;
            this.tbResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResponsable.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbResponsable.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbResponsable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponsable.Location = new System.Drawing.Point(210, 0);
            this.tbResponsable.Multiline = true;
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.ReadOnly = true;
            this.tbResponsable.Size = new System.Drawing.Size(150, 25);
            this.tbResponsable.TabIndex = 23;
            this.tbResponsable.TabStop = false;
            this.tbResponsable.Text = "Comercial";
            // 
            // btnResponsable
            // 
            this.btnResponsable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsable.ForeColor = System.Drawing.Color.White;
            this.btnResponsable.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnResponsable.IconColor = System.Drawing.Color.Black;
            this.btnResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResponsable.IconSize = 25;
            this.btnResponsable.Location = new System.Drawing.Point(172, 0);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(38, 25);
            this.btnResponsable.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnResponsable, "Departamento responsable");
            this.btnResponsable.UseVisualStyleBackColor = true;
            // 
            // tbTipoContrato
            // 
            this.tbTipoContrato.BackColor = System.Drawing.Color.White;
            this.tbTipoContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipoContrato.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTipoContrato.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTipoContrato.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoContrato.Location = new System.Drawing.Point(38, 0);
            this.tbTipoContrato.Multiline = true;
            this.tbTipoContrato.Name = "tbTipoContrato";
            this.tbTipoContrato.ReadOnly = true;
            this.tbTipoContrato.Size = new System.Drawing.Size(134, 25);
            this.tbTipoContrato.TabIndex = 21;
            this.tbTipoContrato.TabStop = false;
            this.tbTipoContrato.Text = "Compra-Venta";
            // 
            // btnTipoContrato
            // 
            this.btnTipoContrato.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoContrato.ForeColor = System.Drawing.Color.White;
            this.btnTipoContrato.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnTipoContrato.IconColor = System.Drawing.Color.Black;
            this.btnTipoContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTipoContrato.IconSize = 25;
            this.btnTipoContrato.Location = new System.Drawing.Point(0, 0);
            this.btnTipoContrato.Name = "btnTipoContrato";
            this.btnTipoContrato.Size = new System.Drawing.Size(38, 25);
            this.btnTipoContrato.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnTipoContrato, "Tipo de Contrato");
            this.btnTipoContrato.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.tbFechaFin);
            this.panel5.Controls.Add(this.btnFechaFin);
            this.panel5.Controls.Add(this.tbFechaInicio);
            this.panel5.Controls.Add(this.btnFechaInicio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(120, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 25);
            this.panel5.TabIndex = 35;
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.BackColor = System.Drawing.Color.White;
            this.tbFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFechaFin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFechaFin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaFin.Location = new System.Drawing.Point(210, 0);
            this.tbFechaFin.Multiline = true;
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.ReadOnly = true;
            this.tbFechaFin.Size = new System.Drawing.Size(150, 25);
            this.tbFechaFin.TabIndex = 23;
            this.tbFechaFin.TabStop = false;
            this.tbFechaFin.Text = "18-enero-2024";
            // 
            // btnFechaFin
            // 
            this.btnFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFechaFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaFin.ForeColor = System.Drawing.Color.White;
            this.btnFechaFin.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.btnFechaFin.IconColor = System.Drawing.Color.Black;
            this.btnFechaFin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaFin.IconSize = 25;
            this.btnFechaFin.Location = new System.Drawing.Point(172, 0);
            this.btnFechaFin.Name = "btnFechaFin";
            this.btnFechaFin.Size = new System.Drawing.Size(38, 25);
            this.btnFechaFin.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnFechaFin, "Fecha de Vencimiento");
            this.btnFechaFin.UseVisualStyleBackColor = true;
            // 
            // tbFechaInicio
            // 
            this.tbFechaInicio.BackColor = System.Drawing.Color.White;
            this.tbFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFechaInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFechaInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFechaInicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaInicio.Location = new System.Drawing.Point(38, 0);
            this.tbFechaInicio.Multiline = true;
            this.tbFechaInicio.Name = "tbFechaInicio";
            this.tbFechaInicio.ReadOnly = true;
            this.tbFechaInicio.Size = new System.Drawing.Size(134, 25);
            this.tbFechaInicio.TabIndex = 21;
            this.tbFechaInicio.TabStop = false;
            this.tbFechaInicio.Text = "18-enero-2023";
            // 
            // btnFechaInicio
            // 
            this.btnFechaInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaInicio.ForeColor = System.Drawing.Color.White;
            this.btnFechaInicio.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.btnFechaInicio.IconColor = System.Drawing.Color.Black;
            this.btnFechaInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaInicio.IconSize = 25;
            this.btnFechaInicio.Location = new System.Drawing.Point(0, 0);
            this.btnFechaInicio.Name = "btnFechaInicio";
            this.btnFechaInicio.Size = new System.Drawing.Size(38, 25);
            this.btnFechaInicio.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnFechaInicio, "Fecha de Firma");
            this.btnFechaInicio.UseVisualStyleBackColor = true;
            // 
            // btnContratoPadre
            // 
            this.btnContratoPadre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContratoPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratoPadre.ForeColor = System.Drawing.Color.White;
            this.btnContratoPadre.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnContratoPadre.IconColor = System.Drawing.Color.Black;
            this.btnContratoPadre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContratoPadre.IconSize = 25;
            this.btnContratoPadre.Location = new System.Drawing.Point(0, 0);
            this.btnContratoPadre.Name = "btnContratoPadre";
            this.btnContratoPadre.Size = new System.Drawing.Size(38, 25);
            this.btnContratoPadre.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnContratoPadre, "Contrato Padre");
            this.btnContratoPadre.UseVisualStyleBackColor = true;
            // 
            // panelContratoPadre
            // 
            this.panelContratoPadre.BackColor = System.Drawing.Color.White;
            this.panelContratoPadre.Controls.Add(this.btnContratoPadre);
            this.panelContratoPadre.Controls.Add(this.tbContratoPadre);
            this.panelContratoPadre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContratoPadre.Location = new System.Drawing.Point(120, 170);
            this.panelContratoPadre.Name = "panelContratoPadre";
            this.panelContratoPadre.Size = new System.Drawing.Size(363, 25);
            this.panelContratoPadre.TabIndex = 36;
            // 
            // tbContratoPadre
            // 
            this.tbContratoPadre.BackColor = System.Drawing.Color.White;
            this.tbContratoPadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContratoPadre.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbContratoPadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContratoPadre.Location = new System.Drawing.Point(38, 0);
            this.tbContratoPadre.Multiline = true;
            this.tbContratoPadre.Name = "tbContratoPadre";
            this.tbContratoPadre.ReadOnly = true;
            this.tbContratoPadre.Size = new System.Drawing.Size(273, 25);
            this.tbContratoPadre.TabIndex = 8;
            this.tbContratoPadre.TabStop = false;
            this.tbContratoPadre.Text = "Contrato Padre";
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.White;
            this.panelImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagen.Controls.Add(this.iconPictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 70);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(120, 138);
            this.panelImagen.TabIndex = 28;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 116;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(117, 116);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // ContratoCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.panelContratoPadre);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ContratoCard";
            this.Size = new System.Drawing.Size(483, 208);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelContratoPadre.ResumeLayout(false);
            this.panelContratoPadre.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
