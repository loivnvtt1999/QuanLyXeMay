using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class HangXeBUS
    {
        HangXeDAL hangDAL;
        public HangXeBUS()
        {
            hangDAL = new HangXeDAL();
        }
        public string layTenHangTheoMaHang(string mahang)
        {
            return hangDAL.layTenHangTheoMaHang(mahang);
        }
        public string layXuatXuTheoMaHang(string mahang)
        {
            return hangDAL.layXuatXuTheoMaHang(mahang);
        }
    }
}
