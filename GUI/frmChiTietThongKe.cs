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
using DevComponents.DotNetBar;
namespace GUI
{
    public partial class frmChiTietThongKe : Office2007Form
    {
        int thangTam;
        int namTam;
        ThongKeBUS tkBUS;
        List<eThongKeXeBanTheoNhanVienTrongThangX> lXeBan;
        XeBUS xBUS;
        NhanVienBUS nvBUS;
        KhachHangBUS khBUS;
        DataTable dts;
        public frmChiTietThongKe()
        {
            InitializeComponent();
        }
        public frmChiTietThongKe(int thangLay,int namLay)
        {
            InitializeComponent();
            thangTam = thangLay;
            namTam = namLay;
            tkBUS = new ThongKeBUS();
            xBUS = new XeBUS();
            nvBUS = new NhanVienBUS();
            khBUS = new KhachHangBUS();
            lXeBan = new List<eThongKeXeBanTheoNhanVienTrongThangX>();
        }

        private void frmChiTietThongKe_Load(object sender, EventArgs e)
        {
            lXeBan = tkBUS.ThongKeNhanVienTheoThang(thangTam,namTam);
            dts = CreatData();
            foreach(eThongKeXeBanTheoNhanVienTrongThangX x in lXeBan)
            {
                dts.Rows.Add(x.MaXe, xBUS.LayXeTheoMa(x.MaXe).TenXe, x.SoLuong, x.ThanhTien);               
            }
            dataGridViewX1.DataSource = dts;
            formatDataGridView(dataGridViewX1);
        }
        System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");
            return dt;
        }
        void formatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Tên xe"].Width = 150;
            dgr.Columns["Thành tiền"].Width = 150;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
