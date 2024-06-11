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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDepartamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelText.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
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
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(10, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
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
            this.panelCard.Location = new System.Drawing.Point(-5, 12);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(5);
            this.panelCard.Size = new System.Drawing.Size(622, 100);
            this.panelCard.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(277, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisorDocumentacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(629, 518);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisorDocumentacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentación";
            this.Load += new System.EventHandler(this.VisorDocumentacionUI_Load);
            this.panelText.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.FlowLayoutPanel panelDepartamentos;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel panelText;
        public System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button button1;
    }
}