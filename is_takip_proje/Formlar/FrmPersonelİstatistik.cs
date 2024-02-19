using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
    public partial class FrmPersonelİstatistik : Form
    {
        public FrmPersonelİstatistik()
        {
            InitializeComponent();
        }
        DbisTAKİPEntities1 db=new DbisTAKİPEntities1();
		private void FrmPersonelİstatistik_Load(object sender, EventArgs e)
		{
			LblToplamDepartman.Text = db.tblDepartmanlar.Count().ToString() ?? "0";
			LblToplamFirma.Text = db.tblFirmalar.Count().ToString() ?? "0";
			LblToplamPersonel.Text = db.tblPersonel.Count().ToString() ?? "0";
			LblAktifis.Text = db.tblGorevler.Count(x => x.Durum == true).ToString() ?? "0";
			LblPasifis.Text = db.tblGorevler.Count(x => x.Durum == false).ToString() ?? "0";
			LblSonGorev.Text = db.tblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault() ?? "";
			LblSehir.Text = db.tblFirmalar.Select(x => x.İl).Distinct().Count().ToString() ?? "0";
			LblSektor.Text = db.tblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString() ?? "0";
			DateTime bugün = DateTime.Today;
			LblBugün.Text = db.tblGorevler.Count(x => x.Tarih == bugün).ToString() ?? "0";
			var d1 = db.tblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(y => y.Count()).Select(Z => Z.Key).FirstOrDefault();
			string ayinPersoneli = db.tblPersonel.Where(x => x.ID == d1).Select(y => y.Ad + " " + y.Soyad).FirstOrDefault();
			LblAyinPersoneli.Text = ayinPersoneli ?? "";
			int? ayinDepartmaniID = db.tblDepartmanlar.Where(x => x.ID == db.tblPersonel.Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault()).Select(y => y.ID).FirstOrDefault();
			string ayinDepartmaniAdi = db.tblDepartmanlar.Where(x => x.ID == ayinDepartmaniID).Select(y => y.Ad).FirstOrDefault();
			LblAyinDepartmani.Text = ayinDepartmaniAdi ?? "";
			string sonDetay = db.tblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault()?.ToString();
			LblSonDetay.Text = sonDetay ?? "";
		}

	}
}
