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
    public partial class frmManHinhChinhNhanVienBanHang : Form
    {
        eNhanVien nv;
        frmDangNhap frmDN;
        public frmManHinhChinhNhanVienBanHang()
        {
            InitializeComponent();
        }

        public frmManHinhChinhNhanVienBanHang(eNhanVien nhanvien, frmDangNhap frmDangNhap)
        {
            InitializeComponent();
            nv = nhanvien;
            frmDN = frmDangNhap;
        }

        private void frmManHinhChinhNhanVienBanHang_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = nv.TenNhanVien;
            frmThongTinNhanVien frmTTNV = new frmThongTinNhanVien(nv);
            hienForm(frmTTNV);
        }

        void hienForm(Form frm)
        {
            this.pnlGiaoDien.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ShowInTaskbar = false;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            this.pnlGiaoDien.Controls.Add(frm);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDN.Close();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien frmTTNV = new frmThongTinNhanVien(nv);
            hienForm(frmTTNV);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManHinhChinhNhanVienBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDN.Close();
        }

        private void tạoHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDong frm = new frmHopDong(nv);
            hienForm(frm);
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon(nv);
            hienForm(frm);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSanPham frm = new frmThongTinSanPham();
            hienForm(frm);
        }
    }
}
