namespace BRappAdmin.UI
{
    partial class TipoDocumentacionUI
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
            this.panelDocumentos = new System.Windows.Forms.Panel();
            this.listViewDocumentacion = new System.Windows.Forms.ListView();
            this.columnDocumentoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipoCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasPdf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnResponsable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumeracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaCreacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaVencimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasOpcional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasPadre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHasActaAcuerdo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nuevoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDocumentos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.Controls.Add(this.listViewDocumentacion);
            this.panelDocumentos.Controls.Add(this.panel7);
            this.panelDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocumentos.Location = new System.Drawing.Point(0, 0);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(1100, 732);
            this.panelDocumentos.TabIndex = 12;
            // 
            // listViewDocumentacion
            // 
            this.listViewDocumentacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDocumentoName,
            this.columnTipoCard,
            this.columnHasPdf,
            this.columnResponsable,
            this.columnNumeracion,
            this.columnFechaCreacion,
            this.columnFechaVencimiento,
            this.columnHasCliente,
            this.columnHasOpcional,
            this.columnHasTipo,
            this.columnHasPadre,
            this.columnHasActaAcuerdo});
            this.listViewDocumentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDocumentacion.FullRowSelect = true;
            this.listViewDocumentacion.GridLines = true;
            this.listViewDocumentacion.HideSelection = false;
            this.listViewDocumentacion.Location = new System.Drawing.Point(0, 34);
            this.listViewDocumentacion.MultiSelect = false;
            this.listViewDocumentacion.Name = "listViewDocumentacion";
            this.listViewDocumentacion.Size = new System.Drawing.Size(1100, 698);
            this.listViewDocumentacion.TabIndex = 9;
            this.listViewDocumentacion.UseCompatibleStateImageBehavior = false;
            this.listViewDocumentacion.View = System.Windows.Forms.View.Details;
            // 
            // columnDocumentoName
            // 
            this.columnDocumentoName.Text = "Nombre";
            this.columnDocumentoName.Width = 112;
            // 
            // columnTipoCard
            // 
            this.columnTipoCard.Text = "Tipo Card";
            // 
            // columnHasPdf
            // 
            this.columnHasPdf.Text = "PDF";
            // 
            // columnResponsable
            // 
            this.columnResponsable.Text = "Responsable";
            // 
            // columnNumeracion
            // 
            this.columnNumeracion.Text = "Numeración";
            // 
            // columnFechaCreacion
            // 
            this.columnFechaCreacion.Text = "Fecha Creación";
            // 
            // columnFechaVencimiento
            // 
            this.columnFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // columnHasCliente
            // 
            this.columnHasCliente.Text = "Cliente";
            // 
            // columnHasOpcional
            // 
            this.columnHasOpcional.Text = "Opcionalidad";
            // 
            // columnHasTipo
            // 
            this.columnHasTipo.Text = "Tipo";
            // 
            // columnHasPadre
            // 
            this.columnHasPadre.Text = "Doc dependiente";
            // 
            // columnHasActaAcuerdo
            // 
            this.columnHasActaAcuerdo.Text = "Acta y Acuerdo";
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
            this.panel8.Controls.Add(this.tbBuscar);
            this.panel8.Controls.Add(this.iconButton1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(900, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 34);
            this.panel8.TabIndex = 1;
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
            this.panel9.Size = new System.Drawing.Size(728, 34);
            this.panel9.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoStripMenuItem1,
            this.modificarStripMenuItem2,
            this.eliminarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(728, 34);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // nuevoStripMenuItem1
            // 
            this.nuevoStripMenuItem1.Name = "nuevoStripMenuItem1";
            this.nuevoStripMenuItem1.Size = new System.Drawing.Size(54, 30);
            this.nuevoStripMenuItem1.Text = "Nuevo";
            // 
            // modificarStripMenuItem2
            // 
            this.modificarStripMenuItem2.Name = "modificarStripMenuItem2";
            this.modificarStripMenuItem2.Size = new System.Drawing.Size(70, 30);
            this.modificarStripMenuItem2.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // TipoDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 732);
            this.Controls.Add(this.panelDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TipoDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Documentación";
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
        public System.Windows.Forms.Panel panelDocumentos;
        public System.Windows.Forms.ListView listViewDocumentacion;
        public System.Windows.Forms.ColumnHeader columnDocumentoName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem nuevoStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem modificarStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        public System.Windows.Forms.ColumnHeader columnTipoCard;
        public System.Windows.Forms.ColumnHeader columnHasPdf;
        public System.Windows.Forms.ColumnHeader columnResponsable;
        public System.Windows.Forms.ColumnHeader columnNumeracion;
        public System.Windows.Forms.ColumnHeader columnFechaCreacion;
        public System.Windows.Forms.ColumnHeader columnFechaVencimiento;
        public System.Windows.Forms.ColumnHeader columnHasCliente;
        public System.Windows.Forms.ColumnHeader columnHasOpcional;
        public System.Windows.Forms.ColumnHeader columnHasTipo;
        public System.Windows.Forms.ColumnHeader columnHasPadre;
        public System.Windows.Forms.ColumnHeader columnHasActaAcuerdo;
    }
}