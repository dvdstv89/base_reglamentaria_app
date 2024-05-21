namespace BRapp.UI.Component
{
    partial class ProgressBarUI
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
            this.progressBarEstado = new System.Windows.Forms.ProgressBar();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarEstado
            // 
            this.progressBarEstado.BackColor = System.Drawing.Color.White;
            this.progressBarEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarEstado.Location = new System.Drawing.Point(0, 15);
            this.progressBarEstado.Name = "progressBarEstado";
            this.progressBarEstado.Size = new System.Drawing.Size(485, 23);
            this.progressBarEstado.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarEstado.TabIndex = 0;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMensaje.Location = new System.Drawing.Point(0, 0);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(49, 13);
            this.labelMensaje.TabIndex = 1;
            this.labelMensaje.Text = "Progreso";
            // 
            // ProgressBarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 38);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.progressBarEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBarEstado;
        public System.Windows.Forms.Label labelMensaje;
    }
}