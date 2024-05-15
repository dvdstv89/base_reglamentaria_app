namespace BRappAdmin.UI
{
    partial class NewTipoGrupoDocumentacionUI
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
            this.tbPJName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescripcion = new RichTextBoxEx.RichTextBoxEx();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(488, 171);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
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
            // tbPJName
            // 
            this.tbPJName.Location = new System.Drawing.Point(62, 6);
            this.tbPJName.Name = "tbPJName";
            this.tbPJName.Size = new System.Drawing.Size(498, 20);
            this.tbPJName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 133);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
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
            this.tbDescripcion.Size = new System.Drawing.Size(536, 104);
            this.tbDescripcion.TabIndex = 15;
            // 
            // NewTipoGrupoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPJName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTipoGrupoDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Grupo de Documentación";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbPJName;
        private System.Windows.Forms.GroupBox groupBox1;
        public RichTextBoxEx.RichTextBoxEx tbDescripcion;
    }
}