namespace BRappAdmin.UI
{
    partial class NewDepartamentoUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbComplejo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lwTipos = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDescripcion = new RichTextBoxEx.RichTextBoxEx();
            this.tbTrabajadores = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Complejo";
            // 
            // tbComplejo
            // 
            this.tbComplejo.Location = new System.Drawing.Point(95, 17);
            this.tbComplejo.Name = "tbComplejo";
            this.tbComplejo.ReadOnly = true;
            this.tbComplejo.Size = new System.Drawing.Size(468, 20);
            this.tbComplejo.TabIndex = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(485, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(468, 20);
            this.tbName.TabIndex = 42;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(95, 68);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(335, 21);
            this.cbTipo.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lwTipos);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 220);
            this.groupBox1.TabIndex = 52;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(15, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 147);
            this.groupBox2.TabIndex = 53;
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
            this.tbDescripcion.Size = new System.Drawing.Size(536, 122);
            this.tbDescripcion.TabIndex = 25;           
            // 
            // tbTrabajadores
            // 
            this.tbTrabajadores.Location = new System.Drawing.Point(511, 71);
            this.tbTrabajadores.Maximum = new decimal(new int[] {
            400,
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
            this.tbTrabajadores.TabIndex = 71;
            this.tbTrabajadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Trabajadores";
            // 
            // NewDepartamentoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 522);
            this.Controls.Add(this.tbTrabajadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbComplejo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewDepartamentoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbComplejo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lwTipos;
        public System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.GroupBox groupBox2;
        public RichTextBoxEx.RichTextBoxEx tbDescripcion;
        public System.Windows.Forms.NumericUpDown tbTrabajadores;
        private System.Windows.Forms.Label label4;
    }
}