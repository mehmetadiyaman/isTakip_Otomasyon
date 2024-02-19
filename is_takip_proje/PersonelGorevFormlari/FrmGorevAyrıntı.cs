using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmGorevAyrıntı : Form
	{
		public FrmGorevAyrıntı()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			var gidenveri = new tblGorevDetaylar();

			if (!int.TryParse(TxtID.Text, out int id))
			{
				XtraMessageBox.Show("Geçersiz ID değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(dateEdit1.Text) || !DateTime.TryParse(dateEdit1.Text, out DateTime tarih))
			{
				XtraMessageBox.Show("Geçersiz tarih değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(TxtAciklama.Text))
			{
				XtraMessageBox.Show("Açıklama girilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			gidenveri.Gorev = id;
			gidenveri.Tarih = tarih;
			gidenveri.Aciklama = TxtAciklama.Text;

			db.tblGorevDetaylar.Add(gidenveri);
			db.SaveChanges();

			XtraMessageBox.Show("Yanıtınız başarılı bir şekilde iletildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
