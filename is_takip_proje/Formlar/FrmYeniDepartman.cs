using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmYeniDepartman : Form
	{
		public FrmYeniDepartman()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public async void ShowFormWithDelay()
		{
			await Task.Delay(300);
			Formlar.FrmYeniDepartman fr = new FrmYeniDepartman();
			fr.Show();
		}
		private void BtnListele_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmDepartmanlar fr = Application.OpenForms["FrmDepartmanlar"] as FrmDepartmanlar;
			fr.Listele();
			fr.Refresh();
		}
		private void BtnEkle_Click(object sender, EventArgs e)
		{
			tblDepartmanlar t = new tblDepartmanlar();
			t.Ad = TxtAd.Text;
			db.tblDepartmanlar.Add(t);
			db.SaveChanges();
			this.Hide();
			FrmDepartmanlar fr = Application.OpenForms["FrmDepartmanlar"] as FrmDepartmanlar;
			fr.Listele();
			fr.Refresh();
			XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ShowFormWithDelay();
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
			bool departmentExists = db.tblDepartmanlar.Any(d => d.ID == x);
			if (!departmentExists)
			{
				XtraMessageBox.Show("Bu ID numarasına sahip bir departman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var deger = db.tblDepartmanlar.Find(x);
			if (deger.tblPersonel.Any())
			{
				XtraMessageBox.Show("Bu Departmana bağlı Personel kayıtları bulunuyor. Departmanı silmek için önce bu kayıtları silin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			db.tblDepartmanlar.Remove(deger);
			db.SaveChanges();
			this.Hide();
			FrmDepartmanlar fr = Application.OpenForms["FrmDepartmanlar"] as FrmDepartmanlar;
			fr.Listele();
			fr.Refresh();
			XtraMessageBox.Show("Departman başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			ShowFormWithDelay();
		}
		private void BtnGüncelle_Click(object sender, EventArgs e)
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
			var deger = db.tblDepartmanlar.Find(x);
			if (deger == null)
			{
				XtraMessageBox.Show("Bu ID numarasına sahip bir departman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrEmpty(TxtAd.Text))
			{
				XtraMessageBox.Show("Lütfen geçerli bir departman adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			deger.Ad = TxtAd.Text;
			db.SaveChanges();
			this.Hide();
			FrmDepartmanlar fr = Application.OpenForms["FrmDepartmanlar"] as FrmDepartmanlar;
			fr.Listele();
			fr.Refresh();
			XtraMessageBox.Show("Departman başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ShowFormWithDelay();
		}
	}
}
