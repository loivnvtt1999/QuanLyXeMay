namespace GUI
{
    partial class frmManHinhChinhNhanVienBanHang
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
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblChao = new System.Windows.Forms.Label();
            this.pnlGiaoDien = new System.Windows.Forms.Panel();
            this.mnusChucNang = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(1091, 3);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(0, 22);
            this.lblTenNV.TabIndex = 9;
            // 
            // lblChao
            // 
            this.lblChao.AutoSize = true;
            this.lblChao.Location = new System.Drawing.Point(982, 3);
            this.lblChao.Name = "lblChao";
            this.lblChao.Size = new System.Drawing.Size(92, 22);
            this.lblChao.TabIndex = 10;
            this.lblChao.Text = "Xin chào: ";
            // 
            // pnlGiaoDien
            // 
            this.pnlGiaoDien.Location = new System.Drawing.Point(0, 28);
            this.pnlGiaoDien.Name = "pnlGiaoDien";
            this.pnlGiaoDien.Size = new System.Drawing.Size(1386, 716);
            this.pnlGiaoDien.TabIndex = 8;
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
            this.mnusChucNang.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.mnusChucNang.Size = new System.Drawing.Size(386, 30);
            this.mnusChucNang.TabIndex = 7;
            this.mnusChucNang.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoHợpĐồngToolStripMenuItem,
            this.tạoHóaĐơnToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tạoHợpĐồngToolStripMenuItem
            // 
            this.tạoHợpĐồngToolStripMenuItem.Name = "tạoHợpĐồngToolStripMenuItem";
            this.tạoHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.tạoHợpĐồngToolStripMenuItem.Text = "Tạo hợp đồng";
            this.tạoHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.tạoHợpĐồngToolStripMenuItem_Click);
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            this.tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            this.tạoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.tạoHóaĐơnToolStripMenuItem.Text = "Tạo hóa đơn";
            this.tạoHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.tạoHóaĐơnToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.trợGiúpToolStripMenuItem.Text = "Thông tin";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmManHinhChinhNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 745);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblChao);
            this.Controls.Add(this.pnlGiaoDien);
            this.Controls.Add(this.mnusChucNang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManHinhChinhNhanVienBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManHinhChinhNhanVienBanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinhNhanVienBanHang_FormClosing);
            this.Load += new System.EventHandler(this.frmManHinhChinhNhanVienBanHang_Load);
            this.mnusChucNang.ResumeLayout(false);
            this.mnusChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblChao;
        private System.Windows.Forms.Panel pnlGiaoDien;
        private System.Windows.Forms.MenuStrip mnusChucNang;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
    }
}