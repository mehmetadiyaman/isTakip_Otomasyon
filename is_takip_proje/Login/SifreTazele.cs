using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using is_takip_proje.Entity;
using DevExpress.XtraEditors;
using System.Windows.Forms;
namespace is_takip_proje.Login
{
	public class SifreTazele
	{
		private FrmSifremiUnuttum _frmSifremiUnuttum;
		DbisTAKİPEntities1 db=new DbisTAKİPEntities1();
		public SifreTazele(FrmSifremiUnuttum frmSifremiUnuttum)
		{
			_frmSifremiUnuttum = frmSifremiUnuttum;
		}
		public void Microsoft(string GondericiMail, string GondericiPass, string AliciMail)
		{
			try
			{
				// Giriş kontrolleri
				if (string.IsNullOrWhiteSpace(GondericiMail) || string.IsNullOrWhiteSpace(GondericiPass) || string.IsNullOrWhiteSpace(AliciMail))
				{
					throw new Exception("Hata: Boş bir alan bırakılamaz.");
				}
				tblPersonel p = db.tblPersonel.FirstOrDefault(x => x.Mail == GondericiMail);
				// E-posta adresine sahip bir kullanıcı yoksa
				if (p == null)
				{
					throw new Exception("Hata: Geçersiz e-posta adresi.");
				}
				Random rnd = new Random();
				p.Sifre = rnd.Next(1000, 10000).ToString();
				db.SaveChanges();
				// Şifre kontrolü
				if (string.IsNullOrEmpty(GondericiPass))
				{
					throw new Exception("Hata: Mail şifresi boş olamaz.");
				}
				SmtpClient sc = new SmtpClient();
				sc.Port = 587;
				sc.Host = "smtp.outlook.com";
				sc.EnableSsl = true;
				// Şifre kontrolü
				sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(GondericiMail, "BAYAZID Holding");
				mail.To.Add(AliciMail);
				mail.Subject = "Şifre Sıfırlama Talebi";
				mail.IsBodyHtml = true;
				mail.Body = $@"{DateTime.Now.ToString()} Tarihinde Şifre Sıfırlama Talebinde Bulundunuz. Yeni Şifreniz: {p.Sifre}";
				sc.Send(mail);
				// Başarılı mesajı
				XtraMessageBox.Show("E-posta başarıyla gönderildi. Lütfen e-postanızı kontrol edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_frmSifremiUnuttum.Close();
			}
			catch (SmtpException smtpEx)
			{
				// SMTP hatası, mail şifresi yanlış olabilir
				if (smtpEx.Message.Contains("535"))
				{
					XtraMessageBox.Show("Hata: Mail şifresi yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					XtraMessageBox.Show($"SMTP Hatası: {smtpEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				// Diğer hata durumunda
				XtraMessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
