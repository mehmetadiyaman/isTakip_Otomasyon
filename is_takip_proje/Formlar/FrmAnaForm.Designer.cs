namespace is_takip_proje.Formlar
{
    partial class FrmAnaForm
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
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
			this.gridControl4 = new DevExpress.XtraGrid.GridControl();
			this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.gridControl3 = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
			this.groupControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
			this.groupControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			this.groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.Color.Aqua;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.groupControl5);
			this.panelControl1.Controls.Add(this.groupControl3);
			this.panelControl1.Controls.Add(this.groupControl2);
			this.panelControl1.Controls.Add(this.groupControl4);
			this.panelControl1.Controls.Add(this.groupControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1072, 473);
			this.panelControl1.TabIndex = 0;
			// 
			// groupControl5
			// 
			this.groupControl5.Controls.Add(this.chartControl1);
			this.groupControl5.Location = new System.Drawing.Point(715, 221);
			this.groupControl5.Name = "groupControl5";
			this.groupControl5.Size = new System.Drawing.Size(364, 252);
			this.groupControl5.TabIndex = 9;
			this.groupControl5.Text = "Çağrı Grafiği";
			// 
			// chartControl1
			// 
			this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControl1.Legend.LegendID = -1;
			this.chartControl1.Location = new System.Drawing.Point(2, 28);
			this.chartControl1.Name = "chartControl1";
			series2.Name = "Series 1";
			series2.SeriesID = 0;
			series2.View = pieSeriesView2;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartControl1.Size = new System.Drawing.Size(360, 222);
			this.chartControl1.TabIndex = 0;
			// 
			// groupControl4
			// 
			this.groupControl4.Controls.Add(this.gridControl4);
			this.groupControl4.Location = new System.Drawing.Point(715, 0);
			this.groupControl4.Name = "groupControl4";
			this.groupControl4.Size = new System.Drawing.Size(364, 229);
			this.groupControl4.TabIndex = 8;
			this.groupControl4.Text = "Fihrist";
			// 
			// gridControl4
			// 
			this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl4.Location = new System.Drawing.Point(2, 28);
			this.gridControl4.MainView = this.gridView4;
			this.gridControl4.Name = "gridControl4";
			this.gridControl4.Size = new System.Drawing.Size(360, 199);
			this.gridControl4.TabIndex = 1;
			this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
			// 
			// gridView4
			// 
			this.gridView4.GridControl = this.gridControl4;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsView.ShowGroupPanel = false;
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.gridControl3);
			this.groupControl3.Location = new System.Drawing.Point(336, 221);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(381, 252);
			this.groupControl3.TabIndex = 7;
			this.groupControl3.Text = "Aktif Çağrı Listesi";
			// 
			// gridControl3
			// 
			this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl3.Location = new System.Drawing.Point(2, 28);
			this.gridControl3.MainView = this.gridView3;
			this.gridControl3.Name = "gridControl3";
			this.gridControl3.Size = new System.Drawing.Size(377, 222);
			this.gridControl3.TabIndex = 1;
			this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.gridControl3;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.gridControl2);
			this.groupControl2.Location = new System.Drawing.Point(336, 0);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(381, 229);
			this.groupControl2.TabIndex = 6;
			this.groupControl2.Text = "Bugün Yapılan Görevler";			
			// gridControl2
			// 
			this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl2.Location = new System.Drawing.Point(2, 28);
			this.gridControl2.MainView = this.gridView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(377, 199);
			this.gridControl2.TabIndex = 1;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl2;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.gridControl1);
			this.groupControl1.Location = new System.Drawing.Point(0, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(336, 473);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Devam Eden Görevler";
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(2, 28);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(332, 443);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// FrmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1072, 473);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmAnaForm";
			this.Text = "Ana Form";
			this.Load += new System.EventHandler(this.FrmAnaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
			this.groupControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
			this.groupControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			this.groupControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl5;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraEditors.GroupControl groupControl4;
		private DevExpress.XtraGrid.GridControl gridControl4;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraGrid.GridControl gridControl3;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}