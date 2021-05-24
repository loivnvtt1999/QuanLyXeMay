using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Charts;
using BUS;
using Entity;
namespace GUI
{
    public partial class frmThongKeSoLuongVaDoanhThu : Office2007RibbonForm
    {
        DataTable dts;
        ThongKeBUS thongKeBus;
        List<eThongKeSoLuongVaDoanhThuTheoThang> lTKSoLuong;
        int thang = 0;
        public frmThongKeSoLuongVaDoanhThu()
        {
            InitializeComponent();
            thongKeBus = new ThongKeBUS();
            lTKSoLuong = new List<eThongKeSoLuongVaDoanhThuTheoThang>();
        }

        private void frmThongKeSoLuongVaDoanhThu_Load(object sender, EventArgs e)
        {
            DateTime year = DateTime.Today;
            for (int i = 2019; i <= year.Year; i++)
            {
                cbNamThongKe.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                chartTien.Series["chartTien"].Points.AddXY(i, 0);
                chartSLuong.Series["chartSLuong"].Points.AddXY(i, 0);
            }
            btnChiTiet.Enabled = false;
        }
        System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Tháng");
            dt.Columns.Add("Số lượng bán ra");
            dt.Columns.Add("Tổng doanh thu");
            return dt;
        }
        void formatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Tháng"].Width = 150;
            dgr.Columns["Số lượng bán ra"].Width = 200;
            dgr.Columns["Tổng doanh thu"].Width = 200;
        }
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            dts = CreatData();
            if (String.IsNullOrWhiteSpace(cbNamThongKe.Text))
            {
                MessageBox.Show("Vui lòng chọn năm");
                cbNamThongKe.Focus();
                return;
            }
            int tam = int.Parse(cbNamThongKe.Text);
            lTKSoLuong = thongKeBus.ThongKeDoanhThuVaSoLuongTheoThang(tam);
            if (lTKSoLuong != null)
            {
                foreach (eThongKeSoLuongVaDoanhThuTheoThang tk in lTKSoLuong)
                {
                    dts.Rows.Add(tk.Thang, tk.SoLuong, tk.DoanhThu);
                   
                }
                dataGridViewX1.DataSource = dts;
                formatDataGridView(dataGridViewX1);
            }
           foreach(eThongKeSoLuongVaDoanhThuTheoThang tk in lTKSoLuong)
            {
                chartTien.Series["chartTien"].Points.AddXY(tk.Thang, tk.DoanhThu);
                chartSLuong.Series["chartSLuong"].Points.AddXY(tk.Thang, tk.SoLuong);
            }
        }

        private void dataGridViewX1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                btnChiTiet.Enabled = true;
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                thang = int.Parse(dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            }
            frmChiTietThongKe fct = new frmChiTietThongKe(thang,int.Parse(cbNamThongKe.Text));
            fct.ShowDialog();
        }
    }
}
