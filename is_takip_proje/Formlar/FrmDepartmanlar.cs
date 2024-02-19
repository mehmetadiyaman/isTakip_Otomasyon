using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmDepartmanlar : Form
	{
		public FrmDepartmanlar()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public void Listele()
		{
			var degerler = (from x in db.tblDepartmanlar
							select new
							{
								x.ID,
								x.Ad

							}).ToList();
			gridControl1.DataSource = degerler;
		}
		private void FrmDepartmanlar_Load(object sender, EventArgs e)
		{
			Listele();
		}
		private void gridControl1_DoubleClick(object sender, EventArgs e)
		{
			Formlar.FrmYeniDepartman fr = new FrmYeniDepartman();
			fr.Show();
			fr.TxtID.Enabled = false;
			fr.TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			fr.TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
		}
	}
}
