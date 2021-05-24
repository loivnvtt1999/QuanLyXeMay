using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class HangXeDAL
    {
        QuanLyBanXeDataContext db;
        public HangXeDAL()
        {
            db = new QuanLyBanXeDataContext();
        }
        public string layTenHangTheoMaHang(string mahang)
        {
            return db.HangXes.Where(x => x.maHang.Equals(mahang)).FirstOrDefault().tenHang;
        }
        public string layXuatXuTheoMaHang(string mahang)
        {
            return db.HangXes.Where(x => x.maHang.Equals(mahang)).FirstOrDefault().xuatXu;
        }
    }
}
