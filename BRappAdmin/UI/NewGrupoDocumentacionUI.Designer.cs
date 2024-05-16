namespace BRappAdmin.UI
{
    partial class NewGrupoDocumentacionUI
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
            this.btnBuscarDocumento = new FontAwesome.Sharp.IconButton();
            this.cbResolucionDerrogada = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDocumento.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscarDocumento.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarDocumento.IconSize = 24;
            this.btnBuscarDocumento.Location = new System.Drawing.Point(482, 6);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarDocumento.TabIndex = 40;
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            // 
            // cbResolucionDerrogada
            // 
            this.cbResolucionDerrogada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResolucionDerrogada.FormattingEnabled = true;
            this.cbResolucionDerrogada.Location = new System.Drawing.Point(12, 12);
            this.cbResolucionDerrogada.Name = "cbResolucionDerrogada";
            this.cbResolucionDerrogada.Size = new System.Drawing.Size(450, 21);
            this.cbResolucionDerrogada.TabIndex = 39;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 24;
            this.btnNuevo.Location = new System.Drawing.Point(527, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 30);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.S;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 24;
            this.btnGuardar.Location = new System.Drawing.Point(579, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 30);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // NewGrupoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 42);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscarDocumento);
            this.Controls.Add(this.cbResolucionDerrogada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGrupoDocumentacionUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento";
            this.ResumeLayout(false);

        }

        #endregion
        public FontAwesome.Sharp.IconButton btnBuscarDocumento;
        public System.Windows.Forms.ComboBox cbResolucionDerrogada;
        public FontAwesome.Sharp.IconButton btnNuevo;
        public FontAwesome.Sharp.IconButton btnGuardar;
    }
}