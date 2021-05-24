using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class ThongKeDAL
    {
        QuanLyBanXeDataContext db;
        public ThongKeDAL()
        {
            db = new QuanLyBanXeDataContext();
        }
        public List<eThongKeXeBanTheoNhanVienTrongThangX> ThongKeXeBanTheoThangVaTheoNhanVien(int thang, int nam)
        {
            var thongke = (from cthd in db.CT_HoaDons join hdong in db.HopDongs on cthd.maHopDong equals hdong.maHopDong
                           join xe in db.Xes on hdong.maXe equals xe.maXe
                           join hd in db.HoaDons on cthd.maHoaDon equals hd.maHoaDon

                           where hd.ngayLap.Month == thang&& hd.ngayLap.Year == nam
                           group xe by new
                           {
                               maxe = xe.maXe,
                               tenxe = xe.tenXe,
                               soluong=db.HopDongs.Where(x=>x.maXe.Equals(xe.maXe)&&x.ngayLap.Month==thang && x.ngayLap.Year == nam && x.trangThai.Equals("Đã thanh toán")).Count(),
                               doanhthu=db.HopDongs.Join(db.CT_HoaDons, hdg => hdg.maHopDong, ct => ct.maHopDong, (hdg, ct) => new { hdg, ct })
                                              .Where(j => j.hdg.maXe.Equals(xe.maXe) && j.hdg.ngayLap.Month == thang && j.hdg.ngayLap.Year == nam)
                                              .GroupBy(j => j).Sum(j => j.Key.ct.thue * j.Key.ct.giaBan + j.Key.ct.giaBan)
                      
                           } into g select g.Key
                         ) ;
            List<eThongKeXeBanTheoNhanVienTrongThangX> l = new List<eThongKeXeBanTheoNhanVienTrongThangX>();
            foreach(var x in thongke)
            {
                eThongKeXeBanTheoNhanVienTrongThangX tam = new eThongKeXeBanTheoNhanVienTrongThangX();
                tam.MaXe = x.maxe;
                tam.TenXe = x.tenxe;
                tam.SoLuong = x.soluong;
                tam.ThanhTien = x.doanhthu;
                l.Add(tam);
            }
            if (l == null)
                return null;
            return l;
        }
        public List<eThongKeSoLuongVaDoanhThuTheoThang> ThongKeSoLuongVaDoanhThuTheoThang(int nam)
        {
            var thongke = (from cthd in db.CT_HoaDons
                           join hdong in db.HopDongs on cthd.maHopDong equals hdong.maHopDong
                           where hdong.ngayLap.Year == nam
                           group hdong by new
                           {
                               thang = hdong.ngayLap.Month,
                               soluong = db.HopDongs.Where(hopdong => hopdong.ngayLap.Month == hdong.ngayLap.Month&&hopdong.trangThai.Equals("Đã thanh toán")).Count(),
                               tongdoanhthu = db.HopDongs.Join(db.CT_HoaDons, hdg => hdg.maHopDong, ct => ct.maHopDong, (hdg, ct) => new { hdg, ct })
                                              .Where(j => j.hdg.ngayLap.Month == hdong.ngayLap.Month).GroupBy(j => j)
                                              .Sum(j => j.Key.ct.thue * j.Key.ct.giaBan + j.Key.ct.giaBan)
                           } into g
                           select g.Key
                        );

            List<eThongKeSoLuongVaDoanhThuTheoThang> l = new List<eThongKeSoLuongVaDoanhThuTheoThang>();
            for (int i = 1; i <= 12; i++)
            {
                eThongKeSoLuongVaDoanhThuTheoThang tam = new eThongKeSoLuongVaDoanhThuTheoThang();
                foreach (var x in thongke)
                {
                    if (x.thang == i)
                    {
                        tam.Thang = x.thang;
                        tam.SoLuong = x.soluong;
                        tam.DoanhThu = x.tongdoanhthu;
                        break;
                    }
                    else
                    {
                        tam.Thang = i;
                        tam.SoLuong = 0;
                        tam.DoanhThu = 0;
                    }
                }
                l.Add(tam);
            }
            if (l == null)
                return null;
            return l;
        }
        public List<eThongKeBanChay> DanhSachBanChay(int thang, int nam)
        {
            var thongke = (from xe in db.Xes
                           join hdong in db.HopDongs on xe.maXe equals hdong.maXe
                           join cthd in db.CT_HoaDons on hdong.maHopDong equals cthd.maHopDong
                           where hdong.ngayLap.Month == thang && hdong.ngayLap.Year == nam
                           group xe by new
                           {
                               maxe = xe.maXe,
                               tenxe = xe.tenXe,
                               mausac= xe.mauSac,
                               soluong= db.HopDongs.Where(hopdong => hopdong.ngayLap.Month == hdong.ngayLap.Month && hopdong.ngayLap.Year==hdong.ngayLap.Year&&hopdong.maXe.Equals(xe.maXe) && hopdong.trangThai.Equals("Đã thanh toán")).Count(),
                           }into g
                           select g.Key
                           );
            var finallist = from a in thongke.OrderByDescending(x => x.soluong)
                            select a;
            List<eThongKeBanChay> l = new List<eThongKeBanChay>();
            foreach(var x in finallist)
            {
                eThongKeBanChay banchay = new eThongKeBanChay();
                banchay.MaXe = x.maxe;
                banchay.TenXe = x.tenxe;
                banchay.SoLuong = x.soluong;
                banchay.MauSac = x.mausac;
                l.Add(banchay);
            }
            return l;

        }
    }
}
