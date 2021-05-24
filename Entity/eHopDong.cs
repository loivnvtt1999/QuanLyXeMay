using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eHopDong
    {
        string maHopDong, maNhanVien, maKhachHang, maXe, trangThai;
        DateTime ngayLap;

        public eHopDong()
        {
            this.MaHopDong = "";
            this.MaNhanVien = "";
            this.MaKhachHang = "";
            this.MaXe = "";
            this.TrangThai = "Chưa thanh toán";
            this.NgayLap = DateTime.Today;
        }

        public eHopDong(string maHDG, string nv, string kh, string xe, string tt, DateTime ngay)
        {
            this.MaHopDong = maHDG;
            this.MaNhanVien = nv;
            this.MaKhachHang = kh;
            this.MaXe = xe;
            this.TrangThai = tt;
            this.NgayLap = ngay;
        }


        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaXe { get => maXe; set => maXe = value; }
    }
}
