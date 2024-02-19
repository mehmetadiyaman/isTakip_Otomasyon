using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Login;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmGorev : Form
	{
		public FrmGorev()
		{
			InitializeComponent();
		}
		private void FrmGorev_Load(object sender, EventArgs e)
		{
			var degerler = (from x in db.tblPersonel
							where x.Admin == false
							select new
							{
								x.ID,
								Adsoyad = x.Ad + " " + x.Soyad,
							}).ToList();
			lookUpEdit1.Properties.ValueMember = "ID";
			lookUpEdit1.Properties.DisplayMember = "Adsoyad";
			lookUpEdit1.Properties.DataSource = degerler;
		}
		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			tblGorevler t = new tblGorevler();
			if (!string.IsNullOrEmpty(TxtAciklama.Text))
			{
				t.Aciklama = TxtAciklama.Text;
			}
			else
			{
				XtraMessageBox.Show("Lütfen görev açıklamasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			t.Durum = true;
			if (lookUpEdit1.EditValue != null)
			{
				if (int.TryParse(lookUpEdit1.EditValue.ToString(), out int gorevAlan))
				{
					t.GorevAlan = gorevAlan;
				}
				else
				{
					XtraMessageBox.Show("Geçersiz görev alanı değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{
				XtraMessageBox.Show("Lütfen görev alanını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DateTime tarih;
			if (DateTime.TryParse(dateEdit1.Text, out tarih))
			{
				t.Tarih = tarih;
			}
			else
			{
				XtraMessageBox.Show("Geçiz tarih değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			t.GorevVeren = FrmLogin.LoggedInUserId;
			try
			{
				db.tblGorevler.Add(t);
				db.SaveChanges();
				this.Close();
				XtraMessageBox.Show("Görev başarılı bir şekilde tanımlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				FrmGorevListesi fr = Application.OpenForms["FrmGorevListesi"] as FrmGorevListesi;
				if (fr != null)
				{
					fr.RefreshData();
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Görev tanımlanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
