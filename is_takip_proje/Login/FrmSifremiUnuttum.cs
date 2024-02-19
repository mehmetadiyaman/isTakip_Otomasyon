using is_takip_proje.Entity;
using System;
using System.Windows.Forms;
namespace is_takip_proje.Login
{
	public partial class FrmSifremiUnuttum : Form
	{
		DbisTAKİPEntities1 db = new DbisTAKİPEntities1();
		SifreTazele s;

		public FrmSifremiUnuttum()
		{
			InitializeComponent();
			s = new SifreTazele(this);
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				TxtSifre.Properties.UseSystemPasswordChar = false;
			}
			else
			{
				TxtSifre.Properties.UseSystemPasswordChar = true;
			}
		}
		private void BtnGonder_Click(object sender, EventArgs e)
		{
			s.Microsoft(TxtMail.Text, TxtSifre.Text, TxtMail.Text);

		}
	}
}
