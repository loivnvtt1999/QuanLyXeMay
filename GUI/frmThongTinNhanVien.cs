using BUS;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinNhanVien : Form
    {
        eNhanVien nv;
        DiaChiBUS dcBUS;
        Thread t1;
        object thisLock = new object();
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        public frmThongTinNhanVien(eNhanVien nhanvien)
        {
            InitializeComponent();
            nv = nhanvien;
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            dcBUS = new DiaChiBUS();
            hienThongTinNhanVien();
            DateTime date = DateTime.Now;
            lblClock.Text = date.ToString("hh:mm:ss");
            t1 = new Thread(start);
            t1.Start();
        }

        private void start()
        {
            Event clock = new Event();
            newdigital(clock);
            clock.Run();
        }
        private void newdigital(Event clock)
        {
            clock.OnSecondChange += new Event.SecondChangeHandler(Show);
        }
        private void Show(object obj, EventArgs arg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate () { Show(obj, arg); }));
            }
            else
            {
                DateTime date = DateTime.Now;
                lblClock.Text = date.ToString("hh:mm:ss");
            }
        }

        public void hienThongTinNhanVien()
        {
            lblMaNV.Text = nv.MaNhanVien;
            lblTenNV.Text = nv.TenNhanVien;
            lblCMND.Text = nv.Cmnd;
            lblNgaySinh.Text = nv.NgaySinh.ToShortDateString().ToString();
            lblSdt.Text = nv.SoDienThoaiNV;
            lblEmail.Text = nv.Email;
            lblChucVu.Text = nv.ChucVu;
            lblDiaChi.Text = layDiaChi(nv.MaDiaChi);
            if (nv.Anh != null)
            {
                Image img = Image.FromStream(nv.Anh);
                if (img == null)
                    return;
                picAnhNV.Image = img;
            }
        }

        public string layDiaChi(string maDC)
        {
            string diachi = "";
            eDiaChi dc = new eDiaChi();
            dc = dcBUS.LayDiaChiCoMa(maDC);
            diachi = dc.SoNha + ", " + dc.PhuongXa + ", " + dc.QuanHuyen + ", " + dc.TinhThanhPho + ", " + dc.QuocGia;
            return diachi;
        }

        private void frmThongTinNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmThongTinNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
