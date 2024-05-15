using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class DocumentoCard : UserControl
    {
        public RichTextBox labelDescripcion;
        public Panel panelFecha;
        public TextBox lbFecha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel1;
        public FontAwesome.Sharp.IconButton btnResponsable;
        public TextBox labelCargoResponsable;
        public Panel panelImagen;
        private Panel panel2;
        public Panel panelTitle;
        public Label labelName;
        public FontAwesome.Sharp.IconButton btnPdf;
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;

        public DocumentoCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDescripcion = new System.Windows.Forms.RichTextBox();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResponsable = new FontAwesome.Sharp.IconButton();
            this.labelCargoResponsable = new System.Windows.Forms.TextBox();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDescripcion.DetectUrls = false;
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(120, 120);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.ReadOnly = true;
            this.labelDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.labelDescripcion.Size = new System.Drawing.Size(308, 88);
            this.labelDescripcion.TabIndex = 25;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // panelFecha
            // 
            this.panelFecha.BackColor = System.Drawing.Color.White;
            this.panelFecha.Controls.Add(this.lbFecha);
            this.panelFecha.Controls.Add(this.iconPictureBox2);
            this.panelFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFecha.Location = new System.Drawing.Point(120, 95);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(363, 25);
            this.panelFecha.TabIndex = 24;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.White;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(40, 0);
            this.lbFecha.Multiline = true;
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.ReadOnly = true;
            this.lbFecha.Size = new System.Drawing.Size(306, 25);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.TabStop = false;
            this.lbFecha.Text = "Informatico sdf sdf sdfg sdfg sdfg sdfg sdfs";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(38, 25);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox2, "Fecha de redacción");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnResponsable);
            this.panel1.Controls.Add(this.labelCargoResponsable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(120, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 25);
            this.panel1.TabIndex = 23;
            // 
            // btnResponsable
            // 
            this.btnResponsable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsable.ForeColor = System.Drawing.Color.White;
            this.btnResponsable.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnResponsable.IconColor = System.Drawing.Color.Black;
            this.btnResponsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResponsable.IconSize = 25;
            this.btnResponsable.Location = new System.Drawing.Point(0, 0);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(38, 25);
            this.btnResponsable.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnResponsable, "Responsable del documento");
            this.btnResponsable.UseVisualStyleBackColor = true;
            // 
            // labelCargoResponsable
            // 
            this.labelCargoResponsable.BackColor = System.Drawing.Color.White;
            this.labelCargoResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCargoResponsable.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCargoResponsable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoResponsable.Location = new System.Drawing.Point(40, 0);
            this.labelCargoResponsable.Multiline = true;
            this.labelCargoResponsable.Name = "labelCargoResponsable";
            this.labelCargoResponsable.ReadOnly = true;
            this.labelCargoResponsable.Size = new System.Drawing.Size(323, 25);
            this.labelCargoResponsable.TabIndex = 8;
            this.labelCargoResponsable.TabStop = false;
            this.labelCargoResponsable.Text = "Informatico sdf sdf sdfg sdfg sdfg sdfg sdfs";
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.White;
            this.panelImagen.BackgroundImage = global::BRapp.Properties.Resources.PDF;
            this.panelImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 70);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(120, 138);
            this.panelImagen.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 10);
            this.panel2.TabIndex = 21;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Orange;
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Controls.Add(this.iconPrincipal);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(483, 60);
            this.panelTitle.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(58, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(425, 60);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPrincipal.IconColor = System.Drawing.Color.White;
            this.iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPrincipal.IconSize = 49;
            this.iconPrincipal.Location = new System.Drawing.Point(3, 5);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(49, 51);
            this.iconPrincipal.TabIndex = 6;
            this.iconPrincipal.TabStop = false;
            // 
            // btnPdf
            // 
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPdf.IconColor = System.Drawing.Color.Black;
            this.btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdf.Location = new System.Drawing.Point(437, 160);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(46, 49);
            this.btnPdf.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnPdf, "Ver documento");
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // DocumentoCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DocumentoCard";
            this.Size = new System.Drawing.Size(483, 208);
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.ResumeLayout(false);

        }                     
    }
}
