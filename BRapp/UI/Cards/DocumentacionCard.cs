using System.Windows.Forms;

namespace BRapp.UI.Cards
{
    internal partial class DocumentacionCard : UserControl
    {
        public ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        public Label lbNumero;
        public FontAwesome.Sharp.IconButton btnList;
        public Label labelName;
        public Panel panelContainer;

        public DocumentacionCard()
        {
            InitializeComponent();         
        }    

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnList = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btnList.IconColor = System.Drawing.Color.Black;
            this.btnList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnList.IconSize = 36;
            this.btnList.Location = new System.Drawing.Point(544, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(36, 33);
            this.btnList.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnList, "Ver detalles");
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.labelName);
            this.panelContainer.Controls.Add(this.btnList);
            this.panelContainer.Controls.Add(this.lbNumero);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(580, 33);
            this.panelContainer.TabIndex = 35;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(35, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(509, 33);
            this.labelName.TabIndex = 39;
            this.labelName.Text = "David Estevez Diaz";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNumero
            // 
            this.lbNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(0, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(35, 33);
            this.lbNumero.TabIndex = 35;
            this.lbNumero.Text = "99";
            this.lbNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocumentacionCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelContainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DocumentacionCard";
            this.Size = new System.Drawing.Size(580, 30);
            this.Load += new System.EventHandler(this.DepartamentoCard_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void DepartamentoCard_Load(object sender, System.EventArgs e)
        {

        }

        private void labelName_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
