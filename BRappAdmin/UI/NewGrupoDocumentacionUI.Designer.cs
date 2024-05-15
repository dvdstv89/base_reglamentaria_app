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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPJName = new System.Windows.Forms.TextBox();
            this.cbOpcional = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipoGrupo = new System.Windows.Forms.TextBox();
            this.btnResolucionDerrogadaPor = new FontAwesome.Sharp.IconButton();
            this.cbResolucionDerrogada = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(485, 93);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbPJName
            // 
            this.tbPJName.Location = new System.Drawing.Point(92, 37);
            this.tbPJName.Name = "tbPJName";
            this.tbPJName.Size = new System.Drawing.Size(381, 20);
            this.tbPJName.TabIndex = 1;
            // 
            // cbOpcional
            // 
            this.cbOpcional.AutoSize = true;
            this.cbOpcional.Location = new System.Drawing.Point(479, 39);
            this.cbOpcional.Name = "cbOpcional";
            this.cbOpcional.Size = new System.Drawing.Size(81, 17);
            this.cbOpcional.TabIndex = 17;
            this.cbOpcional.Text = "Es opcional";
            this.cbOpcional.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo de Grupo";
            // 
            // tbTipoGrupo
            // 
            this.tbTipoGrupo.Location = new System.Drawing.Point(92, 12);
            this.tbTipoGrupo.Name = "tbTipoGrupo";
            this.tbTipoGrupo.ReadOnly = true;
            this.tbTipoGrupo.Size = new System.Drawing.Size(468, 20);
            this.tbTipoGrupo.TabIndex = 19;
            // 
            // btnResolucionDerrogadaPor
            // 
            this.btnResolucionDerrogadaPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolucionDerrogadaPor.ForeColor = System.Drawing.Color.White;
            this.btnResolucionDerrogadaPor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnResolucionDerrogadaPor.IconColor = System.Drawing.Color.Black;
            this.btnResolucionDerrogadaPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResolucionDerrogadaPor.IconSize = 24;
            this.btnResolucionDerrogadaPor.Location = new System.Drawing.Point(92, 63);
            this.btnResolucionDerrogadaPor.Name = "btnResolucionDerrogadaPor";
            this.btnResolucionDerrogadaPor.Size = new System.Drawing.Size(36, 30);
            this.btnResolucionDerrogadaPor.TabIndex = 40;
            this.btnResolucionDerrogadaPor.UseVisualStyleBackColor = true;
            // 
            // cbResolucionDerrogada
            // 
            this.cbResolucionDerrogada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResolucionDerrogada.FormattingEnabled = true;
            this.cbResolucionDerrogada.Location = new System.Drawing.Point(137, 66);
            this.cbResolucionDerrogada.Name = "cbResolucionDerrogada";
            this.cbResolucionDerrogada.Size = new System.Drawing.Size(426, 21);
            this.cbResolucionDerrogada.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Documento";
            // 
            // NewGrupoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 139);
            this.Controls.Add(this.btnResolucionDerrogadaPor);
            this.Controls.Add(this.cbResolucionDerrogada);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTipoGrupo);
            this.Controls.Add(this.cbOpcional);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPJName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGrupoDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo de Documentación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbPJName;
        public System.Windows.Forms.CheckBox cbOpcional;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbTipoGrupo;
        public FontAwesome.Sharp.IconButton btnResolucionDerrogadaPor;
        public System.Windows.Forms.ComboBox cbResolucionDerrogada;
        private System.Windows.Forms.Label label15;
    }
}