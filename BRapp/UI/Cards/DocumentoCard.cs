using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class DocumentoCard : UserControl
    {
        private Panel panel2;
        public Panel panelTitle;
        public Label labelName;
        public FontAwesome.Sharp.IconButton btnPdf;
        public ToolTip toolTip1;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;
        public TextBox tbDiasRestantes;
        public Panel panel1;
        private Panel panel22;
        public TextBox tbPadre;
        private Panel panel23;
        private Panel panel24;
        public FontAwesome.Sharp.IconButton btnPadre;
        public Panel panel10;
        private Panel panel11;
        public TextBox tbCargoResponsable;
        private Panel panel12;
        private Panel panel13;
        public FontAwesome.Sharp.IconButton btnResponsable;
        public Panel gbPanelNumeroActa;
        public Panel gbPanelResponsable;
        public Panel gbPanelFechas;
        public Panel gbPanelAdjunto;
        public RichTextBox labelDescripcion;
        public Panel panelFechaVencimiento;
        private Panel panel15;
        public TextBox tbFechaVencimiento;
        private Panel panel16;
        private Panel panel17;
        private FontAwesome.Sharp.IconButton iconButton3;
        public Panel panelFechaFirma;
        private Panel panel19;
        public TextBox tbFechaFirma;
        private Panel panel20;
        private Panel panel21;
        private FontAwesome.Sharp.IconButton iconButton4;
        public Panel panelActaAcuerdo;
        private Panel panel7;
        public TextBox tbActaAcuerdo;
        private Panel panel8;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton iconButton1;
        public Panel panelNumero;
        private Panel panel5;
        public TextBox tbNumero;
        private Panel panel6;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconNumero;
        private System.ComponentModel.IContainer components;

        public DocumentoCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPadre = new FontAwesome.Sharp.IconButton();
            this.btnResponsable = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconNumero = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tbDiasRestantes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tbPadre = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbCargoResponsable = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.gbPanelNumeroActa = new System.Windows.Forms.Panel();
            this.panelActaAcuerdo = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbActaAcuerdo = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelNumero = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbPanelResponsable = new System.Windows.Forms.Panel();
            this.gbPanelFechas = new System.Windows.Forms.Panel();
            this.panelFechaVencimiento = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tbFechaVencimiento = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panelFechaFirma = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tbFechaFirma = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.gbPanelAdjunto = new System.Windows.Forms.Panel();
            this.labelDescripcion = new System.Windows.Forms.RichTextBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.gbPanelNumeroActa.SuspendLayout();
            this.panelActaAcuerdo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelNumero.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbPanelResponsable.SuspendLayout();
            this.gbPanelFechas.SuspendLayout();
            this.panelFechaVencimiento.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panelFechaFirma.SuspendLayout();
            this.panel19.SuspendLayout();
            this.gbPanelAdjunto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 10);
            this.panel2.TabIndex = 21;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Orange;
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Controls.Add(this.iconPrincipal);
            this.panelTitle.Controls.Add(this.btnPdf);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(483, 60);
            this.panelTitle.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(62, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(369, 60);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPrincipal.ForeColor = System.Drawing.Color.Black;
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPrincipal.IconColor = System.Drawing.Color.Black;
            this.iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPrincipal.IconSize = 60;
            this.iconPrincipal.Location = new System.Drawing.Point(0, 0);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(62, 60);
            this.iconPrincipal.TabIndex = 6;
            this.iconPrincipal.TabStop = false;
            // 
            // btnPdf
            // 
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.ForeColor = System.Drawing.Color.Orange;
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPdf.IconColor = System.Drawing.Color.Black;
            this.btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdf.Location = new System.Drawing.Point(427, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(46, 49);
            this.btnPdf.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnPdf, "Ver documento");
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnPadre
            // 
            this.btnPadre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadre.ForeColor = System.Drawing.Color.White;
            this.btnPadre.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnPadre.IconColor = System.Drawing.Color.Black;
            this.btnPadre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPadre.IconSize = 25;
            this.btnPadre.Location = new System.Drawing.Point(0, 0);
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.Size = new System.Drawing.Size(32, 25);
            this.btnPadre.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnPadre, "Responsable");
            this.btnPadre.UseVisualStyleBackColor = true;
            // 
            // btnResponsable
            // 
            this.btnResponsable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsable.ForeColor = System.Drawing.Color.White;
            this.btnResponsable.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnResponsable.IconColor = System.Drawing.Color.Black;
            this.btnResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResponsable.IconSize = 25;
            this.btnResponsable.Location = new System.Drawing.Point(0, 0);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(32, 25);
            this.btnResponsable.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnResponsable, "Responsable");
            this.btnResponsable.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(32, 25);
            this.iconButton4.TabIndex = 21;
            this.toolTip1.SetToolTip(this.iconButton4, "Fecha de firma");
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(32, 25);
            this.iconButton3.TabIndex = 21;
            this.toolTip1.SetToolTip(this.iconButton3, "Fecha de vencimiento");
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconNumero
            // 
            this.iconNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconNumero.ForeColor = System.Drawing.Color.White;
            this.iconNumero.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.iconNumero.IconColor = System.Drawing.Color.Black;
            this.iconNumero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNumero.IconSize = 25;
            this.iconNumero.Location = new System.Drawing.Point(0, 0);
            this.iconNumero.Name = "iconNumero";
            this.iconNumero.Size = new System.Drawing.Size(32, 25);
            this.iconNumero.TabIndex = 21;
            this.toolTip1.SetToolTip(this.iconNumero, "Número del documento");
            this.iconNumero.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 25);
            this.iconButton1.TabIndex = 21;
            this.toolTip1.SetToolTip(this.iconButton1, "Asiento");
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // tbDiasRestantes
            // 
            this.tbDiasRestantes.BackColor = System.Drawing.Color.Orange;
            this.tbDiasRestantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiasRestantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDiasRestantes.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbDiasRestantes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiasRestantes.ForeColor = System.Drawing.Color.Black;
            this.tbDiasRestantes.Location = new System.Drawing.Point(156, 0);
            this.tbDiasRestantes.Name = "tbDiasRestantes";
            this.tbDiasRestantes.ReadOnly = true;
            this.tbDiasRestantes.Size = new System.Drawing.Size(46, 19);
            this.tbDiasRestantes.TabIndex = 28;
            this.tbDiasRestantes.TabStop = false;
            this.tbDiasRestantes.Text = "150";
            this.tbDiasRestantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tbDiasRestantes, "Dias restantes");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel22);
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.panel24);
            this.panel1.Controls.Add(this.btnPadre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 25);
            this.panel1.TabIndex = 48;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.tbPadre);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(32, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(436, 17);
            this.panel22.TabIndex = 25;
            // 
            // tbPadre
            // 
            this.tbPadre.BackColor = System.Drawing.Color.White;
            this.tbPadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPadre.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPadre.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbPadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPadre.Location = new System.Drawing.Point(0, 0);
            this.tbPadre.Multiline = true;
            this.tbPadre.Name = "tbPadre";
            this.tbPadre.ReadOnly = true;
            this.tbPadre.Size = new System.Drawing.Size(351, 17);
            this.tbPadre.TabIndex = 23;
            this.tbPadre.TabStop = false;
            this.tbPadre.Text = "Documento Padre";
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel23.Location = new System.Drawing.Point(32, 21);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(436, 4);
            this.panel23.TabIndex = 24;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(32, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(436, 4);
            this.panel24.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.btnResponsable);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(468, 25);
            this.panel10.TabIndex = 47;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbCargoResponsable);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(32, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(436, 17);
            this.panel11.TabIndex = 25;
            // 
            // tbCargoResponsable
            // 
            this.tbCargoResponsable.BackColor = System.Drawing.Color.White;
            this.tbCargoResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCargoResponsable.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCargoResponsable.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCargoResponsable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCargoResponsable.Location = new System.Drawing.Point(0, 0);
            this.tbCargoResponsable.Multiline = true;
            this.tbCargoResponsable.Name = "tbCargoResponsable";
            this.tbCargoResponsable.ReadOnly = true;
            this.tbCargoResponsable.Size = new System.Drawing.Size(351, 17);
            this.tbCargoResponsable.TabIndex = 23;
            this.tbCargoResponsable.TabStop = false;
            this.tbCargoResponsable.Text = "Responsable";
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(32, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(436, 4);
            this.panel12.TabIndex = 24;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(32, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(436, 4);
            this.panel13.TabIndex = 22;
            // 
            // gbPanelNumeroActa
            // 
            this.gbPanelNumeroActa.BackColor = System.Drawing.Color.White;
            this.gbPanelNumeroActa.Controls.Add(this.panelActaAcuerdo);
            this.gbPanelNumeroActa.Controls.Add(this.panelNumero);
            this.gbPanelNumeroActa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPanelNumeroActa.Location = new System.Drawing.Point(0, 70);
            this.gbPanelNumeroActa.Name = "gbPanelNumeroActa";
            this.gbPanelNumeroActa.Size = new System.Drawing.Size(483, 25);
            this.gbPanelNumeroActa.TabIndex = 51;
            // 
            // panelActaAcuerdo
            // 
            this.panelActaAcuerdo.Controls.Add(this.panel7);
            this.panelActaAcuerdo.Controls.Add(this.panel8);
            this.panelActaAcuerdo.Controls.Add(this.panel9);
            this.panelActaAcuerdo.Controls.Add(this.iconButton1);
            this.panelActaAcuerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActaAcuerdo.Location = new System.Drawing.Point(234, 0);
            this.panelActaAcuerdo.Name = "panelActaAcuerdo";
            this.panelActaAcuerdo.Size = new System.Drawing.Size(234, 25);
            this.panelActaAcuerdo.TabIndex = 58;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbActaAcuerdo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(32, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 17);
            this.panel7.TabIndex = 25;
            // 
            // tbActaAcuerdo
            // 
            this.tbActaAcuerdo.BackColor = System.Drawing.Color.White;
            this.tbActaAcuerdo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActaAcuerdo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActaAcuerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbActaAcuerdo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActaAcuerdo.Location = new System.Drawing.Point(0, 0);
            this.tbActaAcuerdo.Multiline = true;
            this.tbActaAcuerdo.Name = "tbActaAcuerdo";
            this.tbActaAcuerdo.ReadOnly = true;
            this.tbActaAcuerdo.Size = new System.Drawing.Size(158, 17);
            this.tbActaAcuerdo.TabIndex = 23;
            this.tbActaAcuerdo.TabStop = false;
            this.tbActaAcuerdo.Text = "Acta 1/Acuerdo 3";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(32, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 4);
            this.panel8.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(32, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(202, 4);
            this.panel9.TabIndex = 22;
            // 
            // panelNumero
            // 
            this.panelNumero.Controls.Add(this.panel5);
            this.panelNumero.Controls.Add(this.panel6);
            this.panelNumero.Controls.Add(this.panel4);
            this.panelNumero.Controls.Add(this.iconNumero);
            this.panelNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNumero.Location = new System.Drawing.Point(0, 0);
            this.panelNumero.Name = "panelNumero";
            this.panelNumero.Size = new System.Drawing.Size(234, 25);
            this.panelNumero.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbNumero);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(32, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 17);
            this.panel5.TabIndex = 25;
            // 
            // tbNumero
            // 
            this.tbNumero.BackColor = System.Drawing.Color.White;
            this.tbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(0, 0);
            this.tbNumero.Multiline = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(134, 17);
            this.tbNumero.TabIndex = 23;
            this.tbNumero.TabStop = false;
            this.tbNumero.Text = "401/23";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(32, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 4);
            this.panel6.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(32, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 4);
            this.panel4.TabIndex = 22;
            // 
            // gbPanelResponsable
            // 
            this.gbPanelResponsable.BackColor = System.Drawing.Color.White;
            this.gbPanelResponsable.Controls.Add(this.panel10);
            this.gbPanelResponsable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPanelResponsable.Location = new System.Drawing.Point(0, 95);
            this.gbPanelResponsable.Name = "gbPanelResponsable";
            this.gbPanelResponsable.Size = new System.Drawing.Size(483, 25);
            this.gbPanelResponsable.TabIndex = 52;
            this.gbPanelResponsable.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPanelResponsable_Paint);
            // 
            // gbPanelFechas
            // 
            this.gbPanelFechas.BackColor = System.Drawing.Color.White;
            this.gbPanelFechas.Controls.Add(this.panelFechaVencimiento);
            this.gbPanelFechas.Controls.Add(this.panelFechaFirma);
            this.gbPanelFechas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPanelFechas.Location = new System.Drawing.Point(0, 120);
            this.gbPanelFechas.Name = "gbPanelFechas";
            this.gbPanelFechas.Size = new System.Drawing.Size(483, 25);
            this.gbPanelFechas.TabIndex = 53;
            // 
            // panelFechaVencimiento
            // 
            this.panelFechaVencimiento.Controls.Add(this.panel15);
            this.panelFechaVencimiento.Controls.Add(this.panel16);
            this.panelFechaVencimiento.Controls.Add(this.panel17);
            this.panelFechaVencimiento.Controls.Add(this.iconButton3);
            this.panelFechaVencimiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFechaVencimiento.Location = new System.Drawing.Point(234, 0);
            this.panelFechaVencimiento.Name = "panelFechaVencimiento";
            this.panelFechaVencimiento.Size = new System.Drawing.Size(234, 25);
            this.panelFechaVencimiento.TabIndex = 59;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.tbDiasRestantes);
            this.panel15.Controls.Add(this.tbFechaVencimiento);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(32, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(202, 17);
            this.panel15.TabIndex = 25;
            // 
            // tbFechaVencimiento
            // 
            this.tbFechaVencimiento.BackColor = System.Drawing.Color.White;
            this.tbFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFechaVencimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFechaVencimiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFechaVencimiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaVencimiento.Location = new System.Drawing.Point(0, 0);
            this.tbFechaVencimiento.Multiline = true;
            this.tbFechaVencimiento.Name = "tbFechaVencimiento";
            this.tbFechaVencimiento.ReadOnly = true;
            this.tbFechaVencimiento.Size = new System.Drawing.Size(158, 17);
            this.tbFechaVencimiento.TabIndex = 23;
            this.tbFechaVencimiento.TabStop = false;
            this.tbFechaVencimiento.Text = "18-enero-2024";
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(32, 21);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(202, 4);
            this.panel16.TabIndex = 24;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(32, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(202, 4);
            this.panel17.TabIndex = 22;
            // 
            // panelFechaFirma
            // 
            this.panelFechaFirma.Controls.Add(this.panel19);
            this.panelFechaFirma.Controls.Add(this.panel20);
            this.panelFechaFirma.Controls.Add(this.panel21);
            this.panelFechaFirma.Controls.Add(this.iconButton4);
            this.panelFechaFirma.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFechaFirma.Location = new System.Drawing.Point(0, 0);
            this.panelFechaFirma.Name = "panelFechaFirma";
            this.panelFechaFirma.Size = new System.Drawing.Size(234, 25);
            this.panelFechaFirma.TabIndex = 57;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.tbFechaFirma);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(32, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(202, 17);
            this.panel19.TabIndex = 25;
            // 
            // tbFechaFirma
            // 
            this.tbFechaFirma.BackColor = System.Drawing.Color.White;
            this.tbFechaFirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFechaFirma.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFechaFirma.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFechaFirma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaFirma.Location = new System.Drawing.Point(0, 0);
            this.tbFechaFirma.Multiline = true;
            this.tbFechaFirma.Name = "tbFechaFirma";
            this.tbFechaFirma.ReadOnly = true;
            this.tbFechaFirma.Size = new System.Drawing.Size(185, 17);
            this.tbFechaFirma.TabIndex = 23;
            this.tbFechaFirma.TabStop = false;
            this.tbFechaFirma.Text = "18-enero-2023";
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(32, 21);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(202, 4);
            this.panel20.TabIndex = 24;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(32, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(202, 4);
            this.panel21.TabIndex = 22;
            // 
            // gbPanelAdjunto
            // 
            this.gbPanelAdjunto.BackColor = System.Drawing.Color.White;
            this.gbPanelAdjunto.Controls.Add(this.panel1);
            this.gbPanelAdjunto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPanelAdjunto.Location = new System.Drawing.Point(0, 145);
            this.gbPanelAdjunto.Name = "gbPanelAdjunto";
            this.gbPanelAdjunto.Size = new System.Drawing.Size(483, 25);
            this.gbPanelAdjunto.TabIndex = 54;
            this.gbPanelAdjunto.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPanelAdjunto_Paint);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDescripcion.DetectUrls = false;
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(0, 170);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.ReadOnly = true;
            this.labelDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.labelDescripcion.Size = new System.Drawing.Size(145, 38);
            this.labelDescripcion.TabIndex = 55;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // DocumentoCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.gbPanelAdjunto);
            this.Controls.Add(this.gbPanelFechas);
            this.Controls.Add(this.gbPanelResponsable);
            this.Controls.Add(this.gbPanelNumeroActa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DocumentoCard";
            this.Size = new System.Drawing.Size(483, 208);
            this.toolTip1.SetToolTip(this, "Derrogado por");
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.gbPanelNumeroActa.ResumeLayout(false);
            this.panelActaAcuerdo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelNumero.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbPanelResponsable.ResumeLayout(false);
            this.gbPanelFechas.ResumeLayout(false);
            this.panelFechaVencimiento.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panelFechaFirma.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.gbPanelAdjunto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void iconPictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void panelImagen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbPanelResponsable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbPanelAdjunto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
