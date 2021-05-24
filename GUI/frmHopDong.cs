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

namespace GUI
{
    public partial class frmHopDong : Form
    {
        eNhanVien nv;
        KhachHangBUS khBUS;
        XeBUS xeBUS;
        NhaCungCapBUS nccBUS;
        eHopDong hopdong;
        HopDongBUS hdgBUS;
        LoaiXeBUS loaiBUS;
        HangXeBUS hangBUS;
        public frmHopDong()
        {
            InitializeComponent();
        }

        public frmHopDong(eNhanVien nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            tbxMaNhanVien.Text = nv.MaNhanVien;
            tbxTenNhanVien.Text = nv.TenNhanVien;
            khBUS = new KhachHangBUS();
            xeBUS = new XeBUS();
            nccBUS = new NhaCungCapBUS();
            hopdong = new eHopDong();
            hdgBUS = new HopDongBUS();
            loaiBUS = new LoaiXeBUS();
            hangBUS = new HangXeBUS();
            TaoMoiForm();
        }

        void TaoMoiForm()
        {
            tbxMaHDG.Text = hdgBUS.PhatSinhMa();
            SetDataCboTrangThai();
            cboTrangThai.Text = "Chưa thanh toán";
            SetAutoComplete();
            List<eKhachHang> l = khBUS.LayToanBoDanhSach();
            XuLyHoTroCboSoDienThoaiKhachHang(l);
            List<eXe> l2 = xeBUS.LayDanhSachXe();
            XuLyHoTroTbxTenXe(l2);
            tbxSoDienThoaiKhachHang.Text = "";
            tbxSoDienThoaiKhachHang.Focus();
            tbxMaKhachHang.Text = "";
            tbxTenKhachHang.Text = "";
            tbxTenXe.Text = "";
            tbxMaXe.Text = "";
            tbxCongSuat.Text = "";
            tbxDoCao.Text = "";
            tbxDungTichBinhXang.Text = "";
            tbxKhoiLuong.Text = "";
            tbxMauSac.Text = "";
            tbxPhanKhoi.Text = "";
            tbxLoaiPhanh.Text = "";
            tbxLoaiBanh.Text = "";
            tbxDuongKinhPitTong.Text = "";
            tbxNCC.Text = "";
            tbxLoaiXe.Text = "";
            tbxHangXe.Text = "";
            tbxXuatXu.Text = "";
            tbxGiaThanh.Text = "";
        }

        void SetDataCboTrangThai()
        {
            string[] str = new string[] { "Chưa thanh toán", "Đã thanh toán" };
            cboTrangThai.DataSource = str;
        }

        private void SetAutoComplete()
        {
            tbxSoDienThoaiKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxSoDienThoaiKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxTenXe.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTenXe.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void XuLyHoTroCboSoDienThoaiKhachHang(List<eKhachHang> l)
        {
            tbxSoDienThoaiKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxSoDienThoaiKhachHang.AutoCompleteCustomSource.Add(kh.SdtKH);
            }
        }

        void XuLyHoTroTbxTenXe(List<eXe> l)
        {
            tbxTenXe.AutoCompleteCustomSource.Clear();
            foreach (eXe xe in l)
            {
                tbxTenXe.AutoCompleteCustomSource.Add(xe.TenXe);
            }
        }

        private void tbxSoDienThoaiKhachHang_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSoDienThoaiKhachHang.Text))
            {
                if (tbxSoDienThoaiKhachHang.Text.Length == 10)
                {
                    eKhachHang kh = khBUS.LayKhachHangTheoSDT(tbxSoDienThoaiKhachHang.Text);
                    if (kh != null)
                    {
                        tbxTenKhachHang.Text = kh.TenKH;
                        tbxMaKhachHang.Text = kh.MaKH;
                        tbxTenXe.Focus();
                    }
                }
            }
        }

        private void tbxTenXe_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxTenXe.Text))
            {
                eXe xe = xeBUS.LayXeTheoTen(tbxTenXe.Text);
                if (xe == null)
                    MessageBox.Show("Không có xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (xeBUS.SoLuongConThucSu(xe) == 0)
                        MessageBox.Show("Xe đã bán hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        tbxMaXe.Text = xe.MaXe;
                        tbxCongSuat.Text = string.Format("{0:#,#.}", xe.CongSuat);
                        tbxDoCao.Text = xe.DoCaoYen.ToString();
                        tbxDungTichBinhXang.Text = string.Format("{0:#,#.}", xe.DungTichBinhXang);
                        tbxKhoiLuong.Text = string.Format("{0:#,#.}", xe.KhoiLuong);
                        tbxMauSac.Text = xe.MauSac;
                        tbxPhanKhoi.Text = xe.PhanKhoi;
                        tbxLoaiPhanh.Text = xe.LoaiPhanh;
                        tbxLoaiBanh.Text = xe.LoaiBanh;
                        tbxDuongKinhPitTong.Text = string.Format("{0:#,#.}", xe.DuongKinhPitTong);
                        tbxNCC.Text = nccBUS.LayNhaCungCap(xe.MaNCC).TenNCC;
                        tbxLoaiXe.Text = loaiBUS.layTenLoaiTheoMaLoai(xe.MaLoai);
                        tbxHangXe.Text = hangBUS.layTenHangTheoMaHang(xe.MaHang);
                        tbxXuatXu.Text = hangBUS.layXuatXuTheoMaHang(xe.MaHang);
                        tbxGiaThanh.Text = xeBUS.SinhGiaBan(xe).ToString();
                        btnLuu.Enabled = true;
                        btnLuu.Focus();
                    }
                }
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            if (frmKH.DialogResult == DialogResult.OK)
            {
                eKhachHang kh = frmKH.khachhang;
                tbxSoDienThoaiKhachHang.Text = kh.SdtKH;
                tbxMaKhachHang.Text = kh.MaKH;
                tbxTenKhachHang.Text = kh.TenKH;
                tbxTenXe.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxMaKhachHang.Text) && !string.IsNullOrWhiteSpace(tbxMaXe.Text))
            {
                hopdong.MaHopDong = tbxMaHDG.Text;
                hopdong.MaNhanVien = tbxMaNhanVien.Text;
                hopdong.MaKhachHang = tbxMaKhachHang.Text;
                hopdong.MaXe = tbxMaXe.Text;
                hopdong.TrangThai = cboTrangThai.Text;
                hopdong.NgayLap = dtmNgayLap.Value;
                if (hdgBUS.ThemHopDong(hopdong) == 1)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaoMoiForm();
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TaoMoiForm();
        }
    }
}
