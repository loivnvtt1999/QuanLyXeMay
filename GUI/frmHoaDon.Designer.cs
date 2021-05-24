namespace GUI
{
    partial class frmHoaDon
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
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.tbxSoDienThoaiKhachHang = new System.Windows.Forms.TextBox();
            this.tbxMaKhachHang = new System.Windows.Forms.TextBox();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSoDienThoaiKhachHang = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.tbxMaNhanVien = new System.Windows.Forms.TextBox();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.grpHoaDon = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.tbxTien = new System.Windows.Forms.TextBox();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblTongThue = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.tbxThue = new System.Windows.Forms.TextBox();
            this.tbxTongThue = new System.Windows.Forms.TextBox();
            this.tbxTienThua = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.grpDSHopDong = new System.Windows.Forms.GroupBox();
            this.dgvDSHopDong = new System.Windows.Forms.DataGridView();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.tbxMaHD = new System.Windows.Forms.TextBox();
            this.grpKhachHang.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            this.grpHoaDon.SuspendLayout();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.grpDSHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.tbxSoDienThoaiKhachHang);
            this.grpKhachHang.Controls.Add(this.tbxMaKhachHang);
            this.grpKhachHang.Controls.Add(this.tbxCMND);
            this.grpKhachHang.Controls.Add(this.tbxTenKhachHang);
            this.grpKhachHang.Controls.Add(this.lblCMND);
            this.grpKhachHang.Controls.Add(this.lblTenKhachHang);
            this.grpKhachHang.Controls.Add(this.lblSoDienThoaiKhachHang);
            this.grpKhachHang.Controls.Add(this.lblMaKhachHang);
            this.grpKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpKhachHang.Location = new System.Drawing.Point(13, 9);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(889, 136);
            this.grpKhachHang.TabIndex = 1;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Khách hàng";
            this.grpKhachHang.Enter += new System.EventHandler(this.grpKhachHang_Enter);
            // 
            // tbxSoDienThoaiKhachHang
            // 
            this.tbxSoDienThoaiKhachHang.Location = new System.Drawing.Point(147, 32);
            this.tbxSoDienThoaiKhachHang.Name = "tbxSoDienThoaiKhachHang";
            this.tbxSoDienThoaiKhachHang.Size = new System.Drawing.Size(243, 30);
            this.tbxSoDienThoaiKhachHang.TabIndex = 2;
            this.tbxSoDienThoaiKhachHang.Leave += new System.EventHandler(this.tbxSoDienThoaiKhachHang_Leave);
            // 
            // tbxMaKhachHang
            // 
            this.tbxMaKhachHang.Enabled = false;
            this.tbxMaKhachHang.Location = new System.Drawing.Point(578, 32);
            this.tbxMaKhachHang.Name = "tbxMaKhachHang";
            this.tbxMaKhachHang.Size = new System.Drawing.Size(285, 30);
            this.tbxMaKhachHang.TabIndex = 2;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Enabled = false;
            this.tbxCMND.Location = new System.Drawing.Point(578, 80);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(285, 30);
            this.tbxCMND.TabIndex = 2;
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Enabled = false;
            this.tbxTenKhachHang.Location = new System.Drawing.Point(147, 90);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(243, 30);
            this.tbxTenKhachHang.TabIndex = 2;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(489, 85);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(74, 22);
            this.lblCMND.TabIndex = 0;
            this.lblCMND.Text = "CMND:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(6, 90);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(137, 22);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lblSoDienThoaiKhachHang
            // 
            this.lblSoDienThoaiKhachHang.AutoSize = true;
            this.lblSoDienThoaiKhachHang.Location = new System.Drawing.Point(9, 37);
            this.lblSoDienThoaiKhachHang.Name = "lblSoDienThoaiKhachHang";
            this.lblSoDienThoaiKhachHang.Size = new System.Drawing.Size(120, 22);
            this.lblSoDienThoaiKhachHang.TabIndex = 0;
            this.lblSoDienThoaiKhachHang.Text = "Số điện thoại:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(430, 37);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(133, 22);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.lblMaNhanVien);
            this.grpNhanVien.Controls.Add(this.tbxMaNhanVien);
            this.grpNhanVien.Controls.Add(this.tbxTenNhanVien);
            this.grpNhanVien.Controls.Add(this.lblTenNhanVien);
            this.grpNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNhanVien.Location = new System.Drawing.Point(908, 9);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(558, 136);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Nhân viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(13, 37);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(122, 22);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // tbxMaNhanVien
            // 
            this.tbxMaNhanVien.Enabled = false;
            this.tbxMaNhanVien.Location = new System.Drawing.Point(171, 32);
            this.tbxMaNhanVien.Name = "tbxMaNhanVien";
            this.tbxMaNhanVien.Size = new System.Drawing.Size(370, 30);
            this.tbxMaNhanVien.TabIndex = 2;
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Enabled = false;
            this.tbxTenNhanVien.Location = new System.Drawing.Point(171, 85);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.Size = new System.Drawing.Size(370, 30);
            this.tbxTenNhanVien.TabIndex = 2;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(13, 90);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(126, 22);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // grpHoaDon
            // 
            this.grpHoaDon.Controls.Add(this.btnBack);
            this.grpHoaDon.Controls.Add(this.btnAdd);
            this.grpHoaDon.Controls.Add(this.btnLuu);
            this.grpHoaDon.Controls.Add(this.lblTien);
            this.grpHoaDon.Controls.Add(this.lblTienThua);
            this.grpHoaDon.Controls.Add(this.tbxTien);
            this.grpHoaDon.Controls.Add(this.lblThue);
            this.grpHoaDon.Controls.Add(this.lblTongThue);
            this.grpHoaDon.Controls.Add(this.lblThanhTien);
            this.grpHoaDon.Controls.Add(this.tbxThue);
            this.grpHoaDon.Controls.Add(this.tbxTongThue);
            this.grpHoaDon.Controls.Add(this.tbxTienThua);
            this.grpHoaDon.Controls.Add(this.tbxTongTien);
            this.grpHoaDon.Controls.Add(this.grpChiTiet);
            this.grpHoaDon.Controls.Add(this.grpDSHopDong);
            this.grpHoaDon.Controls.Add(this.cboTrangThai);
            this.grpHoaDon.Controls.Add(this.dtmNgayLap);
            this.grpHoaDon.Controls.Add(this.lblMaHD);
            this.grpHoaDon.Controls.Add(this.lblTrangThai);
            this.grpHoaDon.Controls.Add(this.lblNgayLap);
            this.grpHoaDon.Controls.Add(this.tbxMaHD);
            this.grpHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpHoaDon.Location = new System.Drawing.Point(13, 147);
            this.grpHoaDon.Name = "grpHoaDon";
            this.grpHoaDon.Size = new System.Drawing.Size(1453, 608);
            this.grpHoaDon.TabIndex = 1;
            this.grpHoaDon.TabStop = false;
            this.grpHoaDon.Text = "Hóa đơn";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(683, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 34);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(683, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1247, 515);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(186, 82);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(58, 572);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(168, 22);
            this.lblTien.TabIndex = 14;
            this.lblTien.Text = "Tiền khách hàng trả:";
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Location = new System.Drawing.Point(688, 572);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(103, 22);
            this.lblTienThua.TabIndex = 15;
            this.lblTienThua.Text = "Tiền trả lại:";
            // 
            // tbxTien
            // 
            this.tbxTien.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTien.Location = new System.Drawing.Point(244, 567);
            this.tbxTien.Name = "tbxTien";
            this.tbxTien.Size = new System.Drawing.Size(392, 30);
            this.tbxTien.TabIndex = 17;
            this.tbxTien.Leave += new System.EventHandler(this.tbxTien_Leave);
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(699, 215);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(55, 22);
            this.lblThue.TabIndex = 16;
            this.lblThue.Text = "Thuế:";
            // 
            // lblTongThue
            // 
            this.lblTongThue.AutoSize = true;
            this.lblTongThue.Location = new System.Drawing.Point(58, 520);
            this.lblTongThue.Name = "lblTongThue";
            this.lblTongThue.Size = new System.Drawing.Size(127, 22);
            this.lblTongThue.TabIndex = 16;
            this.lblTongThue.Text = "Tổng tiền thuế:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(688, 520);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(98, 22);
            this.lblThanhTien.TabIndex = 16;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // tbxThue
            // 
            this.tbxThue.Enabled = false;
            this.tbxThue.Location = new System.Drawing.Point(680, 253);
            this.tbxThue.Name = "tbxThue";
            this.tbxThue.Size = new System.Drawing.Size(101, 30);
            this.tbxThue.TabIndex = 19;
            // 
            // tbxTongThue
            // 
            this.tbxTongThue.Enabled = false;
            this.tbxTongThue.Location = new System.Drawing.Point(244, 515);
            this.tbxTongThue.Name = "tbxTongThue";
            this.tbxTongThue.Size = new System.Drawing.Size(392, 30);
            this.tbxTongThue.TabIndex = 19;
            // 
            // tbxTienThua
            // 
            this.tbxTienThua.Enabled = false;
            this.tbxTienThua.Location = new System.Drawing.Point(812, 567);
            this.tbxTienThua.Name = "tbxTienThua";
            this.tbxTienThua.Size = new System.Drawing.Size(380, 30);
            this.tbxTienThua.TabIndex = 18;
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Enabled = false;
            this.tbxTongTien.Location = new System.Drawing.Point(812, 515);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.Size = new System.Drawing.Size(380, 30);
            this.tbxTongTien.TabIndex = 19;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Location = new System.Drawing.Point(787, 84);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(666, 411);
            this.grpChiTiet.TabIndex = 7;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Chi tiết";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 26);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(660, 382);
            this.dgvChiTiet.TabIndex = 6;
            this.dgvChiTiet.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChiTiet_DataBindingComplete);
            this.dgvChiTiet.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvChiTiet_RowStateChanged);
            // 
            // grpDSHopDong
            // 
            this.grpDSHopDong.Controls.Add(this.dgvDSHopDong);
            this.grpDSHopDong.Location = new System.Drawing.Point(11, 84);
            this.grpDSHopDong.Name = "grpDSHopDong";
            this.grpDSHopDong.Size = new System.Drawing.Size(666, 411);
            this.grpDSHopDong.TabIndex = 6;
            this.grpDSHopDong.TabStop = false;
            this.grpDSHopDong.Text = "Danh sách hợp đồng chưa thanh toán";
            // 
            // dgvDSHopDong
            // 
            this.dgvDSHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHopDong.Location = new System.Drawing.Point(3, 26);
            this.dgvDSHopDong.Name = "dgvDSHopDong";
            this.dgvDSHopDong.RowHeadersWidth = 51;
            this.dgvDSHopDong.RowTemplate.Height = 24;
            this.dgvDSHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHopDong.Size = new System.Drawing.Size(660, 382);
            this.dgvDSHopDong.TabIndex = 0;
            this.dgvDSHopDong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSHopDong_DataBindingComplete);
            this.dgvDSHopDong.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDSHopDong_RowStateChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(1177, 29);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(256, 30);
            this.cboTrangThai.TabIndex = 5;
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.Enabled = false;
            this.dtmNgayLap.Location = new System.Drawing.Point(671, 32);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(306, 30);
            this.dtmNgayLap.TabIndex = 4;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(27, 37);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(110, 22);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(1051, 37);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(95, 22);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(552, 37);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(87, 22);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // tbxMaHD
            // 
            this.tbxMaHD.Enabled = false;
            this.tbxMaHD.Location = new System.Drawing.Point(173, 32);
            this.tbxMaHD.Name = "tbxMaHD";
            this.tbxMaHD.Size = new System.Drawing.Size(306, 30);
            this.tbxMaHD.TabIndex = 2;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 767);
            this.Controls.Add(this.grpHoaDon);
            this.Controls.Add(this.grpNhanVien);
            this.Controls.Add(this.grpKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            this.grpHoaDon.ResumeLayout(false);
            this.grpHoaDon.PerformLayout();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.grpDSHopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoDienThoaiKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.GroupBox grpHoaDon;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox tbxMaHD;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox tbxMaKhachHang;
        private System.Windows.Forms.TextBox tbxMaNhanVien;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox tbxSoDienThoaiKhachHang;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.TextBox tbxTien;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblTongThue;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox tbxThue;
        private System.Windows.Forms.TextBox tbxTongThue;
        private System.Windows.Forms.TextBox tbxTienThua;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox grpDSHopDong;
        private System.Windows.Forms.DataGridView dgvDSHopDong;
    }
}