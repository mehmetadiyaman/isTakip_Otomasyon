using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmGorevListesi : Form
	{
		public FrmGorevListesi()
		{
			InitializeComponent();
		}
		public void RefreshData()
		{
			gridControl1.DataSource = db.tblGorevler.Where(x => x.Durum == true).ToList();
			LblAktif.Text = db.tblGorevler.Where(x => x.Durum == true).Count().ToString();
			LblPasif.Text = db.tblGorevler.Where(x => x.Durum == false).Count().ToString();
			LblToplam.Text = db.tblGorevler.Count().ToString();
			chartControl1.Series["Durum"].Points.Clear();
			chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktif.Text));
			chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(LblPasif.Text));
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void FrmGorevListesi_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = (from x in db.tblGorevler
									   select new
									   {
										   x.Aciklama,
									   }).ToList();
			gridControl1.DataSource = db.tblGorevler.Where(x => x.Durum == true).ToList();
			LblAktif.Text = db.tblGorevler.Where(x => x.Durum == true).Count().ToString();
			LblPasif.Text = db.tblGorevler.Where(x => x.Durum == false).Count().ToString();
			LblToplam.Text = db.tblDepartmanlar.Count().ToString();
			chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktif.Text));
			chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(LblPasif.Text));
		}
		private void gridControl1_DoubleClick(object sender, EventArgs e)
		{
			Formlar.FrmPasiflestirme fr = new FrmPasiflestirme();
			fr.Show();
			fr.TxtGoreviAlan.Enabled = false;
			fr.TxtID.Enabled = false;
			fr.TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			fr.TxtGoreviAlan.Text = gridView1.GetFocusedRowCellValue("GorevAlan").ToString();
		}
	}
}
