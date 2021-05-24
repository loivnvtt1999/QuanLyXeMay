using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class LoaiXeBUS
    {
        LoaiXeDAL loaiDAL;
        public LoaiXeBUS()
        {
            loaiDAL = new LoaiXeDAL();
        }
        public string layTenLoaiTheoMaLoai(string maloai)
        {
            return loaiDAL.layTenLoaiTheoMaLoai(maloai);
        }
    }
}
