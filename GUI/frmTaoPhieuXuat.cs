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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
    public partial class frmTaoPhieuXuat : Form
    {
        KhachHangBUS khBUS;
        HoaDonBUS hdBUS;
        CT_HoaDonBUS ctBUS;
        XeBUS xeBUS;
        HopDongBUS hdgBUS;
        LoaiXeBUS loaiBUS;
        HangXeBUS hangBUS;
        eNhanVien nv;
        List<eHoaDon> listChoXuat;
        List<eHoaDon> listXuat;
        List<eCT_HoaDon> listChiTiet;

        public frmTaoPhieuXuat()
        {
            InitializeComponent();
        }

        public frmTaoPhieuXuat(eNhanVien nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void frmTaoPhieuXuat_Load(object sender, EventArgs e)
        {
            khBUS = new KhachHangBUS();
            hdBUS = new HoaDonBUS();
            ctBUS = new CT_HoaDonBUS();
            xeBUS = new XeBUS();
            hdgBUS = new HopDongBUS();
            loaiBUS = new LoaiXeBUS();
            hangBUS = new HangXeBUS();
            tbxTenNhanVien.Text = nv.TenNhanVien;
            SetAutoComplete();
            List<eKhachHang> l = khBUS.LayToanBoDanhSach();
            XuLyHoTroCboSoDienThoaiKhachHang(l);
            listChoXuat = hdBUS.LayDanhSachHoaDonChuaNhanXe();
            CapNhapDgvDSHopDong(listChoXuat);
            listXuat = new List<eHoaDon>();
            listChiTiet = new List<eCT_HoaDon>();
            btnAdd.Enabled = false;
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
        System.Data.DataTable CreatDataTableDSHoaDon()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("maHoaDon");
            dt.Columns.Add("tenKhachHang");
            dt.Columns.Add("trangThai");
            return dt;
        }

        void FormatDSHoaDon(DataGridView dt)
        {
            dt.Columns["STT"].HeaderText = "STT";
            dt.Columns["STT"].Width = 80;
            dt.Columns["maHoaDon"].HeaderText = "Mã hóa đơn";
            dt.Columns["maHoaDon"].Width = 150;
            dt.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
            dt.Columns["tenKhachHang"].Width = 220;
            dt.Columns["trangThai"].HeaderText = "Trạng thái";
            dt.Columns["trangThai"].Width = 200;
        }

        System.Data.DataTable FormatDataDSHoaDon(List<eHoaDon> l)
        {
            System.Data.DataTable dtb = CreatDataTableDSHoaDon();
            for (int i = 0; i < l.Count; i++)
            {
                dtb.Rows.Add((i + 1).ToString(), l[i].MaHoaDon, khBUS.layKhachHangTheoMa(l[i].MaKhachHang).TenKH,
                            l[i].TrangThai);
            }
            return dtb;
        }

        void CapNhapdgvXuat(List<eHoaDon> l)
        {
            if (l.Count > 0)
            {
                dgvXuat.DataSource = FormatDataDSHoaDon(l);
                FormatDSHoaDon(dgvXuat);
            }
        }

        void CapNhapDgvDSHopDong(List<eHoaDon> l)
        {
            if (l.Count > 0)
            {
                dgvDSHoaDon.DataSource = FormatDataDSHoaDon(l);
                FormatDSHoaDon(dgvDSHoaDon);
            }
        }

        void LayDanhSachChiTiet(List<eHoaDon> l)
        {
            listChiTiet.Clear();
            for(int i = 0; i < l.Count; i++)
            {
                List<eCT_HoaDon> l1 = ctBUS.LayTatCaChiTietTheoMaHoaDon(dgvDSHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString());
                for(int j = 0; j < l1.Count; j++)
                {
                    listChiTiet.Add(l1[j]);
                }
            }
            CapNhapdgvCTPhieuXuat(listChiTiet);
            if (listChiTiet.Count == 0)
                dgvCTPhieuXuat.Rows.RemoveAt(0);
        }

        System.Data.DataTable CreatDataTabledgvCTPhieuXuat()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("maXe");
            dt.Columns.Add("tenXe");
            dt.Columns.Add("hang");
            dt.Columns.Add("loai");
            dt.Columns.Add("mauSac");
            dt.Columns.Add("phanKhoi");
            dt.Columns.Add("loaiBanh");
            dt.Columns.Add("loaiPhanh");
            dt.Columns.Add("congSuat");
            dt.Columns.Add("khoiLuong");
            dt.Columns.Add("dungTichBinhXang");
            dt.Columns.Add("duongKinhPittong");
            dt.Columns.Add("doCaoYen");
            dt.Columns.Add("soLuong");
            return dt;
        }

        System.Data.DataTable FormatDatadgvCTPhieuXuat(List<eCT_HoaDon> l)
        {
            System.Data.DataTable dtb = CreatDataTabledgvCTPhieuXuat();
            for (int i = 0; i < l.Count; i++)
            {
                eXe xe = xeBUS.LayXeTheoMa(hdgBUS.LayHopDongTheoMa(l[i].MaHDG).MaXe);
                dtb.Rows.Add((i + 1).ToString(), xe.MaXe, xe.TenXe, hangBUS.layTenHangTheoMaHang(xe.MaHang),
                            loaiBUS.layTenLoaiTheoMaLoai(xe.MaLoai),xe.MauSac, xe.PhanKhoi.ToString(), xe.LoaiBanh,
                            xe.LoaiPhanh, xe.CongSuat.ToString(), xe.KhoiLuong.ToString(), xe.DungTichBinhXang.ToString(),
                            xe.DuongKinhPitTong.ToString(), xe.DoCaoYen.ToString(), 1.ToString());
            }
            return dtb;
        }

        void FormatdgvCTPhieuXuat(DataGridView dt)
        {
            dt.Columns["STT"].HeaderText = "STT";
            dt.Columns["STT"].Width = 66;
            dt.Columns["maXe"].HeaderText = "Mã xe";
            dt.Columns["maXe"].Width = 150;
            dt.Columns["tenXe"].HeaderText = "Tên Xe";
            dt.Columns["tenXe"].Width = 200;
            dt.Columns["hang"].HeaderText = "Hãng";
            dt.Columns["hang"].Width = 200;
            dt.Columns["loai"].HeaderText = "Loại";
            dt.Columns["loai"].Width = 200;
            dt.Columns["mauSac"].HeaderText = "Màu sắc";
            dt.Columns["mauSac"].Width = 200;
            dt.Columns["phanKhoi"].HeaderText = "Phân khối";
            dt.Columns["phanKhoi"].Width = 200;
            dt.Columns["loaiBanh"].HeaderText = "Loại bánh";
            dt.Columns["loaiBanh"].Width = 200;
            dt.Columns["loaiPhanh"].HeaderText = "Loại phanh";
            dt.Columns["loaiPhanh"].Width = 200;
            dt.Columns["congSuat"].HeaderText = "Công xuất";
            dt.Columns["congSuat"].Width = 200;
            dt.Columns["khoiLuong"].HeaderText = "Khối lượng";
            dt.Columns["khoiLuong"].Width = 200;
            dt.Columns["dungTichBinhXang"].HeaderText = "Dung tích bình xăng";
            dt.Columns["dungTichBinhXang"].Width = 200;
            dt.Columns["duongKinhPittong"].HeaderText = "Đường kính pittong";
            dt.Columns["duongKinhPittong"].Width = 200;
            dt.Columns["doCaoYen"].HeaderText = "Độ cao yên";
            dt.Columns["doCaoYen"].Width = 200;
            dt.Columns["soLuong"].HeaderText = "Số lượng";
            dt.Columns["soLuong"].Width = 200;
        }
        void CapNhapdgvCTPhieuXuat(List<eCT_HoaDon> l)
        {
            if (l.Count > 0)
            {
                dgvCTPhieuXuat.DataSource = FormatDatadgvCTPhieuXuat(l);
                FormatdgvCTPhieuXuat(dgvCTPhieuXuat);
            }
        }

        private void dgvXuat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvXuat.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                for (int i = 0; i < listChoXuat.Count(); i++)
                {
                    if (listChoXuat[i].MaHoaDon.Equals(dgvDSHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString()))
                    {
                        listXuat.Add(listChoXuat[i]);
                        listChoXuat.Remove(listChoXuat[i]);
                        CapNhapDgvDSHopDong(listChoXuat);
                        CapNhapdgvXuat(listXuat);;
                        LayDanhSachChiTiet(listXuat);
                        btnAdd.Enabled = false;
                        btnBack.Enabled = false;
                        if (listChoXuat.Count == 0)
                            dgvDSHoaDon.Rows.RemoveAt(dgvDSHoaDon.CurrentRow.Index);
                    }
                }
            }
            else
                MessageBox.Show("Hãy chọn hóa đơn cần xuất xe trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dgvXuat.SelectedRows.Count > 0)
            {
                for (int i = 0; i < listXuat.Count(); i++)
                {
                    if (listXuat[i].MaHoaDon.Equals(dgvXuat.CurrentRow.Cells["maHoaDon"].Value.ToString()))
                    {
                        listChoXuat.Add(listXuat[i]);
                        listXuat.Remove(listXuat[i]);
                        CapNhapdgvXuat(listXuat);
                        CapNhapDgvDSHopDong(listChoXuat);
                        LayDanhSachChiTiet(listXuat);
                        btnAdd.Enabled = false;
                        btnBack.Enabled = false;
                        if(listXuat.Count==0)
                            dgvXuat.Rows.RemoveAt(dgvXuat.CurrentRow.Index);
                    }
                }
            }
        }

        private void dgvXuat_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvXuat.SelectedRows.Count > 0)
            {
                btnBack.Enabled = true;
            }
        }

        private void dgvCTPhieuXuat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCTPhieuXuat.ClearSelection();
        }

        private void dgvDSHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSHoaDon.ClearSelection();
        }

        private void dgvDSHoaDon_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = true;
            }
        }

        private void tbxSoDienThoaiKhachHang_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSoDienThoaiKhachHang.Text) && tbxSoDienThoaiKhachHang.Text.Length == 10)
            {
                listChoXuat = hdBUS.LayDanhSachHoaDonChuaNhanXeTheoMaKhachHang(khBUS.LayKhachHangTheoSDT(tbxSoDienThoaiKhachHang.Text).MaKH);
                CapNhapDgvDSHopDong(listChoXuat);
            }
            else
            {
                listChoXuat = hdBUS.LayDanhSachHoaDonChuaNhanXe();
                CapNhapDgvDSHopDong(listChoXuat);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (listChiTiet.Count > 0)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "Lưu phiếu xuất";
                sf.Filter = "Excel 2003 (*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
                sf.FilterIndex = 2;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string tenFile = sf.FileName;
                    string duongDan = sf.InitialDirectory;
                    XuatFileExcel(dgvCTPhieuXuat, duongDan, tenFile, sf.DefaultExt);
                    MessageBox.Show("Phiếu nhập lưu thành công với đường dẫn là:" + duongDan + @"\" + tenFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (eCT_HoaDon ct in listChiTiet)
                    {
                        xeBUS.GiamSoLuong(xeBUS.LayXeTheoMa(hdgBUS.LayHopDongTheoMa(ct.MaHDG).MaXe), 1);
                    }
                    foreach (eHoaDon hd in listXuat)
                    {
                        hdBUS.SuaTrangThaiHoaDon(hd.MaHoaDon);
                    }
                    listChiTiet.Clear();
                    listXuat.Clear();
                    CapNhapdgvXuat(listXuat);
                    LayDanhSachChiTiet(listXuat);
                    listChoXuat = hdBUS.LayDanhSachHoaDonChuaNhanXe();
                    CapNhapDgvDSHopDong(listChoXuat);
                    if (listXuat.Count == 0)
                        dgvXuat.Rows.RemoveAt(0);
                    
                }

            }
            else
            {
                MessageBox.Show("Không có xe nào được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuatFileExcel(DataGridView dgr, String duongDan, String tenTap, string loaiTap)
        {
            //Khoi tao Excel
            app obj = new app();
            //Khoi tao Workbooks
            Microsoft.Office.Interop.Excel._Workbook workbooks = obj.Workbooks.Add(Type.Missing);
            //Khoi tao Worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbooks.Sheets["Sheet1"];
            worksheet = workbooks.ActiveSheet;
            worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP CÁC XE ĐƯỢC XUẤT";
            worksheet.Cells[2, 1] = "Nhân viên:";
            worksheet.Cells[2, 3] = nv.TenNhanVien;
            worksheet.Cells[3, 1] = "Ngày tạo:";
            worksheet.Cells[3, 3] = "'" + dtmNgayLap.Value.ToString("dd/MM/yy");
            worksheet.Cells[5, 1] = "STT";
            worksheet.Cells[5, 2] = "Mã xe";
            worksheet.Cells[5, 3] = "Tên xe";
            worksheet.Cells[5, 4] = "Hãng";
            worksheet.Cells[5, 5] = "Loại";
            worksheet.Cells[5, 6] = "Màu sắc";
            worksheet.Cells[5, 7] = "Phân khối";
            worksheet.Cells[5, 8] = "Loại bánh";
            worksheet.Cells[5, 9] = "Loại phanh";
            worksheet.Cells[5, 10] = "Công suất";
            worksheet.Cells[5, 11] = "Khối lượng";
            worksheet.Cells[5, 12] = "Dung tích bình xăng";
            worksheet.Cells[5, 13] = "Đường kính pittong";
            worksheet.Cells[5, 14] = "Độ cao yên";
            worksheet.Cells[5, 15] = "Số lượng";

            for (int i = 0; i < dgr.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgr.Columns.Count; j++)
                {
                    worksheet.Cells[i + 6, j + 1] = dgr.Rows[i].Cells[j].Value.ToString();
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + loaiTap);
        }
    }
}