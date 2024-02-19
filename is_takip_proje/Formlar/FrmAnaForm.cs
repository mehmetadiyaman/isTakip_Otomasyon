using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.tblGorevler
                            select new
                            {
                                Ad= x.tblPersonel.Ad + " " + x.tblPersonel.Soyad,
                                x.Aciklama,
                                x.Durum
                            }).ToList();
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.tblGorevDetaylar
                                       select new
                                       {
                                           görev = x.tblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugün).ToList();
            gridControl3.DataSource = (from x in db.tblCagrilar
                                       select new
                                       {
                                           x.tblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible=false;
            gridControl4.DataSource = (from x in db.tblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon
                                       }).ToList();
            int aktif_cağrılar = db.tblCagrilar.Where(x => x.Durum == true).Count();
            int pasif_çağrılar = db.tblCagrilar.Where(x => x.Durum == false).Count();
            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar",aktif_cağrılar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar",pasif_çağrılar);
        }
	}
}
