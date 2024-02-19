using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmCagriListesi : Form
	{
		public FrmCagriListesi()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db=new DbisTAKİPEntities1();
		public string mail2;
		private void FrmCagriListesi_Load(object sender, EventArgs e)
		{
			var personelid = db.tblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
			gridControl1.DataSource=(from x in db.tblCagrilar select new
			{
				x.ID,
				x.CagriFirma,
				x.tblFirmalar.Ad,
				x.tblFirmalar.Telefon,
				x.tblFirmalar.mail,
				x.Aciklama,
				x.CagriPersonel,
				x.Durum
			}).Where(x=>x.Durum==true && x.CagriPersonel==personelid ).ToList();
			gridView1.Columns["CagriPersonel"].Visible=false;
			gridView1.Columns["CagriFirma"].Visible = false;
		}
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmCagriDetayGirisi fr=new FrmCagriDetayGirisi();
			fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
			fr.Show();
		}
	}
}
