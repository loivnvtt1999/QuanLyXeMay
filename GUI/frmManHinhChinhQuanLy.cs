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
    public partial class frmManHinhChinhQuanLy : Form
    {
        eNhanVien nv;
        frmDangNhap frmDN;
        public frmManHinhChinhQuanLy()
        {
            InitializeComponent();
        }

        public frmManHinhChinhQuanLy(eNhanVien nhanvien, frmDangNhap frmDangNhap)
        {
            InitializeComponent();
            nv = nhanvien;
            frmDN = frmDangNhap;
        }

        private void frmManHinhChinhQuanLy_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dt == DialogResult.OK)
            {
                frmDN.Close();
                this.Close();
            } 
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            hienForm(frm);
        }

        private void taToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon(nv);
            hienForm(frm);
        }

        private void frmManHinhChinhQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            pnlGiaoDien.Controls.Clear();
        }

        private void thoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeHoaDon frm = new frmThongKeHoaDon();
            hienForm(frm);
        }

        private void tạoHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDong frm = new frmHopDong(nv);
            hienForm(frm);
        }

        private void lậpPhiếuXuấtXeToolStripMenuItem_Click(object sender, EventArgs e)
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
