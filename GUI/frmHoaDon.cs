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
    public partial class frmHoaDon : Form
    {
        KhachHangBUS khBUS;
        HoaDonBUS hdBUS;
        HopDongBUS hdgBUS;
        XeBUS xeBUS;
        CT_HoaDonBUS ctBUS;
        eNhanVien nv;
        eHoaDon hdmoi;
        List<eHopDong> listHDG;
        List<eCT_HoaDon> listCT;
        double tongtien;
        double tongthue;
        DataTable dtsHDG;
        DataTable dtsCT;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        public frmHoaDon(eNhanVien nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            tbxMaNhanVien.Text = nv.MaNhanVien;
            tbxTenNhanVien.Text = nv.TenNhanVien;
            khBUS = new KhachHangBUS();
            hdgBUS = new HopDongBUS();
            hdBUS = new HoaDonBUS();
            xeBUS = new XeBUS();
            ctBUS = new CT_HoaDonBUS();
            hdmoi = new eHoaDon();
            listHDG = new List<eHopDong>();
            listCT = new List<eCT_HoaDon>();
            tongtien = 0;
            tongthue = 0;
            dtsHDG = new DataTable();
            dtsCT = new DataTable();
            SetAutoComplete();
            List<eKhachHang> l = khBUS.LayToanBoDanhSach();
            XuLyHoTroCboSoDienThoaiKhachHang(l);
            khoaControl();
            SetDataCboTrangThai();
            cboTrangThai.Text = "Chưa nhận xe";
        }

        void SetDataCboTrangThai()
        {
            string[] str = new string[] { "Chưa nhận xe", "Đã nhận xe" };
            cboTrangThai.DataSource = str;
        }

        private void SetAutoComplete()
        {
            tbxSoDienThoaiKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxSoDienThoaiKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void XuLyHoTroCboSoDienThoaiKhachHang(List<eKhachHang> l)
        {
            tbxSoDienThoaiKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxSoDienThoaiKhachHang.AutoCompleteCustomSource.Add(kh.SdtKH);
            }   
        }

        private void khoaControl()
        {
            tbxMaHD.Text = hdBUS.PhatSinhMa();
            dtmNgayLap.Value = DateTime.Now;
            tbxThue.Text = "0.1";
            tongtien = 0;
            tongthue = 0;
            tbxTongTien.Text = "";
            tbxMaKhachHang.Text = "";
            tbxCMND.Text = "";
            tbxSoDienThoaiKhachHang.Text = "";
            tbxTien.Text = "";
            tbxTienThua.Text = "";
            tbxTongThue.Text = "";
            dgvChiTiet.DataSource = null;
            dgvDSHopDong.DataSource = null;
            tbxSoDienThoaiKhachHang.Focus();
        }

        DataTable CreatDataTableDgvHopDong()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("maHopDong");
            dt.Columns.Add("TenXe");
            dt.Columns.Add("GiaBan");
            return dt;
        }

        DataTable FormatDataDgvHopDong(List<eHopDong> l)
        {
            DataTable dtb = CreatDataTableDgvHopDong();
            for (int i = 0; i < l.Count; i++)
            {
                dtb.Rows.Add((i + 1).ToString(), l[i].MaHopDong, xeBUS.LayXeTheoMa(l[i].MaXe).TenXe,
                            xeBUS.SinhGiaBan(xeBUS.LayXeTheoMa(l[i].MaXe)).ToString());
            }
            return dtb;
        }

        void FormatDgvHopDong(DataGridView dt)
        {
            dt.Columns["STT"].HeaderText = "STT";
            dt.Columns["STT"].Width = 66;
            dt.Columns["maHopDong"].HeaderText = "Mã hợp đồng";
            dt.Columns["maHopDong"].Width = 150;
            dt.Columns["TenXe"].HeaderText = "Tên xe";
            dt.Columns["TenXe"].Width = 200;
            dt.Columns["GiaBan"].HeaderText = "Giá bán";
            dt.Columns["GiaBan"].Width = 200;
            dt.Columns["GiaBan"].DefaultCellStyle.Format = "###,### VNĐ";
        }

        void CapNhapDgvDSHopDong(List<eHopDong> l)
        {
            if (l.Count > 0)
            {
                dgvDSHopDong.DataSource = FormatDataDgvHopDong(l);
                FormatDgvHopDong(dgvDSHopDong);
            }
        }

        DataTable CreatDataTableDgvChitiet()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("maHopDong");
            dt.Columns.Add("TenXe");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("GiaBan");
            dt.Columns.Add("Thue");
            dt.Columns.Add("TienThue");
            dt.Columns.Add("TongTien");
            return dt;
        }

        DataTable FormatDataDgvChiTiet(List<eCT_HoaDon> l)
        {
            DataTable dtb = CreatDataTableDgvChitiet();
            for (int i = 0; i < l.Count; i++)
            {
                dtb.Rows.Add((i + 1).ToString(), l[i].MaHDG, xeBUS.LayXeTheoMa(hdgBUS.LayHopDongTheoMa(l[i].MaHDG).MaXe).TenXe,
                            1.ToString(), l[i].GiaBan.ToString(), l[i].Thue.ToString(), ctBUS.TinhTienThue(l[i]).ToString(),
                            ctBUS.TinhTongTien(l[i]).ToString());
            }
            return dtb;
        }


        void FormatDgvChiTiet(DataGridView dt)
        {
            if (dt.DataSource != null)
            {
                dt.Columns["STT"].HeaderText = "STT";
                dt.Columns["STT"].Width = 66;
                dt.Columns["maHopDong"].Visible = false;
                dt.Columns["TenXe"].HeaderText = "Tên xe";
                dt.Columns["TenXe"].Width = 200;
                dt.Columns["SoLuong"].HeaderText = "Số lượng";
                dt.Columns["SoLuong"].Width = 120;
                dt.Columns["GiaBan"].HeaderText = "Giá bán";
                dt.Columns["GiaBan"].Width = 200;
                dt.Columns["GiaBan"].DefaultCellStyle.Format = "###,### VNĐ";
                dt.Columns["Thue"].HeaderText = "Thuế";
                dt.Columns["Thue"].Width = 100;
                dt.Columns["Thue"].DefaultCellStyle.Format = "#%";
                dt.Columns["TienThue"].HeaderText = "Tiền thuế";
                dt.Columns["TienThue"].Width = 200;
                dt.Columns["TienThue"].DefaultCellStyle.Format = "###,### VNĐ";
                dt.Columns["TongTien"].HeaderText = "Tổng tiền";
                dt.Columns["TongTien"].Width = 200;
                dt.Columns["TongTien"].DefaultCellStyle.Format = "###,### VNĐ";
            }
        }

        void CapNhapDgvChiTiet(List<eCT_HoaDon> l)
        {
            if (l.Count > 0)
            {
                dgvChiTiet.DataSource = FormatDataDgvChiTiet(l);
                FormatDgvChiTiet(dgvChiTiet);
            }
        }

        private void tbxSoDienThoaiKhachHang_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSoDienThoaiKhachHang.Text))
            {
                if (tbxSoDienThoaiKhachHang.Text.Length == 10)
                {
                    eKhachHang kh = khBUS.LayKhachHangTheoSDT(tbxSoDienThoaiKhachHang.Text);
                    tbxTenKhachHang.Text = kh.TenKH;
                    tbxMaKhachHang.Text = kh.MaKH;
                    tbxCMND.Text = kh.CMNDKH;
                    listHDG = hdgBUS.LayDSHopDongChuaThanhToanCuaKhachHang(kh.MaKH);
                    CapNhapDgvDSHopDong(listHDG);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvDSHopDong.SelectedRows.Count > 0)
            {
                for (int i = 0; i < listHDG.Count(); i++)
                {
                    if (listHDG[i].MaHopDong.Equals(dgvDSHopDong.CurrentRow.Cells["maHopDong"].Value.ToString()))
                    {
                        eCT_HoaDon ct = new eCT_HoaDon();
                        ct.MaHD = tbxMaHD.Text;
                        ct.MaHDG = listHDG[i].MaHopDong;
                        ct.Thue = double.Parse(tbxThue.Text);
                        double a = xeBUS.SinhGiaBan(xeBUS.LayXeTheoMa(listHDG[i].MaXe));
                        ct.GiaBan = a;                     
                        listCT.Add(ct);
                        tongthue += ctBUS.TinhTienThue(ct);
                        tbxTongThue.Text = string.Format("{0:#,#. VNĐ}", tongthue);
                        tongtien += ctBUS.TinhTongTien(ct);
                        tbxTongTien.Text = string.Format("{0:#,#. VNĐ}", tongtien);
                        listHDG.Remove(listHDG[i]);
                        CapNhapDgvDSHopDong(listHDG);
                        CapNhapDgvChiTiet(listCT);
                        dgvDSHopDong.Rows.RemoveAt(dgvDSHopDong.CurrentRow.Index);
                        dgvDSHopDong.ClearSelection();
                        dgvChiTiet.ClearSelection();
                    }
                }
            }
            else
                MessageBox.Show("Hãy chọn hợp đồng cần thanh toán trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count > 0)
            {
                for (int i = 0; i < listCT.Count(); i++)
                {
                    if (listCT[i].MaHDG.Equals(dgvDSHopDong.CurrentRow.Cells["maHopDong"].Value.ToString()))
                    {
                        eHopDong hdg = hdgBUS.LayHopDongTheoMa(dgvChiTiet.CurrentRow.Cells["maHopDong"].Value.ToString());
                        listHDG.Add(hdg);
                        tongthue -= ctBUS.TinhTienThue(listCT[i]);
                        tbxTongThue.Text = string.Format("{0:#,#. VNĐ}", tongthue);
                        tongtien -= ctBUS.TinhTongTien(listCT[i]);
                        tbxTongTien.Text = string.Format("{0:#,#. VNĐ}", tongtien);
                        listCT.RemoveAt(dgvChiTiet.CurrentRow.Index);
                        CapNhapDgvDSHopDong(listHDG);
                        CapNhapDgvChiTiet(listCT);
                        dgvChiTiet.Rows.RemoveAt(dgvChiTiet.CurrentRow.Index);
                        dgvDSHopDong.ClearSelection();
                        dgvChiTiet.ClearSelection();
                    }                       
                } 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hdmoi.MaHoaDon = tbxMaHD.Text;
            hdmoi.MaNhanVien = tbxMaNhanVien.Text;
            hdmoi.MaKhachHang = tbxMaKhachHang.Text;
            hdmoi.NgayLap = dtmNgayLap.Value;
            hdmoi.TrangThai = cboTrangThai.Text;
            hdBUS.ThemHoaDon(hdmoi);
            for (int i = 0; i < listCT.Count; i++)
            {
                ctBUS.ThemChiTiet(listCT[i]);
                hdgBUS.DoiTrangThai(listCT[i].MaHDG);
            }
            listHDG.Clear();
            listCT.Clear();
            khoaControl();
        }

        private void tbxTien_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxTien.Text))
            {
                double tienthua = double.Parse(tbxTien.Text) - tongtien;
                if (tienthua >= 0)
                {
                    btnLuu.Enabled = true;
                    tbxTien.Text = string.Format("{0:#,#. VNĐ}", double.Parse(tbxTien.Text));
                    tbxTienThua.Text = string.Format("{0:#,#. VNĐ}", tienthua);
                }
                else
                {
                    btnLuu.Enabled = false;
                    MessageBox.Show("Số tiền khách hàng trả chưa đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxTien.Focus();
                }
            }  
        }

        private void dgvDSHopDong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSHopDong.ClearSelection();
            btnAdd.Enabled = false;
        }

        private void dgvDSHopDong_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void dgvChiTiet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvChiTiet.ClearSelection();
            btnBack.Enabled = false;
        }

        private void dgvChiTiet_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnBack.Enabled = true;
        }

        private void grpKhachHang_Enter(object sender, EventArgs e)
        {

        }
    }
}
