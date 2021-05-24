using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAL khDAL;
        public KhachHangBUS()
        {
            khDAL = new KhachHangDAL();
        }

        public int themKhachHang(eKhachHang khmoi)
        {
            return khDAL.themtKhachHang(khmoi);
        }

        public int xoaKhachHang(eKhachHang khxoa)
        {
            return khDAL.xoaKhachHang(khxoa);
        }
        public int suaKhachHang(eKhachHang khsua)
        {
            return khDAL.suaKhachHang(khsua);
        }
        public eKhachHang layKhachHangTheoMa(string makh)
        {
            return khDAL.layKhachHang(makh);
        }
        public string PhatSinhMaMoi()
        {
            return khDAL.PhatSinhMa();
        }
        public List<eKhachHang> LayToanBoDanhSach()
        {
            return khDAL.LayToanBoDanhSach();
        }
        public eKhachHang LayKhachHangTheoSDT(string sdt)
        {
            return khDAL.layKhachHangTheoSDT(sdt);
        }
        public List<eKhachHang> LayDanhSachTheoTen(string ten)
        {
            return khDAL.LayDanhSachTheoTen(ten);
        }
    }
}
