using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FrmLogin : Form
    {
        UserManager userManager;
        public FrmLogin()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (userManager.LoginControl(txtKullaniciAdi.Text.Trim(), txtPassword.Text.Trim()))
            {
                Hosgeldin HG = new Hosgeldin();
                Hide();
                HG.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llblYeniKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.ShowDialog();
        }

        private void linklblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Kullanıcı adını giriniz", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int userId = userManager.GetUserIdByUserName(txtKullaniciAdi.Text.Trim());
            if (userId > 0)
            {
                FrmSifremiUnuttum forgot = new FrmSifremiUnuttum();
                forgot.userId = userId;

                forgot.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }
    }
}
