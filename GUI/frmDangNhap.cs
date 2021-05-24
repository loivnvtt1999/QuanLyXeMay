using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entity;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        eNhanVien nv;
        NhanVienBUS nvBUS;
        Thread trd;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(4000);
            trd.Abort();
            this.BringToFront();
            this.tbxMatKhau.PasswordChar = '*';
            nvBUS = new NhanVienBUS();
            nv = new eNhanVien();
            tbxTenDN.Text = "NV0001";
            tbxMatKhau.Text = "12345678";
            this.ActiveControl = tbxTenDN;
        }

        private void formRun()
        {
            Application.Run(new frmSplash());
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!nvBUS.kiemTraNhanVien(tbxTenDN.Text))
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbxMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nv = nvBUS.kiemTraDangNhap(tbxTenDN.Text, tbxMatKhau.Text);
                    if (nv == null)
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        this.Hide();
                        if (nv.ChucVu.Equals("Quản Lý"))
                        {
                            frmManHinhChinhQuanLy frmMHC = new frmManHinhChinhQuanLy(nv, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                        else if (nv.ChucVu.Equals("Kho"))
                        {
                            frmManHinhChinhKho frmMHC = new frmManHinhChinhKho(nv, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                        else
                        {
                            frmManHinhChinhNhanVienBanHang frmMHC = new frmManHinhChinhNhanVienBanHang(nv, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                        
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
