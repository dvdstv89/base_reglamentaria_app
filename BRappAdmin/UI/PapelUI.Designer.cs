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
            this.tabControTiposPapeles = new System.Windows.Forms.TabControl();
            this.tabSistema = new System.Windows.Forms.TabPage();
            this.cbTipoSistema = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabContrato = new System.Windows.Forms.TabPage();
            this.cbTieneContratoPadre = new System.Windows.Forms.CheckBox();
            this.cbContratoPadre = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbClienteContrato = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAcuerdoContrato = new System.Windows.Forms.NumericUpDown();
            this.dtFechaVencimientoContrato = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbActaContrato = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoContrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeroContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabResolucion = new System.Windows.Forms.TabPage();
            this.tbResolucionNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbResolucionEsDerrogada = new System.Windows.Forms.CheckBox();
            this.cbResolucionDerrogada = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageDG = new System.Windows.Forms.TabPage();
            this.tbDGNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.lbResonsableDocumento = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarImagen = new FontAwesome.Sharp.IconButton();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPdf = new FontAwesome.Sharp.IconButton();
            this.tbPdf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lbFechaDocumento = new System.Windows.Forms.Label();
            this.tbDescripcion = new RichTextBoxEx.RichTextBoxEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResolucionDerrogadaPor = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.btnBuscarContratoPadre = new FontAwesome.Sharp.IconButton();
            this.btnBuscarResponsable = new FontAwesome.Sharp.IconButton();
            this.tabControTiposPapeles.SuspendLayout();
            this.tabSistema.SuspendLayout();
            this.tabContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAcuerdoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbActaContrato)).BeginInit();
            this.tabResolucion.SuspendLayout();
            this.tabPageDG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(323, 563);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabControTiposPapeles
            // 
            this.tabControTiposPapeles.Controls.Add(this.tabSistema);
            this.tabControTiposPapeles.Controls.Add(this.tabContrato);
            this.tabControTiposPapeles.Controls.Add(this.tabResolucion);
            this.tabControTiposPapeles.Controls.Add(this.tabPageDG);
            this.tabControTiposPapeles.Location = new System.Drawing.Point(20, 320);
            this.tabControTiposPapeles.Name = "tabControTiposPapeles";
            this.tabControTiposPapeles.SelectedIndex = 0;
            this.tabControTiposPapeles.Size = new System.Drawing.Size(382, 237);
            this.tabControTiposPapeles.TabIndex = 14;
            // 
            // tabSistema
            // 
            this.tabSistema.Controls.Add(this.cbTipoSistema);
            this.tabSistema.Controls.Add(this.label10);
            this.tabSistema.Location = new System.Drawing.Point(4, 22);
            this.tabSistema.Name = "tabSistema";
            this.tabSistema.Padding = new System.Windows.Forms.Padding(3);
            this.tabSistema.Size = new System.Drawing.Size(374, 211);
            this.tabSistema.TabIndex = 0;
            this.tabSistema.Text = "Sistema";
            this.tabSistema.UseVisualStyleBackColor = true;
            // 
            // cbTipoSistema
            // 
            this.cbTipoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoSistema.FormattingEnabled = true;
            this.cbTipoSistema.Location = new System.Drawing.Point(85, 13);
            this.cbTipoSistema.Name = "cbTipoSistema";
            this.cbTipoSistema.Size = new System.Drawing.Size(283, 21);
            this.cbTipoSistema.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tipo";
            // 
            // tabContrato
            // 
            this.tabContrato.Controls.Add(this.btnBuscarContratoPadre);
            this.tabContrato.Controls.Add(this.btnBuscarCliente);
            this.tabContrato.Controls.Add(this.cbTieneContratoPadre);
            this.tabContrato.Controls.Add(this.cbContratoPadre);
            this.tabContrato.Controls.Add(this.label18);
            this.tabContrato.Controls.Add(this.cbClienteContrato);
            this.tabContrato.Controls.Add(this.label17);
            this.tabContrato.Controls.Add(this.label16);
            this.tabContrato.Controls.Add(this.tbAcuerdoContrato);
            this.tabContrato.Controls.Add(this.dtFechaVencimientoContrato);
            this.tabContrato.Controls.Add(this.label4);
            this.tabContrato.Controls.Add(this.tbActaContrato);
            this.tabContrato.Controls.Add(this.label2);
            this.tabContrato.Controls.Add(this.cbTipoContrato);
            this.tabContrato.Controls.Add(this.label1);
            this.tabContrato.Controls.Add(this.tbNumeroContrato);
            this.tabContrato.Controls.Add(this.label3);
            this.tabContrato.Location = new System.Drawing.Point(4, 22);
            this.tabContrato.Name = "tabContrato";
            this.tabContrato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContrato.Size = new System.Drawing.Size(374, 211);
            this.tabContrato.TabIndex = 1;
            this.tabContrato.Text = "Contrato";
            this.tabContrato.UseVisualStyleBackColor = true;
            // 
            // cbTieneContratoPadre
            // 
            this.cbTieneContratoPadre.AutoSize = true;
            this.cbTieneContratoPadre.Location = new System.Drawing.Point(353, 176);
            this.cbTieneContratoPadre.Name = "cbTieneContratoPadre";
            this.cbTieneContratoPadre.Size = new System.Drawing.Size(15, 14);
            this.cbTieneContratoPadre.TabIndex = 33;
            this.cbTieneContratoPadre.UseVisualStyleBackColor = true;
            // 
            // cbContratoPadre
            // 
            this.cbContratoPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContratoPadre.Enabled = false;
            this.cbContratoPadre.FormattingEnabled = true;
            this.cbContratoPadre.Location = new System.Drawing.Point(127, 173);
            this.cbContratoPadre.Name = "cbContratoPadre";
            this.cbContratoPadre.Size = new System.Drawing.Size(213, 21);
            this.cbContratoPadre.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Padre";
            // 
            // cbClienteContrato
            // 
            this.cbClienteContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienteContrato.FormattingEnabled = true;
            this.cbClienteContrato.Location = new System.Drawing.Point(127, 146);
            this.cbClienteContrato.Name = "cbClienteContrato";
            this.cbClienteContrato.Size = new System.Drawing.Size(241, 21);
            this.cbClienteContrato.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Cliente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Vence";
            // 
            // tbAcuerdoContrato
            // 
            this.tbAcuerdoContrato.Location = new System.Drawing.Point(85, 94);
            this.tbAcuerdoContrato.Name = "tbAcuerdoContrato";
            this.tbAcuerdoContrato.Size = new System.Drawing.Size(283, 20);
            this.tbAcuerdoContrato.TabIndex = 26;
            // 
            // dtFechaVencimientoContrato
            // 
            this.dtFechaVencimientoContrato.Location = new System.Drawing.Point(85, 120);
            this.dtFechaVencimientoContrato.Name = "dtFechaVencimientoContrato";
            this.dtFechaVencimientoContrato.Size = new System.Drawing.Size(283, 20);
            this.dtFechaVencimientoContrato.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Acuerdo";
            // 
            // tbActaContrato
            // 
            this.tbActaContrato.Location = new System.Drawing.Point(85, 68);
            this.tbActaContrato.Name = "tbActaContrato";
            this.tbActaContrato.Size = new System.Drawing.Size(283, 20);
            this.tbActaContrato.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Acta";
            // 
            // cbTipoContrato
            // 
            this.cbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoContrato.FormattingEnabled = true;
            this.cbTipoContrato.Location = new System.Drawing.Point(85, 16);
            this.cbTipoContrato.Name = "cbTipoContrato";
            this.cbTipoContrato.Size = new System.Drawing.Size(283, 21);
            this.cbTipoContrato.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo";
            // 
            // tbNumeroContrato
            // 
            this.tbNumeroContrato.Location = new System.Drawing.Point(85, 42);
            this.tbNumeroContrato.Name = "tbNumeroContrato";
            this.tbNumeroContrato.Size = new System.Drawing.Size(283, 20);
            this.tbNumeroContrato.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número";
            // 
            // tabResolucion
            // 
            this.tabResolucion.Controls.Add(this.btnResolucionDerrogadaPor);
            this.tabResolucion.Controls.Add(this.tbResolucionNumero);
            this.tabResolucion.Controls.Add(this.label7);
            this.tabResolucion.Controls.Add(this.cbResolucionEsDerrogada);
            this.tabResolucion.Controls.Add(this.cbResolucionDerrogada);
            this.tabResolucion.Controls.Add(this.label15);
            this.tabResolucion.Location = new System.Drawing.Point(4, 22);
            this.tabResolucion.Name = "tabResolucion";
            this.tabResolucion.Size = new System.Drawing.Size(374, 211);
            this.tabResolucion.TabIndex = 2;
            this.tabResolucion.Text = "Resolución";
            this.tabResolucion.UseVisualStyleBackColor = true;
            // 
            // tbResolucionNumero
            // 
            this.tbResolucionNumero.Location = new System.Drawing.Point(92, 40);
            this.tbResolucionNumero.Name = "tbResolucionNumero";
            this.tbResolucionNumero.Size = new System.Drawing.Size(272, 20);
            this.tbResolucionNumero.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Número";
            // 
            // cbResolucionEsDerrogada
            // 
            this.cbResolucionEsDerrogada.AutoSize = true;
            this.cbResolucionEsDerrogada.Location = new System.Drawing.Point(349, 16);
            this.cbResolucionEsDerrogada.Name = "cbResolucionEsDerrogada";
            this.cbResolucionEsDerrogada.Size = new System.Drawing.Size(15, 14);
            this.cbResolucionEsDerrogada.TabIndex = 34;
            this.cbResolucionEsDerrogada.UseVisualStyleBackColor = true;
            // 
            // cbResolucionDerrogada
            // 
            this.cbResolucionDerrogada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResolucionDerrogada.Enabled = false;
            this.cbResolucionDerrogada.FormattingEnabled = true;
            this.cbResolucionDerrogada.Location = new System.Drawing.Point(134, 13);
            this.cbResolucionDerrogada.Name = "cbResolucionDerrogada";
            this.cbResolucionDerrogada.Size = new System.Drawing.Size(209, 21);
            this.cbResolucionDerrogada.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Derrogada por";
            // 
            // tabPageDG
            // 
            this.tabPageDG.Controls.Add(this.tbDGNumero);
            this.tabPageDG.Controls.Add(this.label5);
            this.tabPageDG.Location = new System.Drawing.Point(4, 22);
            this.tabPageDG.Name = "tabPageDG";
            this.tabPageDG.Size = new System.Drawing.Size(374, 211);
            this.tabPageDG.TabIndex = 3;
            this.tabPageDG.Text = "DG";
            this.tabPageDG.UseVisualStyleBackColor = true;
            // 
            // tbDGNumero
            // 
            this.tbDGNumero.Location = new System.Drawing.Point(81, 15);
            this.tbDGNumero.Name = "tbDGNumero";
            this.tbDGNumero.Size = new System.Drawing.Size(283, 20);
            this.tbDGNumero.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número";
            // 
            // cbResponsable
            // 
            this.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(134, 42);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(268, 21);
            this.cbResponsable.TabIndex = 24;
            // 
            // lbResonsableDocumento
            // 
            this.lbResonsableDocumento.AutoSize = true;
            this.lbResonsableDocumento.Location = new System.Drawing.Point(17, 45);
            this.lbResonsableDocumento.Name = "lbResonsableDocumento";
            this.lbResonsableDocumento.Size = new System.Drawing.Size(69, 13);
            this.lbResonsableDocumento.TabIndex = 23;
            this.lbResonsableDocumento.Text = "Responsable";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(67, 16);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(335, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombre";
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBuscarImagen.IconColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarImagen.IconSize = 24;
            this.btnBuscarImagen.Location = new System.Drawing.Point(332, 14);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarImagen.TabIndex = 4;
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(85, 19);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.ReadOnly = true;
            this.tbImagen.Size = new System.Drawing.Size(241, 20);
            this.tbImagen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Imagen";
            // 
            // openLogo
            // 
            this.openLogo.FileName = "openFileDialog1";
            this.openLogo.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.svg";
            this.openLogo.Title = "Logo";
            // 
            // openPdf
            // 
            this.openPdf.FileName = "openFileDialog1";
            this.openPdf.Filter = "Pdf Files|*.pdf";
            this.openPdf.Title = "Logo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPdf);
            this.groupBox1.Controls.Add(this.tbPdf);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnBuscarImagen);
            this.groupBox1.Controls.Add(this.tbImagen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 90);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PDF";
            // 
            // btnBuscarPdf
            // 
            this.btnBuscarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPdf.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnBuscarPdf.IconColor = System.Drawing.Color.Black;
            this.btnBuscarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPdf.IconSize = 24;
            this.btnBuscarPdf.Location = new System.Drawing.Point(332, 53);
            this.btnBuscarPdf.Name = "btnBuscarPdf";
            this.btnBuscarPdf.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarPdf.TabIndex = 7;
            this.btnBuscarPdf.UseVisualStyleBackColor = true;
            // 
            // tbPdf
            // 
            this.tbPdf.Location = new System.Drawing.Point(85, 59);
            this.tbPdf.Name = "tbPdf";
            this.tbPdf.ReadOnly = true;
            this.tbPdf.Size = new System.Drawing.Size(241, 20);
            this.tbPdf.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Pdf";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(67, 73);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(335, 20);
            this.dtFecha.TabIndex = 17;
            // 
            // lbFechaDocumento
            // 
            this.lbFechaDocumento.AutoSize = true;
            this.lbFechaDocumento.Location = new System.Drawing.Point(17, 73);
            this.lbFechaDocumento.Name = "lbFechaDocumento";
            this.lbFechaDocumento.Size = new System.Drawing.Size(37, 13);
            this.lbFechaDocumento.TabIndex = 8;
            this.lbFechaDocumento.Text = "Fecha";
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
            this.tbDescripcion.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\" +
    "*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang2057 richTextBox" +
    "Ex1\\par\r\n}\r\n";
            this.tbDescripcion.SetColorWithFont = true;
            this.tbDescripcion.ShowToolStrip = true;
            this.tbDescripcion.Size = new System.Drawing.Size(369, 94);
            this.tbDescripcion.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(20, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 119);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // btnResolucionDerrogadaPor
            // 
            this.btnResolucionDerrogadaPor.Enabled = false;
            this.btnResolucionDerrogadaPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolucionDerrogadaPor.ForeColor = System.Drawing.Color.White;
            this.btnResolucionDerrogadaPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnResolucionDerrogadaPor.IconColor = System.Drawing.Color.Black;
            this.btnResolucionDerrogadaPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResolucionDerrogadaPor.IconSize = 24;
            this.btnResolucionDerrogadaPor.Location = new System.Drawing.Point(92, 7);
            this.btnResolucionDerrogadaPor.Name = "btnResolucionDerrogadaPor";
            this.btnResolucionDerrogadaPor.Size = new System.Drawing.Size(36, 30);
            this.btnResolucionDerrogadaPor.TabIndex = 37;
            this.btnResolucionDerrogadaPor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 24;
            this.btnBuscarCliente.Location = new System.Drawing.Point(85, 140);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarCliente.TabIndex = 38;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarContratoPadre
            // 
            this.btnBuscarContratoPadre.Enabled = false;
            this.btnBuscarContratoPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContratoPadre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContratoPadre.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarContratoPadre.IconColor = System.Drawing.Color.Black;
            this.btnBuscarContratoPadre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarContratoPadre.IconSize = 24;
            this.btnBuscarContratoPadre.Location = new System.Drawing.Point(85, 169);
            this.btnBuscarContratoPadre.Name = "btnBuscarContratoPadre";
            this.btnBuscarContratoPadre.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarContratoPadre.TabIndex = 39;
            this.btnBuscarContratoPadre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarResponsable
            // 
            this.btnBuscarResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarResponsable.ForeColor = System.Drawing.Color.White;
            this.btnBuscarResponsable.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarResponsable.IconColor = System.Drawing.Color.Black;
            this.btnBuscarResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarResponsable.IconSize = 24;
            this.btnBuscarResponsable.Location = new System.Drawing.Point(92, 36);
            this.btnBuscarResponsable.Name = "btnBuscarResponsable";
            this.btnBuscarResponsable.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarResponsable.TabIndex = 39;
            this.btnBuscarResponsable.UseVisualStyleBackColor = true;
            // 
            // PapelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 595);
            this.Controls.Add(this.btnBuscarResponsable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.lbResonsableDocumento);
            this.Controls.Add(this.lbFechaDocumento);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControTiposPapeles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PapelUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Documento";
            this.tabControTiposPapeles.ResumeLayout(false);
            this.tabSistema.ResumeLayout(false);
            this.tabSistema.PerformLayout();
            this.tabContrato.ResumeLayout(false);
            this.tabContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAcuerdoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbActaContrato)).EndInit();
            this.tabResolucion.ResumeLayout(false);
            this.tabResolucion.PerformLayout();
            this.tabPageDG.ResumeLayout(false);
            this.tabPageDG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TabControl tabControTiposPapeles;
        public System.Windows.Forms.TabPage tabSistema;
        public System.Windows.Forms.ComboBox cbTipoSistema;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TabPage tabContrato;
        public FontAwesome.Sharp.IconButton btnBuscarImagen;
        public System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbNumeroContrato;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.OpenFileDialog openLogo;
        public System.Windows.Forms.OpenFileDialog openPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        public FontAwesome.Sharp.IconButton btnBuscarPdf;
        public System.Windows.Forms.TextBox tbPdf;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cbResponsable;
        public System.Windows.Forms.ComboBox cbResolucionDerrogada;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cbContratoPadre;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cbClienteContrato;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTipoContrato;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tabResolucion;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.NumericUpDown tbAcuerdoContrato;
        public System.Windows.Forms.DateTimePicker dtFechaVencimientoContrato;
        public System.Windows.Forms.NumericUpDown tbActaContrato;
        private System.Windows.Forms.Label lbFechaDocumento;
        public System.Windows.Forms.Label lbResonsableDocumento;
        public System.Windows.Forms.CheckBox cbResolucionEsDerrogada;
        public System.Windows.Forms.CheckBox cbTieneContratoPadre;
        public System.Windows.Forms.TabPage tabPageDG;
        public System.Windows.Forms.TextBox tbDGNumero;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbResolucionNumero;
        private System.Windows.Forms.Label label7;
        public RichTextBoxEx.RichTextBoxEx tbDescripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        public FontAwesome.Sharp.IconButton btnBuscarContratoPadre;
        public FontAwesome.Sharp.IconButton btnBuscarCliente;
        public FontAwesome.Sharp.IconButton btnResolucionDerrogadaPor;
        public FontAwesome.Sharp.IconButton btnBuscarResponsable;
    }
}