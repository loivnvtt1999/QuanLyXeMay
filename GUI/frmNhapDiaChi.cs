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
    public partial class frmNhapDiaChi : Form
    {
        DiaChiBUS dcBUS;
        public eDiaChi diaChiTamThoi;
        public frmNhapDiaChi()
        {
            InitializeComponent();
        }

        private void frmNhapDiaChi_Load(object sender, EventArgs e)
        {
            dcBUS = new DiaChiBUS();
        }

        public eDiaChi layDiaChiVuaTao()
        {
            eDiaChi dcmoi = new eDiaChi();
            dcmoi.MaDC = dcBUS.PhatSinhMa();
            dcmoi.SoNha = tbxSoNha.Text;
            dcmoi.TinhThanhPho = tbxTinh.Text;
            dcmoi.QuanHuyen = tbxQuanHuyen.Text;
            dcmoi.PhuongXa = tbxPhuongXa.Text;
            dcmoi.QuocGia = tbxQuocGia.Text;
            return dcmoi;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTinh.Text) || string.IsNullOrEmpty(tbxSoNha.Text) || string.IsNullOrEmpty(tbxPhuongXa.Text) || string.IsNullOrEmpty(tbxQuanHuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                diaChiTamThoi = layDiaChiVuaTao();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
