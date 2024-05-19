﻿namespace BRappAdmin.UI
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lwTipos);
            this.groupBox1.Location = new System.Drawing.Point(15, 306);
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
            this.columnName});
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
            this.tbComplejo.Size = new System.Drawing.Size(468, 20);
            this.tbComplejo.TabIndex = 57;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(485, 532);
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
            this.groupBox2.Location = new System.Drawing.Point(447, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 97);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Certificados";
            // 
            // cbSANITARIA
            // 
            this.cbSANITARIA.AutoSize = true;
            this.cbSANITARIA.Location = new System.Drawing.Point(16, 63);
            this.cbSANITARIA.Name = "cbSANITARIA";
            this.cbSANITARIA.Size = new System.Drawing.Size(83, 17);
            this.cbSANITARIA.TabIndex = 2;
            this.cbSANITARIA.Text = "SANITARIA";
            this.cbSANITARIA.UseVisualStyleBackColor = true;
            // 
            // cbTMHS
            // 
            this.cbTMHS.AutoSize = true;
            this.cbTMHS.Location = new System.Drawing.Point(16, 40);
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
            this.cbActiva.Location = new System.Drawing.Point(18, 539);
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
            1,
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
            this.label6.Location = new System.Drawing.Point(14, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Registro comercial";
            // 
            // tbRegistroComercial
            // 
            this.tbRegistroComercial.Location = new System.Drawing.Point(114, 174);
            this.tbRegistroComercial.Name = "tbRegistroComercial";
            this.tbRegistroComercial.Size = new System.Drawing.Size(451, 20);
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
            this.btnBuscarPdf.Location = new System.Drawing.Point(395, 234);
            this.btnBuscarPdf.Name = "btnBuscarPdf";
            this.btnBuscarPdf.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarPdf.TabIndex = 7;
            this.btnBuscarPdf.UseVisualStyleBackColor = true;
            // 
            // tbPdf
            // 
            this.tbPdf.Location = new System.Drawing.Point(124, 240);
            this.tbPdf.Name = "tbPdf";
            this.tbPdf.ReadOnly = true;
            this.tbPdf.Size = new System.Drawing.Size(265, 20);
            this.tbPdf.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 243);
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
            this.btnBuscarImagen.Location = new System.Drawing.Point(395, 198);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarImagen.TabIndex = 4;
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(124, 204);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.ReadOnly = true;
            this.tbImagen.Size = new System.Drawing.Size(265, 20);
            this.tbImagen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 207);
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
            // NewTiendasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 572);
            this.Controls.Add(this.btnBuscarPdf);
            this.Controls.Add(this.tbPdf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbRegistroComercial);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCajas)).EndInit();
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
    }
}