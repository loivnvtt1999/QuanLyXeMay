using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class HopDongDAL
    {
        QuanLyBanXeDataContext db;

        public HopDongDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public List<eHopDong> LayAllHopDong()
        {
            List<eHopDong> l = new List<eHopDong>();
            foreach (HopDong hd in db.HopDongs)
            {
                eHopDong hd1 = new eHopDong();
                hd1.MaHopDong = hd.maHopDong;
                hd1.MaKhachHang = hd.maKhachHang;
                hd1.MaNhanVien = hd.maNhanVien;
                hd1.MaXe = hd.maXe;
                hd1.TrangThai = hd.trangThai;
                hd1.NgayLap = hd.ngayLap;
                l.Add(hd1);
            }
            return l;
        }

        public eHopDong LayHopDongTheoMa(String ma)
        {
            HopDong hd = db.HopDongs.Where(x => x.maHopDong.Equals(ma)).FirstOrDefault();
            eHopDong hd1 = new eHopDong();
            if (hd != null)
            {
                hd1.MaHopDong = hd.maHopDong;
                hd1.MaKhachHang = hd.maKhachHang;
                hd1.MaNhanVien = hd.maNhanVien;
                hd1.MaXe = hd.maXe;
                hd1.TrangThai = hd.trangThai;
                hd1.NgayLap = hd.ngayLap;
            }
            return hd1;
        }

        private bool TimKiemHopDong(String ma)
        {
            HopDong hd = db.HopDongs.Where(x => x.maHopDong.Equals(ma)).FirstOrDefault();
            if (hd == null)
                return false;
            return true;
        }

        public int ThemHopDong(eHopDong hdThem)
        {
            if (TimKiemHopDong(hdThem.MaHopDong))
                return 0;
            HopDong hd = new HopDong();
            hd.maHopDong = hdThem.MaHopDong;
            hd.maKhachHang = hdThem.MaKhachHang;
            hd.maNhanVien = hdThem.MaNhanVien;
            hd.maXe = hdThem.MaXe;
            hd.trangThai = hdThem.TrangThai;
            hd.ngayLap = hdThem.NgayLap;
            db.HopDongs.InsertOnSubmit(hd);
            db.SubmitChanges();
            return 1;
        }

        public int SuaHopDong(eHopDong hdSua)
        {
            if (!TimKiemHopDong(hdSua.MaHopDong))
                return 0;
            HopDong hd = db.HopDongs.Where(x => x.maHopDong.Equals(hdSua.MaHopDong)).FirstOrDefault();
            hd.maKhachHang = hdSua.MaKhachHang;
            hd.maNhanVien = hdSua.MaNhanVien;
            hd.maXe = hdSua.MaXe;
            hd.trangThai = hdSua.TrangThai;
            hd.ngayLap = hdSua.NgayLap;
            db.SubmitChanges();
            return 1;
        }

        public List<eHopDong> LayDSHopDongChuaThanhToanCuaKhachHang(string maKH)
        {
            List<HopDong> lhd = db.HopDongs.Where(h => h.maKhachHang.Equals(maKH) && h.trangThai.Equals("Chưa thanh toán")).ToList();
            List<eHopDong> list = new List<eHopDong>();
            foreach(HopDong hd in lhd)
            {
                eHopDong ehd = new eHopDong();
                ehd.MaHopDong = hd.maHopDong;
                ehd.MaNhanVien = hd.maNhanVien;
                ehd.MaKhachHang = hd.maKhachHang;
                ehd.MaXe = hd.maXe;
                ehd.TrangThai = hd.trangThai;
                ehd.NgayLap = hd.ngayLap;
                list.Add(ehd);
            }
            return list;
        }

        public void DoiTrangThai(string ma)
        {
            HopDong hd = db.HopDongs.Where(h => h.maHopDong.Equals(ma)).FirstOrDefault();
            hd.trangThai = "Đã thanh toán";
            db.SubmitChanges();
        }

        public string PhatSinhMa()
        {
            int n = 0;
            string str = "HDG";
            HopDong hdg = db.HopDongs.ToList().LastOrDefault();
            if (hdg != null)
            {
                string str1 = hdg.maHopDong.Substring(3);
                n = int.Parse(str1)+1;
            }
            if (n < 10)
            {
                str = str + "000" + n.ToString();
            }
            else if (n < 100)
            {
                str = str + "00" + n.ToString();
            }
            else if (n < 1000)
            {
                str = str + "0" + n.ToString();
            }
            else if (n < 10000)
            {
                str = str + n.ToString();
            }
            return str;
        }
    }
}
