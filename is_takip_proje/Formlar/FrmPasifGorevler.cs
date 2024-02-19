using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmPasifGorevler : Form
	{
		public FrmPasifGorevler()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db=new DbisTAKİPEntities1();
		private void FrmPasifGorevler_Load(object sender, EventArgs e)
		{

			var degerler = (from x in db.tblGorevler
							select new
							{
								x.ID,
								x.Tarih,
								x.Aciklama,
								x.GorevAlan,

							}).ToList();
			gridControl2.DataSource = degerler;
			gridControl2.DataSource = db.tblGorevler.Where(x => x.Durum == false).ToList();
		}
	}
}
