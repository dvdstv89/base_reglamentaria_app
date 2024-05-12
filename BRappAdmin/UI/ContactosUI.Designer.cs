namespace BRappAdmin.UI
{
    partial class ContactosUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnSear = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaJuridicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lwPersonas = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbBuscar);
            this.panel4.Controls.Add(this.btnSear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(497, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 34);
            this.panel4.TabIndex = 1;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(3, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(156, 23);
            this.tbBuscar.TabIndex = 24;
            // 
            // btnSear
            // 
            this.btnSear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSear.Enabled = false;
            this.btnSear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSear.ForeColor = System.Drawing.Color.White;
            this.btnSear.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnSear.IconColor = System.Drawing.Color.Black;
            this.btnSear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSear.IconSize = 25;
            this.btnSear.Location = new System.Drawing.Point(162, 0);
            this.btnSear.Name = "btnSear";
            this.btnSear.Size = new System.Drawing.Size(38, 34);
            this.btnSear.TabIndex = 23;
            this.btnSear.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 34);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.activarToolStripMenuItem,
            this.desactivarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(436, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(56, 30);
            this.activarToolStripMenuItem.Text = "Activar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaNaturalToolStripMenuItem,
            this.personaJuridicaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // personaNaturalToolStripMenuItem
            // 
            this.personaNaturalToolStripMenuItem.Name = "personaNaturalToolStripMenuItem";
            this.personaNaturalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personaNaturalToolStripMenuItem.Text = "Persona Natural";
            // 
            // personaJuridicaToolStripMenuItem
            // 
            this.personaJuridicaToolStripMenuItem.Name = "personaJuridicaToolStripMenuItem";
            this.personaJuridicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personaJuridicaToolStripMenuItem.Text = "Persona Juridica";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lwPersonas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 719);
            this.panel3.TabIndex = 6;
            // 
            // lwPersonas
            // 
            this.lwPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnEmail,
            this.columnPhone,
            this.columnTipo,
            this.columnInterno,
            this.columnActivo});
            this.lwPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwPersonas.FullRowSelect = true;
            this.lwPersonas.GridLines = true;
            this.lwPersonas.HideSelection = false;
            this.lwPersonas.Location = new System.Drawing.Point(0, 0);
            this.lwPersonas.MultiSelect = false;
            this.lwPersonas.Name = "lwPersonas";
            this.lwPersonas.Size = new System.Drawing.Size(697, 719);
            this.lwPersonas.TabIndex = 1;
            this.lwPersonas.UseCompatibleStateImageBehavior = false;
            this.lwPersonas.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 112;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 178;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Telefono";
            this.columnPhone.Width = 157;
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo";
            this.columnTipo.Width = 70;
            // 
            // columnInterno
            // 
            this.columnInterno.Text = "Interno";
            this.columnInterno.Width = 66;
            // 
            // columnActivo
            // 
            this.columnActivo.Text = "Activo";
            this.columnActivo.Width = 72;
            // 
            // ContactosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactosUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox tbBuscar;
        private FontAwesome.Sharp.IconButton btnSear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personaNaturalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personaJuridicaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView lwPersonas;
        public System.Windows.Forms.ColumnHeader columnName;
        public System.Windows.Forms.ColumnHeader columnEmail;
        public System.Windows.Forms.ColumnHeader columnPhone;
        public System.Windows.Forms.ColumnHeader columnTipo;
        public System.Windows.Forms.ColumnHeader columnInterno;
        public System.Windows.Forms.ColumnHeader columnActivo;
    }
}