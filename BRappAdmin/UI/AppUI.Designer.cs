namespace BRappAdmin.UI
{
    partial class AppUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbCopyRight = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarLogo = new FontAwesome.Sharp.IconButton();
            this.tbPJLogo = new System.Windows.Forms.TextBox();
            this.openLogo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbMision = new RichTextBoxEx.RichTextBoxEx();
            this.tbVision = new RichTextBoxEx.RichTextBoxEx();
            this.tbObjetoSocial = new RichTextBoxEx.RichTextBoxEx();
            this.tbValoresCompartidos = new RichTextBoxEx.RichTextBoxEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CopyRight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(81, 21);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(476, 20);
            this.tbEmpresa.TabIndex = 3;
            // 
            // tbCopyRight
            // 
            this.tbCopyRight.Location = new System.Drawing.Point(81, 50);
            this.tbCopyRight.Name = "tbCopyRight";
            this.tbCopyRight.Size = new System.Drawing.Size(476, 20);
            this.tbCopyRight.TabIndex = 4;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(81, 86);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(476, 20);
            this.tbFecha.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1051, 448);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLogo
            // 
            this.btnBuscarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLogo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLogo.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnBuscarLogo.IconColor = System.Drawing.Color.Black;
            this.btnBuscarLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLogo.IconSize = 24;
            this.btnBuscarLogo.Location = new System.Drawing.Point(506, 15);
            this.btnBuscarLogo.Name = "btnBuscarLogo";
            this.btnBuscarLogo.Size = new System.Drawing.Size(36, 27);
            this.btnBuscarLogo.TabIndex = 9;
            this.btnBuscarLogo.UseVisualStyleBackColor = true;
            // 
            // tbPJLogo
            // 
            this.tbPJLogo.Location = new System.Drawing.Point(6, 19);
            this.tbPJLogo.Name = "tbPJLogo";
            this.tbPJLogo.ReadOnly = true;
            this.tbPJLogo.Size = new System.Drawing.Size(502, 20);
            this.tbPJLogo.TabIndex = 8;
            // 
            // openLogo
            // 
            this.openLogo.FileName = "openFileDialog1";
            this.openLogo.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.svg";
            this.openLogo.Title = "Logo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMision);
            this.groupBox1.Location = new System.Drawing.Point(15, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 133);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misión";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVision);
            this.groupBox2.Location = new System.Drawing.Point(584, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visión";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbObjetoSocial);
            this.groupBox3.Location = new System.Drawing.Point(15, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 133);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Objeto Social";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbValoresCompartidos);
            this.groupBox4.Location = new System.Drawing.Point(578, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 133);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valores Compartidos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbPJLogo);
            this.groupBox5.Controls.Add(this.btnBuscarLogo);
            this.groupBox5.Location = new System.Drawing.Point(15, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 52);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Organigrama";
            // 
            // tbMision
            // 
            this.tbMision.AllowBullets = true;
            this.tbMision.AllowDefaultInsertText = true;
            this.tbMision.AllowDefaultSmartText = true;
            this.tbMision.AllowHyphenation = true;
            this.tbMision.AllowPictures = true;
            this.tbMision.AllowSpellCheck = true;
            this.tbMision.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbMision.FilePath = "";
            this.tbMision.Location = new System.Drawing.Point(6, 19);
            this.tbMision.Name = "tbMision";
            this.tbMision.Rtf = "{\\rtf1\\ansi\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\*\\generator " +
    "Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang2057 richTextBoxEx1\\par\r\n}\r\n" +
    "";
            this.tbMision.SetColorWithFont = true;
            this.tbMision.ShowToolStrip = true;
            this.tbMision.Size = new System.Drawing.Size(536, 104);
            this.tbMision.TabIndex = 15;
            // 
            // tbVision
            // 
            this.tbVision.AllowBullets = true;
            this.tbVision.AllowDefaultInsertText = true;
            this.tbVision.AllowDefaultSmartText = true;
            this.tbVision.AllowHyphenation = true;
            this.tbVision.AllowPictures = true;
            this.tbVision.AllowSpellCheck = true;
            this.tbVision.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbVision.FilePath = "";
            this.tbVision.Location = new System.Drawing.Point(9, 19);
            this.tbVision.Name = "tbVision";
            this.tbVision.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\" +
    "*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang2057 richTextBox" +
    "Ex1\\par\r\n}\r\n";
            this.tbVision.SetColorWithFont = true;
            this.tbVision.ShowToolStrip = true;
            this.tbVision.Size = new System.Drawing.Size(536, 104);
            this.tbVision.TabIndex = 16;
            // 
            // tbObjetoSocial
            // 
            this.tbObjetoSocial.AllowBullets = true;
            this.tbObjetoSocial.AllowDefaultInsertText = true;
            this.tbObjetoSocial.AllowDefaultSmartText = true;
            this.tbObjetoSocial.AllowHyphenation = true;
            this.tbObjetoSocial.AllowPictures = true;
            this.tbObjetoSocial.AllowSpellCheck = true;
            this.tbObjetoSocial.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbObjetoSocial.FilePath = "";
            this.tbObjetoSocial.Location = new System.Drawing.Point(6, 14);
            this.tbObjetoSocial.Name = "tbObjetoSocial";
            this.tbObjetoSocial.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\" +
    "*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang2057 richTextBox" +
    "Ex1\\par\r\n}\r\n";
            this.tbObjetoSocial.SetColorWithFont = true;
            this.tbObjetoSocial.ShowToolStrip = true;
            this.tbObjetoSocial.Size = new System.Drawing.Size(536, 104);
            this.tbObjetoSocial.TabIndex = 17;
            // 
            // tbValoresCompartidos
            // 
            this.tbValoresCompartidos.AllowBullets = true;
            this.tbValoresCompartidos.AllowDefaultInsertText = true;
            this.tbValoresCompartidos.AllowDefaultSmartText = true;
            this.tbValoresCompartidos.AllowHyphenation = true;
            this.tbValoresCompartidos.AllowPictures = true;
            this.tbValoresCompartidos.AllowSpellCheck = true;
            this.tbValoresCompartidos.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbValoresCompartidos.FilePath = "";
            this.tbValoresCompartidos.Location = new System.Drawing.Point(6, 14);
            this.tbValoresCompartidos.Name = "tbValoresCompartidos";
            this.tbValoresCompartidos.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n{\\" +
    "*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\fs20\\lang2057 richTextBox" +
    "Ex1\\par\r\n}\r\n";
            this.tbValoresCompartidos.SetColorWithFont = true;
            this.tbValoresCompartidos.ShowToolStrip = true;
            this.tbValoresCompartidos.Size = new System.Drawing.Size(536, 104);
            this.tbValoresCompartidos.TabIndex = 18;
            // 
            // AppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 484);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbCopyRight);
            this.Controls.Add(this.tbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbEmpresa;
        public System.Windows.Forms.TextBox tbCopyRight;
        public System.Windows.Forms.TextBox tbFecha;
        public System.Windows.Forms.Button btnActualizar;
        public FontAwesome.Sharp.IconButton btnBuscarLogo;
        public System.Windows.Forms.TextBox tbPJLogo;
        public System.Windows.Forms.OpenFileDialog openLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public RichTextBoxEx.RichTextBoxEx tbMision;
        public RichTextBoxEx.RichTextBoxEx tbVision;
        public RichTextBoxEx.RichTextBoxEx tbObjetoSocial;
        public RichTextBoxEx.RichTextBoxEx tbValoresCompartidos;
    }
}