using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Login;

namespace is_takip_proje
{
	public partial class Form1 : Form
    {
		public Form1()
		{
			InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }
		Formlar.FrmDepartmanlar frm;
		public void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm == null || frm.IsDisposed)
			{
				frm = new Formlar.FrmDepartmanlar();
				frm.MdiParent = this;
				frm.Show();
			}

		}
		Formlar.FrmPersoneller frm2;
		private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm2 == null || frm2.IsDisposed)
			{
				frm2 = new Formlar.FrmPersoneller();
				frm2.MdiParent = this;
				frm2.Show();
			}

		}
		Formlar.FrmPersonelİstatistik frm3;
		private void BtnPersonelİstatisitk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm3 == null || frm3.IsDisposed)
			{
				frm3 = new Formlar.FrmPersonelİstatistik();
				frm3.MdiParent = this;
				frm3.Show();
			}


		}
		Formlar.FrmGorevListesi frm4;
		private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm4 == null || frm4.IsDisposed)
			{
				frm4 = new Formlar.FrmGorevListesi();
				frm4.MdiParent = this;
				frm4.Show();
			}

		}
		private void BtnYeniGorev_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Formlar.FrmGorev fr = new Formlar.FrmGorev();
			fr.Show();
		}
		
		Formlar.FrmAnaForm frm5;
		private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm5 == null || frm5.IsDisposed)
			{
				frm5 = new Formlar.FrmAnaForm();
				frm5.MdiParent = this;
				frm5.Show();
			}
		}
		Formlar.FrmAktifCagrilar frm6;
		private void BtnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm6 == null || frm6.IsDisposed)
			{
				frm6 = new Formlar.FrmAktifCagrilar();
				frm6.MdiParent = this;
				frm6.Show();
			}

		}
		Formlar.FrmFirmalar frm7;
		private void BtnFirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm7 == null || frm7.IsDisposed)
			{
				frm7 = new Formlar.FrmFirmalar();
				frm7.MdiParent = this;
				frm7.Show();

			}
		}
		private void YeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
			fr.Show();
		}
		private void BtnPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Formlar.FrmPersonelEkle fr = new Formlar.FrmPersonelEkle();
			fr.Show();

		}
		private void BtnFirmaDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Formlar.FrmFirmaDuzenle fr = new Formlar.FrmFirmaDuzenle();
			fr.Show();
		}
		Formlar.FrmPasifGorevler frm9;
		private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm9 == null || frm9.IsDisposed)
			{
				frm9 = new Formlar.FrmPasifGorevler();
				frm9.MdiParent = this;
				frm9.Show();

			}

		}
		Formlar.FrmPasifCagrilar frm10;
		private void BtnPasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm10 == null || frm10.IsDisposed)
			{
				frm10 = new Formlar.FrmPasifCagrilar();
				frm10.MdiParent = this;
				frm10.Show();
			}
		}
		Formlar.FrmGorevDetaylari frm11;
		private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frm11 == null || frm11.IsDisposed)
			{
				frm11 = new Formlar.FrmGorevDetaylari();
				frm11.MdiParent = this;
				frm11.Show();
			}
		}
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			XtraMessageBox.Show("Başarılı Bir Şekilde Çıkış Yapıldı","" ,MessageBoxButtons.OK);
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}

