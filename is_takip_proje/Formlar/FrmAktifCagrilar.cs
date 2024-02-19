using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
	public partial class FrmAktifCagrilar : Form
	{
		public FrmAktifCagrilar()
		{
			InitializeComponent();
		}

		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();

		private void FrmAktifCagrilar_Load(object sender, EventArgs e)
		{
			var degerler = (from c in db.tblCagrilar
							join d in db.tblCagriDetay on c.ID equals d.ID into detaylar
							from detay in detaylar.DefaultIfEmpty()
							where c.Durum == true
							select new
							{
								c.ID,
								c.tblFirmalar.Ad,
								c.tblFirmalar.Telefon,
								c.Konu,
								c.Aciklama,
								personel = c.tblPersonel.Ad,
								c.Durum,
								DetayAciklama = detay != null ? detay.Aciklama : ""
							}).ToList();

			gridControl1.DataSource = degerler;
		}

		private void FrmAktifCagrilar_DoubleClick(object sender, EventArgs e)
		{
			FrmCagriAtama fr1 = new FrmCagriAtama();
			fr1.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
			fr1.Show();
		}
	}
}
