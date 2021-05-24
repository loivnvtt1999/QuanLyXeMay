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
    public partial class frmBanChay : Office2007RibbonForm
    {
        ThongKeBUS tkBUS;
        List<eThongKeBanChay> lBanChay;
        DataTable dts;
        public frmBanChay()
        {
            InitializeComponent();
            tkBUS = new ThongKeBUS();
            lBanChay = new List<eThongKeBanChay>();
        }

        private void frmBanChay_Load(object sender, EventArgs e)
        {
            DateTime year = DateTime.Today;
            for (int i = 2019; i <= year.Year; i++)
            {
                comboBoxEx2.Items.Add(i);
            }
            for(int i = 1; i <= 12; i++)
            {
                comboBoxEx1.Items.Add(i);
            }
        }
        System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã xe");
            dt.Columns.Add("Tên xe");
            dt.Columns.Add("Số lượng đã bán");
            dt.Columns.Add("Màu sắc");
            return dt;
        }
        void formatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Mã xe"].Width = 100;
            dgr.Columns["Tên xe"].Width = 150;
            dgr.Columns["Số lượng đã bán"].Width = 200;
            dgr.Columns["Màu sắc"].Width = 150;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            dts = CreatData();
            if (String.IsNullOrWhiteSpace(comboBoxEx1.Text))
            {
                MessageBox.Show("Vui lòng chọn tháng thống kê");
                comboBoxEx1.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(comboBoxEx2.Text))
            {
                MessageBox.Show("Vui lòng chọn năm thống kê");
                comboBoxEx2.Focus();
                return;
            }
            lBanChay = tkBUS.ThongKebanChay(int.Parse(comboBoxEx1.Text), int.Parse(comboBoxEx2.Text));
            if (lBanChay != null)
            {
                foreach (eThongKeBanChay tk in lBanChay)
                {
                    dts.Rows.Add(tk.MaXe,tk.TenXe,tk.SoLuong,tk.MauSac);

                }
                dgrThongKe.DataSource = dts;
                formatDataGridView(dgrThongKe);
            }
        }
    }
}
