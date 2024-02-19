using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
	public partial class FrmPasifCagrilar : Form
	{
		public FrmPasifCagrilar()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		private void FrmPasifCagrilar_Load(object sender, EventArgs e)
		{
			var degerler = (from x in db.tblCagrilar
							select new
							{
								x.ID,
								x.tblFirmalar.Ad,
								x.tblFirmalar.Telefon,
								x.Konu,
								x.Aciklama,
								personel = x.tblPersonel.Ad,
								x.Durum
							}).Where(y => y.Durum ==false).ToList();
			gridControl1.DataSource = degerler;
		}
	}
}
