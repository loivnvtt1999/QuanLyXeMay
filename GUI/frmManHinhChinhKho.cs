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
    public partial class frmManHinhChinhKho : Form
    {
        eNhanVien nv;
        frmDangNhap frmDN;
        public frmManHinhChinhKho()
        {
            InitializeComponent();
        }

        public frmManHinhChinhKho(eNhanVien nhanvien, frmDangNhap frmDangNhap)
        {
            InitializeComponent();
            nv = nhanvien;
            frmDN = frmDangNhap;
        }

        private void frmManHinhChinhKho_Load(object sender, EventArgs e)
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

        private void quảnLýNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhap frm = new frmTaoPhieuNhap(nv);
            hienForm(frm);
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDN.Close();
            this.Close();
        }

        private void frmManHinhChinhKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDN.Close();
        }

        private void lậpPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoPhieuXuat frm = new frmTaoPhieuXuat(nv);
            hienForm(frm);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSanPham frm = new frmThongTinSanPham();
            hienForm(frm);
        }
    }
}
