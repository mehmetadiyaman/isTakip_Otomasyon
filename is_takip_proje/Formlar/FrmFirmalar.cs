using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmFirmalar : Form
	{
		public void RefreshGridView()
		{
			gridView1.RefreshData();
		}
		public FrmFirmalar()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public void firmalar()
		{
			var degerler = (from x in db.tblFirmalar
							select new
							{
								x.ID,
								x.Ad,
								x.Yetkili,
								x.mail,
								x.Sektor,
								x.Telefon,
								x.İl,
								x.İlce,
								x.Adres
							}).ToList();
			gridControl1.DataSource = degerler;
		}
		private void FrmFirmalar_Load(object sender, EventArgs e)
		{
			firmalar();
		}
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			Formlar.FrmFirmaDuzenle fr = new FrmFirmaDuzenle();
			fr.Show();
			fr.TxtID.Enabled = false;
			fr.TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			fr.TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
			fr.TxtYetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
			fr.TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
			fr.TxtMail.Text = gridView1.GetFocusedRowCellValue("mail").ToString();
			fr.TxtSektor.Text = gridView1.GetFocusedRowCellValue("Sektor").ToString();
			fr.Txtİl.Text = gridView1.GetFocusedRowCellValue("İl").ToString();
			fr.Txtİlce.Text = gridView1.GetFocusedRowCellValue("İlce").ToString();
			fr.TxtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
		}
	}
}
