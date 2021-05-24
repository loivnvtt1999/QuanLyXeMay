using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class XeBUS
    {
        XeDAL xeDAL;

        public XeBUS()
        {
            xeDAL = new XeDAL();
        }

        public List<eXe> LayDanhSachXe()
        {
            return xeDAL.LayDanhSachXe();
        }

        public int ThemXe(eXe xenew)
        {
            return xeDAL.ThemXe(xenew);
        }

        public int SuaThongTinXe(eXe xesua)
        {
            return xeDAL.SuaThongTinXe(xesua);
        }

        public int XoaXe(eXe xexoa)
        {
            return xeDAL.XoaXe(xexoa);
        }

        public int TangSoLuong(eXe xe, int sl)
        {
            return xeDAL.TangSoLuong(xe, sl);
        }

        public int GiamSoLuong(eXe xe, int sl)
        {
            return xeDAL.GiamSoLuong(xe, sl);
        }

        public int KiemTraSoLuong(eXe xe, int sl)
        {
            return xeDAL.KiemTraSoLuong(xe, sl);
        }

        public eXe LayXeTheoMa(string ma)
        {
            return xeDAL.LayXeTheoMa(ma);
        }

        public eXe LayXeTheoTen(string ten)
        {
            return xeDAL.LayXeTheoTen(ten);
        }
        public string PhatSinhMa()
        {
            return xeDAL.PhatSinhMa();
        }
        public double SinhGiaBan(eXe xe)
        {
            return xeDAL.SinhGiaBan(xe);
        }

        public int SoLuongConThucSu(eXe xe)
        {
            return xeDAL.SoLuongConThucSu(xe);
        }
    }
}
