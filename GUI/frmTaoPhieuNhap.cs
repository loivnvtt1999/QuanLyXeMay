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
    public partial class frmTaoPhieuNhap : Form
    {
        List<eXe> lNhap;
        System.Data.DataTable dts;
        System.Data.DataTable dts1;
        XeBUS xeBUS;
        BindingSource bds;
        BindingSource bds1;
        eNhanVien nhanvien;
        LoaiXeBUS loaiBUS;
        HangXeBUS hangBUS;
        NhaCungCapBUS nccBUS;
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
        }

        public frmTaoPhieuNhap(eNhanVien nv)
        {
            InitializeComponent();
            nhanvien = nv;
        }

        private void frmTaoPhieuNhap_Load(object sender, EventArgs e)
        {
            lNhap = new List<eXe>();
            bds = new BindingSource();
            xeBUS = new XeBUS();
            loaiBUS = new LoaiXeBUS();
            hangBUS = new HangXeBUS();
            nccBUS = new NhaCungCapBUS();
            dts = CreatData();
            dts1 = CreatData();
            List<eXe> lX = xeBUS.LayDanhSachXe();
            capNhatDatagridviewXe(lX);
            grpNhapXuat.Text = "Phiếu nhập";
            dgvXe.AllowUserToAddRows = false;
            dgvNhap.AllowUserToAddRows = false;
            bds1 = new BindingSource();
        }

        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Nhà cung cấp");
            dt.Columns.Add("Hãng xe");
            dt.Columns.Add("Loại xe");
            dt.Columns.Add("Màu sắc");
            dt.Columns.Add("Phân khối");
            dt.Columns.Add("Loại bánh");
            dt.Columns.Add("Loại phanh");
            dt.Columns.Add("Công suất");
            dt.Columns.Add("Dung tích bình xăng(lít)");
            dt.Columns.Add("Khối lượng");
            dt.Columns.Add("Đường kính pittong");
            dt.Columns.Add("Giá thành");
            dt.Columns.Add("Độ cao yên");
            dt.Columns.Add("Số lượng");
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvXe.SelectedRows.Count > 0)
            {
                eXe xeXuat = new eXe();
                xeXuat = xeBUS.LayXeTheoMa(dgvXe.CurrentRow.Cells["Mã xe"].Value.ToString());
                if (nudSoLuong.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudSoLuong.Focus();
                    return;
                }
                else
                {
                    xeXuat.SoLuong = int.Parse(nudSoLuong.Value.ToString());
                }
                for (int i = 0; i < lNhap.Count; i++)
                {
                    if (xeXuat.MaXe.Equals(lNhap[i].MaXe))
                    {
                        MessageBox.Show("Xe đã có trong danh sách nhập,vui lòng kiểm tra lại!");
                        return;
                    }
                }
                lNhap.Add(xeXuat);
                capNhatDatagirdview(lNhap);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe cần lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        void capNhatDatagirdview(List<eXe> lNhap)
        {
            dts1.Rows.Clear();
            dts1 = CreatData();
            foreach (eXe xe in lNhap)
            {
                dts1.Rows.Add(xe.MaXe, xe.TenXe, nccBUS.LayNhaCungCap(xe.MaNCC).TenNCC,
                            hangBUS.layTenHangTheoMaHang(xe.MaHang), loaiBUS.layTenLoaiTheoMaLoai(xe.MaLoai),
                            xe.MauSac, xe.PhanKhoi.ToString(), xe.LoaiBanh, xe.LoaiPhanh, xe.CongSuat.ToString(),
                            xe.DungTichBinhXang.ToString(), xe.KhoiLuong.ToString(), xe.DuongKinhPitTong.ToString(),
                            xe.GiaThanh.ToString(), xe.DoCaoYen.ToString(), xe.SoLuong.ToString());
                bds1.DataSource = dts1;
                dgvNhap.DataSource = bds1;
                bindingNavigator2.BindingSource = bds1;
                dgvNhap.RefreshEdit();
            }
        }
        void capNhatDatagridviewXe(List<eXe> l)
        {
            dts.Rows.Clear();
            dts = CreatData();
            foreach (eXe xe in l)
            {
                dts.Rows.Add(xe.MaXe, xe.TenXe, nccBUS.LayNhaCungCap(xe.MaNCC).TenNCC,
                            hangBUS.layTenHangTheoMaHang(xe.MaHang), loaiBUS.layTenLoaiTheoMaLoai(xe.MaLoai),
                            xe.MauSac, xe.PhanKhoi.ToString(), xe.LoaiBanh, xe.LoaiPhanh, xe.CongSuat.ToString(), 
                            xe.DungTichBinhXang.ToString(), xe.KhoiLuong.ToString(), xe.DuongKinhPitTong.ToString(),
                            xe.GiaThanh.ToString(), xe.DoCaoYen.ToString(), xe.SoLuong.ToString());
            }
            bds.DataSource = dts;
            dgvXe.DataSource = bds;
            bindingNavigator2.BindingSource = bds;
            dgvXe.RefreshEdit();
        }

        private void tbtnThemXe_Click(object sender, EventArgs e)
        {
            frmThemXe frmThem = new frmThemXe();
            frmThem.Text = "Thêm xe";
            frmThem.ShowDialog();
            if (frmThem.DialogResult == DialogResult.OK)
            {
                eXe xe = frmThem.xemoi;
                List<eXe> lXe = xeBUS.LayDanhSachXe();
                capNhatDatagridviewXe(lXe);
            }
        }

        private void ttbnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (this.dgvXe.SelectedRows.Count > 0)
            {
                eXe xemoi = xeBUS.LayXeTheoMa(dgvXe.CurrentRow.Cells["Mã xe"].Value.ToString());
                frmThemXe frmThem = new frmThemXe(xemoi);
                frmThem.Text = "Sửa thông tin xe";
                frmThem.ShowDialog();
                xeBUS = new XeBUS();
                List<eXe> lX = xeBUS.LayDanhSachXe();
                capNhatDatagridviewXe(lX);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbtnXoaKhoiPhieu_Click(object sender, EventArgs e)
        {
            if (this.dgvNhap.SelectedRows.Count > 0)
            {
                for (int i = 0; i < lNhap.Count(); i++)
                {
                    if (lNhap[i].MaXe.Equals(this.dgvNhap.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        lNhap.Remove(lNhap[i]);
                    }
                }
                dgvNhap.Rows.RemoveAt(this.dgvNhap.SelectedRows[0].Index);
            }
        }

        private void tbtnLuu_Click(object sender, EventArgs e)
        {
            if (lNhap.Count > 0)
            {

                DateTime ngay = DateTime.Now;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "Lưu phiếu nhập";
                sf.Filter = "Excel 2003 (*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
                sf.FilterIndex = 2;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string tenFile = sf.FileName;
                    string duongDan = sf.InitialDirectory;
                    XuatFileExcel(dgvNhap, duongDan, tenFile, sf.DefaultExt);
                    MessageBox.Show("Phiếu nhập lưu thành công với đường dẫn là:" + duongDan + @"\" + tenFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (eXe xe in lNhap)
                    {
                        xeBUS.TangSoLuong(xe, xe.SoLuong);
                    }
                    lNhap.Clear();
                    capNhatDatagirdview(lNhap);
                    dgvXe.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Không có xe nào được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lNhap.Count > 0)
            {

                DateTime ngay = DateTime.Now;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "Lưu phiếu nhập";
                sf.Filter = "Excel 2003 (*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
                sf.FilterIndex = 2;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string tenFile = sf.FileName;
                    string duongDan = sf.InitialDirectory;
                    XuatFileExcel(dgvNhap, duongDan, tenFile, sf.DefaultExt);
                    MessageBox.Show("Phiếu nhập lưu thành công với đường dẫn là:" + duongDan + @"\" + tenFile, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (eXe xe in lNhap)
                    {
                        xeBUS.TangSoLuong(xe, xe.SoLuong);
                    }
                    lNhap.Clear();
                    capNhatDatagirdview(lNhap);
                    dgvXe.ClearSelection();
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
            worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP CÁC XE ĐƯỢC NHẬP";
            worksheet.Cells[2, 1] = "Nhân viên:";
            worksheet.Cells[2, 3] = nhanvien.TenNhanVien;
            worksheet.Cells[3, 1] = "Ngày tạo:";
            worksheet.Cells[3, 3] = "'" + DateTime.Now.ToString("dd/MM/yy");
            worksheet.Cells[5, 1] = "Mã xe";
            worksheet.Cells[5, 2] = "Tên xe";
            worksheet.Cells[5, 3] = "Nhà cung cấp";
            worksheet.Cells[5, 4] = "Hãng";
            worksheet.Cells[5, 5] = "Loại";
            worksheet.Cells[5, 6] = "Màu sắc";
            worksheet.Cells[5, 7] = "Phân khối";
            worksheet.Cells[5, 8] = "Loại bánh";
            worksheet.Cells[5, 9] = "Loại phanh";
            worksheet.Cells[5, 10] = "Công suất";
            worksheet.Cells[5, 11] = "Dung tích bình xăng";
            worksheet.Cells[5, 12] = "Khối lượng";
            worksheet.Cells[5, 13] = "Đường kính pittong";
            worksheet.Cells[5, 14] = "Giá thành";
            worksheet.Cells[5, 15] = "Độ cao yên";
            worksheet.Cells[5, 16] = "Số lượng";

            for (int i = 0; i < dgr.Rows.Count; i++)
            {
                for (int j = 0; j < dgr.Columns.Count; j++)
                {
                    worksheet.Cells[i + 6, j + 1] = dgr.Rows[i].Cells[j].Value.ToString();
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + loaiTap);
        }

        private void dgvNhap_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNhap.ClearSelection();
        }

        private void dgvXe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvXe.ClearSelection();
        }
    }
}
