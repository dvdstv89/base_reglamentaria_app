namespace BRappAdmin.UI
{
    partial class NewCLasificacionDocumentacionUI
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
            this.ComboTipoDocumentacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboMenuDocumental = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(271, 66);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // ComboTipoDocumentacion
            // 
            this.ComboTipoDocumentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDocumentacion.FormattingEnabled = true;
            this.ComboTipoDocumentacion.Location = new System.Drawing.Point(125, 12);
            this.ComboTipoDocumentacion.Name = "ComboTipoDocumentacion";
            this.ComboTipoDocumentacion.Size = new System.Drawing.Size(221, 21);
            this.ComboTipoDocumentacion.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tipo Documentación";
            // 
            // ComboMenuDocumental
            // 
            this.ComboMenuDocumental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMenuDocumental.FormattingEnabled = true;
            this.ComboMenuDocumental.Location = new System.Drawing.Point(125, 39);
            this.ComboMenuDocumental.Name = "ComboMenuDocumental";
            this.ComboMenuDocumental.Size = new System.Drawing.Size(221, 21);
            this.ComboMenuDocumental.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Menu Documental";
            // 
            // NewCLasificacionDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 105);
            this.Controls.Add(this.ComboMenuDocumental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboTipoDocumentacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewCLasificacionDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clasificación de la Documentación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox ComboTipoDocumentacion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ComboMenuDocumental;
        private System.Windows.Forms.Label label1;
    }
}