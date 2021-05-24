using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL nvDAL;
        public NhanVienBUS()
        {
            nvDAL = new NhanVienDAL();
        }
        public List<eNhanVien> layDanhSachNhanVien()
        {
            return nvDAL.LayDanhSachNhanVien();
        }
        public List<eNhanVien> layDanhSachNhanVienKhongAnh()
        {
            return nvDAL.LayDanhSachNhanVienKhongChuaAnh();
        }
        public eNhanVien TimNhanVienTheoMa(string ma)
        {
            return nvDAL.TimNhanVienTheoMa(ma);
        }
        public bool kiemTraNhanVien(string ma)
        {
            return nvDAL.KiemTraNhanVien(ma);
        }
        public int themNhanVien(eNhanVien nv)
        {
            return nvDAL.ThemNhanVien(nv);
        }
        public int suaNhanVien(eNhanVien nv)
        {
            return nvDAL.SuaNhanVien(nv);
        }
        public int datLaiMatKhau(string manv)
        {
            return nvDAL.DatLaiMatKhau(manv);
        }
        public int xoaNhanVien(eNhanVien nv)
        {
            return nvDAL.XoaNhanVien(nv);
        }
        public eNhanVien kiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return nvDAL.KiemTraDangNhap(taiKhoan, matKhau);
        }
        public int DoiMatKhau(string taikhoan, string matkhau, string matkhaumoi)
        {
            return nvDAL.DoiMatKhau(taikhoan, matkhau, matkhaumoi);
        }
        public string PhatSinhMa()
        {
            return nvDAL.PhatSinhMa();
        }
    }
}
