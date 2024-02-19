namespace is_takip_proje.Formlar
{
    partial class FrmGorevListesi
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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGorevListesi));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.LblAktif = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.LblToplam = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
			this.LblPasif = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
			this.panelControl9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightGray;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.chartControl1);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Controls.Add(this.panelControl9);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1072, 473);
			this.panelControl1.TabIndex = 7;
			// 
			// chartControl1
			// 
			this.chartControl1.AppearanceNameSerializable = "Chameleon";
			this.chartControl1.BackColor = System.Drawing.Color.LightGray;
			this.chartControl1.BorderOptions.Color = System.Drawing.Color.LightGray;
			simpleDiagram3D1.RotationMatrixSerializable = "0.996031272360506;0.0768636816346596;-0.0448740339782623;0;0.0742185574534009;-0." +
    "995559532329645;-0.0579035691224823;0;-0.0491254537836842;0.0543432795582991;-0." +
    "997313139268405;0;0;0;0;1";
			this.chartControl1.Diagram = simpleDiagram3D1;
			this.chartControl1.Legend.LegendID = -1;
			this.chartControl1.Location = new System.Drawing.Point(416, 154);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.PaletteName = "Chameleon";
			series1.Name = "Durum";
			series1.SeriesID = 11;
			series1.View = pie3DSeriesView1;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(655, 319);
			this.chartControl1.TabIndex = 20;
			// 
			// panelControl2
			// 
			this.panelControl2.Appearance.BackColor = System.Drawing.Color.RosyBrown;
			this.panelControl2.Appearance.Options.UseBackColor = true;
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.LblAktif);
			this.panelControl2.Controls.Add(this.pictureEdit2);
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Location = new System.Drawing.Point(649, 0);
			this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(216, 158);
			this.panelControl2.TabIndex = 19;
			// 
			// LblAktif
			// 
			this.LblAktif.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
			this.LblAktif.Appearance.Options.UseFont = true;
			this.LblAktif.Location = new System.Drawing.Point(97, 62);
			this.LblAktif.Name = "LblAktif";
			this.LblAktif.Size = new System.Drawing.Size(16, 36);
			this.LblAktif.TabIndex = 3;
			this.LblAktif.Text = "0";
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(154, 36);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.RosyBrown;
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit2.Size = new System.Drawing.Size(45, 30);
			this.pictureEdit2.TabIndex = 2;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(27, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(152, 21);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Aktif Görev Sayısı";
			// 
			// panelControl3
			// 
			this.panelControl3.Appearance.BackColor = System.Drawing.Color.Moccasin;
			this.panelControl3.Appearance.Options.UseBackColor = true;
			this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl3.Controls.Add(this.LblToplam);
			this.panelControl3.Controls.Add(this.pictureEdit1);
			this.panelControl3.Controls.Add(this.labelControl1);
			this.panelControl3.Location = new System.Drawing.Point(416, 0);
			this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(235, 158);
			this.panelControl3.TabIndex = 19;
			// 
			// LblToplam
			// 
			this.LblToplam.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblToplam.Appearance.Options.UseFont = true;
			this.LblToplam.Location = new System.Drawing.Point(99, 62);
			this.LblToplam.Name = "LblToplam";
			this.LblToplam.Size = new System.Drawing.Size(16, 36);
			this.LblToplam.TabIndex = 2;
			this.LblToplam.Text = "0";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(153, 41);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(45, 30);
			this.pictureEdit1.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(21, 13);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(163, 21);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Toplam Departman";
			// 
			// panelControl9
			// 
			this.panelControl9.Appearance.BackColor = System.Drawing.Color.DarkMagenta;
			this.panelControl9.Appearance.Options.UseBackColor = true;
			this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl9.Controls.Add(this.LblPasif);
			this.panelControl9.Controls.Add(this.pictureEdit3);
			this.panelControl9.Controls.Add(this.labelControl3);
			this.panelControl9.Location = new System.Drawing.Point(854, 0);
			this.panelControl9.LookAndFeel.UseDefaultLookAndFeel = false;
			this.panelControl9.Name = "panelControl9";
			this.panelControl9.Size = new System.Drawing.Size(226, 158);
			this.panelControl9.TabIndex = 19;
			// 
			// LblPasif
			// 
			this.LblPasif.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
			this.LblPasif.Appearance.Options.UseFont = true;
			this.LblPasif.Location = new System.Drawing.Point(103, 62);
			this.LblPasif.Name = "LblPasif";
			this.LblPasif.Size = new System.Drawing.Size(16, 36);
			this.LblPasif.TabIndex = 3;
			this.LblPasif.Text = "0";
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(154, 38);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.DarkMagenta;
			this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit3.Size = new System.Drawing.Size(45, 30);
			this.pictureEdit3.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(32, 12);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(153, 21);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Pasif Görev Sayısı";
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(416, 473);
			this.gridControl1.TabIndex = 7;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
			this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
			// 
			// gridView1
			// 
			this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			// 
			// FrmGorevListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1072, 473);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmGorevListesi";
			this.Text = "Görev Listesi";
			this.Load += new System.EventHandler(this.FrmGorevListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			this.panelControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
			this.panelControl9.ResumeLayout(false);
			this.panelControl9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl LblAktif;
        private DevExpress.XtraEditors.LabelControl LblToplam;
        private DevExpress.XtraEditors.LabelControl LblPasif;
    }
}