using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eNhanVien
    {
        String maNhanVien, tenNhanVien, cmnd, soDienThoaiNV, email, chucVu, matKhau, maDiaChi;
        DateTime ngaySinh;
        MemoryStream anh;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string SoDienThoaiNV { get => soDienThoaiNV; set => soDienThoaiNV = value; }
        public string Email { get => email; set => email = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaDiaChi { get => maDiaChi; set => maDiaChi = value; }
        public MemoryStream Anh { get => anh; set => anh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public eNhanVien()
        {
            MaNhanVien = "";
            TenNhanVien = "";
            Cmnd = "";
            NgaySinh = DateTime.Today;
            SoDienThoaiNV = "";
            Email = "";
            ChucVu = "";
            MatKhau = "";
            MaDiaChi = "";
            Anh = new MemoryStream();
        }

        public eNhanVien(string ma, string ten, string cmnd, DateTime ngay, string sdt, string email, string mk, string cv, string dc, MemoryStream anh)
        {
            MaNhanVien = ma;
            TenNhanVien = ten;
            Cmnd = cmnd;
            NgaySinh = ngay;
            SoDienThoaiNV = sdt;
            Email = email;
            ChucVu = cv;
            MatKhau = mk;
            MaDiaChi = dc;
            Anh = anh;
        } 
    }
}
