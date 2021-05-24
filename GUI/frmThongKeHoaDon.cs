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
    public partial class frmThongKeHoaDon : Form
    {
        HoaDonBUS hdBUS;
        HopDongBUS hdgBUS;
        CT_HoaDonBUS ctBUS;
        BindingSource bds;
        List<object> lst;
        BindingSource bds1;
        List<object> lstct;
        eHoaDon hd;
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            hdBUS = new HoaDonBUS();
            hdgBUS = new HopDongBUS();
            ctBUS = new CT_HoaDonBUS();
            bds = new BindingSource();
            lst = new List<object>();
            lstct = new List<object>();
            bds1 = new BindingSource();
            hd = new eHoaDon();
            tbtnSapXep.Enabled = false;
        }
        void formatDataGridView(DataGridView dt)
        {
            if (dt.DataSource != null)
            {
                dt.Columns["mahoadon"].HeaderText = "Mã hóa đơn";
                dt.Columns["mahoadon"].Width = 200;
                dt.Columns["ngaylap"].HeaderText = "Ngày lập";
                dt.Columns["ngaylap"].Width = 213;
                dt.Columns["ngaylap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dt.Columns["tennhanvien"].HeaderText = "Tên nhân viên";
                dt.Columns["tennhanvien"].Width = 350;
                dt.Columns["tenkhachhang"].HeaderText = "Tên khách hàng";
                dt.Columns["tenkhachhang"].Width = 350;
                dt.Columns["tongtien"].HeaderText = "Tổng tiền";
                dt.Columns["tongtien"].Width = 350;
                dt.Columns["tongtien"].DefaultCellStyle.Format = "###,### VNĐ";
            }
        }
        void formatDataGridView2(DataGridView dt)
        {
            if (dt.DataSource != null)
            {
                dt.Columns["maHopDong"].HeaderText = "Mã hợp đồng";
                dt.Columns["maHopDong"].Width = 168;
                dt.Columns["tenxe"].HeaderText = "Tên xe";
                dt.Columns["tenxe"].Width = 255;
                dt.Columns["xuatXu"].HeaderText = "Xuất xứ";
                dt.Columns["xuatXu"].Width = 200;
                dt.Columns["giaban"].HeaderText = "Giá bán";
                dt.Columns["giaban"].Width = 230;
                dt.Columns["giaban"].DefaultCellStyle.Format = "###,### VNĐ";
                dt.Columns["thue"].HeaderText = "Thuế";
                dt.Columns["thue"].Width = 150;
                dt.Columns["thue"].DefaultCellStyle.Format = "#%";
                dt.Columns["tienThue"].HeaderText = "Tiền thuế";
                dt.Columns["tienThue"].Width = 230;
                dt.Columns["tienThue"].DefaultCellStyle.Format = "###,### VNĐ";
                dt.Columns["thanhTien"].HeaderText = "Thành tiền";
                dt.Columns["thanhTien"].Width = 230;
                dt.Columns["thanhTien"].DefaultCellStyle.Format = "###,### VNĐ";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
            lst = hdBUS.hoaDonHonLoanTheoThang(thang, nam);
            dgvCT.DataSource = null;
            ttbxHD2.Text = "";
            tbtnSapXep.Enabled = true;
            if (lst != null)
            {
                bds.DataSource = lst;
                dgvHD.DataSource = bds;
                bdnHD.BindingSource = bds;
                formatDataGridView(dgvHD);
                tbxTongHD.Text = lst.Count.ToString();
                tbxTongTien.Text = string.Format("{0:#,#. VNĐ}", hdBUS.tongTienTrongThang(thang, nam));
                lstct = ctBUS.chiTietHoaDonHonLoan(hd.MaHoaDon);
            }
            else
            {
                bds.DataSource = lst;
                dgvHD.DataSource = bds;
                bdnHD.BindingSource = bds;
                lstct = null;
                bds1.DataSource = lstct;
                dgvCT.DataSource = bds1;
                bdnCT.BindingSource = bds1;
                tbxTongHD.Text = "0";
                tbxTongTien.Text = "0";
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHD.SelectedRows.Count > 0)
            {
                if (lstct != null)
                {
                    ttbxHD2.Text = hd.MaHoaDon;
                    lstct = ctBUS.chiTietHoaDonHonLoan(hd.MaHoaDon);
                    bds1.DataSource = lstct;
                    dgvCT.DataSource = bds1;
                    bdnCT.BindingSource = bds1;
                    formatDataGridView2(dgvCT);
                }

            }
            else
            {
                MessageBox.Show("Chọn hóa đơn cần xem");
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvHD.SelectedRows.Count > 0)
            {
                dgvCT.DataSource = null;
                ttbxHD2.Text = "";
                hd.MaHoaDon = e.Row.Cells["mahoadon"].Value.ToString();
                bdnCT.BindingSource = null;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvHD.ClearSelection();
        }

        private void cbThang_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbNam_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tbtnSapXep_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
            lst = hdBUS.HoaDonHonLoanSapXep(thang, nam);
            if (lst != null)
            {
                bds.DataSource = lst;
                dgvHD.DataSource = bds;
                bdnHD.BindingSource = bds;
                formatDataGridView(dgvHD);
            }
            else
            {
                MessageBox.Show("Không có hóa đơn để sắp xếp");
            }
        }

        private void cbThang_SelectedValueChanged(object sender, EventArgs e)
        {
            tbtnSapXep.Enabled = false;
        }

        private void cbNam_SelectedValueChanged(object sender, EventArgs e)
        {
            tbtnSapXep.Enabled = false;
        }
    }
}
