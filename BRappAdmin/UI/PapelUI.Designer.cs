namespace BRappAdmin.UI
{
    partial class PapelUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbObligatorio = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.tbDescripcion = new RichTextBoxEx.RichTextBoxEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboTipoDocumentacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbPDF = new System.Windows.Forms.GroupBox();
            this.tbPdf = new System.Windows.Forms.TextBox();
            this.btnBuscarPdf = new FontAwesome.Sharp.IconButton();
            this.gbPadre = new System.Windows.Forms.GroupBox();
            this.btnBuscarPadre = new FontAwesome.Sharp.IconButton();
            this.cbPadre = new System.Windows.Forms.ComboBox();
            this.cbTienePadre = new System.Windows.Forms.CheckBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.gbResponsable = new System.Windows.Forms.GroupBox();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.btnBuscarResponsable = new FontAwesome.Sharp.IconButton();
            this.gbFechaVencimiento = new System.Windows.Forms.GroupBox();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.gbFechaFirma = new System.Windows.Forms.GroupBox();
            this.dtFechaFirma = new System.Windows.Forms.DateTimePicker();
            this.gbActaAcuerdo = new System.Windows.Forms.GroupBox();
            this.tbActa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAcuerdo = new System.Windows.Forms.TextBox();
            this.gbNumero = new System.Windows.Forms.GroupBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbPDF.SuspendLayout();
            this.gbPadre.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbResponsable.SuspendLayout();
            this.gbFechaVencimiento.SuspendLayout();
            this.gbFechaFirma.SuspendLayout();
            this.gbActaAcuerdo.SuspendLayout();
            this.gbNumero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(314, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(7, 24);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(383, 21);
            this.cbTipo.TabIndex = 22;
            // 
            // cbObligatorio
            // 
            this.cbObligatorio.AutoSize = true;
            this.cbObligatorio.Checked = true;
            this.cbObligatorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbObligatorio.Location = new System.Drawing.Point(210, 16);
            this.cbObligatorio.Name = "cbObligatorio";
            this.cbObligatorio.Size = new System.Drawing.Size(81, 17);
            this.cbObligatorio.TabIndex = 62;
            this.cbObligatorio.Text = "Es opcional";
            this.cbObligatorio.UseVisualStyleBackColor = true;
            this.cbObligatorio.CheckedChanged += new System.EventHandler(this.cbObligatorio_CheckedChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(55, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(335, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombre";
            // 
            // openPdf
            // 
            this.openPdf.FileName = "openFileDialog1";
            this.openPdf.Filter = "Pdf Files|*.pdf";
            this.openPdf.Title = "Logo";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.AllowBullets = true;
            this.tbDescripcion.AllowDefaultInsertText = true;
            this.tbDescripcion.AllowDefaultSmartText = true;
            this.tbDescripcion.AllowHyphenation = true;
            this.tbDescripcion.AllowPictures = true;
            this.tbDescripcion.AllowSpellCheck = true;
            this.tbDescripcion.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbDescripcion.FilePath = "";
            this.tbDescripcion.Location = new System.Drawing.Point(6, 19);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang2057{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.tbDescripcion.SetColorWithFont = true;
            this.tbDescripcion.ShowToolStrip = true;
            this.tbDescripcion.Size = new System.Drawing.Size(369, 94);
            this.tbDescripcion.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(8, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 119);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // ComboTipoDocumentacion
            // 
            this.ComboTipoDocumentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDocumentacion.FormattingEnabled = true;
            this.ComboTipoDocumentacion.Location = new System.Drawing.Point(121, 41);
            this.ComboTipoDocumentacion.Name = "ComboTipoDocumentacion";
            this.ComboTipoDocumentacion.Size = new System.Drawing.Size(268, 21);
            this.ComboTipoDocumentacion.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tipo Documentación";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.cbTipo);
            this.gbTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTipo.Location = new System.Drawing.Point(0, 197);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(395, 55);
            this.gbTipo.TabIndex = 43;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ComboTipoDocumentacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 197);
            this.panel1.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gbPDF);
            this.panel2.Controls.Add(this.gbPadre);
            this.panel2.Controls.Add(this.gbCliente);
            this.panel2.Controls.Add(this.gbResponsable);
            this.panel2.Controls.Add(this.gbFechaVencimiento);
            this.panel2.Controls.Add(this.gbFechaFirma);
            this.panel2.Controls.Add(this.gbActaAcuerdo);
            this.panel2.Controls.Add(this.gbNumero);
            this.panel2.Controls.Add(this.gbTipo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 739);
            this.panel2.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.cbObligatorio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 696);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 43);
            this.panel3.TabIndex = 88;
            // 
            // gbPDF
            // 
            this.gbPDF.Controls.Add(this.tbPdf);
            this.gbPDF.Controls.Add(this.btnBuscarPdf);
            this.gbPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPDF.Location = new System.Drawing.Point(0, 637);
            this.gbPDF.Name = "gbPDF";
            this.gbPDF.Size = new System.Drawing.Size(395, 55);
            this.gbPDF.TabIndex = 87;
            this.gbPDF.TabStop = false;
            this.gbPDF.Text = "Documento PDF";
            // 
            // tbPdf
            // 
            this.tbPdf.Location = new System.Drawing.Point(6, 25);
            this.tbPdf.Name = "tbPdf";
            this.tbPdf.ReadOnly = true;
            this.tbPdf.Size = new System.Drawing.Size(347, 20);
            this.tbPdf.TabIndex = 41;
            // 
            // btnBuscarPdf
            // 
            this.btnBuscarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPdf.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnBuscarPdf.IconColor = System.Drawing.Color.Black;
            this.btnBuscarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPdf.IconSize = 24;
            this.btnBuscarPdf.Location = new System.Drawing.Point(359, 19);
            this.btnBuscarPdf.Name = "btnBuscarPdf";
            this.btnBuscarPdf.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarPdf.TabIndex = 42;
            this.btnBuscarPdf.UseVisualStyleBackColor = true;
            // 
            // gbPadre
            // 
            this.gbPadre.Controls.Add(this.btnBuscarPadre);
            this.gbPadre.Controls.Add(this.cbPadre);
            this.gbPadre.Controls.Add(this.cbTienePadre);
            this.gbPadre.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPadre.Location = new System.Drawing.Point(0, 582);
            this.gbPadre.Name = "gbPadre";
            this.gbPadre.Size = new System.Drawing.Size(395, 55);
            this.gbPadre.TabIndex = 86;
            this.gbPadre.TabStop = false;
            this.gbPadre.Text = "Padre";
            // 
            // btnBuscarPadre
            // 
            this.btnBuscarPadre.Enabled = false;
            this.btnBuscarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPadre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPadre.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarPadre.IconColor = System.Drawing.Color.Black;
            this.btnBuscarPadre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPadre.IconSize = 24;
            this.btnBuscarPadre.Location = new System.Drawing.Point(333, 15);
            this.btnBuscarPadre.Name = "btnBuscarPadre";
            this.btnBuscarPadre.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarPadre.TabIndex = 39;
            this.btnBuscarPadre.UseVisualStyleBackColor = true;
            // 
            // cbPadre
            // 
            this.cbPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPadre.Enabled = false;
            this.cbPadre.FormattingEnabled = true;
            this.cbPadre.Location = new System.Drawing.Point(7, 19);
            this.cbPadre.Name = "cbPadre";
            this.cbPadre.Size = new System.Drawing.Size(320, 21);
            this.cbPadre.TabIndex = 32;
            // 
            // cbTienePadre
            // 
            this.cbTienePadre.AutoSize = true;
            this.cbTienePadre.Location = new System.Drawing.Point(375, 24);
            this.cbTienePadre.Name = "cbTienePadre";
            this.cbTienePadre.Size = new System.Drawing.Size(15, 14);
            this.cbTienePadre.TabIndex = 33;
            this.cbTienePadre.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCliente.Location = new System.Drawing.Point(0, 527);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(395, 55);
            this.gbCliente.TabIndex = 85;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(8, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(345, 21);
            this.cbCliente.TabIndex = 24;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 24;
            this.btnBuscarCliente.Location = new System.Drawing.Point(354, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarCliente.TabIndex = 39;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // gbResponsable
            // 
            this.gbResponsable.Controls.Add(this.cbResponsable);
            this.gbResponsable.Controls.Add(this.btnBuscarResponsable);
            this.gbResponsable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbResponsable.Location = new System.Drawing.Point(0, 472);
            this.gbResponsable.Name = "gbResponsable";
            this.gbResponsable.Size = new System.Drawing.Size(395, 55);
            this.gbResponsable.TabIndex = 84;
            this.gbResponsable.TabStop = false;
            this.gbResponsable.Text = "Responsable";
            // 
            // cbResponsable
            // 
            this.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(8, 19);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(345, 21);
            this.cbResponsable.TabIndex = 24;
            // 
            // btnBuscarResponsable
            // 
            this.btnBuscarResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarResponsable.ForeColor = System.Drawing.Color.White;
            this.btnBuscarResponsable.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarResponsable.IconColor = System.Drawing.Color.Black;
            this.btnBuscarResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarResponsable.IconSize = 24;
            this.btnBuscarResponsable.Location = new System.Drawing.Point(354, 13);
            this.btnBuscarResponsable.Name = "btnBuscarResponsable";
            this.btnBuscarResponsable.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarResponsable.TabIndex = 39;
            this.btnBuscarResponsable.UseVisualStyleBackColor = true;
            // 
            // gbFechaVencimiento
            // 
            this.gbFechaVencimiento.Controls.Add(this.dtFechaVencimiento);
            this.gbFechaVencimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFechaVencimiento.Location = new System.Drawing.Point(0, 417);
            this.gbFechaVencimiento.Name = "gbFechaVencimiento";
            this.gbFechaVencimiento.Size = new System.Drawing.Size(395, 55);
            this.gbFechaVencimiento.TabIndex = 83;
            this.gbFechaVencimiento.TabStop = false;
            this.gbFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Location = new System.Drawing.Point(8, 19);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(381, 20);
            this.dtFechaVencimiento.TabIndex = 17;
            // 
            // gbFechaFirma
            // 
            this.gbFechaFirma.Controls.Add(this.dtFechaFirma);
            this.gbFechaFirma.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFechaFirma.Location = new System.Drawing.Point(0, 362);
            this.gbFechaFirma.Name = "gbFechaFirma";
            this.gbFechaFirma.Size = new System.Drawing.Size(395, 55);
            this.gbFechaFirma.TabIndex = 82;
            this.gbFechaFirma.TabStop = false;
            this.gbFechaFirma.Text = "Fecha de firma";
            // 
            // dtFechaFirma
            // 
            this.dtFechaFirma.Location = new System.Drawing.Point(8, 19);
            this.dtFechaFirma.Name = "dtFechaFirma";
            this.dtFechaFirma.Size = new System.Drawing.Size(382, 20);
            this.dtFechaFirma.TabIndex = 17;
            // 
            // gbActaAcuerdo
            // 
            this.gbActaAcuerdo.Controls.Add(this.tbActa);
            this.gbActaAcuerdo.Controls.Add(this.label2);
            this.gbActaAcuerdo.Controls.Add(this.label4);
            this.gbActaAcuerdo.Controls.Add(this.tbAcuerdo);
            this.gbActaAcuerdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbActaAcuerdo.Location = new System.Drawing.Point(0, 307);
            this.gbActaAcuerdo.Name = "gbActaAcuerdo";
            this.gbActaAcuerdo.Size = new System.Drawing.Size(395, 55);
            this.gbActaAcuerdo.TabIndex = 81;
            this.gbActaAcuerdo.TabStop = false;
            this.gbActaAcuerdo.Text = "Acta y Acuerdo";
            // 
            // tbActa
            // 
            this.tbActa.Location = new System.Drawing.Point(38, 27);
            this.tbActa.Name = "tbActa";
            this.tbActa.Size = new System.Drawing.Size(117, 20);
            this.tbActa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Acta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Acuerdo";
            // 
            // tbAcuerdo
            // 
            this.tbAcuerdo.Location = new System.Drawing.Point(224, 27);
            this.tbAcuerdo.Name = "tbAcuerdo";
            this.tbAcuerdo.Size = new System.Drawing.Size(159, 20);
            this.tbAcuerdo.TabIndex = 71;
            // 
            // gbNumero
            // 
            this.gbNumero.Controls.Add(this.tbNumero);
            this.gbNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNumero.Location = new System.Drawing.Point(0, 252);
            this.gbNumero.Name = "gbNumero";
            this.gbNumero.Size = new System.Drawing.Size(395, 55);
            this.gbNumero.TabIndex = 80;
            this.gbNumero.TabStop = false;
            this.gbNumero.Text = "Número";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(6, 24);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(377, 20);
            this.tbNumero.TabIndex = 5;
            // 
            // PapelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 739);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PapelUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Documento";
            this.Load += new System.EventHandler(this.PapelUI_Load);
            this.groupBox2.ResumeLayout(false);
            this.gbTipo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbPDF.ResumeLayout(false);
            this.gbPDF.PerformLayout();
            this.gbPadre.ResumeLayout(false);
            this.gbPadre.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbResponsable.ResumeLayout(false);
            this.gbFechaVencimiento.ResumeLayout(false);
            this.gbFechaFirma.ResumeLayout(false);
            this.gbActaAcuerdo.ResumeLayout(false);
            this.gbActaAcuerdo.PerformLayout();
            this.gbNumero.ResumeLayout(false);
            this.gbNumero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.OpenFileDialog openPdf;
        public System.Windows.Forms.ComboBox cbTipo;
        public RichTextBoxEx.RichTextBoxEx tbDescripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox cbObligatorio;
        public System.Windows.Forms.ComboBox ComboTipoDocumentacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox gbPadre;
        public FontAwesome.Sharp.IconButton btnBuscarPadre;
        public System.Windows.Forms.ComboBox cbPadre;
        public System.Windows.Forms.CheckBox cbTienePadre;
        public System.Windows.Forms.GroupBox gbCliente;
        public System.Windows.Forms.ComboBox cbCliente;
        public FontAwesome.Sharp.IconButton btnBuscarCliente;
        public System.Windows.Forms.GroupBox gbResponsable;
        public System.Windows.Forms.ComboBox cbResponsable;
        public FontAwesome.Sharp.IconButton btnBuscarResponsable;
        public System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        public System.Windows.Forms.DateTimePicker dtFechaFirma;
        public System.Windows.Forms.GroupBox gbActaAcuerdo;
        public System.Windows.Forms.TextBox tbActa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbAcuerdo;
        public System.Windows.Forms.GroupBox gbNumero;
        public System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.GroupBox gbPDF;
        public System.Windows.Forms.TextBox tbPdf;
        public FontAwesome.Sharp.IconButton btnBuscarPdf;
        public System.Windows.Forms.GroupBox gbTipo;
        public System.Windows.Forms.GroupBox gbFechaFirma;
        public System.Windows.Forms.GroupBox gbFechaVencimiento;
    }
}