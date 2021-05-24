namespace GUI
{
    partial class frmManHinhChinhQuanLy
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
            this.mnusChucNang = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuXuấtXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGiaoDien = new System.Windows.Forms.Panel();
            this.lblChao = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.mnusChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusChucNang
            // 
            this.mnusChucNang.Dock = System.Windows.Forms.DockStyle.None;
            this.mnusChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnusChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mnusChucNang.Location = new System.Drawing.Point(0, 0);
            this.mnusChucNang.Name = "mnusChucNang";
            this.mnusChucNang.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnusChucNang.Size = new System.Drawing.Size(445, 30);
            this.mnusChucNang.TabIndex = 0;
            this.mnusChucNang.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.tạoHợpĐồngToolStripMenuItem,
            this.taToolStripMenuItem,
            this.thoonToolStripMenuItem,
            this.quảnLýNhậpXuấtToolStripMenuItem,
            this.lậpPhiếuXuấtXeToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Image = global::GUI.Properties.Resources.quan_ly;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::GUI.Properties.Resources.employees;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // tạoHợpĐồngToolStripMenuItem
            // 
            this.tạoHợpĐồngToolStripMenuItem.Image = global::GUI.Properties.Resources.thong_ke_kh;
            this.tạoHợpĐồngToolStripMenuItem.Name = "tạoHợpĐồngToolStripMenuItem";
            this.tạoHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tạoHợpĐồngToolStripMenuItem.Text = "Tạo hợp đồng";
            this.tạoHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.tạoHợpĐồngToolStripMenuItem_Click);
            // 
            // taToolStripMenuItem
            // 
            this.taToolStripMenuItem.Image = global::GUI.Properties.Resources.hoa_don;
            this.taToolStripMenuItem.Name = "taToolStripMenuItem";
            this.taToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.taToolStripMenuItem.Text = "Tạo hóa đơn";
            this.taToolStripMenuItem.Click += new System.EventHandler(this.taToolStripMenuItem_Click);
            // 
            // thoonToolStripMenuItem
            // 
            this.thoonToolStripMenuItem.Image = global::GUI.Properties.Resources.doanh_thu;
            this.thoonToolStripMenuItem.Name = "thoonToolStripMenuItem";
            this.thoonToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.thoonToolStripMenuItem.Text = "Thống kê hóa đơn";
            this.thoonToolStripMenuItem.Click += new System.EventHandler(this.thoonToolStripMenuItem_Click);
            // 
            // quảnLýNhậpXuấtToolStripMenuItem
            // 
            this.quảnLýNhậpXuấtToolStripMenuItem.Image = global::GUI.Properties.Resources.add_chi_tiet;
            this.quảnLýNhậpXuấtToolStripMenuItem.Name = "quảnLýNhậpXuấtToolStripMenuItem";
            this.quảnLýNhậpXuấtToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.quảnLýNhậpXuấtToolStripMenuItem.Text = "Lập phiếu nhập xe";
            this.quảnLýNhậpXuấtToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhậpXuấtToolStripMenuItem_Click);
            // 
            // lậpPhiếuXuấtXeToolStripMenuItem
            // 
            this.lậpPhiếuXuấtXeToolStripMenuItem.Image = global::GUI.Properties.Resources.mua_ban;
            this.lậpPhiếuXuấtXeToolStripMenuItem.Name = "lậpPhiếuXuấtXeToolStripMenuItem";
            this.lậpPhiếuXuấtXeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.lậpPhiếuXuấtXeToolStripMenuItem.Text = "Lập phiếu xuất xe";
            this.lậpPhiếuXuấtXeToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuXuấtXeToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Image = global::GUI.Properties.Resources.taiKhoan;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::GUI.Properties.Resources.information1;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::GUI.Properties.Resources.log_out;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Image = global::GUI.Properties.Resources.information;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.trợGiúpToolStripMenuItem.Text = "Thông tin";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pnlGiaoDien
            // 
            this.pnlGiaoDien.Location = new System.Drawing.Point(0, 28);
            this.pnlGiaoDien.Name = "pnlGiaoDien";
            this.pnlGiaoDien.Size = new System.Drawing.Size(1512, 814);
            this.pnlGiaoDien.TabIndex = 1;
            // 
            // lblChao
            // 
            this.lblChao.AutoSize = true;
            this.lblChao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChao.Location = new System.Drawing.Point(983, 4);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(92, 22);
            this.lblChao.TabIndex = 2;
            this.lblChao.Text = "Xin chào: ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(1090, 4);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(0, 22);
            this.lblTenNV.TabIndex = 2;
            // 
            // frmManHinhChinhQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 846);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblChao);
            this.Controls.Add(this.pnlGiaoDien);
            this.Controls.Add(this.mnusChucNang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnusChucNang;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManHinhChinhQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhom15_DHKTPM13A_DeTai7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinhQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.frmManHinhChinhQuanLy_Load);
            this.mnusChucNang.ResumeLayout(false);
            this.mnusChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusChucNang;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGiaoDien;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuXuấtXeToolStripMenuItem;
    }
}