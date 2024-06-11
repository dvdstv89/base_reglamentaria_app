namespace BRapp.UI
{
    partial class BienvenidaUI
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
            this.panelText = new System.Windows.Forms.Panel();
            this.bRichTextBox1 = new BRichTextBox.BRichTextBox();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.bRichTextBox1);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Padding = new System.Windows.Forms.Padding(10);
            this.panelText.Size = new System.Drawing.Size(800, 777);
            this.panelText.TabIndex = 29;
            // 
            // bRichTextBox1
            // 
            this.bRichTextBox1.AddDate = false;
            this.bRichTextBox1.AutoScroll = false;
            this.bRichTextBox1.BackColor = System.Drawing.Color.White;
            this.bRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRichTextBox1.Location = new System.Drawing.Point(10, 10);
            this.bRichTextBox1.Name = "bRichTextBox1";
            this.bRichTextBox1.Size = new System.Drawing.Size(780, 757);
            this.bRichTextBox1.TabIndex = 3;
            this.bRichTextBox1.Text = "";
            // 
            // BienvenidaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.panelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BienvenidaUI";
            this.Text = "BienvenidaUI";
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelText;
        public BRichTextBox.BRichTextBox bRichTextBox1;
    }
}