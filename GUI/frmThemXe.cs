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
    public partial class frmThemXe : Form
    {
        int flagSua;
        XeBUS xeBUS;
        NhaCungCapBUS nccBUS;
        HangXeBUS hangBUS;
        LoaiXeBUS loaiBUS;
        List<eNhaCungCap> lNCC;
        public eXe xemoi;
        public frmThemXe()
        {
            InitializeComponent();
            xemoi = new eXe();
            flagSua = 0;
        }

        public frmThemXe(eXe xeCanSua)
        {
            InitializeComponent();
            xemoi = xeCanSua;
            flagSua = 1;
        }

        private void frmThemXe_Load(object sender, EventArgs e)
        {
            xeBUS = new XeBUS();
            nccBUS = new NhaCungCapBUS();
            hangBUS = new HangXeBUS();
            loaiBUS = new LoaiXeBUS();
            lNCC = new List<eNhaCungCap>();
            tbxMaXe.Enabled = false;
            tbxSoLuong.Enabled = false;
            SetDatacboNCC();
            if (flagSua == 1)
            {
                ThietLapDuLieuTrenForm();
            }
            if (flagSua == 0)
            {
                tbxMaXe.Text = xeBUS.PhatSinhMa();
                tbxSoLuong.Text = "0";
            }
            SetDatacboMauSac();
            SetDatacboPhanKhoi();
            SetDatacboLoaiPhanh();
            SetDatacboLoaiBanh();
        }
        public void SetDatacboNCC()
        {
            lNCC = nccBUS.LayToanBoNhaCungCap();
            eNhaCungCap e = new eNhaCungCap();
            cboNCC.DataSource = lNCC;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        public void SetDatacboMauSac()
        {
            string[] str = new string[] { "Đen", "Trắng", "Đỏ", "Hồng", "Xám", "Xanh", "Đỏ đậm" };
            cboMauSac.DataSource = str;
        }
        public void SetDatacboPhanKhoi()
        {
            string[] str = new string[] { "50", "100", "110", "125", "150"};
            cboPhanKhoi.DataSource = str;
        }
        public void SetDatacboLoaiPhanh()
        {
            string[] str = new string[] { "CBS", "Phanh Dĩa"};
            cboLoaiPhanh.DataSource = str;
        }
        public void SetDatacboLoaiBanh()
        {
            string[] str = new string[] { "Bánh mâm", "Bánh căm" };
            cboLoaiBanh.DataSource = str;
        }
        public void ThietLapDuLieuTrenForm()
        {
            if (flagSua == 1)
            {
                tbxMaXe.Text = xemoi.MaXe;
                tbxMaXe.Enabled = false;
                tbxTenXe.Text = xemoi.TenXe;
                tbxTenXe.Enabled = false;
                cboHangXe.Text = hangBUS.layTenHangTheoMaHang(xemoi.MaHang);
                cboHangXe.Enabled = false;
                cboLoaiXe.Text = loaiBUS.layTenLoaiTheoMaLoai(xemoi.MaLoai);
                cboLoaiXe.Enabled = false;
                cboNCC.Text = nccBUS.LayNhaCungCap(xemoi.MaNCC).TenNCC;
                cboNCC.Enabled = false;
                tbxCongSuat.Text = xemoi.CongSuat.ToString("#,#");
                tbxDoCao.Text = xemoi.DoCaoYen.ToString();
                tbxDungTichBinhXang.Text = xemoi.DungTichBinhXang.ToString("#,#");
                tbxKhoiLuong.Text = xemoi.KhoiLuong.ToString("#,#");
                cboMauSac.Text = xemoi.MauSac;
                cboPhanKhoi.Text = xemoi.PhanKhoi;
                cboPhanKhoi.Enabled = false;
                tbxSoLuong.Text = xemoi.SoLuong.ToString();
                tbxGiaThanh.Text = xemoi.GiaThanh.ToString("#,#");
                cboLoaiPhanh.Text = xemoi.LoaiPhanh;
                cboLoaiBanh.Text = xemoi.LoaiBanh;
                tbxDuongKinhPitTong.Text = xemoi.DuongKinhPitTong.ToString("#,#");
            }
        }
        public eXe TaoXe()
        {
            eXe xemoi = new eXe();
            xemoi.MaXe = tbxMaXe.Text;
            xemoi.TenXe = tbxTenXe.Text;
            xemoi.MaHang = "HA0001";
            if (cboLoaiXe.Text.Equals("Xe số")) xemoi.MaLoai = "LX0001";
            else if (cboLoaiXe.Text.Equals("Xe tay ga")) xemoi.MaLoai = "LX0002";
            else xemoi.MaLoai = "LX0003";
            xemoi.PhanKhoi = cboPhanKhoi.Text;
            xemoi.DoCaoYen = int.Parse(tbxDoCao.Text.ToString());
            xemoi.CongSuat = float.Parse(tbxCongSuat.Text.ToString());
            xemoi.DungTichBinhXang = float.Parse(tbxDungTichBinhXang.Text.ToString());
            xemoi.DuongKinhPitTong = float.Parse(tbxDuongKinhPitTong.Text.ToString());
            xemoi.MauSac = cboMauSac.Text;
            xemoi.KhoiLuong = float.Parse(tbxKhoiLuong.Text.ToString());
            xemoi.GiaThanh = float.Parse(tbxGiaThanh.Text.ToString());
            xemoi.SoLuong = int.Parse(tbxSoLuong.Text.ToString());
            xemoi.LoaiPhanh = cboLoaiPhanh.Text;
            xemoi.LoaiBanh = cboLoaiBanh.Text;
            xemoi.MaNCC = cboNCC.SelectedValue.ToString();
            return xemoi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagSua == 0)
            {
                xemoi = TaoXe();
                int kq = xeBUS.ThemXe(xemoi);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã bị trùng");
                }
            }
            else
            {
                eXe xeSua = new eXe();
                xeSua = TaoXe();
                int kq = xeBUS.SuaThongTinXe(xeSua);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("????");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmncc = new frmThemNhaCungCap();
            frmncc.ShowDialog();
            if (frmncc.DialogResult == DialogResult.OK)
            {
                eNhaCungCap nccmoithem = frmncc.nccmoitao;
                SetDatacboNCC();
                cboNCC.Text = nccmoithem.TenNCC;
            }
        }

        private void cbHangXe_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbLoaiXe_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbNCC_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cboMauSac_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cboPhanKhoi_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
