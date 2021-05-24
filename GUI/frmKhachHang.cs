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
    public partial class frmKhachHang : Form
    {
        public eKhachHang khachhang;
        KhachHangBUS khBUS;
        frmNhapDiaChi frmDC;
        eDiaChi dc;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            khachhang = new eKhachHang();
            khBUS = new KhachHangBUS();
            tbxMa.Text = khBUS.PhatSinhMaMoi();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxTen.Text) && !string.IsNullOrWhiteSpace(tbxCMND.Text) && !string.IsNullOrWhiteSpace(tbxEmail.Text) && !string.IsNullOrWhiteSpace(tbxSdt.Text) && dc != null)
            {
                khachhang.MaKH = tbxMa.Text;
                khachhang.TenKH = tbxTen.Text;
                khachhang.CMNDKH = tbxCMND.Text;
                khachhang.EmailKH = tbxEmail.Text;
                khachhang.SdtKH = tbxSdt.Text;
                khachhang.MaDC = dc.MaDC;
                khBUS.themKhachHang(khachhang);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }
    }
}
