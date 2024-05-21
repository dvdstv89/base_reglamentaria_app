using System.Drawing;
using System.Windows.Forms;

namespace BRapp.UI
{
    partial class DocumentoUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutDocumentos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 10);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 847);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1003, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 847);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutDocumentos
            // 
            this.flowLayoutDocumentos.AutoScroll = true;
            this.flowLayoutDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDocumentos.Location = new System.Drawing.Point(5, 10);
            this.flowLayoutDocumentos.Name = "flowLayoutDocumentos";
            this.flowLayoutDocumentos.Size = new System.Drawing.Size(998, 847);
            this.flowLayoutDocumentos.TabIndex = 7;
            // 
            // DocumentoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 857);
            this.Controls.Add(this.flowLayoutDocumentos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentoUI";
            this.Text = "DocumentoUI";
            this.ResumeLayout(false);           

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutDocumentos;


    }
}