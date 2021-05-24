using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;
using System.IO;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        DiaChiBUS dcBUS;
        NhanVienBUS nvBUS;
        List<eNhanVien> lNV;
        OpenFileDialog ofdLoadAnh;
        frmNhapDiaChi frmDC;
        eDiaChi dc;
        eNhanVien nv;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            nvBUS = new NhanVienBUS();
            dcBUS = new DiaChiBUS();
            lNV = new List<eNhanVien>();
            ofdLoadAnh = new OpenFileDialog();
            frmDC = new frmNhapDiaChi();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            lNV = nvBUS.layDanhSachNhanVienKhongAnh();
            dgvNhanVien.DataSource = lNV;
            suaDataGridView();
            khoaTextbox();
            duaDuLieuVaoComboBoxChucVu();
            //ban đầu nút chức năng lưu, sửa, xóa, lấy ảnh, thêm địa chỉ khóa lại
            btnLayAnh.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnDiaChi.Enabled = false;
            btnDatLaiMK.Enabled = false;
            //--------------------------------------------------------------------
        }
        public void duaDuLieuVaoComboBoxChucVu()
        {
            string[] s = new string[] { "Quản Lý", "Thống Kê", "Kho", "Nhân Viên" };
            cbChucVu.DataSource = s;
        }
        void khoaTextbox()
        {
            tbxMa.Enabled = false;
            dpNgaySinh.Enabled = false;
            tbxTen.Enabled = false;
            tbxCMND.Enabled = false;
            tbxSdt.Enabled = false;
            tbxEmail.Enabled = false;
            cbChucVu.Enabled = false;
            rtbxDiaChi.Enabled = false;

        }
        void moKhoaTextbox()
        {
            tbxMa.Enabled = false;
            dpNgaySinh.Enabled = true;
            tbxTen.Enabled = true;
            tbxCMND.Enabled = true;
            tbxSdt.Enabled = true;
            tbxEmail.Enabled = true;
            cbChucVu.Enabled = true;
        }
        void suaDataGridView()
        {
            dgvNhanVien.Columns["Anh"].Visible = false;
            dgvNhanVien.Columns["matkhau"].Visible = false;
            dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["MaNhanVien"].Width = 150;
            dgvNhanVien.Columns["tennhanvien"].HeaderText = "Họ tên";
            dgvNhanVien.Columns["tennhanvien"].Width = 250;
            dgvNhanVien.Columns["cmnd"].HeaderText = "Chứng minh nhân dân";
            dgvNhanVien.Columns["cmnd"].Width = 200;
            dgvNhanVien.Columns["sodienthoainv"].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns["sodienthoainv"].Width = 176;
            dgvNhanVien.Columns["email"].HeaderText = "Email";
            dgvNhanVien.Columns["email"].Width = 300;
            dgvNhanVien.Columns["chucvu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["chucvu"].Width = 193;
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["NgaySinh"].Width = 193;
            dgvNhanVien.Columns["madiachi"].Visible = false;
        }
        public string layDiaChi(string maDC)
        {
            string diachi = "";
            eDiaChi dc = new eDiaChi();
            dc = dcBUS.LayDiaChiCoMa(maDC);
            diachi = dc.SoNha + ", " + dc.PhuongXa + ", " + dc.QuanHuyen + ", " + dc.TinhThanhPho + ", " + dc.QuocGia;
            return diachi;
        }

        private void dgvNhanVien_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                //sau khi chọn dòng thì 2 nút chức năng sửa, xóa mở ra
                btnSua.Enabled = true;
                //---------------------------------------------------------
                khoaTextbox();
                btnThem.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Text = "Thêm";
                btnLuu.Text = "Lưu";
                btnSua.Text = "Sửa";
                btnLayAnh.Enabled = false;
                btnDiaChi.Enabled = false;
                btnLuu.Enabled = false;
                btnDatLaiMK.Enabled = true;
                //---------------------------------------------------------
                nv = nvBUS.TimNhanVienTheoMa(e.Row.Cells["MaNhanVien"].Value.ToString());
                tbxMa.Text = nv.MaNhanVien;
                dpNgaySinh.Text = nv.NgaySinh.ToShortDateString();
                tbxTen.Text = nv.TenNhanVien;
                tbxCMND.Text = nv.Cmnd;
                tbxSdt.Text = nv.SoDienThoaiNV;
                tbxEmail.Text = nv.Email;
                cbChucVu.Text = nv.ChucVu;
                rtbxDiaChi.Text = layDiaChi(nv.MaDiaChi);
                if (nv.Anh == null)
                {
                    picNhanVien.Image = null;
                    return;
                }
                else
                {
                    Image img = Image.FromStream(nv.Anh);
                    picNhanVien.Image = img;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                moKhoaTextbox();
                btnLayAnh.Enabled = true;
                btnSua.Text = "Hủy";
                btnLuu.Text = "Lưu Sửa";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnDiaChi.Enabled = true;
                btnDiaChi.Text = "Sửa địa chỉ";
                btnDatLaiMK.Enabled = false;
                tbxTen.Enabled = false;
                tbxCMND.Enabled = false;
                dpNgaySinh.Enabled = false;
            }
            else
            {
                khoaTextbox();
                btnSua.Text = "Sửa";
                btnLuu.Text = "Lưu";
                btnLuu.Enabled = false;
                btnLayAnh.Enabled = false;
                btnThem.Enabled = true;
                btnDiaChi.Enabled = false;
                btnDiaChi.Text = "Thêm địa chỉ";
                btnDatLaiMK.Enabled = true;
                picNhanVien.Image = null;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Lưu Sửa"))
            {
                if (frmDC.DialogResult == DialogResult.OK)
                {
                    dcBUS.ThemDiaChi(dc);
                    eNhanVien nv = new eNhanVien();
                    nv = nvBUS.TimNhanVienTheoMa(tbxMa.Text);
                    nv.ChucVu = cbChucVu.Text;
                    nv.SoDienThoaiNV = tbxSdt.Text;
                    nv.Email = tbxEmail.Text;
                    nv.MaDiaChi = dc.MaDC;
                    if (picNhanVien.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        picNhanVien.Image.Save(stream, ImageFormat.Jpeg);
                        if (nv.Anh == null)
                            nv.Anh = new MemoryStream();
                        nv.Anh = stream;
                    }
                    else nv.Anh = null;
                    nvBUS.suaNhanVien(nv);
                    lNV = nvBUS.layDanhSachNhanVienKhongAnh();
                    dgvNhanVien.DataSource = lNV;
                    MessageBox.Show("Sửa thành công");
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.Text = "Thêm";
                    btnLuu.Text = "Lưu";
                    btnSua.Text = "Sửa";
                    btnLayAnh.Enabled = false;
                    khoaTextbox();
                }
                else
                {
                    eNhanVien nv = new eNhanVien();
                    nv = nvBUS.TimNhanVienTheoMa(tbxMa.Text);
                    nv.ChucVu = cbChucVu.Text;
                    nv.SoDienThoaiNV = tbxSdt.Text;
                    nv.Email = tbxEmail.Text;
                    if (picNhanVien.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        picNhanVien.Image.Save(stream, ImageFormat.Jpeg);
                        if (nv.Anh == null)
                            nv.Anh = new MemoryStream();
                        nv.Anh = stream;
                    }
                    else nv.Anh = null;
                    nvBUS.suaNhanVien(nv);
                    lNV = nvBUS.layDanhSachNhanVienKhongAnh();
                    dgvNhanVien.DataSource = lNV;
                    MessageBox.Show("Sửa thành công");
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.Text = "Thêm";
                    btnLuu.Text = "Lưu";
                    btnSua.Text = "Sửa";
                    btnLayAnh.Enabled = false;
                    khoaTextbox();
                }
            }
            if (btnLuu.Text.Equals("Lưu thêm"))
            {
                if (string.IsNullOrEmpty(tbxTen.Text) || string.IsNullOrEmpty(tbxCMND.Text) || string.IsNullOrEmpty(tbxSdt.Text)
                    || string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(rtbxDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dcBUS.ThemDiaChi(dc);
                    eNhanVien nv = new eNhanVien();
                    nv.MaNhanVien = nvBUS.PhatSinhMa();
                    nv.TenNhanVien = tbxTen.Text;
                    nv.MatKhau = "12345678";
                    nv.Cmnd = tbxCMND.Text;
                    nv.NgaySinh = dpNgaySinh.Value;
                    nv.ChucVu = cbChucVu.Text;
                    nv.SoDienThoaiNV = tbxSdt.Text;
                    nv.Email = tbxEmail.Text;
                    nv.MaDiaChi = dc.MaDC;
                    if (picNhanVien.Image != null)
                    {
                        MemoryStream stream = new MemoryStream();
                        picNhanVien.Image.Save(stream, ImageFormat.Jpeg);
                        if (nv.Anh == null)
                            nv.Anh = new MemoryStream();
                        nv.Anh = stream;
                    }
                    else nv.Anh = null;
                    nvBUS.themNhanVien(nv);
                    lNV = nvBUS.layDanhSachNhanVienKhongAnh();
                    dgvNhanVien.DataSource = lNV;
                    MessageBox.Show("Thêm thành công");
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.Text = "Thêm";
                    btnLuu.Text = "Lưu";
                    btnSua.Text = "Sửa";
                    btnLayAnh.Enabled = false;
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                moKhoaTextbox();
                tbxMa.Text = nvBUS.PhatSinhMa();
                tbxTen.Text = "";
                tbxCMND.Text = "";
                tbxEmail.Text = "";
                tbxSdt.Text = "";
                rtbxDiaChi.Text = "";
                btnThem.Text = "Hủy";
                btnLuu.Text = "Lưu thêm";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnLayAnh.Enabled = true;
                btnDiaChi.Enabled = true;
                btnDatLaiMK.Enabled = false;
                picNhanVien.Image = null;
            }
            else
            {
                khoaTextbox();
                btnThem.Text = "Thêm";
                btnLuu.Text = "Lưu";
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnLayAnh.Enabled = false;
                btnDiaChi.Enabled = false;
                tbxMa.Text = nv.MaNhanVien;
                dpNgaySinh.Text = nv.NgaySinh.ToShortDateString();
                tbxTen.Text = nv.TenNhanVien;
                tbxCMND.Text = nv.Cmnd;
                tbxSdt.Text = nv.SoDienThoaiNV;
                tbxEmail.Text = nv.Email;
                cbChucVu.Text = nv.ChucVu;
                rtbxDiaChi.Text = layDiaChi(nv.MaDiaChi);
                if (nv.Anh == null)
                {
                    picNhanVien.Image = null;
                    return;
                }
                else
                {
                    Image img = Image.FromStream(nv.Anh);
                    picNhanVien.Image = img;
                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Có chắc xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                eNhanVien nv = new eNhanVien();
                nv.MaNhanVien = tbxMa.Text;
                nvBUS.xoaNhanVien(nv);
                MessageBox.Show("Xóa thành công");
                lNV = nvBUS.layDanhSachNhanVienKhongAnh();
                dgvNhanVien.DataSource = lNV;
            }
        }

        private void btnDiaChi_Click(object sender, EventArgs e)
        {
            frmDC = new frmNhapDiaChi();
            frmDC.ShowDialog();
            if (frmDC.DialogResult == DialogResult.OK)
            {
                string diachi = "";
                diachi = frmDC.diaChiTamThoi.SoNha + ", " + frmDC.diaChiTamThoi.PhuongXa + ", " + frmDC.diaChiTamThoi.QuanHuyen + ", " + frmDC.diaChiTamThoi.TinhThanhPho + ", " + frmDC.diaChiTamThoi.QuocGia;
                rtbxDiaChi.Text = diachi;
                dc = frmDC.diaChiTamThoi;
            }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Có chắc đặt lại mật khẩu thành 12345678 ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                nvBUS.datLaiMatKhau(tbxMa.Text);
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
        }

        private void btnLayAnh_Click(object sender, EventArgs e)
        {
            ofdLoadAnh.ShowDialog();
            string file = ofdLoadAnh.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            picNhanVien.Image = Image.FromFile(file);
        }

        private void dgvNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNhanVien.ClearSelection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbxSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtbxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
