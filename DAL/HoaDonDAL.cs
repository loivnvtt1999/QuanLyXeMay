using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace DAL
{
    public class HoaDonDAL
    {
        QuanLyBanXeDataContext db;

        public HoaDonDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public List<eHoaDon> LayAllHoaDon()
        {
            List<eHoaDon> l = new List<eHoaDon>();
            foreach (HoaDon hdon in db.HoaDons)
            {
                eHoaDon hdon1 = new eHoaDon();
                hdon1.MaHoaDon = hdon.maHoaDon;
                hdon1.MaNhanVien = hdon.maNhanVien;
                hdon1.MaKhachHang = hdon.maKhachHang;
                hdon1.NgayLap = hdon.ngayLap;
                hdon1.TrangThai = hdon.trangThai;
                l.Add(hdon1);
            }
            return l;
        }

        public List<eHoaDon> LayDanhSachHoaDonChuaNhanXe()
        {
            List<eHoaDon> l = new List<eHoaDon>();
            List<HoaDon> list = db.HoaDons.Where(hd => hd.trangThai.Equals("Chưa nhận xe")).ToList();
            foreach (HoaDon hdon in list)
            {
                eHoaDon hdon1 = new eHoaDon();
                hdon1.MaHoaDon = hdon.maHoaDon;
                hdon1.MaNhanVien = hdon.maNhanVien;
                hdon1.MaKhachHang = hdon.maKhachHang;
                hdon1.NgayLap = hdon.ngayLap;
                hdon1.TrangThai = hdon.trangThai;
                l.Add(hdon1);
            }
            return l;
        }

        public List<eHoaDon> LayDanhSachHoaDonChuaNhanXeTheoMaKhachHang(string ma)
        {
            List<eHoaDon> l = new List<eHoaDon>();
            List<HoaDon> list = db.HoaDons.Where(hd => hd.trangThai.Equals("Chưa nhận xe")&&hd.maKhachHang.Equals(ma)).ToList();
            foreach (HoaDon hdon in list)
            {
                eHoaDon hdon1 = new eHoaDon();
                hdon1.MaHoaDon = hdon.maHoaDon;
                hdon1.MaNhanVien = hdon.maNhanVien;
                hdon1.MaKhachHang = hdon.maKhachHang;
                hdon1.NgayLap = hdon.ngayLap;
                hdon1.TrangThai = hdon.trangThai;
                l.Add(hdon1);
            }
            return l;
        }

        public eHoaDon TimKiemHoaDon(String ma)
        {
            HoaDon hdon = db.HoaDons.Where(x => x.maHoaDon.Equals(ma)).FirstOrDefault();
            if (hdon == null)
                return null;
            eHoaDon hdnew = new eHoaDon();
            hdnew.MaHoaDon = hdon.maHoaDon;
            hdnew.TrangThai = hdon.trangThai;
            hdnew.NgayLap = hdon.ngayLap;
            return hdnew;
        }

        private bool KiemTraTonTai(string ma)
        {
            HoaDon hdon = db.HoaDons.Where(x => x.maHoaDon.Equals(ma)).FirstOrDefault();
            if (hdon == null)
                return false;
            return true;
        }

        public List<object> hoaDonHonLoan(int thang, int nam)
        {
            var n = from a in db.HoaDons
                    join chitiet in db.CT_HoaDons on a.maHoaDon equals chitiet.maHoaDon into j1
                    from b in j1.DefaultIfEmpty()
                    join nhanvien in db.NhanViens on a.maNhanVien equals nhanvien.maNhanVien into j2
                    from c in j2.DefaultIfEmpty()
                    join khachhang in db.KhachHangs on a.maKhachHang equals khachhang.maKhachHang into j3
                    from d in j3.DefaultIfEmpty()
                    where a.ngayLap.Month == thang && a.ngayLap.Year == nam
                    group a by
                    new
                    {
                        maHoaDon = a.maHoaDon,
                        tenNhanVien = c.tenNhanVien,
                        tenKhachHang = d.tenKhachHang,
                        ngayLap = a.ngayLap,
                        tongTien = db.CT_HoaDons.Where(h => h.maHoaDon.Equals(a.maHoaDon)).Sum(b => b.giaBan * b.thue + b.giaBan)
                    } into g
                    select g.Key;
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }
            if (lst.Count == 0)
            {
                return null;
            }

            return lst;
        }
        public double tongTienTrongThang(int thang, int nam)
        {
            double tongTienThang = 0;
            List<HoaDon> l1 = db.HoaDons.Where(x => x.ngayLap.Month == thang && x.ngayLap.Year == nam).ToList();
            foreach (HoaDon hdon in l1)
            {
                tongTienThang += TongTienTrongHoaDon(hdon);
            }
            return tongTienThang;
        }
        public List<object> HoaDonHonLoanSapXep(int thang, int nam)
        {
            var n = from a in db.HoaDons
                    join chitiet in db.CT_HoaDons on a.maHoaDon equals chitiet.maHoaDon into j1
                    from b in j1.DefaultIfEmpty()
                    join nhanvien in db.NhanViens on a.maNhanVien equals nhanvien.maNhanVien into j2
                    from c in j2.DefaultIfEmpty()
                    join khachhang in db.KhachHangs on a.maKhachHang equals khachhang.maKhachHang into j3
                    from d in j3.DefaultIfEmpty()
                    where a.ngayLap.Month == thang && a.ngayLap.Year == nam
                    group a by
                    new
                    {
                        maHoaDon = a.maHoaDon,
                        tenNhanVien = c.tenNhanVien,
                        tenKhachHang = d.tenKhachHang,
                        ngayLap = a.ngayLap,
                        tongTien = db.CT_HoaDons.Where(h => h.maHoaDon.Equals(a.maHoaDon)).Sum(b => b.giaBan * b.thue + b.giaBan)
                    } into g
                    select g.Key;
            var finallist = from a in n.OrderByDescending(x => x.tongTien)
                            select a;
            List<object> lst = new List<object>();
            foreach (var item in finallist)
            {
                lst.Add(item);
            }
            if (lst.Count == 0)
            {
                return null;
            }
            return lst;
        }

        public int ThemHoaDon(eHoaDon hdMoi)
        {
            if (KiemTraTonTai(hdMoi.MaHoaDon))
                return 0;
            HoaDon hdon = new HoaDon();
            hdon.maHoaDon = hdMoi.MaHoaDon;
            hdon.maNhanVien = hdMoi.MaNhanVien;
            hdon.maKhachHang = hdMoi.MaKhachHang;
            hdon.ngayLap = hdMoi.NgayLap;
            hdon.trangThai = hdMoi.TrangThai;
            db.HoaDons.InsertOnSubmit(hdon);
            db.SubmitChanges();
            return 1;
        }

        public void SuaTrangThaiHoaDon(string ma)
        {
            HoaDon hdon = db.HoaDons.Where(x => x.maHoaDon.Equals(ma)).FirstOrDefault();
            hdon.trangThai = "Đã nhận xe";
            db.SubmitChanges();
        }

        public string PhatSinhMa()
        {
            int n = 0;
            string str="HD";
            HoaDon hd = db.HoaDons.ToList().LastOrDefault();
            if (hd != null)
            {
                string str1 = hd.maHoaDon.Substring(2);
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
        public double TongTienTrongHoaDon(HoaDon hd)
        {
            double tien = 0;
            List<CT_HoaDon> listct = db.CT_HoaDons.Where(x => x.maHoaDon.Equals(hd.maHoaDon)).ToList();
            foreach(CT_HoaDon h in listct)
            {
                tien += h.giaBan + h.thue * h.giaBan;
            }
            return tien;
        }
    }
}
