using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmCagriDetayGirisi : Form
	{
		public FrmCagriDetayGirisi()
		{
			InitializeComponent();
		}
		public int id;
		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void CagriDetayGirisi_Load(object sender, EventArgs e)
		{
			TxtCagriID.Enabled = false;
			TxtCagriID.Text = id.ToString();
			string saat, tarih;
			tarih = DateTime.Now.ToShortDateString();
			saat = DateTime.Now.ToShortTimeString();
			TxtTarih.Text = tarih;
			TxtSaat.Text = saat;
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			tblCagriDetay t = new tblCagriDetay();
			if (!int.TryParse(TxtCagriID.Text, out int cagri))
			{
				XtraMessageBox.Show("Geçersiz çağrı ID değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			t.Cagri = cagri;
			if (string.IsNullOrEmpty(TxtAciklama.Text))
			{
				XtraMessageBox.Show("Açıklama girilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			t.Aciklama = TxtAciklama.Text;
			t.Tarih = DateTime.Now.Date;
			t.saat = DateTime.Now.ToString("HH:mm:ss");
			db.tblCagriDetay.Add(t);
			db.SaveChanges();
			XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
