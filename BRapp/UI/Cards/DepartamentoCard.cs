using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class DepartamentoCard : UserControl
    {
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public Label labelName;
        private Panel panel1;
        public FontAwesome.Sharp.IconButton btnList;
        public FontAwesome.Sharp.IconPictureBox iconPrincipal;

        public DepartamentoCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnList = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPrincipal
            // 
            this.iconPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPrincipal.ForeColor = System.Drawing.Color.Black;
            this.iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPrincipal.IconColor = System.Drawing.Color.Black;
            this.iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPrincipal.IconSize = 45;
            this.iconPrincipal.Location = new System.Drawing.Point(0, 0);
            this.iconPrincipal.Name = "iconPrincipal";
            this.iconPrincipal.Size = new System.Drawing.Size(45, 45);
            this.iconPrincipal.TabIndex = 6;
            this.iconPrincipal.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(45, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(427, 45);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.iconPrincipal);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 45);
            this.panel1.TabIndex = 35;
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnList.IconColor = System.Drawing.Color.Black;
            this.btnList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnList.IconSize = 36;
            this.btnList.Location = new System.Drawing.Point(436, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(36, 45);
            this.btnList.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnList, "Ver documentación");
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // DepartamentoCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DepartamentoCard";
            this.Size = new System.Drawing.Size(479, 50);
            this.Load += new System.EventHandler(this.DepartamentoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void DepartamentoCard_Load(object sender, System.EventArgs e)
        {

        }

        private void labelName_Click(object sender, System.EventArgs e)
        {

        }
    }
}
