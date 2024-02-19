using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Login;
namespace is_takip_proje.PersonelGorevFormlari
{
	public partial class FrmPersonelFormu : Form
	{
		public string mail;
		public FrmPersonelFormu()
		{
			InitializeComponent();
		}
		private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PersonelGorevFormlari.FrmAktifGorev fr= new
			PersonelGorevFormlari.FrmAktifGorev();
			fr.mail2 = mail;
			fr.MdiParent = this;
			fr.Show();
		}
		private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PersonelGorevFormlari.FrmPasifGorev fr = new PersonelGorevFormlari.FrmPasifGorev();
			fr.mail2 = mail;
			fr.MdiParent = this;
			fr.Show();
		}
		private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PersonelGorevFormlari.FrmCagriListesi fr1 = new
			PersonelGorevFormlari.FrmCagriListesi();
			fr1.MdiParent = this;
			fr1.mail2 = mail;
			fr1.Show();
		}
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Başarılı Bir Şekilde Çıkış Yapıldı", "", MessageBoxButtons.OK);
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

        }
    }
}
