using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class ResolucionCard : UserControl
    {
        private Panel panel4;
        public TextBox lbFecha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel1;
        public TextBox labelCargoResponsable;
        public Panel panelImagen;
        private Panel panel2;
        public Panel panelTitle;
        public Label labelName;
        public FontAwesome.Sharp.IconButton btnPdf;
        public FontAwesome.Sharp.IconButton btnResponsable;
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public Panel panelDerrogadoPor;
        public FontAwesome.Sharp.IconButton btnDerrogadaPor;
        public TextBox tbDerrogadoPor;
        public RichTextBox labelDescripcion;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;

        public ResolucionCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.btnDerrogadaPor = new FontAwesome.Sharp.IconButton();
            this.panelDerrogadoPor = new System.Windows.Forms.Panel();
            this.tbDerrogadoPor = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.RichTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelImagen.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.panelDerrogadoPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbFecha);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(120, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 25);
            this.panel4.TabIndex = 16;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.White;
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(40, 1);
            this.lbFecha.Multiline = true;
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.ReadOnly = true;
            this.lbFecha.Size = new System.Drawing.Size(291, 25);
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
            this.toolTip1.SetToolTip(this.iconPictureBox2, "Fecha de la firma de la resolución");
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
            this.panel1.TabIndex = 15;
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
            this.toolTip1.SetToolTip(this.btnResponsable, "Firmada por");
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
            this.panelImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagen.Controls.Add(this.iconPictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 70);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(120, 138);
            this.panelImagen.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 10);
            this.panel2.TabIndex = 13;
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
            this.panelTitle.TabIndex = 12;
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
            this.btnPdf.Location = new System.Drawing.Point(434, 156);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(46, 49);
            this.btnPdf.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnPdf, "Ver resolución");
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnDerrogadaPor
            // 
            this.btnDerrogadaPor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDerrogadaPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerrogadaPor.ForeColor = System.Drawing.Color.White;
            this.btnDerrogadaPor.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btnDerrogadaPor.IconColor = System.Drawing.Color.Black;
            this.btnDerrogadaPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDerrogadaPor.IconSize = 25;
            this.btnDerrogadaPor.Location = new System.Drawing.Point(0, 0);
            this.btnDerrogadaPor.Name = "btnDerrogadaPor";
            this.btnDerrogadaPor.Size = new System.Drawing.Size(38, 25);
            this.btnDerrogadaPor.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnDerrogadaPor, "Derrogada por");
            this.btnDerrogadaPor.UseVisualStyleBackColor = true;
            // 
            // panelDerrogadoPor
            // 
            this.panelDerrogadoPor.BackColor = System.Drawing.Color.White;
            this.panelDerrogadoPor.Controls.Add(this.btnDerrogadaPor);
            this.panelDerrogadoPor.Controls.Add(this.tbDerrogadoPor);
            this.panelDerrogadoPor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDerrogadoPor.Location = new System.Drawing.Point(120, 120);
            this.panelDerrogadoPor.Name = "panelDerrogadoPor";
            this.panelDerrogadoPor.Size = new System.Drawing.Size(363, 25);
            this.panelDerrogadoPor.TabIndex = 37;
            // 
            // tbDerrogadoPor
            // 
            this.tbDerrogadoPor.BackColor = System.Drawing.Color.White;
            this.tbDerrogadoPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDerrogadoPor.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDerrogadoPor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDerrogadoPor.Location = new System.Drawing.Point(38, 0);
            this.tbDerrogadoPor.Multiline = true;
            this.tbDerrogadoPor.Name = "tbDerrogadoPor";
            this.tbDerrogadoPor.ReadOnly = true;
            this.tbDerrogadoPor.Size = new System.Drawing.Size(322, 22);
            this.tbDerrogadoPor.TabIndex = 8;
            this.tbDerrogadoPor.TabStop = false;
            this.tbDerrogadoPor.Text = "Derrogada por";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDescripcion.DetectUrls = false;
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(120, 145);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.ReadOnly = true;
            this.labelDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.labelDescripcion.Size = new System.Drawing.Size(311, 63);
            this.labelDescripcion.TabIndex = 38;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 116;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(117, 116);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // ResolucionCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.panelDerrogadoPor);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ResolucionCard";
            this.Size = new System.Drawing.Size(483, 208);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.panelDerrogadoPor.ResumeLayout(false);
            this.panelDerrogadoPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }                     
    }
}
