using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class PersonaNaturalCard : UserControl
    {
        public Panel panelTitle;
        public Label labelName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        public TextBox textBoxLocation;
        public TextBox labelPosition;
        public TextBox labelEmail;
        public TextBox labelPhones;
        public FontAwesome.Sharp.IconButton iconButton1;
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;

        public PersonaNaturalCard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelName = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPosition = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPhones = new System.Windows.Forms.TextBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Orange;
            this.panelTitle.Controls.Add(this.iconButton1);
            this.panelTitle.Controls.Add(this.labelName);
            this.panelTitle.Controls.Add(this.iconPictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(480, 48);
            this.panelTitle.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Orange;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(453, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 24);
            this.iconButton1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.iconButton1, "Favorito");
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(50, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(430, 48);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 48);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPosition);
            this.panel3.Controls.Add(this.iconPictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 25);
            this.panel3.TabIndex = 5;
            // 
            // labelPosition
            // 
            this.labelPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosition.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(38, 0);
            this.labelPosition.Multiline = true;
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.ReadOnly = true;
            this.labelPosition.Size = new System.Drawing.Size(439, 25);
            this.labelPosition.TabIndex = 8;
            this.labelPosition.TabStop = false;
            this.labelPosition.Text = "Informatico sdf sdf sdfg sdfg sdfg sdfg sdfs";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox3.IconSize = 25;
            this.iconPictureBox3.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(38, 25);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox3.TabIndex = 7;
            this.iconPictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox3, "Cargo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelEmail);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 25);
            this.panel4.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(38, 0);
            this.labelEmail.Multiline = true;
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.ReadOnly = true;
            this.labelEmail.Size = new System.Drawing.Size(442, 25);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.TabStop = false;
            this.labelEmail.Text = "Informatico";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(38, 25);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox2, "Correo electrónico");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelPhones);
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 25);
            this.panel5.TabIndex = 7;
            // 
            // labelPhones
            // 
            this.labelPhones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPhones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelPhones.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhones.Location = new System.Drawing.Point(38, 0);
            this.labelPhones.Multiline = true;
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.ReadOnly = true;
            this.labelPhones.Size = new System.Drawing.Size(442, 25);
            this.labelPhones.TabIndex = 10;
            this.labelPhones.TabStop = false;
            this.labelPhones.Text = "Informatico";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 25;
            this.iconPictureBox4.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(38, 25);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox4.TabIndex = 7;
            this.iconPictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox4, "Números de teléfonos");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxLocation);
            this.panel6.Controls.Add(this.iconPictureBox5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 43);
            this.panel6.TabIndex = 8;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLocation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(38, 0);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(442, 43);
            this.textBoxLocation.TabIndex = 0;
            this.textBoxLocation.TabStop = false;
            this.textBoxLocation.Text = "Informatico d fsad asd asdf asdf sdf sd asda dfad fasd ";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 38;
            this.iconPictureBox5.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(38, 43);
            this.iconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox5.TabIndex = 7;
            this.iconPictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox5, "Dirección");
            // 
            // PersonaNaturalCard
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PersonaNaturalCard";
            this.Size = new System.Drawing.Size(480, 177);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }       
    }
}
