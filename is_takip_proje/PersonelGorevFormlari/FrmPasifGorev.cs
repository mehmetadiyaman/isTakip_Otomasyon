using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmPasifGorev : Form
	{
		public FrmPasifGorev()
		{
			InitializeComponent();
		}
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		public string mail2;
		private void FrmPasifGorev_Load(object sender, EventArgs e)
		{
			var personelid = db.tblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
			var degerler = (from x in db.tblGorevler
							select new
							{
								Ad = x.tblPersonel.Ad + " " + x.tblPersonel.Soyad,
								x.Aciklama,
								x.Tarih,
								x.GorevAlan,
								x.Durum

							}).Where(x => x.GorevAlan ==personelid && x.Durum == false).ToList();
			gridControl1.DataSource = degerler;
			gridView1.Columns["GorevAlan"].Visible = false;
			gridView1.Columns["Durum"].Visible = false;
		}
	}
}
