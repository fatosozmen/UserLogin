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
    public partial class FrmSignUp : Form
    {
        UserManager userManager;
        public FrmSignUp()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();


        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //user objesi oluştur add userla ekle

            if (txtPassword.Text.Trim() != txtSifreTekrar.Text.Trim())
            {
                MessageBox.Show("Şifreler birbiri ile uyumlu değil.");
                return;
            }
            User user = new User(txtKullaniciAdi.Text, txtPassword.Text,
                txtGizliSoru.Text, txtCevap.Text);
            MessageBox.Show(userManager.AddUser(user));
            string userName = txtKullaniciAdi.Text;
            var frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
            frmLogin.txtKullaniciAdi.Text = userName;
            frmLogin.txtKullaniciAdi.Enabled = false;
            Close(); // ya da this.Close();


        }
    }
}
