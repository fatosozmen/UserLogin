
namespace Form1
{
    partial class Hosgeldin
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
            this.lblHG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHG
            // 
            this.lblHG.AutoSize = true;
            this.lblHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHG.Location = new System.Drawing.Point(34, 43);
            this.lblHG.Name = "lblHG";
            this.lblHG.Size = new System.Drawing.Size(193, 31);
            this.lblHG.TabIndex = 0;
            this.lblHG.Text = "Hoşgeldiniz...";
            // 
            // Hosgeldin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(271, 116);
            this.Controls.Add(this.lblHG);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "Hosgeldin";
            this.Text = "Hosgeldin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHG;
    }
}