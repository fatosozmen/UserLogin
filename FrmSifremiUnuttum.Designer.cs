
namespace Form1
{
    partial class FrmSifremiUnuttum
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
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtGizliSoru = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.LblGizliSoru = new System.Windows.Forms.Label();
            this.lblYenisifre = new System.Windows.Forms.Label();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnCevap = new System.Windows.Forms.Button();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Location = new System.Drawing.Point(149, 67);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(181, 26);
            this.txtCevap.TabIndex = 9;
            // 
            // txtGizliSoru
            // 
            this.txtGizliSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGizliSoru.Location = new System.Drawing.Point(149, 23);
            this.txtGizliSoru.Name = "txtGizliSoru";
            this.txtGizliSoru.Size = new System.Drawing.Size(181, 26);
            this.txtGizliSoru.TabIndex = 10;
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.Location = new System.Drawing.Point(81, 70);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(62, 20);
            this.lblCevap.TabIndex = 7;
            this.lblCevap.Text = "Cevap :";
            // 
            // LblGizliSoru
            // 
            this.LblGizliSoru.AutoSize = true;
            this.LblGizliSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGizliSoru.Location = new System.Drawing.Point(58, 29);
            this.LblGizliSoru.Name = "LblGizliSoru";
            this.LblGizliSoru.Size = new System.Drawing.Size(85, 20);
            this.LblGizliSoru.TabIndex = 8;
            this.LblGizliSoru.Text = "Gizli Soru :";
            // 
            // lblYenisifre
            // 
            this.lblYenisifre.AutoSize = true;
            this.lblYenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYenisifre.Location = new System.Drawing.Point(43, 21);
            this.lblYenisifre.Name = "lblYenisifre";
            this.lblYenisifre.Size = new System.Drawing.Size(90, 20);
            this.lblYenisifre.TabIndex = 8;
            this.lblYenisifre.Text = "Yeni Şifre : ";
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(2, 65);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(139, 20);
            this.lblYeniSifreTekrar.TabIndex = 7;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar : ";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(139, 15);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(181, 26);
            this.txtYeniSifre.TabIndex = 10;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(139, 59);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(181, 26);
            this.txtYeniSifreTekrar.TabIndex = 9;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // btnCevap
            // 
            this.btnCevap.Location = new System.Drawing.Point(168, 113);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(139, 37);
            this.btnCevap.TabIndex = 11;
            this.btnCevap.Text = "Cevabı Kontrol Et";
            this.btnCevap.UseVisualStyleBackColor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevap_Click);
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Location = new System.Drawing.Point(158, 103);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(139, 37);
            this.btnSifreGuncelle.TabIndex = 11;
            this.btnSifreGuncelle.Text = "Şifreyi Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblYenisifre);
            this.grpBox.Controls.Add(this.btnSifreGuncelle);
            this.grpBox.Controls.Add(this.lblYeniSifreTekrar);
            this.grpBox.Controls.Add(this.txtYeniSifre);
            this.grpBox.Controls.Add(this.txtYeniSifreTekrar);
            this.grpBox.Location = new System.Drawing.Point(12, 156);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(332, 153);
            this.grpBox.TabIndex = 12;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Şifre İşlemleri";
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(404, 375);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnCevap);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtGizliSoru);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.LblGizliSoru);
            this.Name = "FrmSifremiUnuttum";
            this.Text = "Şifre Yenileme Formu";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtGizliSoru;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label LblGizliSoru;
        private System.Windows.Forms.Label lblYenisifre;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Button btnCevap;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.GroupBox grpBox;
    }
}