namespace BRappAdmin.UI
{
    partial class NewComplejoUI
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
            this.btnBuscarLogo = new FontAwesome.Sharp.IconButton();
            this.tbPJLogo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPJName = new System.Windows.Forms.TextBox();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(270, 71);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLogo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLogo.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBuscarLogo.IconColor = System.Drawing.Color.Black;
            this.btnBuscarLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLogo.IconSize = 24;
            this.btnBuscarLogo.Location = new System.Drawing.Point(309, 38);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Size = new System.Drawing.Size(36, 27);
            this.btnBuscarLogo.TabIndex = 4;
            this.btnBuscarLogo.UseVisualStyleBackColor = true;
            // 
            // tbPJLogo
            // 
            this.tbPJLogo.Location = new System.Drawing.Point(62, 38);
            this.tbPJLogo.Name = "tbPJLogo";
            this.tbPJLogo.ReadOnly = true;
            this.tbPJLogo.Size = new System.Drawing.Size(241, 20);
            this.tbPJLogo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logo";
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
            this.tbPJName.Size = new System.Drawing.Size(283, 20);
            this.tbPJName.TabIndex = 1;
            // 
            // openLogo
            // 
            this.openLogo.FileName = "openFileDialog1";
            this.openLogo.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.svg";
            this.openLogo.Title = "Logo";
            // 
            // NewComplejoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 109);
            this.Controls.Add(this.btnBuscarLogo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbPJLogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPJName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewComplejoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complejo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public FontAwesome.Sharp.IconButton btnBuscarLogo;
        public System.Windows.Forms.TextBox tbPJLogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbPJName;
        public System.Windows.Forms.OpenFileDialog openLogo;
    }
}