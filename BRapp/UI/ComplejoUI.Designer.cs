namespace BRapp.UI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMenuSeleccionado = new System.Windows.Forms.Label();
            this.pictureBoxOrganigramaEmpresa = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelOrganigrama = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.bRichTextBox1 = new BRichTextBox.BRichTextBox();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganigramaEmpresa)).BeginInit();
            this.panelOrganigrama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelGraficos.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(0, 43);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Node2";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(500, 744);
            this.treeView1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.treeView1, "Departamentos");
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.treeView1);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 787);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 43);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMenuSeleccionado
            // 
            this.labelMenuSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuSeleccionado.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSeleccionado.Location = new System.Drawing.Point(502, 0);
            this.labelMenuSeleccionado.Name = "labelMenuSeleccionado";
            this.labelMenuSeleccionado.Size = new System.Drawing.Size(982, 43);
            this.labelMenuSeleccionado.TabIndex = 4;
            this.labelMenuSeleccionado.Text = "Organigrama";
            this.labelMenuSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenuSeleccionado.Click += new System.EventHandler(this.labelMenuSeleccionado_Click_1);
            // 
            // pictureBoxOrganigramaEmpresa
            // 
            this.pictureBoxOrganigramaEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOrganigramaEmpresa.Location = new System.Drawing.Point(24, 13);
            this.pictureBoxOrganigramaEmpresa.Name = "pictureBoxOrganigramaEmpresa";
            this.pictureBoxOrganigramaEmpresa.Size = new System.Drawing.Size(933, 393);
            this.pictureBoxOrganigramaEmpresa.TabIndex = 0;
            this.pictureBoxOrganigramaEmpresa.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(500, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 787);
            this.panel5.TabIndex = 14;
            // 
            // panelOrganigrama
            // 
            this.panelOrganigrama.Controls.Add(this.iconPictureBox1);
            this.panelOrganigrama.Controls.Add(this.pictureBoxOrganigramaEmpresa);
            this.panelOrganigrama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrganigrama.Location = new System.Drawing.Point(502, 43);
            this.panelOrganigrama.Name = "panelOrganigrama";
            this.panelOrganigrama.Size = new System.Drawing.Size(982, 414);
            this.panelOrganigrama.TabIndex = 15;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 116;
            this.iconPictureBox1.Location = new System.Drawing.Point(407, 136);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(117, 116);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelGraficos
            // 
            this.panelGraficos.BackColor = System.Drawing.Color.White;
            this.panelGraficos.Controls.Add(this.bRichTextBox1);
            this.panelGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraficos.Location = new System.Drawing.Point(502, 457);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Padding = new System.Windows.Forms.Padding(5);
            this.panelGraficos.Size = new System.Drawing.Size(982, 330);
            this.panelGraficos.TabIndex = 16;
            // 
            // bRichTextBox1
            // 
            this.bRichTextBox1.AddDate = false;
            this.bRichTextBox1.AutoScroll = false;
            this.bRichTextBox1.BackColor = System.Drawing.Color.White;
            this.bRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRichTextBox1.Location = new System.Drawing.Point(5, 5);
            this.bRichTextBox1.Name = "bRichTextBox1";
            this.bRichTextBox1.Size = new System.Drawing.Size(972, 320);
            this.bRichTextBox1.TabIndex = 0;
            this.bRichTextBox1.Text = "";
            // 
            // ComplejoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 787);
            this.Controls.Add(this.panelGraficos);
            this.Controls.Add(this.panelOrganigrama);
            this.Controls.Add(this.labelMenuSeleccionado);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Name = "ComplejoUI";
            this.Text = "ComplejoUI";
            this.Load += new System.EventHandler(this.ComplejoUI_Load);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganigramaEmpresa)).EndInit();
            this.panelOrganigrama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelGraficos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelMenuSeleccionado;
        public System.Windows.Forms.PictureBox pictureBoxOrganigramaEmpresa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelOrganigrama;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Panel panelGraficos;
        public BRichTextBox.BRichTextBox bRichTextBox1;
    }
}