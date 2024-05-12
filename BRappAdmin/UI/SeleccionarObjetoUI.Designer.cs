namespace BRappAdmin.UI
{
    partial class SeleccionarObjetoUI
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
            this.lwPapeles = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbBuscar);
            this.panel4.Controls.Add(this.btnSear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 34);
            this.panel4.TabIndex = 1;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(3, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(302, 23);
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
            this.btnSear.Location = new System.Drawing.Point(311, 0);
            this.btnSear.Name = "btnSear";
            this.btnSear.Size = new System.Drawing.Size(38, 34);
            this.btnSear.TabIndex = 23;
            this.btnSear.UseVisualStyleBackColor = true;
            // 
            // lwPapeles
            // 
            this.lwPapeles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.lwPapeles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwPapeles.FullRowSelect = true;
            this.lwPapeles.GridLines = true;
            this.lwPapeles.HideSelection = false;
            this.lwPapeles.Location = new System.Drawing.Point(0, 34);
            this.lwPapeles.MultiSelect = false;
            this.lwPapeles.Name = "lwPapeles";
            this.lwPapeles.Size = new System.Drawing.Size(352, 416);
            this.lwPapeles.TabIndex = 6;
            this.lwPapeles.UseCompatibleStateImageBehavior = false;
            this.lwPapeles.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Nombre";
            this.columnName.Width = 332;
            // 
            // BuscarObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.lwPapeles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar...";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox tbBuscar;
        private FontAwesome.Sharp.IconButton btnSear;
        public System.Windows.Forms.ListView lwPapeles;
        public System.Windows.Forms.ColumnHeader columnName;
    }
}