using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmAktifGorev : Form
	{
		public FrmAktifGorev()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db=new DbisTAKİPEntities1();
		public string mail2;
		private void FrmAktifGorev_Load(object sender, EventArgs e)
		{
			var personelid=db.tblPersonel.Where(x=>x.Mail==mail2).Select(y=>y.ID).FirstOrDefault();
			var degerler=(from x in db.tblGorevler select new
			{
				x.ID,
				Ad=x.tblPersonel.Ad+" "+x.tblPersonel.Soyad,
				x.Aciklama,
				x.Tarih,
				x.GorevAlan,
				x.Durum
			}).Where(x=>x.GorevAlan==personelid && x.Durum==true).ToList();
			gridControl1.DataSource = degerler;
			gridView1.Columns["GorevAlan"].Visible = false;
			gridView1.Columns["Durum"].Visible = false;
		}
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmGorevAyrıntı fr=new FrmGorevAyrıntı();
			fr.Show();
			fr.TxtID.Enabled=false;
			fr.TxtAd.Enabled=false;
			fr.TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			fr.TxtAd.Text= gridView1.GetFocusedRowCellValue("Ad").ToString();
			fr.TxtKonu.Text= gridView1.GetFocusedRowCellValue("Aciklama").ToString();	
		}
	}
}
