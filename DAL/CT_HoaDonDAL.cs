using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CT_HoaDonDAL
    {
        QuanLyBanXeDataContext db;
        public CT_HoaDonDAL()
        {
            db = new QuanLyBanXeDataContext();
        }

        public List<eCT_HoaDon> LayTatCaChiTietTheoMaHoaDon(string ma)
        {
            List<eCT_HoaDon> l = new List<eCT_HoaDon>();
            List<CT_HoaDon> list = db.CT_HoaDons.Where(ct => ct.maHoaDon.Equals(ma)).ToList();
            foreach(CT_HoaDon ct in list)
            {
                eCT_HoaDon chitiet = new eCT_HoaDon();
                chitiet.MaHD = ct.maHoaDon;
                chitiet.MaHDG = ct.maHopDong;
                chitiet.GiaBan = ct.giaBan;
                chitiet.Thue = ct.thue;
                l.Add(chitiet);
            }
            return l;
        }

        public List<object> chiTietHoaDonHonLoan(string ma)
        {
            var n = from a in db.HoaDons
                    join ct in db.CT_HoaDons on a.maHoaDon equals ct.maHoaDon into j1
                    from b in j1.DefaultIfEmpty()
                    join hopdong in db.HopDongs on b.maHopDong equals hopdong.maHopDong into j2
                    from c in j2.DefaultIfEmpty()
                    join xe in db.Xes on c.maXe equals xe.maXe into j3
                    from d in j3.DefaultIfEmpty()
                    join loaixe in db.LoaiXes on d.maLoai equals loaixe.maLoai into j4
                    from e in j4.DefaultIfEmpty()
                    join hangxe in db.HangXes on d.maHang equals hangxe.maHang into j5
                    from f in j5.DefaultIfEmpty()
                    where a.maHoaDon.Equals(ma)
                    group a by
                    new
                    {
                        maHopDong = c.maHopDong,
                        tenXe = d.tenXe,
                        xuatXu = f.xuatXu,
                        giaBan = b.giaBan,
                        thue = b.thue,
                        tienThue = b.giaBan * b.thue,
                        thanhTien = b.giaBan + b.giaBan * b.thue
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
        public double TinhTienThue(eCT_HoaDon ct)
        {
            return ct.GiaBan * ct.Thue;
        }
        public double TinhTongTien(eCT_HoaDon ct)
        {
            return ct.GiaBan + TinhTienThue(ct);
        }

        public void ThemChiTiet(eCT_HoaDon ctmoi)
        {
            CT_HoaDon ct = new CT_HoaDon();
            ct.maHoaDon = ctmoi.MaHD;
            ct.maHopDong = ctmoi.MaHDG;
            ct.giaBan = ctmoi.GiaBan;
            ct.thue = ctmoi.Thue;
            db.CT_HoaDons.InsertOnSubmit(ct);
            db.SubmitChanges();
        }
    }
}
