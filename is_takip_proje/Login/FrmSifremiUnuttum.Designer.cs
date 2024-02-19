namespace is_takip_proje.Login
{
	partial class FrmSifremiUnuttum
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.BtnGonder = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.TxtMail = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.BtnGonder);
			this.panelControl1.Controls.Add(this.checkBox1);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.TxtSifre);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.TxtMail);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(455, 307);
			this.panelControl1.TabIndex = 12;
			// 
			// BtnGonder
			// 
			this.BtnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnGonder.Cursor = System.Windows.Forms.Cursors.Default;
			this.BtnGonder.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGonder.ForeColor = System.Drawing.Color.Transparent;
			this.BtnGonder.Location = new System.Drawing.Point(239, 214);
			this.BtnGonder.Name = "BtnGonder";
			this.BtnGonder.Size = new System.Drawing.Size(157, 48);
			this.BtnGonder.TabIndex = 162;
			this.BtnGonder.Text = "Gönder";
			this.BtnGonder.UseVisualStyleBackColor = false;
			this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.checkBox1.ForeColor = System.Drawing.Color.Goldenrod;
			this.checkBox1.Location = new System.Drawing.Point(327, 145);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(114, 22);
			this.checkBox1.TabIndex = 161;
			this.checkBox1.Text = "şifreyi göster";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(19, 109);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(115, 22);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Mail Şifreniz ";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(19, 137);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Properties.Appearance.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F);
			this.TxtSifre.Properties.Appearance.Options.UseFont = true;
			this.TxtSifre.Properties.UseSystemPasswordChar = true;
			this.TxtSifre.Size = new System.Drawing.Size(302, 30);
			this.TxtSifre.TabIndex = 3;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(19, 28);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(129, 22);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Mail Adresiniz ";
			// 
			// TxtMail
			// 
			this.TxtMail.Location = new System.Drawing.Point(19, 52);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F);
			this.TxtMail.Properties.Appearance.Options.UseFont = true;
			this.TxtMail.Size = new System.Drawing.Size(302, 30);
			this.TxtMail.TabIndex = 0;
			// 
			// FrmSifremiUnuttum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Goldenrod;
			this.ClientSize = new System.Drawing.Size(455, 307);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmSifremiUnuttum";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Şifremi Unuttum";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit TxtMail;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit TxtSifre;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button BtnGonder;
	}
}