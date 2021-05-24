using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BUS
{
    public class ThongKeBUS
    {
        ThongKeDAL tkDAL;
        public ThongKeBUS()
        {
            tkDAL = new ThongKeDAL();
        }
        public List<eThongKeXeBanTheoNhanVienTrongThangX> ThongKeNhanVienTheoThang(int thang, int nam)
        {
            return tkDAL.ThongKeXeBanTheoThangVaTheoNhanVien(thang, nam);
        }
        public List<eThongKeSoLuongVaDoanhThuTheoThang> ThongKeDoanhThuVaSoLuongTheoThang(int nam)
        {
            return tkDAL.ThongKeSoLuongVaDoanhThuTheoThang(nam);
        }
        public List<eThongKeBanChay> ThongKebanChay(int thang, int nam)
        {
            return tkDAL.DanhSachBanChay(thang, nam);
        }
    }
}
