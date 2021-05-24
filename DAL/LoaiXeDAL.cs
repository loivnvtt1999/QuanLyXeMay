using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class LoaiXeDAL
    {
        QuanLyBanXeDataContext db;
        public LoaiXeDAL()
        {
            db = new QuanLyBanXeDataContext();
        }
        public string layTenLoaiTheoMaLoai(string maloai)
        {
            return db.LoaiXes.Where(x => x.maLoai.Equals(maloai)).FirstOrDefault().tenLoai;
        }
    }
}
