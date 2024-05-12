namespace BRappAdmin.UI
{
    partial class PersonaUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPJName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPJEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPJTelefono = new System.Windows.Forms.TextBox();
            this.tbPJDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInterno = new System.Windows.Forms.CheckBox();
            this.tabControlPersonas = new System.Windows.Forms.TabControl();
            this.tabPersonaNatural = new System.Windows.Forms.TabPage();
            this.cbPNTitulo = new System.Windows.Forms.ComboBox();
            this.tbPNMovil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPNDireccion = new System.Windows.Forms.TextBox();
            this.tbPNTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPNEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPNNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPNCargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPersonaJuridica = new System.Windows.Forms.TabPage();
            this.btnBuscarLogo = new FontAwesome.Sharp.IconButton();
            this.tbPJLogo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPJContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControlPersonas.SuspendLayout();
            this.tabPersonaNatural.SuspendLayout();
            this.tabPersonaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbPJName
            // 
            this.tbPJName.Location = new System.Drawing.Point(85, 15);
            this.tbPJName.Name = "tbPJName";
            this.tbPJName.Size = new System.Drawing.Size(283, 20);
            this.tbPJName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // tbPJEmail
            // 
            this.tbPJEmail.Location = new System.Drawing.Point(85, 41);
            this.tbPJEmail.Name = "tbPJEmail";
            this.tbPJEmail.Size = new System.Drawing.Size(283, 20);
            this.tbPJEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono";
            // 
            // tbPJTelefono
            // 
            this.tbPJTelefono.Location = new System.Drawing.Point(85, 71);
            this.tbPJTelefono.Name = "tbPJTelefono";
            this.tbPJTelefono.Size = new System.Drawing.Size(283, 20);
            this.tbPJTelefono.TabIndex = 5;
            // 
            // tbPJDireccion
            // 
            this.tbPJDireccion.Location = new System.Drawing.Point(85, 97);
            this.tbPJDireccion.Multiline = true;
            this.tbPJDireccion.Name = "tbPJDireccion";
            this.tbPJDireccion.Size = new System.Drawing.Size(283, 58);
            this.tbPJDireccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // cbInterno
            // 
            this.cbInterno.AutoSize = true;
            this.cbInterno.Location = new System.Drawing.Point(16, 275);
            this.cbInterno.Name = "cbInterno";
            this.cbInterno.Size = new System.Drawing.Size(59, 17);
            this.cbInterno.TabIndex = 8;
            this.cbInterno.Text = "Interno";
            this.cbInterno.UseVisualStyleBackColor = true;
            // 
            // tabControlPersonas
            // 
            this.tabControlPersonas.Controls.Add(this.tabPersonaNatural);
            this.tabControlPersonas.Controls.Add(this.tabPersonaJuridica);
            this.tabControlPersonas.Location = new System.Drawing.Point(12, 12);
            this.tabControlPersonas.Name = "tabControlPersonas";
            this.tabControlPersonas.SelectedIndex = 0;
            this.tabControlPersonas.Size = new System.Drawing.Size(390, 246);
            this.tabControlPersonas.TabIndex = 11;
            // 
            // tabPersonaNatural
            // 
            this.tabPersonaNatural.Controls.Add(this.cbPNTitulo);
            this.tabPersonaNatural.Controls.Add(this.tbPNMovil);
            this.tabPersonaNatural.Controls.Add(this.label12);
            this.tabPersonaNatural.Controls.Add(this.label8);
            this.tabPersonaNatural.Controls.Add(this.tbPNDireccion);
            this.tabPersonaNatural.Controls.Add(this.tbPNTelefono);
            this.tabPersonaNatural.Controls.Add(this.label9);
            this.tabPersonaNatural.Controls.Add(this.tbPNEmail);
            this.tabPersonaNatural.Controls.Add(this.label10);
            this.tabPersonaNatural.Controls.Add(this.tbPNNombre);
            this.tabPersonaNatural.Controls.Add(this.label11);
            this.tabPersonaNatural.Controls.Add(this.tbPNCargo);
            this.tabPersonaNatural.Controls.Add(this.label7);
            this.tabPersonaNatural.Location = new System.Drawing.Point(4, 22);
            this.tabPersonaNatural.Name = "tabPersonaNatural";
            this.tabPersonaNatural.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonaNatural.Size = new System.Drawing.Size(382, 220);
            this.tabPersonaNatural.TabIndex = 0;
            this.tabPersonaNatural.Text = "Persona Natural";
            this.tabPersonaNatural.UseVisualStyleBackColor = true;
            // 
            // cbPNTitulo
            // 
            this.cbPNTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPNTitulo.FormattingEnabled = true;
            this.cbPNTitulo.Location = new System.Drawing.Point(85, 13);
            this.cbPNTitulo.Name = "cbPNTitulo";
            this.cbPNTitulo.Size = new System.Drawing.Size(68, 21);
            this.cbPNTitulo.TabIndex = 20;
            // 
            // tbPNMovil
            // 
            this.tbPNMovil.Location = new System.Drawing.Point(258, 96);
            this.tbPNMovil.Name = "tbPNMovil";
            this.tbPNMovil.Size = new System.Drawing.Size(110, 20);
            this.tbPNMovil.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Movil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dirección";
            // 
            // tbPNDireccion
            // 
            this.tbPNDireccion.Location = new System.Drawing.Point(85, 122);
            this.tbPNDireccion.Multiline = true;
            this.tbPNDireccion.Name = "tbPNDireccion";
            this.tbPNDireccion.Size = new System.Drawing.Size(283, 58);
            this.tbPNDireccion.TabIndex = 15;
            // 
            // tbPNTelefono
            // 
            this.tbPNTelefono.Location = new System.Drawing.Point(85, 96);
            this.tbPNTelefono.Name = "tbPNTelefono";
            this.tbPNTelefono.Size = new System.Drawing.Size(110, 20);
            this.tbPNTelefono.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Teléfono";
            // 
            // tbPNEmail
            // 
            this.tbPNEmail.Location = new System.Drawing.Point(85, 41);
            this.tbPNEmail.Name = "tbPNEmail";
            this.tbPNEmail.Size = new System.Drawing.Size(283, 20);
            this.tbPNEmail.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Email";
            // 
            // tbPNNombre
            // 
            this.tbPNNombre.Location = new System.Drawing.Point(159, 15);
            this.tbPNNombre.Name = "tbPNNombre";
            this.tbPNNombre.Size = new System.Drawing.Size(209, 20);
            this.tbPNNombre.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombre";
            // 
            // tbPNCargo
            // 
            this.tbPNCargo.Location = new System.Drawing.Point(85, 67);
            this.tbPNCargo.Name = "tbPNCargo";
            this.tbPNCargo.Size = new System.Drawing.Size(283, 20);
            this.tbPNCargo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cargo";
            // 
            // tabPersonaJuridica
            // 
            this.tabPersonaJuridica.Controls.Add(this.btnBuscarLogo);
            this.tabPersonaJuridica.Controls.Add(this.tbPJLogo);
            this.tabPersonaJuridica.Controls.Add(this.label4);
            this.tabPersonaJuridica.Controls.Add(this.label6);
            this.tabPersonaJuridica.Controls.Add(this.tbPJDireccion);
            this.tabPersonaJuridica.Controls.Add(this.tbPJContacto);
            this.tabPersonaJuridica.Controls.Add(this.tbPJTelefono);
            this.tabPersonaJuridica.Controls.Add(this.label5);
            this.tabPersonaJuridica.Controls.Add(this.label3);
            this.tabPersonaJuridica.Controls.Add(this.label1);
            this.tabPersonaJuridica.Controls.Add(this.tbPJEmail);
            this.tabPersonaJuridica.Controls.Add(this.tbPJName);
            this.tabPersonaJuridica.Controls.Add(this.label2);
            this.tabPersonaJuridica.Location = new System.Drawing.Point(4, 22);
            this.tabPersonaJuridica.Name = "tabPersonaJuridica";
            this.tabPersonaJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonaJuridica.Size = new System.Drawing.Size(382, 220);
            this.tabPersonaJuridica.TabIndex = 1;
            this.tabPersonaJuridica.Text = "Persona Jurídica";
            this.tabPersonaJuridica.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLogo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLogo.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBuscarLogo.IconColor = System.Drawing.Color.Black;
            this.btnBuscarLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLogo.IconSize = 24;
            this.btnBuscarLogo.Location = new System.Drawing.Point(332, 184);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Size = new System.Drawing.Size(36, 27);
            this.btnBuscarLogo.TabIndex = 4;
            this.btnBuscarLogo.UseVisualStyleBackColor = true;
            // 
            // tbPJLogo
            // 
            this.tbPJLogo.Location = new System.Drawing.Point(85, 187);
            this.tbPJLogo.Name = "tbPJLogo";
            this.tbPJLogo.ReadOnly = true;
            this.tbPJLogo.Size = new System.Drawing.Size(241, 20);
            this.tbPJLogo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logo";
            // 
            // tbPJContacto
            // 
            this.tbPJContacto.Location = new System.Drawing.Point(85, 161);
            this.tbPJContacto.Name = "tbPJContacto";
            this.tbPJContacto.Size = new System.Drawing.Size(283, 20);
            this.tbPJContacto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contacto";
            // 
            // openLogo
            // 
            this.openLogo.FileName = "openFileDialog1";
            this.openLogo.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.svg";
            this.openLogo.Title = "Logo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(323, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // PersonaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 305);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbInterno);
            this.Controls.Add(this.tabControlPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persona";
            this.tabControlPersonas.ResumeLayout(false);
            this.tabPersonaNatural.ResumeLayout(false);
            this.tabPersonaNatural.PerformLayout();
            this.tabPersonaJuridica.ResumeLayout(false);
            this.tabPersonaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbPJName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbPJEmail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbPJTelefono;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbPJDireccion;
        public System.Windows.Forms.CheckBox cbInterno;
        public System.Windows.Forms.TabPage tabPersonaNatural;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbPNTitulo;
        public System.Windows.Forms.TextBox tbPNMovil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbPNDireccion;
        public System.Windows.Forms.TextBox tbPNTelefono;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbPNEmail;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbPNNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.OpenFileDialog openLogo;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TabControl tabControlPersonas;
        public FontAwesome.Sharp.IconButton btnBuscarLogo;
        public System.Windows.Forms.TextBox tbPJLogo;
        public System.Windows.Forms.TextBox tbPJContacto;
        public System.Windows.Forms.TabPage tabPersonaJuridica;
        public System.Windows.Forms.TextBox tbPNCargo;
    }
}