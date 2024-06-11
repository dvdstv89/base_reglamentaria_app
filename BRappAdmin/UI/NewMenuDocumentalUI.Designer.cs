namespace BRappAdmin.UI
{
    partial class NewMenuDocumentalUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.ComboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDescripcion = new RichTextBoxEx.RichTextBoxEx();
            this.cbShowPanelBusqueda = new System.Windows.Forms.CheckBox();
            this.cbShowArchivados = new System.Windows.Forms.CheckBox();
            this.cbIsRaiz = new System.Windows.Forms.CheckBox();
            this.cbAbrirPagina = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(322, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(73, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(324, 20);
            this.tbName.TabIndex = 1;
            // 
            // openLogo
            // 
            this.openLogo.FileName = "openFileDialog1";
            this.openLogo.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.svg";
            this.openLogo.Title = "Logo";
            // 
            // ComboBoxUbicacion
            // 
            this.ComboBoxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUbicacion.FormattingEnabled = true;
            this.ComboBoxUbicacion.Location = new System.Drawing.Point(73, 32);
            this.ComboBoxUbicacion.Name = "ComboBoxUbicacion";
            this.ComboBoxUbicacion.Size = new System.Drawing.Size(324, 21);
            this.ComboBoxUbicacion.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ubicación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(15, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 119);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
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
            // cbShowPanelBusqueda
            // 
            this.cbShowPanelBusqueda.AutoSize = true;
            this.cbShowPanelBusqueda.Location = new System.Drawing.Point(15, 188);
            this.cbShowPanelBusqueda.Name = "cbShowPanelBusqueda";
            this.cbShowPanelBusqueda.Size = new System.Drawing.Size(157, 17);
            this.cbShowPanelBusqueda.TabIndex = 69;
            this.cbShowPanelBusqueda.Text = "Mostrar Panel de Busqueda";
            this.cbShowPanelBusqueda.UseVisualStyleBackColor = true;
            // 
            // cbShowArchivados
            // 
            this.cbShowArchivados.AutoSize = true;
            this.cbShowArchivados.Location = new System.Drawing.Point(15, 211);
            this.cbShowArchivados.Name = "cbShowArchivados";
            this.cbShowArchivados.Size = new System.Drawing.Size(117, 17);
            this.cbShowArchivados.TabIndex = 70;
            this.cbShowArchivados.Text = "Mostrar Archivados";
            this.cbShowArchivados.UseVisualStyleBackColor = true;
            // 
            // cbIsRaiz
            // 
            this.cbIsRaiz.AutoSize = true;
            this.cbIsRaiz.Location = new System.Drawing.Point(205, 188);
            this.cbIsRaiz.Name = "cbIsRaiz";
            this.cbIsRaiz.Size = new System.Drawing.Size(62, 17);
            this.cbIsRaiz.TabIndex = 71;
            this.cbIsRaiz.Text = "Es Raiz";
            this.cbIsRaiz.UseVisualStyleBackColor = true;
            // 
            // cbAbrirPagina
            // 
            this.cbAbrirPagina.AutoSize = true;
            this.cbAbrirPagina.Location = new System.Drawing.Point(205, 211);
            this.cbAbrirPagina.Name = "cbAbrirPagina";
            this.cbAbrirPagina.Size = new System.Drawing.Size(82, 17);
            this.cbAbrirPagina.TabIndex = 72;
            this.cbAbrirPagina.Text = "Abrir página";
            this.cbAbrirPagina.UseVisualStyleBackColor = true;
            // 
            // NewMenuDocumentalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 254);
            this.Controls.Add(this.cbAbrirPagina);
            this.Controls.Add(this.cbIsRaiz);
            this.Controls.Add(this.cbShowArchivados);
            this.Controls.Add(this.cbShowPanelBusqueda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ComboBoxUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewMenuDocumentalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Documental";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.OpenFileDialog openLogo;
        public System.Windows.Forms.ComboBox ComboBoxUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public RichTextBoxEx.RichTextBoxEx tbDescripcion;
        public System.Windows.Forms.CheckBox cbShowPanelBusqueda;
        public System.Windows.Forms.CheckBox cbShowArchivados;
        public System.Windows.Forms.CheckBox cbIsRaiz;
        public System.Windows.Forms.CheckBox cbAbrirPagina;
    }
}