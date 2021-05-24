namespace GUI
{
    partial class frmThongKeSoLuongVaDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.collapsibleSplitContainer1 = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.cbNamThongKe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.collapsibleSplitContainer2 = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.chartTien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartDoanhThu = new DevComponents.DotNetBar.Charts.ChartControl();
            this.chartSLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartSoLuong = new DevComponents.DotNetBar.Charts.ChartControl();
            this.btnChiTiet = new DevComponents.DotNetBar.ButtonX();
            this.btnXemThongTin = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer1)).BeginInit();
            this.collapsibleSplitContainer1.Panel1.SuspendLayout();
            this.collapsibleSplitContainer1.Panel2.SuspendLayout();
            this.collapsibleSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer2)).BeginInit();
            this.collapsibleSplitContainer2.Panel1.SuspendLayout();
            this.collapsibleSplitContainer2.Panel2.SuspendLayout();
            this.collapsibleSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // collapsibleSplitContainer1
            // 
            this.collapsibleSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapsibleSplitContainer1.Location = new System.Drawing.Point(5, 1);
            this.collapsibleSplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.collapsibleSplitContainer1.Name = "collapsibleSplitContainer1";
            // 
            // collapsibleSplitContainer1.Panel1
            // 
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.btnChiTiet);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.cbNamThongKe);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.btnXemThongTin);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.label1);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            // 
            // collapsibleSplitContainer1.Panel2
            // 
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.collapsibleSplitContainer2);
            this.collapsibleSplitContainer1.Size = new System.Drawing.Size(1245, 576);
            this.collapsibleSplitContainer1.SplitterDistance = 604;
            this.collapsibleSplitContainer1.SplitterWidth = 28;
            this.collapsibleSplitContainer1.TabIndex = 0;
            // 
            // cbNamThongKe
            // 
            this.cbNamThongKe.DisplayMember = "Text";
            this.cbNamThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNamThongKe.FormattingEnabled = true;
            this.cbNamThongKe.ItemHeight = 25;
            this.cbNamThongKe.Location = new System.Drawing.Point(145, 26);
            this.cbNamThongKe.Name = "cbNamThongKe";
            this.cbNamThongKe.Size = new System.Drawing.Size(140, 31);
            this.cbNamThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNamThongKe.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm thống kê";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 76);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.Size = new System.Drawing.Size(604, 500);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewX1_RowStateChanged);
            // 
            // collapsibleSplitContainer2
            // 
            this.collapsibleSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapsibleSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.collapsibleSplitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.collapsibleSplitContainer2.Name = "collapsibleSplitContainer2";
            this.collapsibleSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // collapsibleSplitContainer2.Panel1
            // 
            this.collapsibleSplitContainer2.Panel1.Controls.Add(this.chartTien);
            this.collapsibleSplitContainer2.Panel1.Controls.Add(this.ChartDoanhThu);
            // 
            // collapsibleSplitContainer2.Panel2
            // 
            this.collapsibleSplitContainer2.Panel2.Controls.Add(this.chartSLuong);
            this.collapsibleSplitContainer2.Panel2.Controls.Add(this.ChartSoLuong);
            this.collapsibleSplitContainer2.Size = new System.Drawing.Size(613, 576);
            this.collapsibleSplitContainer2.SplitterDistance = 249;
            this.collapsibleSplitContainer2.SplitterWidth = 28;
            this.collapsibleSplitContainer2.TabIndex = 0;
            // 
            // chartTien
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTien.ChartAreas.Add(chartArea3);
            this.chartTien.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartTien.Legends.Add(legend3);
            this.chartTien.Location = new System.Drawing.Point(0, 0);
            this.chartTien.Name = "chartTien";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Doanh Thu (VNĐ)";
            series3.Name = "chartTien";
            this.chartTien.Series.Add(series3);
            this.chartTien.Size = new System.Drawing.Size(613, 249);
            this.chartTien.TabIndex = 1;
            this.chartTien.Text = "chart1";
            title3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Red;
            title3.Name = "Title1";
            title3.Text = "BIỂU ĐỒ CỘT DOANH THU";
            this.chartTien.Titles.Add(title3);
            // 
            // ChartDoanhThu
            // 
            this.ChartDoanhThu.ChartPanel.Legend.Visible = false;
            this.ChartDoanhThu.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ChartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            this.ChartDoanhThu.Size = new System.Drawing.Size(250, 250);
            this.ChartDoanhThu.TabIndex = 2;
            // 
            // chartSLuong
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSLuong.ChartAreas.Add(chartArea4);
            this.chartSLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartSLuong.Legends.Add(legend4);
            this.chartSLuong.Location = new System.Drawing.Point(0, 0);
            this.chartSLuong.Name = "chartSLuong";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.LegendText = "Số lượng (chiếc)";
            series4.Name = "chartSLuong";
            this.chartSLuong.Series.Add(series4);
            this.chartSLuong.Size = new System.Drawing.Size(613, 299);
            this.chartSLuong.TabIndex = 1;
            this.chartSLuong.Text = "chart2";
            title4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Red;
            title4.Name = "Title1";
            title4.Text = "BIỂU ĐỒ CỘT SỐ LƯỢNG";
            this.chartSLuong.Titles.Add(title4);
            // 
            // ChartSoLuong
            // 
            this.ChartSoLuong.ChartPanel.Legend.Visible = false;
            this.ChartSoLuong.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ChartSoLuong.Location = new System.Drawing.Point(0, 0);
            this.ChartSoLuong.Name = "ChartSoLuong";
            this.ChartSoLuong.Size = new System.Drawing.Size(250, 250);
            this.ChartSoLuong.TabIndex = 2;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChiTiet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChiTiet.Image = global::GUI.Properties.Resources.chi_tiet;
            this.btnChiTiet.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnChiTiet.Location = new System.Drawing.Point(440, 12);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(151, 55);
            this.btnChiTiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChiTiet.TabIndex = 9;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemThongTin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXemThongTin.Image = global::GUI.Properties.Resources.tim_Kiem;
            this.btnXemThongTin.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXemThongTin.Location = new System.Drawing.Point(297, 12);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(137, 55);
            this.btnXemThongTin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXemThongTin.TabIndex = 3;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // frmThongKeSoLuongVaDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 579);
            this.Controls.Add(this.collapsibleSplitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmThongKeSoLuongVaDoanhThu";
            this.Text = "frmThongKeSoLuongVaDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeSoLuongVaDoanhThu_Load);
            this.collapsibleSplitContainer1.Panel1.ResumeLayout(false);
            this.collapsibleSplitContainer1.Panel1.PerformLayout();
            this.collapsibleSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer1)).EndInit();
            this.collapsibleSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.collapsibleSplitContainer2.Panel1.ResumeLayout(false);
            this.collapsibleSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer2)).EndInit();
            this.collapsibleSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer collapsibleSplitContainer1;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer collapsibleSplitContainer2;
        private DevComponents.DotNetBar.ButtonX btnXemThongTin;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNamThongKe;
        private DevComponents.DotNetBar.Charts.ChartControl ChartDoanhThu;
        private DevComponents.DotNetBar.Charts.ChartControl ChartSoLuong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTien;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLuong;
        private DevComponents.DotNetBar.ButtonX btnChiTiet;
    }
}