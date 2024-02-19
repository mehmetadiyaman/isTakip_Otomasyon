using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.Login
{
	public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
	{
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public FrmLogin()
		{
			InitializeComponent();
		}
		public static int LoggedInUserId;
		private void BtnPersonelGirisi_Click(object sender, EventArgs e)
		{
			var personelvalue = db.tblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
			if (personelvalue != null)
			{
				PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
				fr.mail = TxtKullanici.Text;
				fr.Show();
				this.Hide();
			}
			else
			{
				XtraMessageBox.Show("Kullanıcı adı veya Şifre yanlış");
			}
		}
		private void BtnAdminGirisi_Click(object sender, EventArgs e)
		{
			var adminvalue = db.tblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text && x.Admin == true).FirstOrDefault();
			if (adminvalue != null)
			{
				LoggedInUserId = adminvalue.ID;
				XtraMessageBox.Show("Hoşgeldiniz");
				Form1 fr = new Form1();
				fr.Show();
				this.Hide();
			}
			else
			{
				XtraMessageBox.Show("Kullanıcı adı veya şifre yanlış");
			}
		}
		private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
		{
			string websiteUrl = "https://localhost:44350/Login/Index/?ReturnUrl=%2fDefault%2fIndex";
			System.Diagnostics.Process.Start(websiteUrl);
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				TxtSifre.Properties.UseSystemPasswordChar = false;
			}
			else
			{
				TxtSifre.Properties.UseSystemPasswordChar = true;
			}
		}
		private void SifremiUnuttum_Click(object sender, EventArgs e)
		{
			Login.FrmSifremiUnuttum fr =new FrmSifremiUnuttum();
			fr.Show();
		}

		private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

		}
	}
}

