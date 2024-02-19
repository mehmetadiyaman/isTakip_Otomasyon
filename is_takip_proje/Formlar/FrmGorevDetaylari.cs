using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmGorevDetaylari : Form
	{
		public FrmGorevDetaylari()
		{
			InitializeComponent();
		}
		
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void FrmGorevDetaylari_Load(object sender, EventArgs e)
		{
			var yanıt = (from x in db.tblGorevDetaylar
						 select new
						 {
							 x.ID,
							 x.Aciklama,
							 x.Tarih,
							 x.Saat,
						 }).ToList();
			gridControl1.DataSource = yanıt;
		}
	}
}
