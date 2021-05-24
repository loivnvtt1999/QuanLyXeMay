using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class HopDongBUS
    {
        HopDongDAL hdgDAL;
        public HopDongBUS()
        {
            hdgDAL = new HopDongDAL();
        }

        public List<eHopDong> LayAllHopDong()
        {
            return hdgDAL.LayAllHopDong();
        }

        public List<eHopDong> LayDSHopDongChuaThanhToanCuaKhachHang(string maKH)
        {
            return hdgDAL.LayDSHopDongChuaThanhToanCuaKhachHang(maKH);
        }

        public int ThemHopDong(eHopDong hdThem)
        {
            return hdgDAL.ThemHopDong(hdThem);
        }

        public int SuaHopDong(eHopDong hdSua)
        {
            return hdgDAL.SuaHopDong(hdSua);
        }
        public string PhatSinhMa()
        {
            return hdgDAL.PhatSinhMa();
        }
        public eHopDong LayHopDongTheoMa(String ma)
        {
            return hdgDAL.LayHopDongTheoMa(ma);
        }
        public void DoiTrangThai(string ma)
        {
            hdgDAL.DoiTrangThai(ma);
        }
    }
}
