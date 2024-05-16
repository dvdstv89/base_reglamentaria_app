namespace BRapp.UI.Component
{
    partial class VisorDocumentacionUI
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnResolucion61 = new FontAwesome.Sharp.IconButton();
            this.lbResolucion61 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDepartamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnResolucion61);
            this.panelHeader.Controls.Add(this.lbResolucion61);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(629, 25);
            this.panelHeader.TabIndex = 25;
            // 
            // btnResolucion61
            // 
            this.btnResolucion61.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResolucion61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolucion61.ForeColor = System.Drawing.Color.White;
            this.btnResolucion61.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnResolucion61.IconColor = System.Drawing.Color.Black;
            this.btnResolucion61.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResolucion61.IconSize = 25;
            this.btnResolucion61.Location = new System.Drawing.Point(0, 0);
            this.btnResolucion61.Name = "btnResolucion61";
            this.btnResolucion61.Size = new System.Drawing.Size(38, 25);
            this.btnResolucion61.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnResolucion61, "Ver resolución 61/23");
            this.btnResolucion61.UseVisualStyleBackColor = true;
            // 
            // lbResolucion61
            // 
            this.lbResolucion61.BackColor = System.Drawing.Color.White;
            this.lbResolucion61.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbResolucion61.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbResolucion61.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResolucion61.Location = new System.Drawing.Point(40, 3);
            this.lbResolucion61.Multiline = true;
            this.lbResolucion61.Name = "lbResolucion61";
            this.lbResolucion61.ReadOnly = true;
            this.lbResolucion61.Size = new System.Drawing.Size(557, 19);
            this.lbResolucion61.TabIndex = 9;
            this.lbResolucion61.TabStop = false;
            this.lbResolucion61.Text = "Resolución 61/2023 Documentos establecidos a estar en tiendas y almacenes";
            this.lbResolucion61.TextChanged += new System.EventHandler(this.lbResolucion61_TextChanged);
            // 
            // panelDepartamentos
            // 
            this.panelDepartamentos.AutoScroll = true;
            this.panelDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDepartamentos.Location = new System.Drawing.Point(5, 5);
            this.panelDepartamentos.Name = "panelDepartamentos";
            this.panelDepartamentos.Size = new System.Drawing.Size(612, 90);
            this.panelDepartamentos.TabIndex = 26;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(10, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(180, 80);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.richTextBox1);
            this.panelText.Location = new System.Drawing.Point(55, 369);
            this.panelText.Name = "panelText";
            this.panelText.Padding = new System.Windows.Forms.Padding(10);
            this.panelText.Size = new System.Drawing.Size(200, 100);
            this.panelText.TabIndex = 28;
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.panelDepartamentos);
            this.panelCard.Location = new System.Drawing.Point(1, 31);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(5);
            this.panelCard.Size = new System.Drawing.Size(622, 100);
            this.panelCard.TabIndex = 29;
            // 
            // VisorDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 518);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisorDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentación";
            this.Load += new System.EventHandler(this.VisorDocumentacionUI_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelText.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.TextBox lbResolucion61;
        public FontAwesome.Sharp.IconButton btnResolucion61;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.FlowLayoutPanel panelDepartamentos;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel panelText;
        public System.Windows.Forms.Panel panelCard;
    }
}