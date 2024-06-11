namespace BRapp.UI
{
    partial class SucursalUI
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplejoUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelDepartamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMenuSeleccionado = new System.Windows.Forms.Label();
            this.pictureBoxOrganigramaEmpresa = new System.Windows.Forms.PictureBox();
            this.panelTiendasHeader = new System.Windows.Forms.Panel();
            this.panelSucursal = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.richTextBoxValoresCompartidos = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.richTextBoxObjetoSocialIzquierdo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.richTextBoxVision = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.richTextBoxMision = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganigramaEmpresa)).BeginInit();
            this.panelSucursal.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 441);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.treeView1);
            this.panel4.Controls.Add(this.panelDepartamentos);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(972, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 441);
            this.panel4.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(16, 61);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(496, 380);
            this.treeView1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.treeView1, "Departamentos");
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // panelDepartamentos
            // 
            this.panelDepartamentos.AutoScroll = true;
            this.panelDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDepartamentos.Location = new System.Drawing.Point(16, 43);
            this.panelDepartamentos.Name = "panelDepartamentos";
            this.panelDepartamentos.Size = new System.Drawing.Size(496, 18);
            this.panelDepartamentos.TabIndex = 8;
            this.panelDepartamentos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDepartamentos_Paint);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(1, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 398);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(511, 43);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Departamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 441);
            this.panel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBoxOrganigramaEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 441);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 116;
            this.iconPictureBox1.Location = new System.Drawing.Point(401, 169);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(117, 116);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelMenuSeleccionado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 43);
            this.panel3.TabIndex = 1;
            // 
            // labelMenuSeleccionado
            // 
            this.labelMenuSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMenuSeleccionado.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.labelMenuSeleccionado.Name = "labelMenuSeleccionado";
            this.labelMenuSeleccionado.Size = new System.Drawing.Size(972, 43);
            this.labelMenuSeleccionado.TabIndex = 4;
            this.labelMenuSeleccionado.Text = "Organigrama";
            this.labelMenuSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenuSeleccionado.Click += new System.EventHandler(this.labelMenuSeleccionado_Click);
            // 
            // pictureBoxOrganigramaEmpresa
            // 
            this.pictureBoxOrganigramaEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOrganigramaEmpresa.Location = new System.Drawing.Point(12, 43);
            this.pictureBoxOrganigramaEmpresa.Name = "pictureBoxOrganigramaEmpresa";
            this.pictureBoxOrganigramaEmpresa.Size = new System.Drawing.Size(933, 393);
            this.pictureBoxOrganigramaEmpresa.TabIndex = 0;
            this.pictureBoxOrganigramaEmpresa.TabStop = false;
            this.pictureBoxOrganigramaEmpresa.Click += new System.EventHandler(this.pictureBoxOrganigramaEmpresa_Click);
            // 
            // panelTiendasHeader
            // 
            this.panelTiendasHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTiendasHeader.Location = new System.Drawing.Point(0, 441);
            this.panelTiendasHeader.Name = "panelTiendasHeader";
            this.panelTiendasHeader.Size = new System.Drawing.Size(1484, 16);
            this.panelTiendasHeader.TabIndex = 3;
            // 
            // panelSucursal
            // 
            this.panelSucursal.AutoScroll = true;
            this.panelSucursal.Controls.Add(this.panel7);
            this.panelSucursal.Controls.Add(this.panel9);
            this.panelSucursal.Controls.Add(this.panel10);
            this.panelSucursal.Controls.Add(this.panel11);
            this.panelSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSucursal.Location = new System.Drawing.Point(0, 457);
            this.panelSucursal.Name = "panelSucursal";
            this.panelSucursal.Size = new System.Drawing.Size(1484, 330);
            this.panelSucursal.TabIndex = 10;
            this.panelSucursal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSucursal_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel7.Controls.Add(this.richTextBoxValoresCompartidos);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(511, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(956, 323);
            this.panel7.TabIndex = 10;
            // 
            // richTextBoxValoresCompartidos
            // 
            this.richTextBoxValoresCompartidos.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxValoresCompartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxValoresCompartidos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxValoresCompartidos.Location = new System.Drawing.Point(6, 51);
            this.richTextBoxValoresCompartidos.Name = "richTextBoxValoresCompartidos";
            this.richTextBoxValoresCompartidos.ReadOnly = true;
            this.richTextBoxValoresCompartidos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxValoresCompartidos.Size = new System.Drawing.Size(938, 260);
            this.richTextBoxValoresCompartidos.TabIndex = 0;
            this.richTextBoxValoresCompartidos.TabStop = false;
            this.richTextBoxValoresCompartidos.Text = resources.GetString("richTextBoxValoresCompartidos.Text");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(956, 48);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valores Compartidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel9.Controls.Add(this.richTextBoxObjetoSocialIzquierdo);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(19, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(486, 193);
            this.panel9.TabIndex = 9;
            // 
            // richTextBoxObjetoSocialIzquierdo
            // 
            this.richTextBoxObjetoSocialIzquierdo.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxObjetoSocialIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxObjetoSocialIzquierdo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxObjetoSocialIzquierdo.Location = new System.Drawing.Point(6, 51);
            this.richTextBoxObjetoSocialIzquierdo.Name = "richTextBoxObjetoSocialIzquierdo";
            this.richTextBoxObjetoSocialIzquierdo.ReadOnly = true;
            this.richTextBoxObjetoSocialIzquierdo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxObjetoSocialIzquierdo.Size = new System.Drawing.Size(477, 130);
            this.richTextBoxObjetoSocialIzquierdo.TabIndex = 0;
            this.richTextBoxObjetoSocialIzquierdo.TabStop = false;
            this.richTextBoxObjetoSocialIzquierdo.Text = "Operar redes de tiendas para la venta minorista de mercancías, incluyendo la ofer" +
    "ta de otros servicios comerciales y de actividades promocionales.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Objeto Social";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel10.Controls.Add(this.richTextBoxVision);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(265, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 124);
            this.panel10.TabIndex = 8;
            // 
            // richTextBoxVision
            // 
            this.richTextBoxVision.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxVision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxVision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxVision.Location = new System.Drawing.Point(6, 51);
            this.richTextBoxVision.Name = "richTextBoxVision";
            this.richTextBoxVision.ReadOnly = true;
            this.richTextBoxVision.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxVision.Size = new System.Drawing.Size(231, 57);
            this.richTextBoxVision.TabIndex = 0;
            this.richTextBoxVision.TabStop = false;
            this.richTextBoxVision.Text = "Ser reconocidos por la calidad y profesionalidad de los servicios que brindamos a" +
    " nuestros clientes";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visión";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel11.Controls.Add(this.richTextBoxMision);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(19, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(240, 124);
            this.panel11.TabIndex = 7;
            // 
            // richTextBoxMision
            // 
            this.richTextBoxMision.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxMision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMision.Location = new System.Drawing.Point(6, 51);
            this.richTextBoxMision.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBoxMision.Name = "richTextBoxMision";
            this.richTextBoxMision.ReadOnly = true;
            this.richTextBoxMision.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxMision.Size = new System.Drawing.Size(229, 57);
            this.richTextBoxMision.TabIndex = 0;
            this.richTextBoxMision.TabStop = false;
            this.richTextBoxMision.Text = "Ofertar productos y servicios turísticos atractivos que distingan por su calidad";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 48);
            this.label6.TabIndex = 0;
            this.label6.Text = "Misión";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // ComplejoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 787);
            this.Controls.Add(this.panelSucursal);
            this.Controls.Add(this.panelTiendasHeader);
            this.Controls.Add(this.panel2);
            this.Name = "ComplejoUI";
            this.Text = "ComplejoUI";
            this.Load += new System.EventHandler(this.ComplejoUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganigramaEmpresa)).EndInit();
            this.panelSucursal.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBoxOrganigramaEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label labelMenuSeleccionado;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panelTiendasHeader;
        public System.Windows.Forms.Panel panelSucursal;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.RichTextBox richTextBoxValoresCompartidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.RichTextBox richTextBoxObjetoSocialIzquierdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.RichTextBox richTextBoxVision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.RichTextBox richTextBoxMision;
        private System.Windows.Forms.Label label6;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.FlowLayoutPanel panelDepartamentos;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}