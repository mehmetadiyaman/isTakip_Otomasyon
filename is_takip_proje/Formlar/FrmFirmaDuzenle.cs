using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmFirmaDuzenle : Form
	{
		public FrmFirmaDuzenle()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public async void ShowFormWithDelay()
		{
			await Task.Delay(300);
			Formlar.FrmFirmaDuzenle fr = new Formlar.FrmFirmaDuzenle();
			fr.Show();
		}
		private void BtnListele_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			FrmFirmalar fr = Application.OpenForms["FrmPersoneller"] as FrmFirmalar;
			fr?.firmalar();
			fr?.Refresh();
		}
		private void BtnEkle_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtYetkili.Text) || string.IsNullOrWhiteSpace(TxtMail.Text) || string.IsNullOrWhiteSpace(TxtSektor.Text) || string.IsNullOrWhiteSpace(TxtTelefon.Text)
				|| string.IsNullOrWhiteSpace(Txtİl.Text) || string.IsNullOrWhiteSpace(Txtİlce.Text) || string.IsNullOrWhiteSpace(TxtAdres.Text))
			{
				XtraMessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			tblFirmalar firma = db.tblFirmalar.FirstOrDefault(f => f.ID == int.Parse(TxtID.Text));
			if (firma == null)
			{
				XtraMessageBox.Show("Belirtilen ID'ye sahip bir firma bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				firma.Ad = TxtAd.Text;
				firma.Yetkili = TxtYetkili.Text;
				firma.mail = TxtMail.Text;
				firma.Sektor = TxtSektor.Text;
				firma.Telefon = TxtTelefon.Text;
				firma.İl = Txtİl.Text;
				firma.İlce = Txtİlce.Text;
				firma.Adres = TxtAdres.Text;
				db.SaveChanges();
				this.Hide();
				FrmFirmalar fr = Application.OpenForms["FrmPersoneller"] as FrmFirmalar;
				fr?.firmalar();
				fr?.Refresh();
				XtraMessageBox.Show("Firma bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ShowFormWithDelay();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Firma güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnGüncelle_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxtID.Text))
			{
				XtraMessageBox.Show("Lütfen geçerli bir ID numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(TxtID.Text, out int x))
			{
				XtraMessageBox.Show("Lütfen geçerli bir tamsayı ID numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var deger = db.tblFirmalar.Find(x);
			if (deger == null)
			{
				XtraMessageBox.Show("Bu ID numarasına sahip bir firma bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool anyChanges = false;

			if (!string.IsNullOrEmpty(TxtAd.Text))
			{
				deger.Ad = TxtAd.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(TxtYetkili.Text))
			{
				deger.Yetkili = TxtYetkili.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(TxtSektor.Text))
			{
				deger.Sektor = TxtSektor.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(TxtMail.Text))
			{
				deger.mail = TxtMail.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(TxtTelefon.Text))
			{
				deger.Telefon = TxtTelefon.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(Txtİl.Text))
			{
				deger.İl = Txtİl.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(Txtİlce.Text))
			{
				deger.İlce = Txtİlce.Text;
				anyChanges = true;
			}

			if (!string.IsNullOrEmpty(TxtAdres.Text))
			{
				deger.Adres = TxtAdres.Text;
				anyChanges = true;
			}

			if (anyChanges)
			{
				db.SaveChanges();
				FrmFirmalar fr = Application.OpenForms["FrmFirmalar"] as FrmFirmalar;
				fr?.firmalar();
				fr?.RefreshGridView();
				this.Hide();
				XtraMessageBox.Show("Firma başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ShowFormWithDelay();
			}
			else
			{
				XtraMessageBox.Show("Güncellemek için en az bir alanı doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void BtnSil_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxtID.Text))
			{
				XtraMessageBox.Show("Lütfen geçerli bir ID numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(TxtID.Text, out int x))
			{
				XtraMessageBox.Show("Lütfen geçerli bir tamsayı ID numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var deger = db.tblFirmalar.Find(x);
			if (deger == null)
			{
				XtraMessageBox.Show("Bu IDarasına sahip bir firma bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			db.tblFirmalar.Remove(deger);
			db.SaveChanges();
			XtraMessageBox.Show("Firma başarılı bir şekilde silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

	}
}
