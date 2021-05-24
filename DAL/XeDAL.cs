using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class XeDAL
    {
        QuanLyBanXeDataContext db;
        public XeDAL()
        {
            this.db = new QuanLyBanXeDataContext();
        }

        public List<eXe> LayDanhSachXe()
        {
            List<eXe> l = new List<eXe>();
            foreach (Xe xe in db.Xes)
            {
                eXe xe1 = new eXe();
                xe1.MaXe = xe.maXe;
                xe1.TenXe = xe.tenXe;
                xe1.MaHang = xe.maHang;
                xe1.MaLoai = xe.maLoai;
                xe1.PhanKhoi = xe.phanKhoi;
                xe1.DoCaoYen = xe.doCaoYen;
                xe1.CongSuat = xe.congSuat;
                xe1.DungTichBinhXang = xe.dungTichBinhXang;
                xe1.DuongKinhPitTong = xe.duongKinhPitTong;
                xe1.MauSac = xe.mauSac;
                xe1.KhoiLuong = xe.khoiLuong;
                xe1.GiaThanh = xe.giaThanh;
                xe1.SoLuong = xe.soLuong;
                xe1.LoaiPhanh = xe.loaiPhanh;
                xe1.LoaiBanh = xe.loaiBanh;
                xe1.MaNCC = xe.maNCC;
                l.Add(xe1);
            }
            return l;
        }

        public eXe LayXeTheoMa(string ma)
        {
            eXe xe1 = new eXe();
            Xe xe = db.Xes.Where(x => x.maXe.Equals(ma)).FirstOrDefault();
            if (xe != null)
            {             
                xe1.MaXe = xe.maXe;
                xe1.TenXe = xe.tenXe;
                xe1.MaHang = xe.maHang;
                xe1.MaLoai = xe.maLoai;
                xe1.PhanKhoi = xe.phanKhoi;
                xe1.DoCaoYen = xe.doCaoYen;
                xe1.CongSuat = (float)xe.congSuat;
                xe1.DungTichBinhXang = (float)xe.dungTichBinhXang;
                xe1.DuongKinhPitTong = (float)xe.duongKinhPitTong;
                xe1.MauSac = xe.mauSac;
                xe1.KhoiLuong = (float)xe.khoiLuong;
                xe1.GiaThanh = (float)xe.giaThanh;
                xe1.SoLuong = xe.soLuong;
                xe1.LoaiPhanh = xe.loaiPhanh;
                xe1.LoaiBanh = xe.loaiBanh;
                xe1.MaNCC = xe.maNCC;
                return xe1;
            }
            return null;
        }

        public eXe LayXeTheoTen(string ten)
        {
            eXe xe1 = new eXe();
            Xe xe = db.Xes.Where(x => x.tenXe.Equals(ten)).FirstOrDefault();
            if (xe != null)
            {
                xe1.MaXe = xe.maXe;
                xe1.TenXe = xe.tenXe;
                xe1.MaHang = xe.maHang;
                xe1.MaLoai = xe.maLoai;
                xe1.PhanKhoi = xe.phanKhoi;
                xe1.DoCaoYen = xe.doCaoYen;
                xe1.CongSuat = (float)xe.congSuat;
                xe1.DungTichBinhXang = (float)xe.dungTichBinhXang;
                xe1.DuongKinhPitTong = (float)xe.duongKinhPitTong;
                xe1.MauSac = xe.mauSac;
                xe1.KhoiLuong = (float)xe.khoiLuong;
                xe1.GiaThanh = (float)xe.giaThanh;
                xe1.SoLuong = xe.soLuong;
                xe1.LoaiPhanh = xe.loaiPhanh;
                xe1.LoaiBanh = xe.loaiBanh;
                xe1.MaNCC = xe.maNCC;
                return xe1;
            }
            return null;
        }

        public double SinhGiaBan(eXe xe)
        {
            return xe.GiaThanh * 110 / 100;
        }

        public bool KiemTraXe(String ma)
        {
            Xe xe = db.Xes.Where(x => x.maXe.Equals(ma)).FirstOrDefault();
            if (xe == null)
            {
                return false;
            }
            return true;
        }

        public int ThemXe(eXe xenew)
        {
            if (KiemTraXe(xenew.MaXe))
                return 0;
            Xe xe = new Xe();
            xe.maXe = xenew.MaXe;
            xe.tenXe = xenew.TenXe;
            xe.maHang = xenew.MaHang;
            xe.maLoai = xenew.MaLoai;
            xe.phanKhoi = xenew.PhanKhoi;
            xe.doCaoYen = xenew.DoCaoYen;
            xe.congSuat = xenew.CongSuat;
            xe.dungTichBinhXang = xenew.DungTichBinhXang;
            xe.duongKinhPitTong = xenew.DuongKinhPitTong;
            xe.mauSac = xenew.MauSac;
            xe.khoiLuong = xenew.KhoiLuong;
            xe.giaThanh = xenew.GiaThanh;
            xe.soLuong = xenew.SoLuong;
            xe.loaiPhanh = xenew.LoaiPhanh;
            xe.loaiBanh = xenew.LoaiBanh;
            xe.maNCC = xenew.MaNCC;
            db.Xes.InsertOnSubmit(xe);
            db.SubmitChanges();
            return 1;
        }

        public int SuaThongTinXe(eXe xesua)
        {
            if (!KiemTraXe(xesua.MaXe))
                return 0;
            Xe xe = db.Xes.Where(x => x.maXe.Equals(xesua.MaXe)).FirstOrDefault();
            xe.phanKhoi = xesua.PhanKhoi;
            xe.doCaoYen = xesua.DoCaoYen;
            xe.congSuat = xesua.CongSuat;
            xe.dungTichBinhXang = xesua.DungTichBinhXang;
            xe.duongKinhPitTong = xesua.DuongKinhPitTong;
            xe.mauSac = xesua.MauSac;
            xe.khoiLuong = xesua.KhoiLuong;
            xe.giaThanh = xesua.GiaThanh;
            xe.loaiPhanh = xesua.LoaiPhanh;
            xe.loaiBanh = xesua.LoaiBanh;
            xe.maNCC = xesua.MaNCC;
            db.SubmitChanges();
            return 1;
        }

        public int TangSoLuong(eXe xe1, int sl)
        {
            if (!KiemTraXe(xe1.MaXe))
                return 0;
            Xe xe = db.Xes.Where(x => x.maXe.Equals(xe1.MaXe)).FirstOrDefault();
            xe.soLuong = xe.soLuong + sl;
            db.SubmitChanges();
            return 1;
        }

        public int GiamSoLuong(eXe xe1, int sl)
        {
            if (!KiemTraXe(xe1.MaXe))
                return 0;
            Xe xe = db.Xes.Where(x => x.maXe.Equals(xe1.MaXe)).FirstOrDefault();
            xe.soLuong = xe.soLuong - sl;
            db.SubmitChanges();
            return 1;
        }

        public int KiemTraSoLuong(eXe xe1, int sl)
        {
            if (xe1.SoLuong >= sl)
                return 1;
            return 0;
        }

        public int XoaXe(eXe xexoa)
        {
            if (!KiemTraXe(xexoa.MaXe))
                return 0;
            Xe xe = db.Xes.Where(x => x.maXe.Equals(xexoa.MaXe)).FirstOrDefault();
            db.Xes.DeleteOnSubmit(xe);
            db.SubmitChanges();
            return 1;
        }

        public int SoLuongConThucSu(eXe xe)
        {
            int n = db.HopDongs.Join(db.CT_HoaDons, hdg => hdg.maHopDong, ct => ct.maHopDong, (hdg, ct) => new { hdg, ct })
                .Join(db.HoaDons, j1 => j1.ct.maHoaDon, hd => hd.maHoaDon, (j1, hd) => new { j1, hd })
                .Where(j2 => j2.hd.trangThai.Equals("Chưa nhận xe") && j2.j1.hdg.trangThai.Equals("Đã thanh toán") && j2.j1.hdg.maXe.Equals(xe.MaXe)).Count();
            return xe.SoLuong - n;
        }
        
        public string PhatSinhMa()
        {
            int n = 0;
            string str = "XE";
            Xe xe = db.Xes.ToList().LastOrDefault();
            if (xe != null)
            {
                string str1 = xe.maXe.Substring(2);
                n = int.Parse(str1) + 1;
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
