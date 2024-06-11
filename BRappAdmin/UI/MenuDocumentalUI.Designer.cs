namespace BRappAdmin.UI
{
    partial class MenuDocumentalUI
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
            this.listViewMenus = new System.Windows.Forms.ListView();
            this.columnDocumentoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbBuscarDocumentos = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.nuevoDocumentoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDocumentoStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.subirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnUbicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPanelBusqueda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMostrarArchivados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDocumentos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.Controls.Add(this.listViewMenus);
            this.panelDocumentos.Controls.Add(this.panel7);
            this.panelDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocumentos.Location = new System.Drawing.Point(0, 0);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(1100, 732);
            this.panelDocumentos.TabIndex = 12;
            // 
            // listViewMenus
            // 
            this.listViewMenus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDocumentoName,
            this.columnUbicacion,
            this.columnPanelBusqueda,
            this.columnMostrarArchivados});
            this.listViewMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMenus.FullRowSelect = true;
            this.listViewMenus.GridLines = true;
            this.listViewMenus.HideSelection = false;
            this.listViewMenus.Location = new System.Drawing.Point(0, 34);
            this.listViewMenus.MultiSelect = false;
            this.listViewMenus.Name = "listViewMenus";
            this.listViewMenus.Size = new System.Drawing.Size(1100, 698);
            this.listViewMenus.TabIndex = 9;
            this.listViewMenus.UseCompatibleStateImageBehavior = false;
            this.listViewMenus.View = System.Windows.Forms.View.Details;
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
            this.panel9.Size = new System.Drawing.Size(728, 34);
            this.panel9.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocumentoStripMenuItem1,
            this.modificarDocumentoStripMenuItem2,
            this.subirToolStripMenuItem,
            this.bajarToolStripMenuItem,
            this.eliminarDocumentoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(728, 34);
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
            // subirToolStripMenuItem
            // 
            this.subirToolStripMenuItem.Name = "subirToolStripMenuItem";
            this.subirToolStripMenuItem.Size = new System.Drawing.Size(46, 30);
            this.subirToolStripMenuItem.Text = "Subir";
            // 
            // bajarToolStripMenuItem
            // 
            this.bajarToolStripMenuItem.Name = "bajarToolStripMenuItem";
            this.bajarToolStripMenuItem.Size = new System.Drawing.Size(45, 30);
            this.bajarToolStripMenuItem.Text = "Bajar";
            // 
            // eliminarDocumentoToolStripMenuItem
            // 
            this.eliminarDocumentoToolStripMenuItem.Name = "eliminarDocumentoToolStripMenuItem";
            this.eliminarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.eliminarDocumentoToolStripMenuItem.Text = "Eliminar";
            // 
            // columnUbicacion
            // 
            this.columnUbicacion.Text = "Ubicación";
            // 
            // columnPanelBusqueda
            // 
            this.columnPanelBusqueda.Text = "Panel de Busqueda";
            // 
            // columnMostrarArchivados
            // 
            this.columnMostrarArchivados.Text = "Mostrar Archivados";
            // 
            // MenuDocumentalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 732);
            this.Controls.Add(this.panelDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuDocumentalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Documental";
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
        public System.Windows.Forms.ListView listViewMenus;
        public System.Windows.Forms.ColumnHeader columnDocumentoName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbBuscarDocumentos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem nuevoDocumentoStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem modificarDocumentoStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem eliminarDocumentoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bajarToolStripMenuItem;
        public System.Windows.Forms.ColumnHeader columnUbicacion;
        public System.Windows.Forms.ColumnHeader columnPanelBusqueda;
        public System.Windows.Forms.ColumnHeader columnMostrarArchivados;
    }
}