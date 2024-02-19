using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmCagriAtama : Form
	{
		public FrmCagriAtama()
		{
			InitializeComponent();
		}
		public int id;
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void FrmCagriAtama_Load(object sender, EventArgs e)
		{
			var degerler = (from x in db.tblPersonel
							select new
							{
								x.ID,
								Adsoyad = x.Ad + " " + x.Soyad,
								x.tblDepartmanlar.Ad
							}).ToList();
			lookUpEdit1.Properties.ValueMember = "ID";
			lookUpEdit1.Properties.DisplayMember = "Adsoyad";
			lookUpEdit1.Properties.DataSource = degerler;
			TxtCagriID.Text = id.ToString();
			var gelenveri = db.tblCagrilar.Find(id);
			TxtAciklama.Text = gelenveri.Aciklama;
			dateEdit1.Text = gelenveri.Tarih.ToString();
			TxtKonu.Text = gelenveri.Konu;
		}
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			if (lookUpEdit1.EditValue == null)
			{
				XtraMessageBox.Show("Lütfen bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}
			var gelenveri = db.tblCagrilar.Find(id);
			gelenveri.Konu = TxtKonu.Text;
			gelenveri.Aciklama = TxtAciklama.Text;
			gelenveri.Tarih = Convert.ToDateTime(dateEdit1.Text);
			gelenveri.CagriPersonel = Convert.ToInt32(lookUpEdit1.EditValue); 
			db.SaveChanges();
			XtraMessageBox.Show("Çağrı Personele Başarılı Bir Şekilde İletildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		private void BtnPasifCagri_Click(object sender, EventArgs e)
		{
			int x = int.Parse(TxtCagriID.Text);
			var deger = db.tblCagrilar.Find(x);
			deger.Durum = false;
			db.SaveChanges();
			XtraMessageBox.Show("Çağrı Kaydı Başarılı Bir Şekilde Sonlandırıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
