using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmPasiflestirme : Form
	{
		public FrmPasiflestirme()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			int x = int.Parse(TxtID.Text);
			var deger = db.tblGorevler.Find(x);
			deger.Durum = false;
			db.SaveChanges();
			this.Close();
			XtraMessageBox.Show("Görev Kaydı Başarılı Bir Şekilde Sonlandırıldı", "Bilgi");
			FrmGorevListesi fr = Application.OpenForms["FrmGorevListesi"] as FrmGorevListesi;
			if (fr != null)
			{
				fr.RefreshData();
			}
		}

	}
}
