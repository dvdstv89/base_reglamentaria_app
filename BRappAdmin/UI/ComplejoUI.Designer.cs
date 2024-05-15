namespace BRappAdmin.UI
{
    partial class ComplejoUI
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMenuSeleccionado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lwComplejos = new System.Windows.Forms.ListView();
            this.columnNameComplejo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbBuscarComplejo = new System.Windows.Forms.TextBox();
            this.btnSear = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoComplejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarComplejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDptoAfuera = new System.Windows.Forms.Panel();
            this.panelDepartamentos = new System.Windows.Forms.Panel();
            this.lwDepartamentos = new System.Windows.Forms.ListView();
            this.columnNombreDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbBuscarDepartamento = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nuevoDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDapartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTiendaAfuera = new System.Windows.Forms.Panel();
            this.panelTiendas = new System.Windows.Forms.Panel();
            this.lwTiendas = new System.Windows.Forms.ListView();
            this.columnNombreTienda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbBuscarTienda = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.nuevaTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDptoAfuera.SuspendLayout();
            this.panelDepartamentos.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelTiendaAfuera.SuspendLayout();
            this.panelTiendas.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelMenuSeleccionado);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1023, 42);
            this.panel6.TabIndex = 6;
            // 
            // labelMenuSeleccionado
            // 
            this.labelMenuSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuSeleccionado.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.labelMenuSeleccionado.Name = "labelMenuSeleccionado";
            this.labelMenuSeleccionado.Size = new System.Drawing.Size(1023, 42);
            this.labelMenuSeleccionado.TabIndex = 3;
            this.labelMenuSeleccionado.Text = "Complejos";
            this.labelMenuSeleccionado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lwComplejos);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 268);
            this.panel3.TabIndex = 7;
            // 
            // lwComplejos
            // 
            this.lwComplejos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameComplejo});
            this.lwComplejos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lwComplejos.FullRowSelect = true;
            this.lwComplejos.GridLines = true;
            this.lwComplejos.HideSelection = false;
            this.lwComplejos.Location = new System.Drawing.Point(0, 34);
            this.lwComplejos.MultiSelect = false;
            this.lwComplejos.Name = "lwComplejos";
            this.lwComplejos.Size = new System.Drawing.Size(1023, 217);
            this.lwComplejos.TabIndex = 6;
            this.lwComplejos.UseCompatibleStateImageBehavior = false;
            this.lwComplejos.View = System.Windows.Forms.View.Details;
            // 
            // columnNameComplejo
            // 
            this.columnNameComplejo.Text = "Nombre";
            this.columnNameComplejo.Width = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbBuscarComplejo);
            this.panel4.Controls.Add(this.btnSear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(823, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 34);
            this.panel4.TabIndex = 1;
            // 
            // tbBuscarComplejo
            // 
            this.tbBuscarComplejo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarComplejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarComplejo.Location = new System.Drawing.Point(3, 5);
            this.tbBuscarComplejo.Name = "tbBuscarComplejo";
            this.tbBuscarComplejo.Size = new System.Drawing.Size(156, 23);
            this.tbBuscarComplejo.TabIndex = 24;
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
            this.panel2.Size = new System.Drawing.Size(423, 34);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoComplejoToolStripMenuItem,
            this.modificarComplejoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(423, 34);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoComplejoToolStripMenuItem
            // 
            this.nuevoComplejoToolStripMenuItem.Name = "nuevoComplejoToolStripMenuItem";
            this.nuevoComplejoToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.nuevoComplejoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarComplejoToolStripMenuItem
            // 
            this.modificarComplejoToolStripMenuItem.Name = "modificarComplejoToolStripMenuItem";
            this.modificarComplejoToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.modificarComplejoToolStripMenuItem.Text = "Modificar";
            // 
            // panelDptoAfuera
            // 
            this.panelDptoAfuera.Controls.Add(this.panelDepartamentos);
            this.panelDptoAfuera.Controls.Add(this.panel7);
            this.panelDptoAfuera.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDptoAfuera.Location = new System.Drawing.Point(0, 310);
            this.panelDptoAfuera.Name = "panelDptoAfuera";
            this.panelDptoAfuera.Size = new System.Drawing.Size(545, 424);
            this.panelDptoAfuera.TabIndex = 8;
            // 
            // panelDepartamentos
            // 
            this.panelDepartamentos.Controls.Add(this.lwDepartamentos);
            this.panelDepartamentos.Controls.Add(this.panel5);
            this.panelDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDepartamentos.Location = new System.Drawing.Point(0, 42);
            this.panelDepartamentos.Name = "panelDepartamentos";
            this.panelDepartamentos.Size = new System.Drawing.Size(545, 382);
            this.panelDepartamentos.TabIndex = 8;
            // 
            // lwDepartamentos
            // 
            this.lwDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombreDepartamento});
            this.lwDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwDepartamentos.FullRowSelect = true;
            this.lwDepartamentos.GridLines = true;
            this.lwDepartamentos.HideSelection = false;
            this.lwDepartamentos.Location = new System.Drawing.Point(0, 34);
            this.lwDepartamentos.MultiSelect = false;
            this.lwDepartamentos.Name = "lwDepartamentos";
            this.lwDepartamentos.Size = new System.Drawing.Size(545, 348);
            this.lwDepartamentos.TabIndex = 8;
            this.lwDepartamentos.UseCompatibleStateImageBehavior = false;
            this.lwDepartamentos.View = System.Windows.Forms.View.Details;
            // 
            // columnNombreDepartamento
            // 
            this.columnNombreDepartamento.Text = "Nombre";
            this.columnNombreDepartamento.Width = 112;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 34);
            this.panel5.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbBuscarDepartamento);
            this.panel8.Controls.Add(this.iconButton1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(345, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 34);
            this.panel8.TabIndex = 1;
            // 
            // tbBuscarDepartamento
            // 
            this.tbBuscarDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarDepartamento.Location = new System.Drawing.Point(3, 5);
            this.tbBuscarDepartamento.Name = "tbBuscarDepartamento";
            this.tbBuscarDepartamento.Size = new System.Drawing.Size(156, 23);
            this.tbBuscarDepartamento.TabIndex = 24;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(162, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 34);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.menuStrip2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(423, 34);
            this.panel10.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDepartamentoToolStripMenuItem,
            this.modificarDapartamentoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(423, 34);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // nuevoDepartamentoToolStripMenuItem
            // 
            this.nuevoDepartamentoToolStripMenuItem.Name = "nuevoDepartamentoToolStripMenuItem";
            this.nuevoDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.nuevoDepartamentoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarDapartamentoToolStripMenuItem
            // 
            this.modificarDapartamentoToolStripMenuItem.Name = "modificarDapartamentoToolStripMenuItem";
            this.modificarDapartamentoToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.modificarDapartamentoToolStripMenuItem.Text = "Modificar";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(545, 42);
            this.panel7.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelTiendaAfuera
            // 
            this.panelTiendaAfuera.Controls.Add(this.panelTiendas);
            this.panelTiendaAfuera.Controls.Add(this.panel9);
            this.panelTiendaAfuera.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTiendaAfuera.Location = new System.Drawing.Point(565, 310);
            this.panelTiendaAfuera.Name = "panelTiendaAfuera";
            this.panelTiendaAfuera.Size = new System.Drawing.Size(458, 424);
            this.panelTiendaAfuera.TabIndex = 9;
            // 
            // panelTiendas
            // 
            this.panelTiendas.Controls.Add(this.lwTiendas);
            this.panelTiendas.Controls.Add(this.panel11);
            this.panelTiendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTiendas.Location = new System.Drawing.Point(0, 42);
            this.panelTiendas.Name = "panelTiendas";
            this.panelTiendas.Size = new System.Drawing.Size(458, 382);
            this.panelTiendas.TabIndex = 8;
            // 
            // lwTiendas
            // 
            this.lwTiendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombreTienda});
            this.lwTiendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwTiendas.FullRowSelect = true;
            this.lwTiendas.GridLines = true;
            this.lwTiendas.HideSelection = false;
            this.lwTiendas.Location = new System.Drawing.Point(0, 34);
            this.lwTiendas.MultiSelect = false;
            this.lwTiendas.Name = "lwTiendas";
            this.lwTiendas.Size = new System.Drawing.Size(458, 348);
            this.lwTiendas.TabIndex = 8;
            this.lwTiendas.UseCompatibleStateImageBehavior = false;
            this.lwTiendas.View = System.Windows.Forms.View.Details;
            // 
            // columnNombreTienda
            // 
            this.columnNombreTienda.Text = "Nombre";
            this.columnNombreTienda.Width = 112;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(458, 34);
            this.panel11.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tbBuscarTienda);
            this.panel12.Controls.Add(this.iconButton2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(258, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 34);
            this.panel12.TabIndex = 1;
            // 
            // tbBuscarTienda
            // 
            this.tbBuscarTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarTienda.Location = new System.Drawing.Point(3, 5);
            this.tbBuscarTienda.Name = "tbBuscarTienda";
            this.tbBuscarTienda.Size = new System.Drawing.Size(156, 23);
            this.tbBuscarTienda.TabIndex = 24;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(162, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(38, 34);
            this.iconButton2.TabIndex = 23;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.menuStrip3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(423, 34);
            this.panel13.TabIndex = 0;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaTiendaToolStripMenuItem,
            this.modificarTiendaToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip3.Size = new System.Drawing.Size(423, 34);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // nuevaTiendaToolStripMenuItem
            // 
            this.nuevaTiendaToolStripMenuItem.Name = "nuevaTiendaToolStripMenuItem";
            this.nuevaTiendaToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.nuevaTiendaToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarTiendaToolStripMenuItem
            // 
            this.modificarTiendaToolStripMenuItem.Name = "modificarTiendaToolStripMenuItem";
            this.modificarTiendaToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.modificarTiendaToolStripMenuItem.Text = "Modificar";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(458, 42);
            this.panel9.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiendas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ComplejoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 734);
            this.Controls.Add(this.panelTiendaAfuera);
            this.Controls.Add(this.panelDptoAfuera);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComplejoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complejos";
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDptoAfuera.ResumeLayout(false);
            this.panelDepartamentos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panelTiendaAfuera.ResumeLayout(false);
            this.panelTiendas.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label labelMenuSeleccionado;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView lwComplejos;
        public System.Windows.Forms.ColumnHeader columnNameComplejo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox tbBuscarComplejo;
        private FontAwesome.Sharp.IconButton btnSear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem nuevoComplejoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarComplejoToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelDptoAfuera;
        public System.Windows.Forms.Panel panelTiendaAfuera;
        public System.Windows.Forms.Panel panelDepartamentos;
        public System.Windows.Forms.Panel panelTiendas;
        public System.Windows.Forms.ListView lwDepartamentos;
        public System.Windows.Forms.ColumnHeader columnNombreDepartamento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbBuscarDepartamento;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem nuevoDepartamentoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarDapartamentoToolStripMenuItem;
        public System.Windows.Forms.ListView lwTiendas;
        public System.Windows.Forms.ColumnHeader columnNombreTienda;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.TextBox tbBuscarTienda;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.MenuStrip menuStrip3;
        public System.Windows.Forms.ToolStripMenuItem nuevaTiendaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarTiendaToolStripMenuItem;
    }
}