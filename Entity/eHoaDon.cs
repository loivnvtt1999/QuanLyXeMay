using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eHoaDon
    {
        string maHoaDon, maNhanVien, maKhachHang, trangThai;
        DateTime ngayLap;

        public eHoaDon()
        {
            this.MaHoaDon = "";
            this.MaNhanVien = "";
            this.MaKhachHang = "";
            this.TrangThai = "Chưa nhận xe";
            this.NgayLap = DateTime.Today;
        }

        public eHoaDon(string maHD, string nv, string kh, string tt, DateTime ngay)
        {
            this.MaHoaDon = maHD;
            this.MaNhanVien = nv;
            this.MaKhachHang = kh;
            this.TrangThai = tt;
            this.NgayLap = ngay;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
    }
}
