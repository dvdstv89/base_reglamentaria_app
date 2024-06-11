namespace BRappAdmin.UI
{
    partial class NewTipoDocumentacionUI
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
            this.comboBoxIcon = new System.Windows.Forms.ComboBox();
            this.comboBoxCard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHasPDF = new System.Windows.Forms.CheckBox();
            this.cbHasNumeracion = new System.Windows.Forms.CheckBox();
            this.cbHasFechaCreacion = new System.Windows.Forms.CheckBox();
            this.cbHasFechaVencimiento = new System.Windows.Forms.CheckBox();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHasPadre = new System.Windows.Forms.CheckBox();
            this.cbHasTipo = new System.Windows.Forms.CheckBox();
            this.cbHasObligatorio = new System.Windows.Forms.CheckBox();
            this.cbHasActaAcuerdo = new System.Windows.Forms.CheckBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(271, 311);
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
            this.tbName.Location = new System.Drawing.Point(75, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(270, 20);
            this.tbName.TabIndex = 1;
            // 
            // comboBoxIcon
            // 
            this.comboBoxIcon.FormattingEnabled = true;
            this.comboBoxIcon.Location = new System.Drawing.Point(88, 39);
            this.comboBoxIcon.Name = "comboBoxIcon";
            this.comboBoxIcon.Size = new System.Drawing.Size(236, 21);
            this.comboBoxIcon.TabIndex = 67;
            // 
            // comboBoxCard
            // 
            this.comboBoxCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCard.FormattingEnabled = true;
            this.comboBoxCard.Location = new System.Drawing.Point(75, 32);
            this.comboBoxCard.Name = "comboBoxCard";
            this.comboBoxCard.Size = new System.Drawing.Size(271, 21);
            this.comboBoxCard.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tipo Card";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.White;
            this.iconPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox.IconSize = 64;
            this.iconPictureBox.Location = new System.Drawing.Point(6, 19);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(64, 64);
            this.iconPictureBox.TabIndex = 70;
            this.iconPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIcon);
            this.groupBox1.Controls.Add(this.iconPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 100);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icono";
            // 
            // cbHasPDF
            // 
            this.cbHasPDF.AutoSize = true;
            this.cbHasPDF.Location = new System.Drawing.Point(16, 219);
            this.cbHasPDF.Name = "cbHasPDF";
            this.cbHasPDF.Size = new System.Drawing.Size(77, 17);
            this.cbHasPDF.TabIndex = 72;
            this.cbHasPDF.Text = "Tiene PDF";
            this.cbHasPDF.UseVisualStyleBackColor = true;
            // 
            // cbHasNumeracion
            // 
            this.cbHasNumeracion.AutoSize = true;
            this.cbHasNumeracion.Location = new System.Drawing.Point(203, 219);
            this.cbHasNumeracion.Name = "cbHasNumeracion";
            this.cbHasNumeracion.Size = new System.Drawing.Size(113, 17);
            this.cbHasNumeracion.TabIndex = 74;
            this.cbHasNumeracion.Text = "Tiene Numeración";
            this.cbHasNumeracion.UseVisualStyleBackColor = true;
            // 
            // cbHasFechaCreacion
            // 
            this.cbHasFechaCreacion.AutoSize = true;
            this.cbHasFechaCreacion.Location = new System.Drawing.Point(16, 242);
            this.cbHasFechaCreacion.Name = "cbHasFechaCreacion";
            this.cbHasFechaCreacion.Size = new System.Drawing.Size(146, 17);
            this.cbHasFechaCreacion.TabIndex = 75;
            this.cbHasFechaCreacion.Text = "Tiene Fecha de Creación";
            this.cbHasFechaCreacion.UseVisualStyleBackColor = true;
            // 
            // cbHasFechaVencimiento
            // 
            this.cbHasFechaVencimiento.AutoSize = true;
            this.cbHasFechaVencimiento.Location = new System.Drawing.Point(16, 265);
            this.cbHasFechaVencimiento.Name = "cbHasFechaVencimiento";
            this.cbHasFechaVencimiento.Size = new System.Drawing.Size(162, 17);
            this.cbHasFechaVencimiento.TabIndex = 76;
            this.cbHasFechaVencimiento.Text = "Tiene Fecha de Vencimiento";
            this.cbHasFechaVencimiento.UseVisualStyleBackColor = true;
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(75, 59);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(271, 21);
            this.comboBoxResponsable.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Reponsable";
            // 
            // cbHasPadre
            // 
            this.cbHasPadre.AutoSize = true;
            this.cbHasPadre.Location = new System.Drawing.Point(16, 288);
            this.cbHasPadre.Name = "cbHasPadre";
            this.cbHasPadre.Size = new System.Drawing.Size(175, 17);
            this.cbHasPadre.TabIndex = 82;
            this.cbHasPadre.Text = "Tiene Documento Dependiente";
            this.cbHasPadre.UseVisualStyleBackColor = true;
            // 
            // cbHasTipo
            // 
            this.cbHasTipo.AutoSize = true;
            this.cbHasTipo.Location = new System.Drawing.Point(203, 265);
            this.cbHasTipo.Name = "cbHasTipo";
            this.cbHasTipo.Size = new System.Drawing.Size(77, 17);
            this.cbHasTipo.TabIndex = 81;
            this.cbHasTipo.Text = "Tiene Tipo";
            this.cbHasTipo.UseVisualStyleBackColor = true;
            // 
            // cbHasObligatorio
            // 
            this.cbHasObligatorio.AutoSize = true;
            this.cbHasObligatorio.Location = new System.Drawing.Point(203, 242);
            this.cbHasObligatorio.Name = "cbHasObligatorio";
            this.cbHasObligatorio.Size = new System.Drawing.Size(123, 17);
            this.cbHasObligatorio.TabIndex = 80;
            this.cbHasObligatorio.Text = "Permitir opcionalidad";
            this.cbHasObligatorio.UseVisualStyleBackColor = true;
            // 
            // cbHasActaAcuerdo
            // 
            this.cbHasActaAcuerdo.AutoSize = true;
            this.cbHasActaAcuerdo.Location = new System.Drawing.Point(203, 288);
            this.cbHasActaAcuerdo.Name = "cbHasActaAcuerdo";
            this.cbHasActaAcuerdo.Size = new System.Drawing.Size(129, 17);
            this.cbHasActaAcuerdo.TabIndex = 83;
            this.cbHasActaAcuerdo.Text = "Tiene Acta y Acuerdo";
            this.cbHasActaAcuerdo.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(74, 86);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(271, 21);
            this.comboBoxCliente.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cliente";
            // 
            // NewTipoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 350);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHasActaAcuerdo);
            this.Controls.Add(this.cbHasPadre);
            this.Controls.Add(this.cbHasTipo);
            this.Controls.Add(this.cbHasObligatorio);
            this.Controls.Add(this.comboBoxResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHasFechaVencimiento);
            this.Controls.Add(this.cbHasFechaCreacion);
            this.Controls.Add(this.cbHasNumeracion);
            this.Controls.Add(this.cbHasPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTipoDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Documentación";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.ComboBox comboBoxIcon;
        public System.Windows.Forms.ComboBox comboBoxCard;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox cbHasPDF;
        public System.Windows.Forms.CheckBox cbHasNumeracion;
        public System.Windows.Forms.CheckBox cbHasFechaCreacion;
        public System.Windows.Forms.CheckBox cbHasFechaVencimiento;
        public System.Windows.Forms.ComboBox comboBoxResponsable;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox cbHasPadre;
        public System.Windows.Forms.CheckBox cbHasTipo;
        public System.Windows.Forms.CheckBox cbHasObligatorio;
        public System.Windows.Forms.CheckBox cbHasActaAcuerdo;
        public System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
    }
}