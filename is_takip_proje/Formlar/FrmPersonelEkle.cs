using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
	public partial class FrmPersonelEkle : Form
	{
		public FrmPersonelEkle()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public async void ShowFormWithDelay()
		{
			await Task.Delay(300);
			Formlar.FrmPersonelEkle fr = new Formlar.FrmPersonelEkle();
			fr.Show();
		}
		private void FrmPersonelEkle_Load(object sender, EventArgs e)
		{
			var departmanlar = (from x in db.tblDepartmanlar
								select new
								{
									x.ID,
									x.Ad,
								}).ToList();
			if (departmanlar != null && departmanlar.Count > 0)
			{
				lookUpEdit1.Properties.ValueMember = "ID";
				lookUpEdit1.Properties.DisplayMember = "Ad";
				lookUpEdit1.Properties.DataSource = departmanlar;
			}
		}
		private void BtnEkle_Click_1(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyad.Text) || string.IsNullOrWhiteSpace(TxtMail.Text) || string.IsNullOrWhiteSpace(TxtSifre.Text))
			{
				XtraMessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (lookUpEdit1.EditValue == null)
			{
				XtraMessageBox.Show("Bir departman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try
			{
				tblPersonel yeniPersonel = new tblPersonel();
				yeniPersonel.Ad = TxtAd.Text;
				yeniPersonel.Soyad = TxtSoyad.Text;
				yeniPersonel.Mail = TxtMail.Text;
				yeniPersonel.Durum = true;
				yeniPersonel.Admin = false;
				yeniPersonel.Sifre = TxtSifre.Text;
				yeniPersonel.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
				db.tblPersonel.Add(yeniPersonel);
				db.SaveChanges();
				FrmPersoneller fr = Application.OpenForms["FrmPersoneller"] as FrmPersoneller;
				fr.personeller();
				fr.Refresh();
				this.Hide();
				XtraMessageBox.Show("Yeni personel bilgisi başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ShowFormWithDelay();
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Personel ekleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void BtnListele_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmPersoneller fr = Application.OpenForms["FrmPersoneller"] as FrmPersoneller;
			fr?.personeller();
			fr?.Refresh();
		}
		private void BtnSil_Click(object sender, EventArgs e)
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
			var deger = db.tblPersonel.Find(x);
			if (deger == null)
			{
				XtraMessageBox.Show("Bu ID numarasına sahip bir personel bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			deger.Durum = false;
			db.SaveChanges();
			FrmPersoneller fr = Application.OpenForms["FrmPersoneller"] as FrmPersoneller;
			fr?.personeller();
			fr?.Refresh();
			this.Hide();
			XtraMessageBox.Show("Personel kaydı başarılı bir şekilde silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			ShowFormWithDelay();
		}
		private void BtnGüncelle_Click_1(object sender, EventArgs e)
		{

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
				var deger = db.tblPersonel.Find(x);
				if (deger == null)
				{
					XtraMessageBox.Show("Bu ID numarasına sahip bir personel bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrEmpty(lookUpEdit1.EditValue?.ToString()))
				{
					XtraMessageBox.Show("Lütfen bir departman seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				bool anyChanges = false;
				if (!string.IsNullOrEmpty(TxtAd.Text))
				{
					deger.Ad = TxtAd.Text;
					anyChanges = true;
				}
				if (!string.IsNullOrEmpty(TxtSoyad.Text))
				{
					deger.Soyad = TxtSoyad.Text;
					anyChanges = true;
				}
				if (!string.IsNullOrEmpty(TxtMail.Text))
				{
					deger.Mail = TxtMail.Text;
					anyChanges = true;
				}
				if (!string.IsNullOrEmpty(TxtSifre.Text))
				{
					deger.Sifre = TxtSifre.Text;
					anyChanges = true;
				}
				if (anyChanges)
				{
					deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
					db.SaveChanges();
					FrmPersoneller fr = Application.OpenForms["FrmPersoneller"] as FrmPersoneller;
					fr?.personeller();
					fr?.Refresh();
					this.Hide();
					XtraMessageBox.Show("Personel kaydı başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
					ShowFormWithDelay();
				}
				else
				{
					XtraMessageBox.Show("Güncellemek için en az bir alanı doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}