namespace GUI
{
    partial class frmTaoPhieuXuat
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
            this.grpThongTinPhieuXuat = new System.Windows.Forms.GroupBox();
            this.tbxSoDienThoaiKhachHang = new System.Windows.Forms.TextBox();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblSDTKhachHang = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.grpCTPhieuXuat = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dgvCTPhieuXuat = new System.Windows.Forms.DataGridView();
            this.grpHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.grpHoaDonXuat = new System.Windows.Forms.GroupBox();
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpThongTinPhieuXuat.SuspendLayout();
            this.grpCTPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).BeginInit();
            this.grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.grpHoaDonXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinPhieuXuat
            // 
            this.grpThongTinPhieuXuat.Controls.Add(this.tbxSoDienThoaiKhachHang);
            this.grpThongTinPhieuXuat.Controls.Add(this.tbxTenNhanVien);
            this.grpThongTinPhieuXuat.Controls.Add(this.dtmNgayLap);
            this.grpThongTinPhieuXuat.Controls.Add(this.lblSDTKhachHang);
            this.grpThongTinPhieuXuat.Controls.Add(this.lblTenNhanVien);
            this.grpThongTinPhieuXuat.Controls.Add(this.lblNgayLap);
            this.grpThongTinPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.grpThongTinPhieuXuat.Name = "grpThongTinPhieuXuat";
            this.grpThongTinPhieuXuat.Size = new System.Drawing.Size(1483, 74);
            this.grpThongTinPhieuXuat.TabIndex = 5;
            this.grpThongTinPhieuXuat.TabStop = false;
            this.grpThongTinPhieuXuat.Text = "Thông tin phiếu xuất";
            // 
            // tbxSoDienThoaiKhachHang
            // 
            this.tbxSoDienThoaiKhachHang.Location = new System.Drawing.Point(328, 29);
            this.tbxSoDienThoaiKhachHang.Name = "tbxSoDienThoaiKhachHang";
            this.tbxSoDienThoaiKhachHang.Size = new System.Drawing.Size(269, 30);
            this.tbxSoDienThoaiKhachHang.TabIndex = 2;
            this.tbxSoDienThoaiKhachHang.Leave += new System.EventHandler(this.tbxSoDienThoaiKhachHang_Leave);
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Enabled = false;
            this.tbxTenNhanVien.Location = new System.Drawing.Point(1179, 29);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.Size = new System.Drawing.Size(285, 30);
            this.tbxTenNhanVien.TabIndex = 2;
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.Enabled = false;
            this.dtmNgayLap.Location = new System.Drawing.Point(732, 29);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(302, 30);
            this.dtmNgayLap.TabIndex = 1;
            // 
            // lblSDTKhachHang
            // 
            this.lblSDTKhachHang.AutoSize = true;
            this.lblSDTKhachHang.Location = new System.Drawing.Point(15, 34);
            this.lblSDTKhachHang.Name = "lblSDTKhachHang";
            this.lblSDTKhachHang.Size = new System.Drawing.Size(283, 22);
            this.lblSDTKhachHang.TabIndex = 0;
            this.lblSDTKhachHang.Text = "Tìm theo số điện thoại khách hàng:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(1061, 34);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(96, 22);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Nhân viên:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(626, 34);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(86, 22);
            this.lblNgayLap.TabIndex = 0;
            this.lblNgayLap.Text = "Ngày tạo:";
            // 
            // grpCTPhieuXuat
            // 
            this.grpCTPhieuXuat.Controls.Add(this.btnXuatExcel);
            this.grpCTPhieuXuat.Controls.Add(this.dgvCTPhieuXuat);
            this.grpCTPhieuXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpCTPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpCTPhieuXuat.Location = new System.Drawing.Point(0, 391);
            this.grpCTPhieuXuat.Name = "grpCTPhieuXuat";
            this.grpCTPhieuXuat.Size = new System.Drawing.Size(1483, 376);
            this.grpCTPhieuXuat.TabIndex = 7;
            this.grpCTPhieuXuat.TabStop = false;
            this.grpCTPhieuXuat.Text = "Chi tiết phiếu xuất";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(1280, 257);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(197, 52);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất file Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dgvCTPhieuXuat
            // 
            this.dgvCTPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCTPhieuXuat.Enabled = false;
            this.dgvCTPhieuXuat.Location = new System.Drawing.Point(3, 26);
            this.dgvCTPhieuXuat.Name = "dgvCTPhieuXuat";
            this.dgvCTPhieuXuat.RowHeadersWidth = 51;
            this.dgvCTPhieuXuat.RowTemplate.Height = 24;
            this.dgvCTPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuXuat.Size = new System.Drawing.Size(1477, 225);
            this.dgvCTPhieuXuat.TabIndex = 0;
            this.dgvCTPhieuXuat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTPhieuXuat_DataBindingComplete);
            // 
            // grpHoaDon
            // 
            this.grpHoaDon.Controls.Add(this.dgvDSHoaDon);
            this.grpHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpHoaDon.Location = new System.Drawing.Point(0, 74);
            this.grpHoaDon.Name = "grpHoaDon";
            this.grpHoaDon.Size = new System.Drawing.Size(700, 317);
            this.grpHoaDon.TabIndex = 8;
            this.grpHoaDon.TabStop = false;
            this.grpHoaDon.Text = "Danh sách hóa đơn chờ xuất xe";
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(3, 26);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.RowHeadersWidth = 51;
            this.dgvDSHoaDon.RowTemplate.Height = 24;
            this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(694, 288);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSHoaDon_DataBindingComplete);
            this.dgvDSHoaDon.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDSHoaDon_RowStateChanged);
            // 
            // grpHoaDonXuat
            // 
            this.grpHoaDonXuat.Controls.Add(this.dgvXuat);
            this.grpHoaDonXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpHoaDonXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpHoaDonXuat.Location = new System.Drawing.Point(783, 74);
            this.grpHoaDonXuat.Name = "grpHoaDonXuat";
            this.grpHoaDonXuat.Size = new System.Drawing.Size(700, 317);
            this.grpHoaDonXuat.TabIndex = 9;
            this.grpHoaDonXuat.TabStop = false;
            this.grpHoaDonXuat.Text = "Danh sách hóa đơn xuất xe";
            // 
            // dgvXuat
            // 
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXuat.Location = new System.Drawing.Point(3, 26);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.RowHeadersWidth = 51;
            this.dgvXuat.RowTemplate.Height = 24;
            this.dgvXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuat.Size = new System.Drawing.Size(694, 288);
            this.dgvXuat.TabIndex = 0;
            this.dgvXuat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvXuat_DataBindingComplete);
            this.dgvXuat.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvXuat_RowStateChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(706, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(706, 264);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTaoPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 767);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpHoaDonXuat);
            this.Controls.Add(this.grpHoaDon);
            this.Controls.Add(this.grpCTPhieuXuat);
            this.Controls.Add(this.grpThongTinPhieuXuat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaoPhieuXuat";
            this.Text = "frmTaoPhieuXuat";
            this.Load += new System.EventHandler(this.frmTaoPhieuXuat_Load);
            this.grpThongTinPhieuXuat.ResumeLayout(false);
            this.grpThongTinPhieuXuat.PerformLayout();
            this.grpCTPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).EndInit();
            this.grpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.grpHoaDonXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpThongTinPhieuXuat;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.TextBox tbxSoDienThoaiKhachHang;
        private System.Windows.Forms.Label lblSDTKhachHang;
        private System.Windows.Forms.GroupBox grpCTPhieuXuat;
        private System.Windows.Forms.DataGridView dgvCTPhieuXuat;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.GroupBox grpHoaDon;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.GroupBox grpHoaDonXuat;
        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}