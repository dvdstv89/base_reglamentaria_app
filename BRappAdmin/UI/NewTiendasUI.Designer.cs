namespace BRappAdmin.UI
{
    partial class NewTiendasUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lwTipos = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComplejo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSANITARIA = new System.Windows.Forms.CheckBox();
            this.cbTMHS = new System.Windows.Forms.CheckBox();
            this.cbSCG = new System.Windows.Forms.CheckBox();
            this.cbActiva = new System.Windows.Forms.CheckBox();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTrabajadores = new System.Windows.Forms.NumericUpDown();
            this.tbCajas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegistroComercial = new System.Windows.Forms.TextBox();
            this.btnBuscarPdf = new FontAwesome.Sharp.IconButton();
            this.tbPdf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarImagen = new FontAwesome.Sharp.IconButton();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.comboDepartamentos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtFechaVencimientoContrato = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboTipoDocumentacion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCajas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lwTipos);
            this.groupBox1.Location = new System.Drawing.Point(11, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 220);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupos de Documentación";
            // 
            // lwTipos
            // 
            this.lwTipos.CheckBoxes = true;
            this.lwTipos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescripcion});
            this.lwTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwTipos.FullRowSelect = true;
            this.lwTipos.GridLines = true;
            this.lwTipos.HideSelection = false;
            this.lwTipos.Location = new System.Drawing.Point(3, 16);
            this.lwTipos.Name = "lwTipos";
            this.lwTipos.Size = new System.Drawing.Size(542, 201);
            this.lwTipos.TabIndex = 10;
            this.lwTipos.UseCompatibleStateImageBehavior = false;
            this.lwTipos.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 112;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 75;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(403, 147);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(160, 21);
            this.comboTipo.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tipo de tienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Complejo";
            // 
            // tbComplejo
            // 
            this.tbComplejo.Location = new System.Drawing.Point(96, 5);
            this.tbComplejo.Name = "tbComplejo";
            this.tbComplejo.ReadOnly = true;
            this.tbComplejo.Size = new System.Drawing.Size(190, 20);
            this.tbComplejo.TabIndex = 57;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(481, 601);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(468, 20);
            this.tbName.TabIndex = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSANITARIA);
            this.groupBox2.Controls.Add(this.cbTMHS);
            this.groupBox2.Controls.Add(this.cbSCG);
            this.groupBox2.Location = new System.Drawing.Point(11, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 38);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Certificos";
            // 
            // cbSANITARIA
            // 
            this.cbSANITARIA.AutoSize = true;
            this.cbSANITARIA.Location = new System.Drawing.Point(175, 19);
            this.cbSANITARIA.Name = "cbSANITARIA";
            this.cbSANITARIA.Size = new System.Drawing.Size(83, 17);
            this.cbSANITARIA.TabIndex = 2;
            this.cbSANITARIA.Text = "SANITARIA";
            this.cbSANITARIA.UseVisualStyleBackColor = true;
            // 
            // cbTMHS
            // 
            this.cbTMHS.AutoSize = true;
            this.cbTMHS.Location = new System.Drawing.Point(91, 19);
            this.cbTMHS.Name = "cbTMHS";
            this.cbTMHS.Size = new System.Drawing.Size(57, 17);
            this.cbTMHS.TabIndex = 1;
            this.cbTMHS.Text = "TMHS";
            this.cbTMHS.UseVisualStyleBackColor = true;
            // 
            // cbSCG
            // 
            this.cbSCG.AutoSize = true;
            this.cbSCG.Location = new System.Drawing.Point(16, 19);
            this.cbSCG.Name = "cbSCG";
            this.cbSCG.Size = new System.Drawing.Size(48, 17);
            this.cbSCG.TabIndex = 0;
            this.cbSCG.Text = "SCG";
            this.cbSCG.UseVisualStyleBackColor = true;
            // 
            // cbActiva
            // 
            this.cbActiva.AutoSize = true;
            this.cbActiva.Location = new System.Drawing.Point(14, 608);
            this.cbActiva.Name = "cbActiva";
            this.cbActiva.Size = new System.Drawing.Size(56, 17);
            this.cbActiva.TabIndex = 3;
            this.cbActiva.Text = "Activa";
            this.cbActiva.UseVisualStyleBackColor = true;
            // 
            // comboMoneda
            // 
            this.comboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoneda.FormattingEnabled = true;
            this.comboMoneda.Location = new System.Drawing.Point(96, 147);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(204, 21);
            this.comboMoneda.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tipo de moneda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Ubicación";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(96, 57);
            this.tbUbicacion.Multiline = true;
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(469, 58);
            this.tbUbicacion.TabIndex = 64;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(95, 121);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(110, 20);
            this.tbTelefono.TabIndex = 67;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Trabajadores";
            // 
            // tbTrabajadores
            // 
            this.tbTrabajadores.Location = new System.Drawing.Point(306, 121);
            this.tbTrabajadores.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbTrabajadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbTrabajadores.Name = "tbTrabajadores";
            this.tbTrabajadores.Size = new System.Drawing.Size(52, 20);
            this.tbTrabajadores.TabIndex = 69;
            this.tbTrabajadores.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tbCajas
            // 
            this.tbCajas.Location = new System.Drawing.Point(511, 121);
            this.tbCajas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbCajas.Name = "tbCajas";
            this.tbCajas.Size = new System.Drawing.Size(52, 20);
            this.tbCajas.TabIndex = 71;
            this.tbCajas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCajas.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Cajas registradoras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Registro comercial";
            // 
            // tbRegistroComercial
            // 
            this.tbRegistroComercial.Location = new System.Drawing.Point(116, 20);
            this.tbRegistroComercial.Name = "tbRegistroComercial";
            this.tbRegistroComercial.Size = new System.Drawing.Size(129, 20);
            this.tbRegistroComercial.TabIndex = 73;
            // 
            // btnBuscarPdf
            // 
            this.btnBuscarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPdf.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnBuscarPdf.IconColor = System.Drawing.Color.Black;
            this.btnBuscarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPdf.IconSize = 24;
            this.btnBuscarPdf.Location = new System.Drawing.Point(493, 48);
            this.btnBuscarPdf.Name = "btnBuscarPdf";
            this.btnBuscarPdf.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarPdf.TabIndex = 7;
            this.btnBuscarPdf.UseVisualStyleBackColor = true;
            // 
            // tbPdf
            // 
            this.tbPdf.Location = new System.Drawing.Point(116, 54);
            this.tbPdf.Name = "tbPdf";
            this.tbPdf.ReadOnly = true;
            this.tbPdf.Size = new System.Drawing.Size(371, 20);
            this.tbPdf.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Certificado Comercial";
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBuscarImagen.IconColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarImagen.IconSize = 24;
            this.btnBuscarImagen.Location = new System.Drawing.Point(524, 174);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarImagen.TabIndex = 4;
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(95, 180);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.ReadOnly = true;
            this.tbImagen.Size = new System.Drawing.Size(422, 20);
            this.tbImagen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logo";
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
            // comboDepartamentos
            // 
            this.comboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartamentos.FormattingEnabled = true;
            this.comboDepartamentos.Location = new System.Drawing.Point(379, 5);
            this.comboDepartamentos.Name = "comboDepartamentos";
            this.comboDepartamentos.Size = new System.Drawing.Size(186, 21);
            this.comboDepartamentos.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Departamento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Vence";
            // 
            // dtFechaVencimientoContrato
            // 
            this.dtFechaVencimientoContrato.Location = new System.Drawing.Point(295, 19);
            this.dtFechaVencimientoContrato.Name = "dtFechaVencimientoContrato";
            this.dtFechaVencimientoContrato.Size = new System.Drawing.Size(234, 20);
            this.dtFechaVencimientoContrato.TabIndex = 77;
            this.dtFechaVencimientoContrato.ValueChanged += new System.EventHandler(this.dtFechaVencimientoContrato_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboTipoDocumentacion);
            this.groupBox3.Controls.Add(this.tbRegistroComercial);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnBuscarPdf);
            this.groupBox3.Controls.Add(this.dtFechaVencimientoContrato);
            this.groupBox3.Controls.Add(this.tbPdf);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(11, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 115);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificado Comercial";
            // 
            // ComboTipoDocumentacion
            // 
            this.ComboTipoDocumentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDocumentacion.FormattingEnabled = true;
            this.ComboTipoDocumentacion.Location = new System.Drawing.Point(116, 80);
            this.ComboTipoDocumentacion.Name = "ComboTipoDocumentacion";
            this.ComboTipoDocumentacion.Size = new System.Drawing.Size(413, 21);
            this.ComboTipoDocumentacion.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Tipo Documentación";
            // 
            // NewTiendasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboDepartamentos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.tbImagen);
            this.Controls.Add(this.tbCajas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTrabajadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.comboMoneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbActiva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbComplejo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTiendasUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiendas";
            this.Load += new System.EventHandler(this.NewTiendasUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCajas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lwTipos;
        public System.Windows.Forms.ColumnHeader columnName;
        public System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbComplejo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox cbSANITARIA;
        public System.Windows.Forms.CheckBox cbTMHS;
        public System.Windows.Forms.CheckBox cbSCG;
        public System.Windows.Forms.CheckBox cbActiva;
        public System.Windows.Forms.ComboBox comboMoneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbUbicacion;
        public System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown tbTrabajadores;
        public System.Windows.Forms.NumericUpDown tbCajas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbRegistroComercial;
        public FontAwesome.Sharp.IconButton btnBuscarPdf;
        public System.Windows.Forms.TextBox tbPdf;
        private System.Windows.Forms.Label label13;
        public FontAwesome.Sharp.IconButton btnBuscarImagen;
        public System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.OpenFileDialog openLogo;
        public System.Windows.Forms.OpenFileDialog openPdf;
        public System.Windows.Forms.ComboBox comboDepartamentos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DateTimePicker dtFechaVencimientoContrato;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox ComboTipoDocumentacion;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ColumnHeader columnDescripcion;
    }
}