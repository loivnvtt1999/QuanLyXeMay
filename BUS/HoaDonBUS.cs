using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL hdDAL;
        public HoaDonBUS()
        {
            hdDAL = new HoaDonDAL();
        }

        public List<eHoaDon> LayTatCaHoaDon()
        {
            return hdDAL.LayAllHoaDon();
        }

        public eHoaDon TimKiemHoaDonTheoMa(String ma)
        {
            return hdDAL.TimKiemHoaDon(ma);
        }

        public List<object> hoaDonHonLoanTheoThang(int thang, int nam)
        {
            return hdDAL.hoaDonHonLoan(thang, nam);
        }

        public double tongTienTrongThang(int thang, int nam)
        {
            return hdDAL.tongTienTrongThang(thang, nam);
        }

        public List<object> HoaDonHonLoanSapXep(int thang, int nam)
        {
            return hdDAL.HoaDonHonLoanSapXep(thang, nam);
        }

        public int ThemHoaDon(eHoaDon hdMoi)
        {
            return hdDAL.ThemHoaDon(hdMoi);
        }

        public void SuaTrangThaiHoaDon(string ma)
        {
            hdDAL.SuaTrangThaiHoaDon(ma);
        }

        public string PhatSinhMa()
        {
            return hdDAL.PhatSinhMa();
        }
        public double TongTienTrongHoaDon(HoaDon hd)
        {
            return hdDAL.TongTienTrongHoaDon(hd);
        }
        public List<eHoaDon> LayDanhSachHoaDonChuaNhanXe()
        {
            return hdDAL.LayDanhSachHoaDonChuaNhanXe();
        }
        public List<eHoaDon> LayDanhSachHoaDonChuaNhanXeTheoMaKhachHang(string ma)
        {
            return hdDAL.LayDanhSachHoaDonChuaNhanXeTheoMaKhachHang(ma);
        }
    }
}
