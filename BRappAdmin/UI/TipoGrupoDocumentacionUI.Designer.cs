﻿namespace BRappAdmin.UI
{
    partial class TipoGrupoDocumentacionUI
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lwTipos = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnSear = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMenuSeleccionado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDocumentos = new System.Windows.Forms.Panel();
            this.listViewDocumentos = new System.Windows.Forms.ListView();
            this.columnDocumentoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbBuscarDocumentos = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nuevoDocumentoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDocumentoStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obligatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelDocumentos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lwTipos);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 244);
            this.panel5.TabIndex = 8;
            // 
            // lwTipos
            // 
            this.lwTipos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.lwTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwTipos.FullRowSelect = true;
            this.lwTipos.GridLines = true;
            this.lwTipos.HideSelection = false;
            this.lwTipos.Location = new System.Drawing.Point(0, 76);
            this.lwTipos.MultiSelect = false;
            this.lwTipos.Name = "lwTipos";
            this.lwTipos.Size = new System.Drawing.Size(1100, 168);
            this.lwTipos.TabIndex = 9;
            this.lwTipos.UseCompatibleStateImageBehavior = false;
            this.lwTipos.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 34);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbBuscar);
            this.panel4.Controls.Add(this.btnSear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(900, 0);
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
            this.panel2.Size = new System.Drawing.Size(423, 34);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(423, 34);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelMenuSeleccionado);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1100, 42);
            this.panel6.TabIndex = 0;
            // 
            // labelMenuSeleccionado
            // 
            this.labelMenuSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuSeleccionado.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.labelMenuSeleccionado.Name = "labelMenuSeleccionado";
            this.labelMenuSeleccionado.Size = new System.Drawing.Size(1100, 42);
            this.labelMenuSeleccionado.TabIndex = 3;
            this.labelMenuSeleccionado.Text = "Tipos";
            this.labelMenuSeleccionado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Documentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.Controls.Add(this.listViewDocumentos);
            this.panelDocumentos.Controls.Add(this.panel7);
            this.panelDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocumentos.Location = new System.Drawing.Point(0, 285);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(1100, 447);
            this.panelDocumentos.TabIndex = 12;
            // 
            // listViewDocumentos
            // 
            this.listViewDocumentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDocumentoName});
            this.listViewDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDocumentos.FullRowSelect = true;
            this.listViewDocumentos.GridLines = true;
            this.listViewDocumentos.HideSelection = false;
            this.listViewDocumentos.Location = new System.Drawing.Point(0, 34);
            this.listViewDocumentos.MultiSelect = false;
            this.listViewDocumentos.Name = "listViewDocumentos";
            this.listViewDocumentos.Size = new System.Drawing.Size(1100, 413);
            this.listViewDocumentos.TabIndex = 9;
            this.listViewDocumentos.UseCompatibleStateImageBehavior = false;
            this.listViewDocumentos.View = System.Windows.Forms.View.Details;
            // 
            // columnDocumentoName
            // 
            this.columnDocumentoName.Text = "Nombre";
            this.columnDocumentoName.Width = 112;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1100, 34);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbBuscarDocumentos);
            this.panel8.Controls.Add(this.iconButton1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(900, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 34);
            this.panel8.TabIndex = 1;
            // 
            // tbBuscarDocumentos
            // 
            this.tbBuscarDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarDocumentos.Location = new System.Drawing.Point(3, 5);
            this.tbBuscarDocumentos.Name = "tbBuscarDocumentos";
            this.tbBuscarDocumentos.Size = new System.Drawing.Size(156, 23);
            this.tbBuscarDocumentos.TabIndex = 24;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.menuStrip2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(423, 34);
            this.panel9.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocumentoStripMenuItem1,
            this.modificarDocumentoStripMenuItem2,
            this.opcionalToolStripMenuItem,
            this.obligatorioToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(423, 34);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // nuevoDocumentoStripMenuItem1
            // 
            this.nuevoDocumentoStripMenuItem1.Name = "nuevoDocumentoStripMenuItem1";
            this.nuevoDocumentoStripMenuItem1.Size = new System.Drawing.Size(54, 30);
            this.nuevoDocumentoStripMenuItem1.Text = "Nuevo";
            // 
            // modificarDocumentoStripMenuItem2
            // 
            this.modificarDocumentoStripMenuItem2.Name = "modificarDocumentoStripMenuItem2";
            this.modificarDocumentoStripMenuItem2.Size = new System.Drawing.Size(70, 30);
            this.modificarDocumentoStripMenuItem2.Text = "Modificar";
            // 
            // opcionalToolStripMenuItem
            // 
            this.opcionalToolStripMenuItem.Name = "opcionalToolStripMenuItem";
            this.opcionalToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.opcionalToolStripMenuItem.Text = "Opcional";
            // 
            // obligatorioToolStripMenuItem
            // 
            this.obligatorioToolStripMenuItem.Name = "obligatorioToolStripMenuItem";
            this.obligatorioToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.obligatorioToolStripMenuItem.Text = "Obligatorio";
            // 
            // TipoGrupoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 732);
            this.Controls.Add(this.panelDocumentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TipoGrupoDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Documentación";
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelDocumentos.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ListView lwTipos;
        public System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox tbBuscar;
        private FontAwesome.Sharp.IconButton btnSear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label labelMenuSeleccionado;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelDocumentos;
        public System.Windows.Forms.ListView listViewDocumentos;
        public System.Windows.Forms.ColumnHeader columnDocumentoName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbBuscarDocumentos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem nuevoDocumentoStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem modificarDocumentoStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem opcionalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem obligatorioToolStripMenuItem;
    }
}