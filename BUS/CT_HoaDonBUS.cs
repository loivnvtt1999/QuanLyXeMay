using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class CT_HoaDonBUS
    {
        CT_HoaDonDAL ctDAL;
        public CT_HoaDonBUS()
        {
            ctDAL = new CT_HoaDonDAL();
        }
        public List<object> chiTietHoaDonHonLoan(string ma)
        {
            return ctDAL.chiTietHoaDonHonLoan(ma);
        }
        public double TinhTienThue(eCT_HoaDon ct)
        {
            return ctDAL.TinhTienThue(ct);
        }
        public double TinhTongTien(eCT_HoaDon ct)
        {
            return ctDAL.TinhTongTien(ct);
        }
        public void ThemChiTiet(eCT_HoaDon ctmoi)
        {
            ctDAL.ThemChiTiet(ctmoi);
        }

        public List<eCT_HoaDon> LayTatCaChiTietTheoMaHoaDon(string ma)
        {
            return ctDAL.LayTatCaChiTietTheoMaHoaDon(ma);
        }
    }
}
