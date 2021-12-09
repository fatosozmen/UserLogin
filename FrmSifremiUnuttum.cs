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
    public partial class FrmSifremiUnuttum : Form
    {
        UserManager userManager;      
        public int userId;
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
            userManager = UserManager.GetInstance();

        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            grpBox.Visible = false;
            txtGizliSoru.Text = userManager.GetQuestionByUserId(userId);
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text == userManager.GetAnswerByUserId(userId))
            {
                grpBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Cevap hatalı.");
            }
            
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text==txtYeniSifreTekrar.Text)
            {
                MessageBox.Show(userManager.UpdatePassword(userId,txtYeniSifre.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
            }
            string userName = userManager.GetUserNameByUserId(userId);
            FrmLogin frm = (FrmLogin)Application.OpenForms["frmLogin"];
            frm.txtKullaniciAdi.Text = userName;
            frm.txtKullaniciAdi.Enabled = false;
            Close();

        }
        

    }
}
