using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmPersoneller : Form
	{
		public FrmPersoneller()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public void personeller()
		{
			var degerler = (from x in db.tblPersonel 
							join d in db.tblDepartmanlar on x.Departman equals d.ID
							where x.Durum == true
							where x.Admin==false
							select new
							{
								x.ID,
								x.Ad,
								x.Soyad,
								x.Mail,
								Departman = d.Ad,
								x.Durum,
								x.Sifre
							}).ToList();

			gridControl1.DataSource = degerler;
			gridView1.Columns["Sifre"].Visible = false;
			
		}
		private void FrmPersoneller_Load(object sender, EventArgs e)
		{
			personeller();
		}
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			Formlar.FrmPersonelEkle fr = new FrmPersonelEkle();
			fr.Show();
			fr.TxtID.Enabled = false;
			fr.TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			fr.TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
			fr.TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
			fr.TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
			fr.lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
			fr.TxtSifre.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();

		}
	}
}
